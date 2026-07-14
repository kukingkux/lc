## v1.2.6
- Changed dependencies to work with newest version of game

## v1.2.5
- Changed dependencies to work with fork of facility meltdown

## v1.2.4
- Changed dependencies to work with newest facility meltdown v73 reupload

## v1.2.3
- FacilityMeltdown's warning voice is now disabled when MuteWarnings is enabled in the config.

## v1.2.2
- PizzaProbability now utilizes FacilityMeltdown's provided API to start and detect meltdowns.
- Sadly, there is no API function to disable automatic meltdowns, so a workaround is still utilized to block meltdowns.
- In simple terms, PizzaProbability now tampers as little as possible with FacilityMeltdown's internals; potentially improving stability.
  
## v1.2.1
- Added support for FacilityMeltdown v2.6.13.
- FacilityMeltdown's music is now disabled when PizzaPatch is enabled in the config.

## v1.2.0
- Added the ability to enable and adjust moon-specific config values.
- Enabled ApparatusValueMultiplier by default. If you've previously used PizzaProbability, your previous setting will remain intact.

## v1.1.0
### To utilize the new music tracks and scripts, please check the README.
- Added automatic configuration syncing based on [this guide](https://lethal.wiki/dev/intermediate/custom-config-syncing).
- Added 3 music tracks from The Noise Update.
- Added 2 music tracks from Pizza Tower.
- Added a non-meltdown version of Tsunami (Jay Cosmic Remix).
- Added 7 additional [PizzaTowerEscapeMusic](https://thunderstore.io/c/lethal-company/p/BGN/PizzaTowerEscapeMusic/) scripts.
- Added the ability to change the base value of an Apparatus via the config.
- Apparatus value is now forcibly overwritten when using ApparatusValueMultiplier.
- Reduced the absurdity of PizzaProbability's console output.

## v1.0.2
- Added support for FacilityMeltdown v2.5.

## v1.0.1
- Fixed paths for PizzaTowerEscapeMusic music and scripts.
- Fixed package file structure.

## v1.0.0
- Initial release.