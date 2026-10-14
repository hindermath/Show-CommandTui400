"""DE: Fester automatischer Prüfablauf. EN: Fixed automated product proof suite.

CI evidence belongs to its runner only. Target hand-offs use the approved driver.
Expected S07 Fail is preserved separately; never called successful restoration.
"""
import argparse, hashlib, json, os, platform, subprocess, sys
from pathlib import Path
import importlib.util
_spec=importlib.util.spec_from_file_location("platform_case",Path(__file__).with_name("platform-case.py"))
_case=importlib.util.module_from_spec(_spec);_spec.loader.exec_module(_case)
external=_case.external

parser=argparse.ArgumentParser()
parser.add_argument('--output-root',required=True)
parser.add_argument('--scope',choices=['maca','ci'],required=True)
args=parser.parse_args()
root=Path(__file__).resolve().parents[3]
out=external(args.output_root)
out.mkdir()  # New run only.
head=subprocess.check_output(['git','rev-parse','HEAD'],cwd=root,text=True).strip()
manifest=json.loads((root/'docs/validation/lh01/platform-handoff.json').read_text())
order=sorted(manifest['cases'],key=lambda c: 9 if c['id']=='S07' else 0 if c['id']=='PF01' else 1 if c['group']=='Negative' else 3 if c['id']=='EV01' else 2)
records=[]
try:
    for case in order:
        command=[sys.executable,str(Path(__file__).with_name('platform-case.py')),
            '--case-id',case['id'],'--build-root',str(out/'build'),
            '--output-root',str(out/'cases'),'--product-commit',head]
        result=subprocess.run(command,cwd=root,capture_output=True,text=True,timeout=150)
        text=(result.stdout+result.stderr).replace(str(root),'<checkout>').replace(str(out),'<output>').replace(str(Path.home()),'<user>')
        (out/(case['id']+'.txt')).write_text(text,encoding='utf-8')
        try:record=json.loads(result.stdout.strip().splitlines()[-1])
        except (ValueError,IndexError):record={}
        expected=1 if case['id']=='S07' else 0
        matched=result.returncode==expected and record.get('caseId')==case['id'] and record.get('result')==case['requiredResult'] and record.get('outcome')==case['expectedOutcome']
        records.append({'caseId':case['id'],'exitCode':result.returncode,'expectationSatisfied':matched,'result':record.get('result','NotObserved')})
        print(json.dumps(records[-1]),flush=True)
        if not matched:raise RuntimeError('Case failed: '+case['id']+'; see isolated raw evidence')
    status='Pass'
except (RuntimeError,subprocess.SubprocessError) as error:
    status='Fail'
    print(str(error),flush=True)
files=[]
for path in sorted(out.rglob('*')):
    if path.is_file() and 'build' not in path.relative_to(out).parts:
        files.append({'path':path.relative_to(out).as_posix(),'sha256':hashlib.sha256(path.read_bytes()).hexdigest()})
environment={'os':platform.platform(),'machine':platform.machine(),'python':platform.python_version(),
    'powershell':subprocess.check_output(['pwsh','-NoProfile','-Command','$PSVersionTable.PSVersion.ToString();[Environment]::Version.ToString()'],text=True).splitlines(),
    'sdk':subprocess.check_output(['dotnet','--version'],text=True).strip()}
if sys.platform=='darwin':
    hw=json.loads(subprocess.check_output(['system_profiler','SPHardwareDataType','-json'],text=True))['SPHardwareDataType'][0]
    environment['hardware']={k:hw.get(k) for k in ('machine_name','chip_type','model_number')}
record={'schemaVersion':1,'mainStatus':status,'diagnosticStatus':'Fail' if status=='Pass' else 'NotCompleted',
    'diagnosticExpectationSatisfied':status=='Pass','scope':args.scope,'productCommit':head,
    'environment':environment,'cases':records,'files':files,'review':'Open',
    'physicalTerminal':'Deferred','screenReader':'Deferred','brailleHardware':'Excluded',
    'limits':['7.6.4 minimum is a model boundary; actual host version listed above',
              'CI does not prove Windows 11, WSL2 or Mac B',
              'S07 injects failure after real restore; its result remains Fail']}
(out/'suite-result.json').write_text(json.dumps(record,ensure_ascii=False,indent=2)+'\n')
raise SystemExit(0 if status=='Pass' else 2)
