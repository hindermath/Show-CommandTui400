/* DE: Nur ABI-Groessen lesen. EN: Read-only ABI size probe, no terminal changes. */
#include <stdio.h>
#include <stddef.h>
#include <termios.h>
#include <string.h>
int main(int argc, char **argv) {
 if (argc == 2 && strcmp(argv[1], "--roundtrip") == 0) {
  struct termios saved, raw, after;
  if (tcgetattr(0, &saved)) return 2;
  raw = saved; cfmakeraw(&raw);
  if (tcsetattr(0, TCSANOW, &raw) || tcsetattr(0, TCSANOW, &saved) || tcgetattr(0, &after)) return 3;
  printf("{\"BeforeLocal\":%lu,\"AfterLocal\":%lu,\"Pendin\":%lu}\n", saved.c_lflag, after.c_lflag, (unsigned long)PENDIN);
  return 0;
 }
 printf("{\"TermiosBytes\":%zu,\"FlagBytes\":%zu,\"SpeedBytes\":%zu,\"NCCS\":%d,\"CcOffset\":%zu,\"ISpeedOffset\":%zu,\"OSpeedOffset\":%zu}\n",sizeof(struct termios),sizeof(tcflag_t),sizeof(speed_t),NCCS,offsetof(struct termios,c_cc),offsetof(struct termios,c_ispeed),offsetof(struct termios,c_ospeed));
 return 0;
}
