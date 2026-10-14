"""DE: Synthetischer Unix-PTY-Produkttest. EN: Synthetic Unix PTY product test."""
import argparse, hashlib, json, os, sys, time
from terminal_transport import UnixTerminal, WindowsTerminal
from pathlib import Path
from terminal_probes import TerminalProbes
parser = argparse.ArgumentParser()
parser.add_argument('--scenario', choices=['Normal','Cancel','Repeat','Stop','HandledFailure','RestorationFailure','Redirect','HiddenCursor','InputRedirect','AggregateFailure','Keyboard','Remap','FunctionExit','BindingConflict','Resize','SmallExit','TinyExit','TextState','NegativeSecurity'], required=True)
parser.add_argument('--output', required=True)
parser.add_argument('--build-root')
parser.add_argument('--case-id', choices=['N02','N03','S01','S02','S03','S04','S05','S06','S07','K01','V01','V02'])
args=parser.parse_args()
root=Path(__file__).resolve().parents[3]
output=Path(args.output).resolve()
if output.exists(): raise SystemExit('Output must be new')
if output==root or root in output.parents:raise SystemExit('Output must stay outside checkout')
for parent in [Path(args.output).absolute(), *Path(args.output).absolute().parents]:
    if parent.is_symlink():raise SystemExit('Symlink in output path')
output.parent.mkdir(parents=True,exist_ok=True)
observation_file=output.with_suffix('.observation.json')
if observation_file.exists():raise SystemExit('Observation must be new')
command=['pwsh','-NoLogo','-NoProfile','-File','tests/feasibility/lh01/session-contract.ps1','-Scenario',args.scenario,'-Module','src/ShowCommandTui400/bin/Debug/net10.0/ShowCommandTui400.psd1','-TestAssembly','tests/ShowCommandTui400.Tests/bin/Debug/net10.0/ShowCommandTui400.Tests.dll']
if args.build_root:
    build=Path(args.build_root).resolve()
    command[command.index('-Module')+1]=str(build/'ShowCommandTui400/bin/net10.0/ShowCommandTui400.psd1')
    command[command.index('-TestAssembly')+1]=str(build/'ShowCommandTui400.Tests/bin/net10.0/ShowCommandTui400.Tests.dll')
command+=['-ObservationFile',str(observation_file)]
if os.name=='nt' and args.scenario in ('InputRedirect','Redirect'):
    command[command.index('-File')+1]='tests/feasibility/lh01/redirect-session.ps1'
