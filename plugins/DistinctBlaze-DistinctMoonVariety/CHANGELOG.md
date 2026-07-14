# v3.0.4

- Fixed items from the Dropship clipping into the ground on Retinue

# v3.0.3

- Small Hotfix

# v3.0.2

- Removed Dawnlib Dependency (No longer needed)
- Fixed moons not actually having tags the whole entire time since this mod's existence because of using an outdated LLL feature
- Yes, I'm serious.

# v3.0.1

- Added VR Support
- Fixed missing dungeon components on all moons preventing them from loading with Lethal Performance
- Fixed windows not having collision on Detritus
- Fixed a couple floating trees on Volition

# v3.0.0 | The Standards Update

### General
- Updated for v81
- More parity with vanilla moons
- Added Dawnlib & UniversalRadar dependency (temporary)
- Removed custom story logs (temporary)
- Removed Clownhorn B, Airhorn B, Radiobox & Shroud Sample
- Overall optimization & balancing
### 16 Attenuation
- Terrain & Level Design revision
- Tweaked Volumes & Fog
- Added more routes to and from Fire
- Changed texturing/details to Main & Fire buildings
- Added another fence
- Fixed Extension Ladder clipping through the fences
#### 77 Volition
- Terrain & Level Design revision
- Tweaked Volumes & Fog
- New tree & "cabin" models
- Reverted building models back to the ones before v2.0.0, with a revision on texturing and details
- Exterior lights are no longer tied to breaker box. They start off and turn on when approaching buildings
- Removed unique manor interior visuals
- Ambience inside is more soft and loops less harshly
- Fixed fog not covering the entire playable area
- Fixed the big trees having blocky shadows and weird leaves
### 24 Detritus
- New facility building model
- Added more debris/setpieces around the facility
- Fake Old Bird changes
  - Incomplete Old Birds no longer spawn randomly and are static
  - Complete Old birds now have scan nodes
### 98 Retinue
- New giant wall model & lights
- Added more debris/setpieces around the map
- Tunnel changes
  - The fire exits are now in a new outside area seperated from the rest of map, only accessible through where they previously were in the tunnels
  - Going inside the tunnels now properly counts as being "inside" (proper lighting and nightvision)
  - Added lights in the tunnels
  - The Eyeless Dog now spawns later into the day

# v2.1.3

