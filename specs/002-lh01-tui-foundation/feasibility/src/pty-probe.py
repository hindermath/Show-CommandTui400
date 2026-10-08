"""DE: Isolierter, begrenzter PTY-Proof. EN: Isolated, bounded PTY proof."""
import os, pty, subprocess, termios, fcntl, struct, select, time, json, sys, hashlib, datetime
from pathlib import Path
mode=sys.argv[1] if len(sys.argv)>1 else 'normal'
assert mode in ('normal','error','cancel','resize','small-exit','control','matrix','remap','repeat','stop','invalid','invalid-remap','out-redirect')
root=Path(__file__).resolve().parent
master,slave=pty.openpty();os.set_blocking(master,False)
def size(cols,rows):fcntl.ioctl(slave,termios.TIOCSWINSZ,struct.pack('HHHH',rows,cols,0,0))
size(100,24);before=termios.tcgetattr(slave)
def child_setup():os.setsid();fcntl.ioctl(0,termios.TIOCSCTTY,0)
psmode='Control' if mode=='control' else 'Stop' if mode=='stop' else 'Redirect' if mode=='out-redirect' else 'Ui'
cmd=['pwsh','-NoLogo','-NoProfile','-File',str(root/'probe-session.ps1'),'-Assembly','/tmp/lh01-proof-build/bin/net10.0/Lh01Fixture.dll','-Mode',psmode,'-RestoreSnapshotWindow']
if mode=='remap':cmd+=['-HelpKey','F2']
if mode=='invalid-remap':cmd+=['-HelpKey','F3']
if mode=='repeat':cmd+=['-Repeat']
if mode=='invalid':cmd+=['-InvalidContext']
env=os.environ.copy();env['TERM']='xterm-256color';env['LC_ALL']='en_US.UTF-8'
redirect=mode=='out-redirect'
p=subprocess.Popen(cmd,stdin=slave,stdout=subprocess.PIPE if redirect else slave,stderr=slave,env=env,preexec_fn=child_setup)
inputs=[master]+([p.stdout.fileno()] if redirect else [])
for fd in inputs:os.set_blocking(fd,False)
buf=bytearray();start=time.monotonic();steps=[];send_at=None;restore_sample=None;ack=False;shell_ack=False;phase=0;repeated=False
# Real framework keys in a synthetic PTY; no physical terminal or assistive proof.
schedule=[(.4,b'\x1bOP','F1'),(.8,b'\x1b[15~','F5'),(1.2,b'\x1bx','Alt+X')]
if mode=='error':schedule=[(.5,b'\x1b[19~','F8-injected-error')]
if mode=='cancel':schedule=[(.5,b'\x03','Ctrl+C')]
if mode=='invalid':schedule=[(.4,b'\r','Enter-invalid'),(.8,b'\x1bx','Alt+X')]
if mode=='remap':schedule=[(.3,b'\x1bOP','old-F1-unbound'),(.6,b'\x1bOQ','F2-remapped-help'),(.9,b'\x1bh','Alt+H'),(1.2,b'\x1bm','Alt+M'),(1.5,b'\x1bb','Alt+B'),(1.8,b'\x1bx','Alt+X')]
if mode=='matrix':
 keys=[(b'\x1bOP','F1'),(b'\x1bOS','F4-unavailable'),(b'\x1b[15~','F5'),(b'\x1b[20~','F9-unavailable'),(b'\x1b[21~','F10-unavailable'),(b'\x1b[23~','F11-unavailable'),(b'\x1b[24~','F12-root-back'),(b'\x1b','Esc-root-back'),(b'\t','Tab'),(b'\x1b[Z','Shift+Tab'),(b'\t','Tab'),(b'\t','Tab-to-list'),(b'\x1b[B','Down-first'),(b'\x1b[B','Down-second'),(b'\x1b[A','Up'),(b'\x1b[6~','PageDown'),(b'\x1b[5~','PageUp'),(b'\r','Enter-confirm'),(b'\x1bOR','F3-exit')]
 schedule=[(.5+i*.3,data,label) for i,(data,label) in enumerate(keys)]