env=os.environ.copy();env['TERM']='xterm-256color';env['LC_ALL']='en_US.UTF-8'
terminal=(WindowsTerminal if os.name=='nt' else UnixTerminal)(command,root,env,args.scenario)
before=terminal.before
probes=TerminalProbes()
raw=bytearray();start=time.monotonic();ui_at=None;phase=0;ack=False;sample=None;steps=[]
sequences = {
    'Keyboard': [('Unknown',b'z'),('Esc',b'\x1b'),('F12',b'\x1b[24~'),('F4',b'\x1bOS'),('F9',b'\x1b[20~'),('F10',b'\x1b[21~'),('F11',b'\x1b[23~'),('Tab',b'\t'),('Enter',b'\r'),('Alt+B',b'\x1bb'),('Shift+Tab',b'\x1b[Z'),('Down',b'\x1b[B'),('Up',b'\x1b[A'),('Right',b'\x1b[C'),('Left',b'\x1b[D'),('PageDown',b'\x1b[6~'),('Enter',b'\r'),('PageUp',b'\x1b[5~'),('Enter',b'\r'),('F5',b'\x1b[15~'),('F1',b'\x1bOP'),('Alt+B',b'\x1bb'),('Alt+M',b'\x1bm'),('Alt+H',b'\x1bh'),('F12',b'\x1b[24~'),('Esc',b'\x1b'),('Alt+X',b'\x1bx')],
    'Remap': [('F1-unbound',b'\x1bOP'),('F5-unbound',b'\x1b[15~'),('F6',b'\x1b[17~'),('F2',b'\x1bOQ'),('Alt+B',b'\x1bb'),('Alt+H',b'\x1bh'),('Esc',b'\x1b'),('Alt+X',b'\x1bx')],
    'FunctionExit': [('F3',b'\x1bOR')],
    'Resize': [('Tab',b'\t'),('Resize-small',None),('F5-blocked',b'\x1b[15~'),('Alt+H',b'\x1bh'),('Alt+B',b'\x1bb'),('Resize-large',None),('Tab',b'\t'),('Alt+X',b'\x1bx')],
    'SmallExit': [('Resize-small',None),('Alt+H',b'\x1bh'),('Alt+X',b'\x1bx')],
    'TinyExit': [('Resize-tiny',None),('Alt+X',b'\x1bx')],
    'TextState': [('Alt+H',b'\x1bh'),('PageDown',b'\x1b[6~'),('PageUp',b'\x1b[5~'),('Alt+X',b'\x1bx')]
}
sequence = sequences.get(args.scenario, [('Ctrl+C',b'\x03')] if args.scenario=='Cancel' else [('Alt+X',b'\x1bx')] * (3 if args.scenario=='Repeat' else 1))
try:
    while time.monotonic()-start<45:
        for fd,chunk in terminal.read():
            raw.extend(chunk)
            for response in probes.feed(fd,chunk):terminal.write(response)
        if ui_at is None and b'Show-CommandTui400' in raw and args.scenario in ('Normal','Cancel','Repeat','HiddenCursor','Keyboard','Remap','FunctionExit','Resize','SmallExit','TinyExit','TextState'):ui_at=time.monotonic()
        if ui_at is not None:
            elapsed=time.monotonic()-ui_at
            if phase<len(sequence) and elapsed>.8+phase*.65:
                label,data=sequence[phase]
                if data is None:
                    rows,columns=(5,20) if label=='Resize-small' else (1,1) if label=='Resize-tiny' else (30,110)
                    terminal.resize(columns,rows)
                else:terminal.write(data)
                phase+=1;steps.append(label)
        if not ack and b'LH01_SHELL_INPUT_READY' in raw:terminal.write(b'LH01_ACK\r');ack=True;steps.append('synthetic-shell-readback')
        if sample is None and b'LH01_RESTORE_READY' in raw:sample=terminal.sample()
        if terminal.poll() is not None:break
    timeout=terminal.poll() is None
    if timeout:terminal.terminate()
    # Drain asynchronous output after child exit, including final ConPTY bytes.
    for _ in range(5):
        for fd,chunk in terminal.read(.05):raw.extend(chunk)
    exit_code=terminal.poll()
    parsed=None
    for line in raw.decode('utf-8','replace').splitlines():
        if line.startswith('{"Scenario"'):
            try:parsed=json.loads(line)
            except json.JSONDecodeError:pass
    if observation_file.exists():parsed=json.loads(observation_file.read_text(encoding='utf-8-sig'))
    expected_exit=1 if args.scenario=='RestorationFailure' else 0
    expected_failure=args.scenario=='RestorationFailure'
    ok=not timeout and exit_code==expected_exit and parsed is not None and parsed['ContextUnchanged']
    if args.scenario not in ('Redirect','InputRedirect','BindingConflict','NegativeSecurity'):
        ok=ok and parsed['ShellReadback']=='LH01_ACK' and parsed['NativeRestore']['ConfiguredEqual']
    if os.name!='nt' and args.scenario in ('Normal','Repeat','Cancel'):
        ok=ok and b'\x1b[?25h' in raw
    if args.scenario in ('Redirect','InputRedirect'):
        ok=ok and parsed['RedirectBoundary']=={'Input':args.scenario=='InputRedirect','Output':args.scenario=='Redirect'}
    if args.scenario=='Repeat':
        observations=parsed['ScopeObservations'];ok=ok and len(observations)==3 and [v['Synthetic'] for v in observations]==[710,711,712] and all(v['ProcessId']==parsed['Before']['Pid'] and v['RunspaceId']==parsed['Before']['Runspace'] for v in observations)
    if args.scenario=='Stop':ok=ok and parsed['StopCalls']>0 and parsed['PipelineState']=='Stopped'
    if args.scenario in ('Keyboard','Remap','FunctionExit'):
        observations=parsed.get('InputObservations',[]) if parsed else []
        expected=[v[0] for v in sequence if v[0] not in ('Unknown','F1-unbound','F5-unbound')]
        ok=ok and phase==len(sequence) and parsed['ModuleSetUnchanged'] and observations[-1:]==[v for v in observations[-1:] if v['ExitRequested']]
        ok=ok and all(not v['ExitRequested'] for v in observations[:-1])
        ok=ok and [v['Key'] for v in observations]==expected and all(v['Focus']==v['FrameworkFocus'] for v in observations)
        if args.scenario=='Keyboard':
            ok=ok and all(not v['Accepted'] for v in observations[2:6]) and all(not v['ExitRequested'] for v in observations[:-1])
            ok=ok and observations[0]['Context']=='Root' and observations[1]['Context']=='Root'
            ok=ok and [v['Action'] for v in observations if v['Key']=='Enter']==['ActionsMenu','Refresh','Help']
            contexts=['Root']*7+['ActionsMenu']+['Root']*9+['Help']*3+['Root','ActionsMenu','Help','ActionsMenu','Root','Root']
            focuses=['Help']*6+['ActionsMenu']*3+['Help','ActionsMenu','Help','ActionsMenu','Help','Refresh','Refresh']+['Help']*10
            actions=['Back','Back','Context','AllParameters','MoreParameters','Details',None,'ActionsMenu','Back',None,None,None,None,None,None,'Refresh',None,'Help','Refresh','Help','Back','ActionsMenu','Help','Back','Back','Exit']
            ok=ok and [v['Context'] for v in observations]==contexts and [v['Focus'] for v in observations]==focuses
            ok=ok and [v['Action'] for v in observations]==actions and [v['Accepted'] for v in observations]==[i not in (2,3,4,5) for i in range(26)]

        if args.scenario=='Remap':ok=ok and observations[0]['Key']=='F6' and observations[0]['Action']=='Refresh' and observations[1]['Key']=='F2' and observations[1]['Context']=='Help'
    if args.scenario in ('Resize','SmallExit','TinyExit','TextState'):
        observations=parsed.get('InputObservations',[]) if parsed else []
        renders=parsed.get('RenderObservations',[]) if parsed else []
        ok=ok and phase==len(sequence) and parsed['ModuleSetUnchanged'] and parsed['SyntheticValueRetained']
        ok=ok and observations and observations[-1]['ExitRequested'] and all(not v['ExitRequested'] for v in observations[:-1])
        if args.scenario in ('Resize','SmallExit','TinyExit'):
            smalls=[v for v in renders if v['Small']]
            ok=ok and bool(smalls) and all('Alt+X' in v['Text'] for v in smalls)
            if args.scenario=='Resize':
                ok=ok and [v['Key'] for v in observations]==['Tab','F5','Alt+H','Alt+B','Tab','Alt+X']
                ok=ok and not observations[1]['Accepted'] and observations[1]['Focus']=='ActionsMenu'
                ok=ok and observations[-2]['Focus']=='Refresh' and observations[-2]['FrameworkFocus']=='Refresh'
                ok=ok and any(v['Width']==110 and v['Height']==30 and not v['Small'] and v['Focus']=='ActionsMenu' for v in renders)
            if args.scenario=='TinyExit':ok=ok and any(v['Width']==1 and v['Height']==1 for v in smalls)
        if args.scenario=='TextState':
            initial=renders[0]['Text']
            ok=ok and renders[0]['Busy'] and all(v in initial for v in ['Focus','Busy','Error','synthetic?[2J?error','synthetic?status','unavailable'])
            ok=ok and all(c not in initial for c in ('\x1b','\x07','\u202e')) and [v['Key'] for v in observations]==['Alt+H','PageDown','PageUp','Alt+X']
            ok=ok and observations[1]['ScrollTop']>observations[0]['ScrollTop'] and observations[2]['ScrollTop']==observations[0]['ScrollTop']
            ok=ok and all('synthetic?[2J?error' in v['Text'] for v in renders)
    if args.scenario=='NegativeSecurity':
        negative=parsed['SecurityNegative'] if parsed else {}
        ok=ok and negative.get('Cases')==['UnknownAction','ActionExpression','KeyExpression','Conflict','EscapeLoss']
        ok=ok and negative.get('TargetCalls')==0 and negative.get('NetworkAttempts')==0 and negative.get('FilesUnchanged')
        ok=ok and parsed['ModuleSetUnchanged'] and parsed['LeaseAcquisitions']==0 and parsed['UiCreations']==0 and parsed['Failure'] is None and parsed['ShellReadback']=='LH01_ACK'
    if args.scenario=='BindingConflict':ok=ok and parsed['LeaseAcquisitions']==0 and parsed['UiCreations']==0 and parsed['ModuleSetUnchanged'] and parsed['Failure']['ErrorId'].startswith('InvalidConfiguration')
    boundary=bytes(raw).split(b'LH01_SHELL_INPUT_READY')[0]
    import re
    cursor_visible=True; saved_cursor=None; restore_observed=False
    for match in re.finditer(rb'\x1b\[\?25([hlsr])',boundary):
        operation=match[1]
        if operation==b'h':cursor_visible=True
        elif operation==b'l':cursor_visible=False
        elif operation==b's':saved_cursor=cursor_visible
        elif operation==b'r' and saved_cursor is not None:cursor_visible=saved_cursor;restore_observed=True
    final_cursor_visible=cursor_visible
    if os.name!='nt' and args.scenario in ('Normal','Cancel','Repeat','HiddenCursor','Keyboard','Remap','FunctionExit','Resize','SmallExit','TinyExit','TextState'):ok=ok and restore_observed and cursor_visible==(args.scenario!='HiddenCursor')
    binary=Path(command[command.index('-Module')+1]).with_suffix('.dll')
    if not binary.is_absolute():binary=root/binary
    sanitized=raw.decode('utf-8','replace').replace(str(root),'<checkout>')
    if args.build_root:sanitized=sanitized.replace(str(Path(args.build_root).resolve()),'<build>')
    record={'sanitizedTranscript':sanitized,'sanitizedTranscriptSha256':hashlib.sha256(sanitized.encode()).hexdigest(),'assemblySha256':hashlib.sha256(binary.read_bytes()).hexdigest(),'finalCursorVisibleAtReturn':final_cursor_visible,'cursorModeRestoreObserved':restore_observed,'initialCursorBoundary':('Windows native restore observation; no Unix mode-25 assertion' if os.name=='nt' else 'synthetic xterm mode-25 protocol emulation; hidden and visible cases; no physical terminal proof'),'scenario':args.scenario,'environment':('synthetic Windows ConPTY; native console restore observation; redirects use real pipes (one stream per case)' if os.name=='nt' else 'synthetic Unix PTY; no physical terminal/assistive acceptance'),'command':[v.replace(str(root),'<checkout>').replace(str(Path(args.build_root).resolve()),'<build>') if args.build_root else v.replace(str(root),'<checkout>') for v in command],'exitCode':exit_code,'expectedExitCode':expected_exit,'result':'Pass' if ok and not expected_failure else 'Fail','diagnosticContractSatisfied':bool(ok),'failureScope':'injected restoration failure after successful real restore; not actual host restore failure' if expected_failure else None,'timeout':timeout,'steps':steps,'cursorShowObserved':b'\x1b[?25h' in raw,'transcriptSha256':hashlib.sha256(raw).hexdigest(),'termiosBefore':before,'termiosAfter':sample,'observation':parsed}
    output.parent.mkdir(parents=True,exist_ok=True)
    output.write_text(json.dumps(record,ensure_ascii=False,indent=2,default=lambda v:v.hex() if isinstance(v,bytes) else str(v))+'\n')
    outcomes={'N02':'RejectedWithoutStateChange','N03':'RejectedWithoutStateChange','S01':'CallerContextRetained','S02':'RestoredAndShellUsable','S03':'RestoredAndShellUsable','S04':'StoppedAndRestored','S05':'RestoredAndErrorPreserved','S06':'NoLeakedState','S07':'FailWithPrimaryAndRestorationErrorsPreserved','K01':'ActionContractsPass','V01':'ValuesAndFocusRetained','V02':'ExplainedAndSafeExit'}
    print(json.dumps({'caseId':args.case_id,'outcome':outcomes.get(args.case_id),'scenario':args.scenario,'result':record['result'],'diagnosticContractSatisfied':bool(ok),'exitCode':exit_code}))
    if not ok:
        # Test output is synthetic; scrub the checkout prefix before diagnostics.
        print(raw.decode('utf-8','replace').replace(str(root),'<checkout>')[-2500:],file=sys.stderr)
    raise SystemExit(expected_exit if ok else 2)
finally:
    terminal.close()
