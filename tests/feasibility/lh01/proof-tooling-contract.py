"""DE: Regressionen für Pfadgrenzen/PTY-Fragmente. EN: Boundary/fragment regressions."""
import json, subprocess
from pathlib import Path
from terminal_probes import TerminalProbes
root = Path(__file__).resolve().parents[3]
checks = []
for query, response in TerminalProbes.queries:
    for split in range(1, len(query)):
        probes = TerminalProbes()
        assert probes.feed(1, query[:split]) == []
        assert probes.feed(2, query[split:]) == []  # Descriptors never share tails.
        assert probes.feed(1, query[split:]) == [response]
        assert probes.feed(1, b'x') == []
    probes = TerminalProbes()
    assert sum((probes.feed(1, bytes([byte])) for byte in query), []) == [response]
checks.append('all-query-splits-and-descriptor-isolation')
probes = TerminalProbes()
assert probes.feed(1, b'\x1b[c\x1b[6n\x1b[0c') == [b'\x1b[?1;2c', b'\x1b[1;1R', b'\x1b[?1;2c']
assert probes.feed(1, b'next') == []
checks.append('multiple-queries-without-duplicate-replies')
inside = Path(str(root).swapcase()) / 'lh01-must-not-create'
assert not inside.exists()
result = subprocess.run(['pwsh', '-NoProfile', '-File', str(root/'tests/feasibility/lh01/Invoke-Lh01ContractProof.ps1'), '-CaseId', 'B01', '-BuildRoot', str(inside)], capture_output=True, text=True, timeout=30)
assert result.returncode != 0 and 'BuildRoot must stay outside source' in result.stderr and not inside.exists(), result.stderr
checks.append('case-varied-build-root-rejected-before-write')
result = subprocess.run(['pwsh','-NoProfile','-File',str(root/'tests/feasibility/lh01/Invoke-Lh01PlatformProof.ps1'),'-Plan',str(root/'docs/validation/lh01/platform-handoff.json'),'-Target','macb','-OutputDirectory',str(inside),'-CheckOnly'], capture_output=True,text=True,timeout=30)
assert result.returncode == 2 and 'Use isolated output outside the source checkout' in result.stdout and not inside.exists(), (result.stdout,result.stderr)
checks.append('case-varied-output-root-rejected-before-write')
print(json.dumps({'result':'Pass','checks':checks}, indent=2))
