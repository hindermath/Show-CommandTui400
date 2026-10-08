"""DE: Beobachtete Vertraege pruefen. EN: Assert observed contracts, not screenshots."""
import json
from pathlib import Path
root=Path(__file__).resolve().parent.parent
checks=[]
def require(condition,name):
 if not condition:raise AssertionError(name)
 checks.append(name)
for mode in ('normal','error','cancel','resize','small-exit','control','matrix','remap','repeat','stop','invalid','invalid-remap','out-redirect'):
 d=json.loads((root/'evidence'/f'maca-pty-{mode}.json').read_text());r=d['Result']
 require(r is not None and 'timeout-terminated' not in d['Steps'],f'{mode}:result-and-no-timeout')
 require(r['ContextUnchanged'] and r['ConfiguredTerminalModesRestored'],f'{mode}:context-and-configured-modes')
 if mode in ('error','invalid-remap','out-redirect'):
  require(d['ExitCode']==3 and r['Failure'] is not None,f'{mode}:expected-negative-result')
 else:require(d['ExitCode']==0 and r['Failure'] is None,f'{mode}:normal-result')
 if mode not in ('out-redirect',):require(r['ShellReadback']=='LH01_ACK',f'{mode}:caller-input-roundtrip')
 if mode=='out-redirect':require(r['Failure']['ErrorId'].startswith('CapabilityRejected') and r['TerminalBefore']==r['TerminalAfter'] and 'UI-render-observed' not in d['Steps'],'redirect:reject-before-change')
 if mode=='invalid-remap':require(r['Failure']['ErrorId'].startswith('ParameterArgumentValidationError') and 'UI-render-observed' not in d['Steps'],'remap-conflict:reject-before-init')
 if mode=='stop':require(r['Results'][0]['Calls']>=1 and r['Results'][0]['State']=='Stopped','actual-StopProcessing')
 if mode=='repeat':require(sum(bool(x.get('UiEvents')) for x in r['Results'])==2,'two-UI-entries-in-same-host')
 if mode in ('matrix','remap','invalid'):
  events=r['Results'][0]['UiEvents'];actions=[x['Action'] for x in events if x['Kind']=='Action']
  require(all(x['Value']=='synthetic-value' for x in events if x['Kind']=='Action'),f'{mode}:no-value-loss')
  final=next(x for x in events if x['Kind']=='FinalState');require(final['First']=='synthetic-value' and final['Second']=='second-value',f'{mode}:both-fields-retained')
  if mode=='matrix':
   inputs=[x for x in events if x['Kind']=='Input']
   require(actions.count('Unavailable')==4 and actions.count('Back')==2 and 'Confirm' in actions and 'Exit' in actions,'matrix:contextual-actions-and-root-back')
   require(next(x for x in inputs if x['Key']=='Shift+Tab')['FocusName']=='second','Tab-moves-to-second-field')
   require(next(x for x in inputs if x['Key']=='PageDown')['FocusName']=='list' and next(x for x in inputs if x['Key']=='PageUp')['Selected']==5,'page-navigation-stays-in-list')
   require(final['Selected']==0,'page-up-restores-first-item')
  if mode=='remap':require(actions.count('Help')==2 and 'ActionsMenu' in actions and 'Back' in actions and 'Exit' in actions,'real-F2-remap-and-alternatives')
  if mode=='invalid':require('Confirm' not in actions and 'Unavailable' in actions,'invalid-confirm-has-no-action-effect')
(root/'evidence/contract-assessment.json').write_text(json.dumps({'Status':'PASS','Checks':checks,'Scope':'automated synthetic Mac A contracts; no physical/assistive acceptance'},indent=2)+'\n')
print(f'PASS: {len(checks)} observed contract assertions')
