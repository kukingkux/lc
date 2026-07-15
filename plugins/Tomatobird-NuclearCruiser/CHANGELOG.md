# 1.3.0
- Code cleanup (by ScandalTheVandal)
- Fixed potential bug where multiple CruiserNuker components could be added to the same cruiser (by ScandalTheVandal)
- Replaced some expensive operations with more efficient ones (by ScandalTheVandal)
- Disallow patching anything but vanilla cruiser to avoid issues (by ScandalTheVandal)
- Added configurable time period after detach from dropship where cruiser will take less damage
- Added option for compensation when nuclear cruiser is spawned
  - This also includes a chat message option that tells everyone how much compensation was given
- Added a patch that allows nuclear cruiser to spawn before ship has left orbit (only with FasterItemDropShip)
- Added option to reduce the intensity of the light emitted by the nuclear blast
- Added option to change the audio volume of the nuclear blast
- Added option to change the size and visibility range of the nuclear blast decal
- Added screen shake to the nuclear blast
- Organized the mod configuration
- Renamed a cruiser fragility option from "Normal" to "Default"
- Fixed incorrect decal object rotation

# 1.2.0
- Cruiser type flag is now saved to the savefile
- Cruiser type flag is now synchronized to all joining clients

# 1.1.1
- Fixed texture application (hopefully)
- Fixed custom vehicles not exploding
- Prevented alerts from displaying if ship is in orbit

# 1.1.0
- Made the mod only apply to the vanilla cruiser by default.
- Made the Nuclear Cruiser way more fragile by default.
- Added fragility options (Normal, Fragile, Extreme), configurable crash velocity and damage per crash.
- Made the explosion bigger by default.

# 1.0.0
- Initial Release