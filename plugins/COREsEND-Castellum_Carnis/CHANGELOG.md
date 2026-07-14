# Changelog

### 1.1.3

- Tweaked some balancing with the bone columns and vein pillars
  - Vein pillars can now show up as purple (was bugged before)
- Updated "Gutless Mode"
  - Updated the lights to be crystalline structures
  - Disabled the ambient light in the brain rooms
  - Added some screenshots to the mod description 

### 1.1.2

- Updated the entrance room with some overdue material detailing
- Added three new prop sets to the flesh labyrinth to add more landmarks
  - Vein pillars
  - Villi 'grass'
  - Bone columns (shows up a bit more when approaching the bone caves)
- Updated the "pinch" flesh labyrinth tile slightly
- Added "Gutless Mode" option in the config for those who don't have the guts to traverse the guts
  - Loosely censors the entire interior as a cave system
  - Removes veins by the exits
  - Mutes most ambient sounds
- Went through and crunched any remaining files to reduce filesize a bit more
- Made it so the "big" flesh labyrinth tile can't connect to another "big" tile
- Tweaked the "liver canyon" room's radar a smidge

### 1.1.1

- Added more configs
  - "Terrain" room biome matching the moon's biome (Defaults to False, True **requires** Loadstone to avoid a desync)
  - Apparatus pull event color correction
- Removed Loadstone as a hard dependancy with the "terrain" room config addition
- The "nasal cavity" room and its extention tile now has mucus dripping from the ceiling
- Fixed the entrance stinger being global for all players (sometimes?)
  - Clients can retrigger it for the host until the host enters (not worth delaying this update more to fix it)
- Added missing note in 1.1.0 changes about the new particles
- The █████ has become slightly more valuable
- Updated most texture to texture materials to have normal maps at the texture transition areas
- Added a mist to the "liver canyon" room's liquids
- Removed the non functional interior water from the entrance room
- Made tiles compatible with the v70 radar minimap
  - Certain vertical rooms have imperfect transitions due to draw distance limitations
  - Should be fairly compatible with "RadarEdits"
  - Main Entrance and fire exits are still cyan
  - Fire exits' radar line was made slightly bigger
  - Death pits have unique radar symbols for each room
  - Increased the enemy spawners' radar symbol's size
- Reworked the "flesh to bone" tiles' generation to better link their navmesh with the flesh archetype
- Adjusted one of the "liver canyon" room's bile animations to stay flooded slightly longer

### 1.1.0

- Added two new flesh loot rooms
  - Reduced the interior's max size due to the scale and chance of these rooms (15:18 → 13:16)
  - Made Loadstone a dependency to prevent a new room from desyncing during generation
- An irritant has produced ███████
- Added a new flesh labyrinth room to guarantee at least two fire exit spawns
- Added 6 extra scrap spawns similar to the Mineshaft
- Fixed "Landmines" (not "LandMines") not spawning in the interior
- Improved the smoothing on the spawner mouths to [slightly] blend in better with the walls
- Added a few configs
  - Employee corpses
  - Skylights changing with weather and time of day
  - Entrance stingers
  - Droplet particles
  - Six extra scrap spawns
- Fixed the content tags
- Updated the shader for the bioluminescent lights
- Updated the flesh "crossroads" room's breathing animation
- Updated the "eye" and flesh "crossroads" rooms' skylights to match the weather like the "two handed" room
- Fixed the 'grass' of the "eye" room covering scrap icons
- Added droplet particles to certain rooms

### 1.0.5

- **Added a blueprint and advice to the mod description for those who struggle with finding scrap**
- Fixed the minimap hiders for the "void" room
- Tweaked one of the sounds in the "void" room
- Added +1 light spawn as preparation for an upcoming room
- Adjusted some lighting and animation speed in the "two handed" room to better match their respective weather
- Moved the scrap spawn in the "horn" rooms a smidge closer to its entrance
- Added content tags "**Bloody, Flesh, Living, Organic**"
- Reduced the "spiral" hallway's weight for the start of the dungeon (0.75 → 0.55)
- Adjusted the bone archetype's branch lengths (2:4 → 2:3)
- Added minimap arrows for the "spiral" hallways to designate its vertical nature from similar tiles
- Added minimap hiders for the "spiral" hallway
- Darkened the bone texture for better scrap visibility on the ship minimap
  - Does not affect rooms that use the bone texture for detailing
- Updated the "flesh to bone" tile with more detailing to better match its concept
- Slightly increased the chance of the "nasal cavity" room to extend
- Added minimap hiders for the "nasal cavity" room
- Fixed the mouth vents' color on the minimap
- Fixed the "lung forest" room requiring you to jump to exit if you have too much weight
- Added a scrap spawn to the pit version of the flesh "crossroads" room and the entrance room
- Adjusted the various light fade distances to further improve optimization

### 1.0.4

- Project updated to v69 (Thank you so much, Xu Xiaolan!)
- Added a unique ground light prop to the "void" room
- Added veins to the fire exit metal walls
- Fixed the normal map on some of the veins
- Fixed the main entrance and fire exit walls not having collision
- The "two handed" room skylight now changes with the time of day and weather.  Supports:
  - Stormy
  - Eclipsed
  - Snowy
  - Snowy eclipsed
- Updated the Apparatus room's pull event

### 1.0.3

- Updated "two handed" room to have teeth at the base of the sinew ladder for readability
- Made a rare "two handed" room variation slightly more common (4% → 8%)
- Changed the "hand jump" room's collision to prevent players from sticking when falling

### 1.0.2

- Applied a change that should fix large interior generations
- Adjusted fire exit spawn chances to fix moons with multiple fire exits
- Slightly reduced flesh pillar spawn chances

### 1.0.1

- Removed nonfunctioning reverb triggers to fix the autopilot ship having an echo
- Reduced the inhale and exhale volume by 50%

### 1.0.0

- Initial release