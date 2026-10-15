"""DE: Compile-only PowerShell-Grenze prüfen. EN: Check compile-only PowerShell boundary.
Use restored NuGet assets and actual build/publish output, not a fixed DLL list.
"""
import argparse
import json
from pathlib import Path


def inspect(assets_path, outputs):
    assets = json.loads(assets_path.read_text(encoding='utf-8-sig'))
    target = assets['targets']['net10.0']
    by_name = {key.split('/')[0].lower(): key for key in target}

    def closure(names):
        seen = set()
        pending = list(names)
        while pending:
            name = pending.pop().lower()
            if name in seen:
                continue
            if name not in by_name:
                raise ValueError('Missing package: ' + name)
            seen.add(name)
            pending.extend(target[by_name[name]].get('dependencies', {}))
        return seen

    host = 'system.management.automation'
    if by_name.get(host) != 'System.Management.Automation/7.6.4':
        raise ValueError('Expected exact PowerShell API 7.6.4')
    direct = assets['project']['frameworks']['net10.0']['dependencies']
    if direct['System.Management.Automation'].get('include') != 'Compile':
        raise ValueError('PowerShell reference is not compile-only')
    if direct['System.Management.Automation'].get('suppressParent') != 'All':
        raise ValueError('PowerShell reference is not private')
    other = [name for name, policy in direct.items()
             if name.lower() != host and policy.get('include') not in ('Compile', 'None')]
    exclusive = closure([host]) - closure(other)
    forbidden = {'System.Management.Automation.dll'}
    for name in exclusive:
        for section in ('runtime', 'native', 'runtimeTargets', 'resource'):
            for asset in target[by_name[name]].get(section, {}):
                if Path(asset).name != '_._':
                    forbidden.add(Path(asset).name.lower())
        # Excluded runtime assets may be absent from the target; use package inventory too.
        for asset in assets['libraries'][by_name[name]].get('files', []):
            if asset.lower().endswith(('.dll', '.so', '.dylib')) and asset.startswith(('lib/', 'runtimes/')):
                forbidden.add(Path(asset).name.lower())
    forbidden = {name.lower() for name in forbidden}
    for output in outputs:
        if not output.is_dir() or not (output / 'ShowCommandTui400.dll').is_file():
            raise ValueError('Missing product output: ' + str(output))
        leaked = [p.name for p in output.rglob('*') if p.is_file() and p.name.lower() in forbidden]
        if leaked:
            raise ValueError('PowerShell runtime leaked: ' + ', '.join(sorted(set(leaked))))
        for deps in output.glob('*.deps.json'):
            data = json.loads(deps.read_text())
            for packages in data['targets'].values():
                for name, package in packages.items():
                    if name.split('/')[0].lower() in exclusive and any(
                        package.get(section) for section in ('runtime', 'native', 'runtimeTargets', 'resources')
                    ):
                        raise ValueError('PowerShell runtime in dependency manifest: ' + name)
    return {'result': 'Pass', 'apiVersion': '7.6.4', 'checkedOutputs': len(outputs),
            'excludedPackages': sorted(exclusive), 'scope': 'build/publish boundary; no host compatibility claim'}


if __name__ == '__main__':
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument('--assets', required=True, type=Path)
    parser.add_argument('--output', required=True, action='append', type=Path)
    args = parser.parse_args()
    try:
        print(json.dumps(inspect(args.assets, args.output)))
    except (ValueError, KeyError, OSError) as error:
        print(json.dumps({'result': 'Fail', 'reason': str(error)}))
        raise SystemExit(1)