if mode in ('stop','control','invalid-remap','out-redirect'):schedule=[]
while time.monotonic()-start<25:
 ready,_,_=select.select(inputs,[],[],.1)
 for fd in ready:
  try:chunk=os.read(fd,65536)
  except OSError:continue
  if not chunk:continue
  buf.extend(chunk)
  if b'\x1b[c' in chunk or b'\x1b[0c' in chunk:os.write(master,b'\x1b[?1;2c')
  if b'\x1b[6n' in chunk:os.write(master,b'\x1b[1;1R')
 if send_at is None and b'LH-01 FIXTURE' in buf:send_at=time.monotonic();steps.append('UI-render-observed')
 if send_at is not None:
  elapsed=time.monotonic()-send_at
  if mode in ('resize','small-exit'):
   if phase==0 and elapsed>.5:size(30,6);steps.append('resize-30x6');phase=1
   elif phase==1 and elapsed>1:
    if mode=='resize':size(100,24);steps.append('resize-100x24')
    else:os.write(master,b'\x1bx');steps.append('Alt+X-at-30x6')
    phase=2
   elif phase==2 and elapsed>1.5 and mode=='resize':os.write(master,b'\x1bx');steps.append('Alt+X');phase=3
  elif phase<len(schedule) and elapsed>schedule[phase][0]:
   os.write(master,schedule[phase][1]);steps.append(schedule[phase][2]);phase+=1
  if mode=='repeat' and not repeated and elapsed>2:
   # Second UI is sequential in the same host; give it a separate real exit key.
   os.write(master,b'\x1bOR');steps.append('F3-second-entry-exit');repeated=True
 if not shell_ack and b'LH01_SHELL_INPUT_READY' in buf:os.write(master,b'LH01_ACK\r');shell_ack=True;steps.append('caller-ReadHost-roundtrip')
 if not ack and b'LH01_RESTORE_READY' in buf:restore_sample=termios.tcgetattr(slave);ack=True;steps.append('restore-snapshot-before-shell-exit')
 if p.poll() is not None:break
if p.poll() is None:
 p.terminate()
 try:p.wait(timeout=3)
 except subprocess.TimeoutExpired:p.kill();p.wait()
 steps.append('timeout-terminated')
for fd in inputs:
 while select.select([fd],[],[],0)[0]:
  try:chunk=os.read(fd,65536)
  except OSError:break
  if not chunk:break
  buf.extend(chunk)
try:after=restore_sample if restore_sample is not None else termios.tcgetattr(slave);termios_error=None
except termios.error as e:after=None;termios_error=str(e)
text=buf.decode('utf-8','replace');parsed=None
for line in text.splitlines():
 if line.startswith('{"Mode"'):
  try:parsed=json.loads(line)
  except json.JSONDecodeError:pass
record={'TimestampUtc':datetime.datetime.now(datetime.timezone.utc).isoformat(),'SourceHashes':{q.name:hashlib.sha256(q.read_bytes()).hexdigest() for q in root.iterdir() if q.is_file()},'AssemblySha256':hashlib.sha256(Path(cmd[cmd.index('-Assembly')+1]).read_bytes()).hexdigest(),'Mode':mode,'Command':cmd,'Environment':{'TERM':env['TERM'],'Surface':'synthetic local macOS PTY; no physical/assistive proof'},'ExitCode':p.returncode,'Steps':steps,'InitialPtySettingsMatch':before==after if after is not None else None,'TermiosObservationError':termios_error,'TermiosBefore':before,'TermiosAfter':after,'CursorShowSequenceObserved':b'\x1b[?25h' in buf,'AlternateScreenLeaveObserved':b'\x1b[?1049l' in buf,'TranscriptSha256':hashlib.sha256(buf).hexdigest(),'Result':parsed,'Transcript':text}
out=root.parent/'evidence'/f'maca-pty-{mode}.json';out.parent.mkdir(parents=True,exist_ok=True);out.write_text(json.dumps(record,ensure_ascii=False,indent=2,default=lambda v:v.hex() if isinstance(v,bytes) else str(v))+'\n')
print(json.dumps({'Mode':mode,'ExitCode':p.returncode,'Steps':steps,'Result':parsed},ensure_ascii=False))
os.close(master);os.close(slave)
