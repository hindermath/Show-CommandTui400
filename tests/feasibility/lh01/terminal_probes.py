"""DE: PTY-Abfragen über Lesegrenzen sammeln. EN: Reassemble split PTY queries."""
class TerminalProbes:
    queries = ((b'\x1b[c', b'\x1b[?1;2c'), (b'\x1b[0c', b'\x1b[?1;2c'), (b'\x1b[6n', b'\x1b[1;1R'))

    def __init__(self):
        self.tails = {}

    def feed(self, descriptor, chunk):
        tail = self.tails.get(descriptor, b'')
        combined = tail + chunk
        matches = []
        for query, response in self.queries:
            start = 0
            while (index := combined.find(query, start)) >= 0:
                # A complete query retained in the tail was answered previously.
                if index + len(query) > len(tail):
                    matches.append((index, response))
                start = index + len(query)
        self.tails[descriptor] = combined[-3:]
        return [response for _, response in sorted(matches)]
