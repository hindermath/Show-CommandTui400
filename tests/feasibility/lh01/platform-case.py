"""DE: Gebundene Fallgruppen und Rohbelege. EN: Bound cases with raw evidence.

Only fixed test entry points and argv arrays run. Output/build roots must be
external, without symlink parents. No installation, delivery or acceptance.
"""
import argparse, hashlib, json, os, platform, shutil, subprocess, sys
from pathlib import Path

ROOT = Path(__file__).resolve().parents[3]
SCENARIOS = {
    'N02': ['InputRedirect'], 'N03': ['Redirect'],
    'S01': ['Repeat'], 'S02': ['Normal', 'HiddenCursor'], 'S03': ['Cancel'],
    'S04': ['Stop'], 'S05': ['HandledFailure', 'AggregateFailure'], 'S06': ['Repeat'],
    'K01': ['Keyboard', 'Remap', 'FunctionExit', 'BindingConflict'],
    'V01': ['Resize', 'TextState'], 'V02': ['SmallExit', 'TinyExit'],
    'S07': ['RestorationFailure'],
}


def external(value):
    path = Path(value).absolute()
    for part in [path, *path.parents]:
        if part.is_symlink():
            raise ValueError('Symlink in external proof path')
    path = path.resolve()
    if path == ROOT or ROOT in path.parents:
        raise ValueError('Proof writes must stay outside checkout')
    return path


def run(command, log):
    result = subprocess.run(command, cwd=ROOT, capture_output=True, text=True, encoding="utf-8", errors="replace", timeout=110)
    text = result.stdout + result.stderr
    text = text.replace(str(ROOT), '<checkout>').replace(str(Path.home()), '<user>')
    log.write_text(text, encoding='utf-8')
    lines = result.stdout.strip().splitlines()
    try:
        record = json.loads(lines[-1])
    except (IndexError, ValueError):
        raise RuntimeError(f'No machine-readable result; see {log.name}')
    return result.returncode, record


def main():
    parser = argparse.ArgumentParser()
    parser.add_argument('--case-id', required=True)
    parser.add_argument('--build-root', required=True)
    parser.add_argument('--output-root', required=True)
    parser.add_argument('--product-commit', required=True)
    args = parser.parse_args()
    manifest = json.loads((ROOT / 'docs/validation/lh01/platform-handoff.json').read_text())
    definition = next(c for c in manifest['cases'] if c['id'] == args.case_id)
    head = subprocess.check_output(['git', '-C', str(ROOT), 'rev-parse', 'HEAD'], text=True).strip()
    if head != args.product_commit:
        raise ValueError('Product revision mismatch')
    build, output = external(args.build_root), external(args.output_root)
    output.mkdir(parents=True, exist_ok=True)
    temporary = output / "temporary"
    temporary.mkdir(exist_ok=True)
    for name in ("TMPDIR", "TEMP", "TMP"):
        os.environ[name] = str(temporary)
    case = output / args.case_id
    case.mkdir()  # Existing evidence must never be overwritten.
    observations, files = [], []
    if args.case_id == 'PF01':
        if subprocess.check_output(['git', '-C', str(ROOT), 'status', '--porcelain'], text=True).strip():
            raise ValueError('Product checkout must be clean')
        for tool in ('pwsh', 'dotnet'):
            if not shutil.which(tool):
                raise ValueError(f'Missing tool: {tool}')
        observations.append({'productCommit': head, 'platform': platform.platform(),
            'python': platform.python_version(), 'executable': 'current Python interpreter',
            'authority': 'driver validates target, approval, schema, inventory and hashes before PF01'})
    elif args.case_id == 'EV01':
        for entry in manifest['cases']:
            if entry['id'] in ('EV01', 'S07') or not entry['enabled']:
                continue
            path = output / entry['id'] / 'result.json'
            record = json.loads(path.read_text())
            if record['result'] != 'Pass' or record['caseId'] != entry['id'] or record['productCommit'] != head:
                raise ValueError('Prior case evidence incomplete or revision mismatch')
            for bound in record['files']:
                source = output / entry['id'] / bound['path']
                if source.is_symlink() or hashlib.sha256(source.read_bytes()).hexdigest() != bound['sha256']:
                    raise ValueError('Raw case evidence hash mismatch')
            observations.append({'caseId': entry['id'], 'sha256': hashlib.sha256(path.read_bytes()).hexdigest()})
        if len(observations) != 18:
            raise ValueError('Evidence inventory incomplete; S07 is deliberately separate and follows EV01')
    elif args.case_id in SCENARIOS:
        for scenario in SCENARIOS[args.case_id]:
            log = case / (scenario + '.txt')
            raw = case / (scenario + '.json')
            command = [sys.executable, str(ROOT / 'tests/feasibility/lh01/pty-product.py'),
                '--scenario', scenario, '--output', str(raw), '--build-root', str(build)]
            code, record = run(command, log)
            expected = 1 if args.case_id == 'S07' else 0
            proof = json.loads(raw.read_text())
            if code != expected or not record['diagnosticContractSatisfied'] or not proof['diagnosticContractSatisfied']:
                raise RuntimeError(f'Product case failed: {scenario}; exit {code}')
            observations.append({'scenario': scenario, 'exitCode': code,
                'result': proof['result'], 'diagnosticContractSatisfied': True})
    else:
        code, record = run(['pwsh', '-NoProfile', '-File', str(ROOT / 'tests/feasibility/lh01/Invoke-Lh01ContractProof.ps1'),
            '-CaseId', args.case_id, '-BuildRoot', str(build)], case / 'contract.txt')
        if code != 0 or record['caseId'] != args.case_id or record['result'] != 'Pass':
            raise RuntimeError('Build/model case failed')
        observations.append(record)
    for path in sorted(case.iterdir()):
        if path.is_file():
            files.append({'path': path.name, 'sha256': hashlib.sha256(path.read_bytes()).hexdigest()})
    record = {'caseId': args.case_id, 'productCommit': head, 'outcome': definition['expectedOutcome'],
        'result': definition['requiredResult'], 'evidenceIds': definition['evidenceIds'],
        'observations': observations, 'files': files,
        'scope': 'automated product/model evidence only; independent review and physical acceptance remain open'}
    (case / 'result.json').write_text(json.dumps(record, ensure_ascii=False, indent=2) + '\n')
    print(json.dumps(record, ensure_ascii=False))
    return 1 if args.case_id == 'S07' else 0


if __name__ == '__main__':
    try:
        raise SystemExit(main())
    except (OSError, ValueError, RuntimeError, subprocess.SubprocessError, StopIteration) as error:
        print(json.dumps({'status': 'BlockedOrFailed', 'reason': str(error)}))
        raise SystemExit(2)
