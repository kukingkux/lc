# ReviveDesyncPatch

While playing with mods that increase the max lobby size (e.g. MoreCompany) there is a chance the revived player count desyncs from the total player count.
If this occurs, the game never finishes the EndOfGame cycle, and therefore softlocks you into a '[Wait for ship to land]' message on the lever.

This mod simply adds a timeout to that check and continues after the set amount of time to prevent softlocking.

## Configuration

**EndOfGameWaitUntilTimeoutSeconds**: The time (in seconds) to wait until timeout. Default: 10