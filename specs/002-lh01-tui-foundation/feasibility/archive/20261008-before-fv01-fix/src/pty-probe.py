"""DE: Begrenzter PTY-Test des isolierten Fixtures. EN: Bounded fixture PTY proof."""
import os,pty,subprocess,termios,fcntl,struct,select,time,json,sys,hashlib,datetime
from pathlib import Path
mode=sys.argv[1] if len(sys.argv)>1 else 'normal'
assert mode in ('normal','error','cancel','resize','small-exit','control')
root=Path(__file__).resolve().parent
master,slave=pty.openpty()
os.set_blocking(master,False)
def size(cols,rows):fcntl.ioctl(slave,termios.TIOCSWINSZ,struct.pack('HHHH',rows,cols,0,0))
size(100,24);before=termios.tcgetattr(slave)
def child_setup():
 os.setsid();fcntl.ioctl(0,termios.TIOCSCTTY,0)
cmd=['pwsh','-NoLogo','-NoProfile','-File',str(root/'probe-session.ps1'),'-Assembly','/tmp/lh01-proof-build/bin/net10.0/Lh01Fixture.dll','-Mode','Control' if mode=='control' else 'Ui','-RestoreSnapshotWindow']
env=os.environ.copy();env['TERM']='xterm-256color';env['LC_ALL']='en_US.UTF-8'
p=subprocess.Popen(cmd,stdin=slave,stdout=slave,stderr=slave,env=env,preexec_fn=child_setup)
buf=bytearray();sent=False;resized=False;start=time.monotonic();steps=[];send_at=None;phase=0;restore_sample=None;ack=False
while time.monotonic()-start<25:
 ready,_,_=select.select([master],[],[],0.1)
 if ready:
  try:chunk=os.read(master,65536)
  except OSError:break
  if not chunk:break
  buf.extend(chunk)
  # The PTY emulates only terminal query responses; no screen-reader/GUI proof.
  if b'\x1b[c' in chunk or b'\x1b[0c' in chunk:os.write(master,b'\x1b[?1;2c')
  if b'\x1b[6n' in chunk:os.write(master,b'\x1b[1;1R')
 if not ack and b'LH01_RESTORE_READY' in buf:
  restore_sample=termios.tcgetattr(slave);ack=True;steps.append('restore-snapshot-before-shell-exit')
 if not sent and b'LH-01 FIXTURE' in buf:
  sent=True;send_at=time.monotonic();steps.append('UI-render-observed')
 if sent:
  elapsed=time.monotonic()-send_at
  if phase==0 and elapsed>0.5:
   if mode in ('resize','small-exit','control'):size(30,6);steps.append('resize-30x6');phase=1
   elif mode=='error':os.write(master,b'\x1b[19~');steps.append('F8-error');phase=4
   elif mode=='cancel':os.write(master,b'\x03');steps.append('Ctrl+C');phase=4
   else:os.write(master,b'\x1bOP');steps.append('F1');phase=1
  if phase==1 and elapsed>1.0:
   if mode=='small-exit':os.write(master,b'\x1bx');steps.append('Alt+X-exit-at-30x6');phase=4
   elif mode=='resize':size(100,24);steps.append('resize-100x24')
   else:os.write(master,b'\x1b[15~');steps.append('F5')
   if phase != 4:phase=2
  if phase==2 and elapsed>1.5:os.write(master,b'\x1bx');steps.append('Alt+X-exit');phase=4
 if p.poll() is not None:break
if p.poll() is None:
 p.terminate()
 try:p.wait(timeout=3)
 except subprocess.TimeoutExpired:p.kill();p.wait()
 steps.append('timeout-terminated')
while select.select([master],[],[],0)[0]:
 try:chunk=os.read(master,65536)
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
record={'TimestampUtc':datetime.datetime.now(datetime.timezone.utc).isoformat(),'SourceHashes':{p.name:hashlib.sha256(p.read_bytes()).hexdigest() for p in root.iterdir() if p.is_file()},'AssemblySha256':hashlib.sha256(Path(cmd[cmd.index('-Assembly')+1]).read_bytes()).hexdigest(),'Mode':mode,'Command':cmd,'Environment':{'TERM':env['TERM'],'Surface':'synthetic local macOS PTY, not physical terminal/assistive technology'},'ExitCode':p.returncode,'Steps':steps,'InitialPtySettingsMatch':before==after if after is not None else None,'TermiosObservationError':termios_error,'TermiosBefore':before,'TermiosAfter':after,'CursorShowSequenceObserved':b'\x1b[?25h' in buf,'AlternateScreenLeaveObserved':b'\x1b[?1049l' in buf,'TranscriptSha256':hashlib.sha256(buf).hexdigest(),'Result':parsed,'Transcript':text}
out=root.parent/'evidence'/f'maca-pty-{mode}.json';out.parent.mkdir(parents=True,exist_ok=True);out.write_text(json.dumps(record,ensure_ascii=False,indent=2,default=lambda v:v.hex() if isinstance(v,bytes) else str(v))+'\n')
print(json.dumps({k:record[k] for k in ('Mode','ExitCode','Steps','InitialPtySettingsMatch','CursorShowSequenceObserved','AlternateScreenLeaveObserved','Result')},ensure_ascii=False))
os.close(master);os.close(slave)
