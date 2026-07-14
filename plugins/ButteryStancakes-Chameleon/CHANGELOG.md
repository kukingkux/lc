# v2.4.3
- Updated how the double-sided material cache is emptied (so now you shouldn't see objects turn pink when disconnecting anymore)
- Updated [WaterAssetRestorer](https://thunderstore.io/c/lethal-company/p/Sniper1_1/WaterAssetRestorer/) compatibility to properly point to [MaterialAssetRestorerCore](https://thunderstore.io/c/lethal-company/p/Sniper1_1/MaterialAssetRestorerCore/) (this might have been causing a resurgence of the pink water bug)
# v2.4.2
- Fixed collisions with double-sided material cache (when using both `FixShipMeshes` and `FixDoorMeshes`) since this broke doorknobs again...
# v2.4.1
- `FixShipMeshes`
- Fixed `FancyEntrances` not correcting visuals for factory/mineshaft doors on vanilla moons since v2.3.5
# v2.4.0
- `ArcticFox`
# v2.3.5
- `FancyEntrances`
  - Now supports [Boom's Interiors](https://thunderstore.io/c/lethal-company/p/BLB_Thunderstore_Mods_LOL/Lead_Interiors/) by default
  - Although fancy entrances are still only *visually* supported on vanilla exteriors, custom moons/interiors now support wooden entrance *sounds* (interior/exterior)
- Maybe(?) fixed an issue with `FixDoorMeshes` which sometimes caused doorknobs (or entire doors) to turn pink
# v2.3.4
- Fixed `Flowery` window missing textures
- Fixes and adjustments to `FixDoorMeshes`
  - Now programmatically alters materials when possible, slightly reducing filesize
  - Now caches altered materials, reducing memory usage
  - Fixed a problem with echo scanner's blue visuals interacting incorrectly with manor doors
  - Fixed missing glass on singular greenhouse doors
- Adjusted default config
  - `RainyMarch` is now disabled by default
  - Titan now uses `Ice` caverns by default
# v2.3.3
- Fixed frosty footsteps not working consistently in ice caverns after v80
# v2.3.2
- `FancyFoliage` now fixes vanilla's incorrect lighting for March's Wych elms
# v2.3.1
- Hotfix for `SnowyCadavers` applying constantly until encountering the first mineshaft of a session
# v2.3.0
- v81 compatibility
  - `FancyEntrances` now works with animations
  - Removed `ReworkFoggyWeather`
  - Removed `FancyShrouds`
  - Removed `RecolorRandomRocks`
  - Added `SnowyCadavers`
- Moved `EclipsesBlockMusic` to [Enemy Sound Fixes](https://thunderstore.io/c/lethal-company/p/ButteryStancakes/EnemySoundFixes/)
# v2.2.4
- Fixed manor window settings not working with [Old Mansion](https://thunderstore.io/c/lethal-company/p/MBCollector672/OldMansion/)
# v2.2.3
- Added `DontChangeCaveSteps` setting
# v2.2.2
- `FancyEntranceDoors`
  - Added a new, fancier doorframe
  - Now accepts a list of interior names for manual compatibility (look at your logs after booting a lobby for all acceptable values)
    - Fixed [The Scarlet Devil Mansion](https://thunderstore.io/c/lethal-company/p/Alice/ScarletDevilMansion/) support being broken since v2.2.0 of that mod
	- Now supports [The Art Gallery](https://thunderstore.io/c/lethal-company/p/Magic_Wesley/WesleysInteriors/) by default
	- Now supports [CabIn](https://thunderstore.io/c/lethal-company/p/Sniper1_1/CabIn/) by default
	- Now supports [Old Mansion](https://thunderstore.io/c/lethal-company/p/MBCollector672/OldMansion/) by default
# v2.2.1
- Fixed an error being printed in the log when generating Salt/Slate caverns
- [Wesley's Interiors](https://thunderstore.io/c/lethal-company/p/Magic_Wesley/WesleysInteriors/) compatibility
  - This is just an initial pass, so let me know if any issues arise (or if I missed something)
  - "The Atlantean Citadel"
    - `FixDoorMeshes` no longer corrupts the texture of the entrance doors
	- Now supports `FancyEntranceDoors`
  - "Dilapidated Manor"
	- Now supports `FancyEntranceDoors`
  - "Expanded Mineshaft"
    - Now supports all cave variants
# v2.2.0
- v70 compatibility
  - Fixed rendering errors with greenhouse doors in manor (when using `FixDoorMeshes`)
  - `FancyFoliage` now applies to greenhouse plants
  - Fake window settings now work for the bedroom tile
- [Lobby Compatibility](https://thunderstore.io/c/lethal-company/p/BMX/LobbyCompatibility/) integration
- Fixed fake "windows" and cavern types not working on certain custom moons
- [Buttery Fixes](https://thunderstore.io/c/lethal-company/p/ButteryStancakes/ButteryFixes/) is now required for cavern types (Ice/Mesa/Gravel) to change footsteps
  - This is a limitation of the "No signal!" screen in vanilla
  - Changing footsteps would disable this feature and allow client-sided cheating
- Added "salt" and "slate" cavern types
  - Both use default footstep sounds, and can substitute as vanilla-consistent alternatives to Ice and Gravel respectively
- "ALL" can now be used as a keyword in any list-type config setting to apply a weight to all loaded moons
# v2.1.2
- Fixed snow disappearing from giants when they chase players
- Fixed `PowerOffBreakerBox` only working for the first round you unplug the apparatus
- Added `ReworkFoggyWeather` setting
# v2.1.1
- Added `BlackoutWindows` setting
- Fixed incompatibility I accidentally caused for [Rebalanced Moons](https://thunderstore.io/c/lethal-company/p/dopadream/RebalancedMoonsBeta/) with v2.1
# v2.1.0
- Re-implementation of `WindowVariants`
  - Added several new varieties of windows (for modded moons)
  - Now uses weighted lists like the mineshaft caverns for better customization
  - Windows no longer turn solid black when powered off
- Performance improvements
# v2.0.2
- Fixed `FancyEntranceDoors` causing softlocks on custom moons
# v2.0.1
- Reuploaded README because imgur broke all of my screenshots
# v2.0.0
- Complete refactor of internals
- Expanded on `SnowyGiants` setting (now `GiantSkins`)
  - Now includes a charred skin for giants burning to death
  - Also fixed the config setting being ignored (so you can now actually disable it)
- Changed `RainyMarch` behavior
  - "Mild" weather now always has rain (no longer a random chance)
  - Rain will no longer occur during foggy weather and eclipses
- Expanded on `RecolorRandomRocks` setting
  - Forest moons now have gray boulders instead of sandstone
  - Embrion now has amethyst boulders
- Expanded `PlanetPreview`
  - Artifice now has a unique appearance
  - Embrion now has a unique appearance
- Added a few more preview screenshots
# v1.4.2
- Migrated `FixDoorSounds` to [Enemy Sound Fixes](https://thunderstore.io/c/lethal-company/p/ButteryStancakes/EnemySoundFixes/)
- Fixed a bug with `DoorLightColors` when leaving a moon late in the night and relanding in the same hosted game
- Removed several bits of redundant [Rebalanced Moons](https://thunderstore.io/c/lethal-company/p/dopadream/RebalancedMoonsBeta/) compatibility code
# v1.4.1
- Fixed some old config settings still being visible after loading a new version
- Fixed `WindowVariants` not working unless `PowerOffWindows` was also enabled
# v1.4.0
- More treats from [dopadream](https://thunderstore.io/c/lethal-company/p/dopadream/):
  - `FogQuality`
  - `FogReprojection`
  - `FixTitanVolume`
  - `FixArtificeVolume`
- Added config settings:
  - `FixDoorSounds`
  - `WindowVariants`
  - `WeatherAmbience`
- Improvements to `DoorLightColors`
  - New colors for Stormy, Flooded, and Foggy weather
  - Now changes color as it gets darker outside
- General improvements to custom content compatibility
  - `FixDoorMeshes` should no longer cause softlocks on certain custom moons/interiors
  - [Rebalanced Moons](https://thunderstore.io/c/lethal-company/p/dopadream/RebalancedMoonsBeta/) should now support `FancyEntranceDoors` (except on Dine)
# v1.3.0
- Added config settings: (thx [dopadream](https://thunderstore.io/c/lethal-company/p/dopadream/)!)
  - `FancyFoliage`
  - `FancyShrouds`
  - `FixDoors`
- Increased the chance for March to be rainy
  - Also, hopefully fixed compatibility with [Rebalanced Moons](https://thunderstore.io/c/lethal-company/p/dopadream/RebalancedMoonsBeta/)
- Touched up snowy Keepers' texture
# v1.2.4
- Fixed the sun disappearing after you get fired
# v1.2.3
- Added config settings;
  - `PlanetPreview`
  - `SnowyGiants`
- Improved mod compatibility
# v1.2.2
- Added config settings:
  - `AutoAdaptSnow`
  - `PowerOffBreakerBox`
  - `PowerOffWindows`
# v1.2.1
- Resolved a potential error when landing on a moon configured to have no cavern types
# v1.2.0
- Added screenshots to Thunderstore page
- Now you can customize which moons have which types of caverns (includes modded levels)
- New "Gravel" cavern type
- Fixed helmet condensation not working on Gordion
- Fixed "EclipsesBlockMusic" setting being ignored
# v1.1.3
- Visual improvements and fixes
# v1.1.2
- Fixed rain clipping on Gordion (for real)
- You can now enable guaranteed storms on Gordion
# v1.1.1
- Titan now uses mesa caverns by default
- Fixed footsteps in mesa caverns
- Tried to improve rain clipping on Gordion
- Weather shouldn't desync between host and clients anymore on Gordion
# v1.1.0
- Significantly improved the aesthetics of the ice caverns
- New "Mesa" cavern type for Experimentation
- New "Desert" cavern type for Assurance and Offense
- March now experiences constant drizzle, as described in its terminal page (does not spawn quicksand)
- Gordion now experiences constant storms, as described in its terminal page (no lightning, just heavy rain)
- `FancyEntranceDoors` now supports [Scarlet Devil Mansion](https://thunderstore.io/c/lethal-company/p/Alice/ScarletDevilMansion/)
# v1.0.1
- Hotfix for Dine's main entrance changing location in v64
# v1.0.0
- Initial release