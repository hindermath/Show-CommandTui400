"""DE: Tatsächliche Textausgabe auf gleiche Farben prüfen.
EN: Reject identical foreground/background attributes in actual terminal text.
This is a rendering regression, not a physical-terminal or WCAG acceptance test.
"""
import argparse, json, re
from pathlib import Path

ESCAPE = re.compile(r'\x1b\[[0-?]*[ -/]*[@-~]|\x1b\][^\x07\x1b]*(?:\x07|\x1b\\)|\x1b[()][A-Z0-9]|\x1b[=>]')


def visible_spans(transcript):
    foreground, background = ('default-foreground',), ('default-background',)
    position = 0
    spans = []
    for match in ESCAPE.finditer(transcript):
        if position < match.start():
            spans.append((transcript[position:match.start()], foreground, background))
        token = match.group()
        if token.startswith('\x1b[') and token.endswith('m'):
            values = [int(v) if v else 0 for v in token[2:-1].split(';')]
            i = 0
            while i < len(values):
                code = values[i]
                if code == 0:
                    foreground, background = ('default-foreground',), ('default-background',)
                elif code == 39: foreground = ('default-foreground',)
                elif code == 49: background = ('default-background',)
                elif 30 <= code <= 37: foreground = ('palette', code-30)
                elif 40 <= code <= 47: background = ('palette', code-40)
                elif 90 <= code <= 97: foreground = ('palette', code-90+8)
                elif 100 <= code <= 107: background = ('palette', code-100+8)
                elif code in (38, 48) and i+1 < len(values):
                    count = 3 if values[i+1] == 2 else 1 if values[i+1] == 5 else 0
                    if count and i+2+count <= len(values):
                        color = tuple(['rgb' if count == 3 else 'palette', *values[i+2:i+2+count]])
                        if code == 38: foreground = color
                        else: background = color
                        i += count+1
                i += 1
        position = match.end()
    if position < len(transcript): spans.append((transcript[position:], foreground, background))
    return spans


def inspect(record):
    spans = visible_spans(record['sanitizedTranscript'])
    text = ''.join(s[0] for s in spans)
    assert 'Fokus / Focus:' in text, 'No actual state text rendered'
    assert 'Hilfe / Help: Hilfe und Aktionen / Help and actions' in text, 'Help was not rendered'
    assert 'Status / Status: Ansicht aktualisiert; Werte erhalten' in text, 'German refresh result was not rendered'
    assert 'View refreshed; values retained' in text, 'English refresh result was not rendered'
    hidden = [value for value, fg, bg in spans if fg == bg and any(c.isalnum() for c in value)]
    assert not hidden, 'Text rendered with identical foreground/background: '+repr(hidden[0][:80])
    return {'result':'Pass','checks':['actual-state-text','actual-help-context','actual-refresh-status','no-identical-color-text'],
            'scope':'synthetic terminal attributes; no physical-terminal or WCAG acceptance'}


if __name__ == '__main__':
    parser = argparse.ArgumentParser()
    parser.add_argument('--record', required=True)
    args = parser.parse_args()
    try:
        print(json.dumps(inspect(json.loads(Path(args.record).read_text(encoding='utf-8-sig')))))
    except AssertionError as error:
        print(json.dumps({'result':'Fail','reason':str(error)}))
        raise SystemExit(1)
