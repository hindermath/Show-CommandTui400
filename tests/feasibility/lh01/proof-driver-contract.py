"""DE: Negative Prüfplanverträge ohne Produktstart. EN: Negative proof-plan contracts without product entry."""
import json,subprocess,tempfile
from pathlib import Path
root=Path.cwd();base=json.loads((root/'docs/validation/lh01/platform-handoff.json').read_text());temp=Path(tempfile.mkdtemp(prefix='lh01-driver-contract-'));records=[]
variants=[('prepared',lambda p:None,'Prepared plan grants no execution authority'),('empty-inventory',lambda p:p.update(cases=[]),'Canonical case inventory'),('changed-outcome',lambda p:p['cases'][1].update(expectedOutcome='Anything'),'Canonical case field'),('changed-order',lambda p:p['cases'][1].update(group='Positive'),'Canonical case field'),('missing-evidence',lambda p:p['cases'][1].update(evidenceIds=[]),'Canonical E01'),('duplicate-case',lambda p:p['cases'].append(p['cases'][1]),'Canonical case inventory'),('schema',lambda p:p.update(approvedCommands=[{'bad':1}]),'')]
for name,mutate,expected in variants:
 plan=json.loads(json.dumps(base));mutate(plan);path=temp/(name+'.json');path.write_text(json.dumps(plan));out=temp/(name+'-output')
 command=['pwsh','-NoProfile','-File','tests/feasibility/lh01/Invoke-Lh01PlatformProof.ps1','-Plan',str(path),'-Target','macb','-OutputDirectory',str(out),'-CheckOnly']
 result=subprocess.run(command,cwd=root,capture_output=True,text=True,timeout=30)
 assert result.returncode==2 and not out.exists() and expected in result.stdout,(name,result.stdout,result.stderr)
 records.append({'case':name,'exitCode':result.returncode,'outputCreated':out.exists(),'expectedBlockerObserved':True})
print(json.dumps({'result':'Pass','checks':records},indent=2))
