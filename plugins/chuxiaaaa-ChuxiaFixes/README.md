# Chuxia Fixes

[![Thunderstore Version](https://img.shields.io/thunderstore/v/chuxiaaaa/ChuxiaFixes?style=for-the-badge\&logo=thunderstore\&logoColor=white)](https://thunderstore.io/c/lethal-company/p/chuxiaaaa/ChuxiaFixes/versions/)
[![Thunderstore Downloads](https://img.shields.io/thunderstore/dt/chuxiaaaa/ChuxiaFixes?style=for-the-badge\&logo=thunderstore\&logoColor=white)](https://thunderstore.io/c/lethal-company/p/chuxiaaaa/ChuxiaFixes/)

## Features

### General Fixes

* **Disable Unknown Font Warning:**
  Disables console warning messages about unknown fonts.

* **Disable Network Analyzer:**
  Disables the built-in network analyzer,network analyzer will cause performance issues.

* **Fix NetworkObject Parent Reference:**
  Fixes an issue where a `NetworkObject`’s cached parent was not set correctly.

* **Fix Death Boxes Display:**
  Fixes the issue where player names and avatars were displayed incorrectly in spectator mode.

* **Fix Gift Box:**
  Fixed the bug with the gift box in late joining (that is: when a gift box has been opened, a new player joining the lobby can still see and use the gift box)
---

### Player Name Fix

* **Fix Incorrect or Unknown Player Names**
  Automatically detects and corrects incorrectly displayed or "unknown" player names.

* **Work Interval (30s)**
  Checks and corrects player names every 30 seconds.

---

## Configuration

| Section       | Key                    | Default | Description                                   |
| ------------- | ---------------------- | ------- | --------------------------------------------- |
| General       | DisableFontWarn        | `true`  | Disable unknown font warnings                 |
| General       | DisableNetworkAnalyzer | `true`  | Disable the built-in network analyzer         |
| General       | FixNetworkObject       | `true`  | Fix cached parent reference for NetworkObject |
| General       | FixDeathBoxes          | `true`  | Fix spectator mode name/avatar display        |
| General       | FixGiftBox             | `true`  | Fix bug with the gift box in late joining     |
| FixPlayerName | Enable                 | `true`  | Enable player name correction                 |
| FixPlayerName | WorkInterval           | `30f`   | Time interval between checks (in seconds)     |

---

## Support

* The [thread](https://discord.com/channels/1168655651455639582/1396719856161915011) in the [LC Modding Discord Server](https://discord.gg/XeyYqRdRGC)

* QQ group: **1060993887**