### 77 Volition
- Readded the terminal video (didn't realize it was missing)
- Changed how the unique Stormy volume is applied so it does not apply to other weathers that also use the Stormy volume
- Adjusted Stormy & Eclipsed volume fog & darkness
- Adjusted outside enemy spawns & curves

### 98 Retinue
- Fixed inaccurate mesh colliders
- Fixed certain Reverb Trigger errors
- Changed Trainyard Turntable material

# v2.1.2

- Literally forgot to bundle Volition's scene.
- Hopefully the last hotfix for a while

# v2.1.1

- I did a bad.

# v2.1.0

- Remove unused custom scrap (Volatile Grenade & Pin Flashlight)

### 77 Volition
- Added a unique Mansion visual pass if its the chosen interior
- Many minor fixes around the outside
- Fixed Radiobox having no icon
- Fixed the Main mod version not having the SoS Graffiti (again..)
- Balance Pass

### 98 Retinue
- Many minor fixes around the outside

### 24 Detritus
- Fixed naturally spawning missles floating
- Balance Pass

# v2.0.3

### 16 Attenuation
- Fixed Main Entrance being partially submerged into the ground
- Removed unused Mesh Terrains

### 98 Retinue
- Fixed broken lighting during Eclipsed & Stormy

# v2.0.2

- Revised outdated README info
- Rebaked Occlusion Culling for all moons (forgot to do so for v2.0.0)

### 16 Attenuation
- Fixed missing girders in Main Building

### 77 Volition
- Fixed Fog not reaching low enough for certain parts of the map
- Fixed odd material on exterior lights when turned off
- Fixed missing SOS in the main mod

### 24 Detritus
- Reverted some Offmesh Link changes on Ship from long ago
- Reversed Old Bird & Eyeless Dog spawn chances (and reduced Eyeless Dog spawn chances even further for good measure)

### 98 Retinue
- Fixed absurdly low Daytime enemy spawn curve (for real this time)

# v2.0.1

### 16 Attenuation
- Fixed Main Entrance & Fire missing assets

# DistinctMoonVariety | The Optimization Update (v2.0.0)

- Did a lot of optimization throughout all the moons.
  - Overall filesize has gone from ~120MB to ~73MB
- Removed CustomStoryLogs as a dependency
  - Logs now uses LLL's ExtendedStoryLogs

### 16 Attenuation
- **Moon Redesign**
  - Opened up map playable space
  - Added new intertwining routes
  - Extended the tight crevice section
  - Fence to Main is now destructable via Cruiser
  - Added more general structures, rocks, and debris
- Removed Broken Device from Scrap spawn table
- Adjusted overall balancing

### 77 Volition
- (Standalone only) Volition will only have the SOS hint if Detritus is also installed
- Turned the radio boombox into it's own item, the Radiobox
  - It has worse audio range and lower volume than the normal boombox
- Added the dangerous bridge in the pit between Main and Fire Exit
- Redesigned Main & Side buildings
- Replaced most of the mushrooms in the ditch with different foiliage
- Adjusted Fog & Volume for Stormy & Eclipsed Weather
- Added *very* low chance for Factory interior
- Added new exclusive Insanity sounds
- Exterior lights are now tied to the Breaker Box
- Adjusted overall balancing

### 24 Detritus
- Recolored the Crane
- Trimmed the Crane's ladder (no longer climbable)
- Sunken Old Bird at the Main Entrance now only has a very low chance of being activated upon landing
- Reduced the value of the Mech Apparatus
- Added more LOD to objects around the map for performance
- Moved & Rewritten the Log
- Added Broken Device to the Scrap spawn table

### 98 Retinue
- Touched up on all the shipping crates, moved them around, and overall decreased how many there are
- Added LOD to a lot more objects in a effort to improve performance
- Added low chance for Mansion interior
- Raised chanced for Mineshaft interior
- Adjusted overall balancing

# v1.6.1

### 98 Retinue

- Fixed Outer Terrain not unloading in a very specific scenario
- Fixed enemies besides the dog being able to spawn in a part of the tunnels

# v1.6.0

- Added 1 New Moon, 98 Retinue

### 24 Detritus
- Added a preview video
- Adjusted lighting around the factory region and entrance building
- Moved several minor objects, mainly debris and easter eggs
- Made attempts to improve performance wherever possible
- Fixed several lights on the map unintentionally being tied to interior power and having null audio sources
- Balance Pass
  - Adjusted Enemy Spawn table
  - Lowered Outdoor Power `(24 -> 20)`
  - Lowered Min & Max Scrap `(18 to 22 -> 17 to 20)`
  - Decreased Interior Size `(1.8 -> 1.55)`
  - Slightly increased value of the special scrap

# v1.5.0

- Converted the Terrain on all 3 moons into meshes, improving their shading and lighting significantly to be more in line with Vanilla

# v1.4.0

- Added JLL as a required Dependency
- Updated README. Now includes level tags for all moons
- Added 2 new scrap variants that can spawn on any of the 3 moons `(Fog Airhorn, Party Clownhorn)`
- Fixed the Item Dropship playing its music way too early on all 3 moons

### 16 Attenuation
- Added 1 new custom scrap to the spawn table `(Broken Device)`
- Re-added Flooded as a possible weather, but now it's reversed
- Removed Turrets from the Interior
- Increased Interior Size `(1.0 -> 1.15)`

### 77 Volition
- Removed Halloween decorations
- Added 1 new custom scrap to the spawn table `(Shroud Sample)`
- Map Changes
   - Main Entrance Building Area & Houses Area have been expanded
   - Added new routes for the side buildings at Main Entrance
   - Leveled some pits that would get the cruiser stuck guranteed to incentivize more cruiser travel
   - Separated the water trigger for the pits into 2 separate water triggers 
- Added Foggy as a possible random weather
- Increased Routing Price `(450 -> 550)`

### 24 Detritus
- Updated the section for Detritus on the README. It'll stay hidden in Terminal but is no longer super top secret
- Map Changes
   - Changed lighting & ambience within the factory region
   - Removed all outside scrap spawn nodes
   - Added a new useable machine within the fire warehouse that can recharge a dull apparatus... if you can get inside
   - Have you seen Rusty?
- Increased Routing Price `(200 -> 250)`

# v1.3.3

### ???

- Improved NavMesh
- Adjusted OffMeshLinks and Terrain around the ship for easier navigation, both for enemies and players
- Adjusted some Objects and Terrain within the first half of the map for better cruiser navigation between Main and Ship
- Removed the Crate near the fence since you were able to climb it and jump over the fence into the map's second half without tools early, which was unintended (You can still use the Extension Ladder, Jetpack, or Cruiser)
- Lowered value of the Apparatus (Inactive) scrap & renamed it to Dull Apparatus
- Lowered value of the Missile scrap & increased its rarity weight
- Adjusted scrap spawn table & weights
- Adjusted spawn curves

# v1.3.2

- Rebaked Occlusion Culling on all moons

### 77 Volition
- Changed "the hint" for more clarity

### ???
- Slight rebalance to Scrap & enemy spawns

# v1.3.1

- Small Hotfix

# v1.3.0

### 16 Attenuation
- Remade the terrain because I accidently wiped the old one :What:  (It should be basically the same as the original)
- Removed Flooded as a possible random weather (*might* be revisited in the future)

### 77 Volition
- Terrain improvements
- Fixed Ground Fog not covering the entire map
- Added Foggy as a possible random weather
- Decorated the moon a bit for Halloween (Temporarily)
- YOUR CALL AWAITS

# v1.2.0

### 16 Attenuation

- Updated Moon Info
- Overhauled the outer terrain to give more of an impression of being within a canyon, similar to Assurance & Offense
- Opened up a bit more space around the ship for better cruiser navigation
- Extended the crevice section. Enemies can now wander a little into both crevice openings
- Added the appropriate reverb & ambience within the building's opening to match how it is on Assurance & Offense
- Increased chance of having the Factory Interior (~5% -> ~11%)
- Lowered Min & Max Scrap Value (250 - 500 -> 100 - 250)
- Increased Scrap Amount (10 - 14 -> 11 - 15)
- Remade the scrap spawn table to be unique and not just a tweaked version of Experimentation's table
- Raised Outside Power (6 -> 8)
- Lowered Daytime Power (7 -> 6)
- Adjusted enemy spawn chances

### 77 Volition

- Updated Moon Info
- Lowered Min & Max Scrap Value (400 - 800 -> 300 - 700)
- Remade the scrap spawn table to be unique and not just a tweaked version of Rend's table

# v1.1.0

### 16 Attenuation

- Made slight changes to the beginning area
- Flattened a bit of terrain near the fence that allowed you to jump over it
- Lowered fence and adjusted collider so the extension ladder doesn't clip into it as bad and so you can jump over it if you have the cruiser
- Increased Min & Max scrap (7 to 13 -> 10 to 14)
- Increased Min total scrap value (200 to 500 -> 250 to 500)
- Increased outdoor power (5 -> 6)
- Significantly reduced factory chances (~25% -> ~5%)
- Adjusted Landmine spawns & added Turrets to the interior
- Adjusted enemy & scrap spawn chances

### 77 Volition

- Fixed Volition using the wrong ambience clips
- Misc. Map Fixes
- Increased Price (300 -> 450)
- Adjusted Min & Max scrap (17 to 22 -> 18 to 21)
- Adjusted Spike Trap spawns & added Landmines to the interior
- Adjusted Enemy & Scrap spawn chances

# v1.0.0

- Initial Release