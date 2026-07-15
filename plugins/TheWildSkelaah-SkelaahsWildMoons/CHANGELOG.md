## Version 3.0.8
**Noctis**
- Revamped the terrain layout slightly
## Version 3.0.7
- Fixed a compatibility issue regarding Immersive Entrance (excluding Bilge and Kanie, these 2 absolutely do NOT want to cooperate)
- Fixed various small bugs across some moons
- Added breakable trees to Terra
## Version 3.0.6
**All Moons**
- Fixed an issue that causes a player to rotate to the right when leaving the Fire Exit
- Added diffusion profiles to hopefully fix any shader issues on flowers, trees etc.

**Fracture**
- Added a new ambience to both the lower and higher altitudes
- Fixed an issue with the vertical ziplines working only for the first player that goes through them

**Deadlock**
- Added (slightly) new visuals
- Hopefully fixed an issue where the masked would stay in place after leaving the interior through the Main Entrance
## Version 3.0.5
**Bilge**
- Added a config to set the initial tide when landing the ship

**Deadlock**
- Added a config to alter the train's behavior (default / eclipsed)

## Version 3.0.4
**Noctis**
- Fixed an issue where the dropship items would clip through the concrete slab

**Fracture**
- Added zipline sound effects (special thanks to Moroxide for providing the sound effect)
- Removed all ladders
- Added vertical ziplines in place of ladders

**Kanie**
- Added a missing collider at the wooden bridge
- Added a config file which changes the behavior of the gate: Manual, Open, Automatic
## Version 3.0.3
**All Moons**
- Fixed an issue where the Main Entrance scannode would be positioned slightly to the side of the door

**Chronos**
- Fixed the collision issue (same one as 3.0.2)

**Noctis**
- Added volume shader exclusion zones to the ship and interior
## Version 3.0.2
- Fixed collision issues, specifically regarding the Fire Exit buildings on: Bilge, Fracture, Obscura, Deadlock, Kanie.

**Fracture**
- Fixed an issue where the tutorial popup would be cut short

**Obscura and Deadlock**
- Fixed an issue with a missing dungeon generator
## Version 3.0.1
**Fracture**
- Added missing colliders for some assets in the cabin

**Terra**
- Fixed an issue with the missing dungeon generator
## Version 3.0.0
*Unsure if its THE final content update, but at least for now I will be taking a 2-3 month break from new content to focus on finishing college*

**Added a new moon to the bundle: 412-Fracture**

**Moonpack changes**
- Updated dependencies to v80+ 
- Removed TerraMesh (for most moons)
- Added DawnLib's DawnSurface for dynamic footstep sounds, depending on the ground you step on
- Added Achievements (moonpack only)
- Added v80 creatures to specific moons:<br>

Feiopar: Kanie, Bilge <br>
GunkFish: Bilge, Kanie, Acheron<br>
Cadaver Growths: Obscura, Phobos/Deimos, Kanie, Fracture<br>
Kidnapper Fox: Terra, Fracture, Bilge<br>

**Terra**
- Added a new mod icon
- Added new foliage, Maple Trees and changed the overall feel of the moon
- Reduced the spawn rates of Forest Giants and Baboon Hawks

**Kanie**
- Replaced old foliage with the new v80 version
- Reduced the spawn rates of multiple outside enemies
- Replaced the breakable bridge with a destroyed wooden bridge

**Obscura**
- Replaced old foliage with the v80 version
- Reduced spawn rates of all interior creatures

**Phobos/Deimos**
- Added low gravity, which further decreases by changing altitude (works most of the time)
- Floating asteroid parts now have colliders to account possible collision with players

**Bilge**
- Added a new icon
- Added the v80 foliage
- Added more greenery around the Fire Exit path

## Version 2.13.9
**Chronos**
- Fixed an issue where the dropship would not drop bought items
## Version 2.13.8
**Chronos**
- Fixed an issue where the NavMesh in the interiors would break, causing enemies to not path into other tiles
## Version 2.13.7
**Kanie**
- Fixed an issue where all players would get the drunken effect upon taking out the Botanic Apparatus
- Added something....yellow

**Obscura**
- Fixed an issue where the players would keep losing battery upon pulling out the EMP'y

**Chronos**
- Updated the mod icon
- Updated the readme logo
## Version 2.13.6
- Readme Update
## Version 2.13.5
**Chronos**
- Fixed an issue where the Time Anomalies were not synced between clients
- Added variety to Time Anomalies depending on weather:<br>
Clear: (unchanged)<br>
Eclipsed:(small cooldowns, stronger anomalies)<br>
Stormy: (increased chance for reverse anomalies, weaker anomalies)<br>
Majora Moon:(very small cooldowns, weaker anomalies, they also stop occuring after 12:00pm)<br>
Blood Moon (stronger reverse anomalies,bigger cooldowns)<br>


(Big shoutout to Zigzag for fixing the anomaly code for me)
## Version 2.13.4
**Deadlock**
- Fixed an issue where the train's ambience would be heard inside the interior and when it was not moving
- The train can now go in 2 directions
- Readded Eclipsed as a weather
- Reduced interior size to 1.65x from 1.90x
- Added a new icon 

**Kanie**
- Fixed an audio issue, where the automatic gate would be heard at a much longer distance than it was supposed to
- Fixed an issue with an AI node being under the terrain
- Added a new icon

**Obscura**
- Fixed an audio issue, where the EMP Blast would be heard at a much longer distance than it was supposed to

**Noctis**
- Fixed a reoccurring issue where the Old Bird's rockets would clip into the terrain instead of exploding on contact
## Version 2.13.3
**Chronos**
- Nuked snowmen as they're not included in vanilla anymore
## Version 2.13.2
- Updated README as some moons had outdated info
- Properly bundled the pack
## Version 2.13.1
**Bilge**
- Made the water plane render the backside as well as the front side (you're now able to see the water plane)
- Reworked the tides to make the starting cycle be random instead of defaulting into Low Tide

**Acheron**
- Added an easier way to access main building (look near the pipes)
- Added a backside rendering to the lava (same as Bilge)

**Noctis**
- Fixed an issue where the Main Entrance doors would clip into the ground slightly
- Added volume effects to make the map more athmospheric for people using maximum gamma settings

**Deadlock**
- Fixed an issue where a gap would be seen in between the Main Entrance wall and the ground

**Chronos**
- Added Stormy weather (with custom "rain" particle system)
- Reduced the interior size down to 1.50x (was 1.75x)
- Nerfed the spawn curve of interior enemies (will spawn later in the day)
- Made the lighting during Eclipsed more orange during later parts of the day (was defaulting back to blue)
## Version 2.13.0
- Changed / Added new Content Tags for every moon:
- Every moon will now have 3 content tags - Skelaah | Modded | Custom - as well as additional ones which change / add specific modded interiors to the vibe of the moon:
- Acheron: Volcanic | Dry | GIDR150 | Redlight
- Noctis: Dry | Dark | HasCabin100 | GIBR150
- Terra: Temple | Jade | Rocky
- Deadlock: Factory | Argon | GIDR50 | Redlight
- Kanie: Fun | Temple | GIBR50 | GISH150 | HasCabin50
- Bilge: Ocean | Factory | GISH50 | GIBR50 | GIDR300
- Obscura: Urban | Atomic | Murica | GIBR50 | GISH50 | HasCabin50
- Chronos: Anomaly | Tundra | Ice | Glacier | Bloody | GIDR50 | GISH50
- PhobosDeimos: Deimos | Flesh | Organic | Bloody

**Kanie**
- Fixed an issue where the Botanic Apparatus would not spawn
- Added a funny new effect that players will experience when holding the Botanic Apparatus
- Same effect is added to Cannabis Plants, albeit only upon "Consuming" the plant
## Version 2.12.2
**Obscura**
- Fixed an issue where the item dropship would not open its doors, making players lose their bought items

**Kanie**
- Replaced the dropship christmas jingle with the vanilla one
- Added more athmospheric volume shaders during the end of the day
- Map objects, such as rocks, trees or the Sapsucker Nest should not be spawning on the landing area anymore
## Version 2.12.1
**Chronos**
- Readded Bird Watchers, now with a reworked behaviour
- Replaced the stop sign with a much more diagetic one (design made by Kenji)
## Version 2.12.0
**All Moons**
- Significantly reduced file sizes (shoutout to pacoito)

**Terra**
- Reduced the route price to 0
- Reduced interior size multiplier to 1.3
- Reduced scrap spawn for balance reasons
- Added Tulip Snakes to daytime enemy pool
- Added Baboon Hawks to outside enemy pool
- Added Foggy and Rainy weather
- Removed some enemies from the inside enemy pool
- Optimized the terrain

**Bilge**
- Readded terrameshed terrain as it was missing for quite some time
- Reworked the scrap pool

**Deadlock**
- Forced the weather to override to Clear (intended behavior, most weathers dont work really well on that moon)
## Version 2.11.3
- Updated dependencies
## Version 2.11.2
**Pho/Dei**
- Removed the "Phobos" tag as it made some terminal mods unable to route properly
- Removed the landing platform as I didn't like how it looked on the moon

**Kanie**
- Fixed an issue where the cruiser would take damage as it's too close to an opening gate
- Fixed an issue where the gate would sometimes take an extra second to begin its opening animation
- Slightly optimized the terrain
- Added new gameplay clutter to the landing area
- Added more visual and sound elements to main entrance
- Reduced the chance of Forest Giants and Old Birds spawning
- Added Tulip Snakes and Baboon Hawks to the spawn list
- Removed some out of bounds AI nodes, which caused a spam of NavMesh errors
## Version 2.11.1
**Pho/Dei**
- Added content tags "Phobos" and "Deimos"
- Increased scrap amount from 5-12 to 33-39
## Version 2.11.0
- Added a new entry to the pack: 02-Phobos / Deimos
## Version 2.10.7
**Kanie**
- Fixed the Botanic Apparatus not displaying its value when bringing it to the ship
## Version 2.10.6
- Added a wiki page where I will be talking about all of my moons
**Noctis**
- Removed the issue where the lantern sound effect would sometimes play multiple times

**Acheron**
- Fixed an issue where the floating rock would rotate to its side near the end of its animation
- Fixed an issue where staying on the rock until it sinks would fling you out of the map bounds
## Version 2.10.5
- Updated readme, now every moon is sorted from the cheapest -> most expensive 
- Each one of the moons now has a set of recommended modded interiors (authors of said interiors are credited near the Special Thanks part)
## Version 2.10.4
**Deadlock**
- Added volume shaders for slightly better presentation
- Added Eclipsed weather compatibility
- Blacklisted all other weathers including **most **custom weathers
- During Eclipsed, the train will show up way more frequently
## Version 2.10.3
**Obscura**
- Fixed an issue where the entrance teleports would not work
## Version 2.10.2
**Terra**
- Reduced level size by almost 60%
- Reduced price to 400 credits
- Reduced hazard level to A+
- Changed the position of the Fire Exit

**Obscura**
- Changed the Fire Exit leading towards the EMP'y
- The person pulling the EMP'y out will be able to see the Unstable Core exploding
- Changed the battery drain that the EMP'y causes from 75% to 100%
- Increased the scrap value of EMP'y from ~50 to 175 credits
- Changed the Fire Exit position to be closer to the pond area
- Added a new terrain path to lead the players back to the ship from said Fire Exit
- Fixed the issue where the player could softlock by going into a specific building near the Main Entrance

**Noctis**
- (Hopefully...?) fixed an issue with the interior lighting being too bright
## Version 2.10.1
**Bilge**
- Smoothed out the animations of the water after changing tide (removed it's "snap" to the position)
- Fixed the issue where the HUD warning would play multiple sounds after announcing a specific tide

**Noctis**
- Noctis' ambience no longer plays in the interior
- Reduced the flash beacon's light intensity to reduce the eye strain

**Chronos**
- Fixed an issue with bundling a duplicate of the Spike trap
## Version 2.10.0
**All Moons**
- Increased the amount of min. / max. scrap available

**Chronos**
- Added the reworked version to the moonpack
- Removed the Bird Watchers for now, they are way too unbalanced and too complex to simply tweak them
- Added compatibilty with Zigzag's Blood Moon (not a major one but it'll still be noticed I hope)
- Changed the postition of the prefab orbit so it doesn't clip into the ship sometimes

**Deadlock**
- Reduced the size down from 1.95 to 1.60

**Bilge**
- Tweaked with the spawn graphs, now there shouldn't be any creatures spawning at like 9am
- Increased the amount of inside hazards from 0-1 (both turrets and landmines) to 2-9 (landmines) and 1-4 (turrets)
- Decreased the interior size from 2.15 to 1.85
## Version 2.9.3
- Deleted the extra kanie.lethalbundle which I must have put there by accident (my bad)
## Version 2.9.2
**Kanie**
- The lamps will turn on instantly (instead of 6PM) during the following weathers: Eclipsed, Blood Moon, Forsaken, Hallowed
- The gate can now be opened manually, it will close itself after a while though, so use it wisely

**Acheron**
- Fixed the issue where the player's model would offset after jumping in and out of the moving rocks
- Fixed the issue where placed items would become comically large
- Made the interior fog slightly more purple
- Fixed the dropship dropping items a bit too low below the ground
## Version 2.9.1
- Small readme update (you can now support me on Ko-fi)
## Version 2.9.0
**Acheron**
- Overhauled the entire map layout
- Increased the difficulty of the moon from C to B-
- Decreased the interior multiplier from 1.80 to 1.55
- Added StarlancerAIFix as a dependancy
- Added itolib as a dependancy
- Added JLL as a dependancy
- Added new available weather types: Stormy, Rainy, Foggy.
- Reduced the file size from >36MB to 17.5MB
- Added a new moon Gimmick - Blazing Heat: Acheron is now flooded by a magma river. Players in close proximity to the magma will lose their HP every 25 seconds. Entering the range of Blazing Heat can be recognized by the screen becoming red-ish. Entering the lava is near instant death. To navigate around the moon, use the floating obsidian rocks.
- Blazing Heat does not affect players whenever the weather is Rainy, Stormy or Hurricane (from Wesley's Weathers).
- Removed the outside enemies, had to due to issues with the lava :/
- Added a certain outside entity to the interior spawns

**Obscura**
- Reduced the film grain to avoid video bitrate issues.
## Version 2.8.8
**Noctis**
- Fixed the Old Birds' rockets clipping through the terrain
- Removed the Butler from the enemy pool due to bugs
## Version 2.8.7
**Chronos**
- Finally updated to v73 (massive shoutout to Zigzag)
- Upped the numbers on the time anomalies: Strong Anomalies will appear slighly faster (120s > 100s) and if forward, will skip up to 3 hours.
## Version 2.8.6
**Kanie / Bilge**
- Fixed the position of the moon prefabs when routing to them, now you'll be able to see them more clearly

**Kanie**
- Added colliders and navmesh obstacle components to the lamp posts as they were previously missing
- Removed OoB nodes which allowed the Giant Sapsucker to spawn behind the fence gates in the landing area

## Version 2.8.5
- Readded Acheron back to the pack (Chronos still broken :c)
## Version 2.8.4
**Deadlock**
- Updated moon images in the readme since they weren't showing up (thank you norman6700)
## Version 2.8.3
**Bilge**
- Nerfed the time it takes for the High Tide to spawn from the initial warning to 45 seconds (was 25 seconds)
- Readded the pilot warnings for both High and Low Tides and made them more descriptive

**Obscura**
- Added a pilot warning message whenever the EMP'y is pulled out (will expand on it in future update)
- Terramesh'ed the terrain

## Version 2.8.2
**Obscura**
- Added proper images to the readme
- Changed the Reverb Zone when near the Unstable Core; hopefully fixing the audio distortion glitch
- Removed the (unforseen) motion blur effect when spectating dead players
- Nerfed the interior multiplier from 2.75 to 2.50
- Swapped around the daylight entities' weights (too many locust bees)
- Added new effect to the Unstable Core, now you might expect what happens whenever you pull the appy out

- **Other Moons**
- Updated standalones to v73 (except Chronos and Acheron)
- Added images to Deadlock's readme
- Added fish to Kanie (because fish)
## Version 2.8.1
- Readme update (I forgor)
- Fixed Obscura crashing the game upon landing
## Version 2.8.0
Added new moon: 874-Obscura

**All Moons**
- Updated to v73

**Chronos / Acheron**
- Currently disabled due to lost files / script issues
- Removed / changed the dependancies of these moons above to reduce unnessecary bloat

**Deadlock**
- Fixed the main entrance not aligning to the wall
## Version 2.7.4
**Kanie**
- Switched guidance poles for actual lamps

**Deadlock**
- Fixed an issue where the massive building in the background would clip into some modded interiors
## Version 2.7.3
- Removed something you were NOT supposed to see yet
## Version 2.7.2
- Added new moon prefabs when routing to certain moons: Kanie, Deadlock, Noctis, Bilge. Chronos doesn't really need one atm, and Acheron and Terra will be getting their ones when I eventually finish them.
## Version 2.7.1
**Kanie**
- Fixed an issue where the Botanic Apparatus would re-insert in the air after starting the game
- Changed the Botanic Apparatus so now it will no longer: increase spawns, wake up Old Birds, turn the interior lights off, give off a radiation warning and no longer trigger Facility Meltdown if you have that mod.
- Added itolib as a dependancy
- Added more tracking for the players to find the fence gate hole
## Version 2.7.0
**Kanie**
- Overhauled the entire map
## Version 2.6.9
**Deadlock**
- Temporarely fixed an issue with the train desyncing on other clients
## Version 2.6.8
**Deadlock**
- Buffed up the scrap spawns
## Version 2.6.7
- Readded content tags to multiple moons
- Fixed a volumetric fox on Deadlock

## Version 2.6.6
**Deadlock**
- Fixed a skybox issue (would change into the vanilla one after 6PM)

**Kanie**
- Fixed the stupid fucking issue with voiding players on lobby launch
- Changed some indoor / outdoor enemy spawns
- Added TZP as a possible scrap spawn (gonna be a bit before I learn how to properly add custom items)
- FUCK YOU STORY LOG VOID ISSUE
## Version 2.6.5
- Reverted Kanie to its previous iteration which will now suffice as a fix to the void issue
## Version 2.6.4
**All Moons**
- Updated content tags
## Version 2.6.3
**Deadlock**
- Fixed an issue with CodeRebirth softlocking the level
## Version 2.6.2
**Deadlock**
- Added colliders towards the back wall near the Main Entrance
## Version 2.6.1
- Readme Update
## Version 2.6.0
- ADDED A NEW MOON: 81-Deadlock
## Version 2.5.5
- Updated some readme files

**Noctis**
- Added lights near the dropship to make the dropped items more visible

## Version 2.5.4
**Bilge**
- Reduced the price down to 500

**Terra**
- Fixed the dropship's items spawning under the terrain
- Fixed multiple grass meshes floating above the terrain
- Updated the water to have custom Ogopogo spawn zones
## Version 2.5.3
**Kanie**
- Removed the rest of unbreakable trees
## Version 2.5.2
**Kanie**
- Added a new mechanic - automatic door gate (be sure not the be near them when they are closing)
- Added an alternative exit from the landing zone
- Added JLL as a dependency

**Bilge**
- Readded the VFX on a breakable pipe
- Added extra lights near the bottom platform to make it more visible during the midday
- Increased the route price from 450 to 625
## Version 2.5.1
**Terra**
- Made the pillar jump near the fire exit a bit easier
- Increased the quality of the grass patches near the main entrance
## Version 2.5.0
- ADDED A NEW MOON: 28-Terra.
## Version 2.4.10
**Chronos**
- Fixed an issue where the anomalies would appear on other modded moons after going to Chronos
- Changed the colour of the fog and increased it's visibility slightly
- Added a new Fire Exit
- Removed the weird parkour thing next to the bridge (I will make it better in the next updates)
## Version 2.4.9
- Reverted Kanie back to the previous version
## Version 2.4.8
**Noctis**
- Changed the way the flash beacon works (proximity instead of stable cooldown)
- Added a new flash animation whenever an enemy is nearby

**Kanie, Bilge**
- Further decreased the file sizes
## Version 2.4.7
**Kanie**
- Fixed the issue where some trees had a wrong breakable vfx 

**Noctis**
- (Potentially) fixed an issue with the light not synchronising between clients
## Version 2.4.6 (Bilge is working so I've finally sat down and optimized the moons)
- Changed the icon so it includes 's at the end
- Changed the README (had a mismatching number of moons on its page)

**Noctis, Kanie, Bilge**
- Reduced the lethalbundle file sizes by nearly a half
## Version 2.4.5 (EXPERIMENTAL VERSION, ROLL BACK TO 2.4.4 IF SOMETHINGS NOT WORKING)
**Bilge**
- Optimized the file
- Readded Tides, now triggering on specific hours instead of randomly
## Version 2.4.4
**Noctis**
- Slightly lowered down moon's ambiance
- The flash beacon can now be activated manually
- Removed the ability for the flash beacon to activate automatically
## Version 2.4.3
- Added Noctis into the official README
- Sligtly optimized some moons
## Version 2.4.2
**Noctis**
- The flash beacon now has a longer uptime (from 5 > 8 seconds)
- Fixed the off-mesh links on the ship
- Changed the spawn curves for outside enemies
- Increased the outdoor enemy power count from 4 to 5
**Kanie**
- Potentially fixed an issue where the masked would become unkillable upon entering the ship
## Version 2.4.1
- Changed the manifest to say 5 moons (so Moroxide doesnt snap at me again)
## Version 2.4.0
- ADDED A NEW MOON: 615-Noctis.

## Version 2.3.4
- Fixed an issue where some of the trees would become unbreakable by the Cruiser
- Replaced Masked spawns to prevent from a potential ship navmesh issue
## Version 2.3.3(ITS SO OVER)
- REMOVED TIDES FROM BILGE (for the time being, to make the maps playable)
## Version 2.3.1
**Bilge**
- Changed some stuff around the platform 
- Added colliders to the main building roof
- Removed peak from the elevator back to a vanilla jingle
## Version 2.3.0 (WE ARE SO BACK)
**All Moons**
- Updated to v70 <br>

**Bilge**
- Reworked the entire layout of the map
- Added a new pathway towards Main Entrance, which includes an elevator
- Possibly fixed an issue where the Tides were not synchronized between clients<br>

**Kanie**
- Added the new vanilla outdoor enemy to its outside enemy list
## Version 2.2.7
**Bilge**
- Possibly fixed an issue of a preview video not showing up in standalone version
- Fixed an issue where the interior fog would mess with laser pointers
## Version 2.2.6
**Bilge**
- Added new, immersive ambience
## Version 2.2.5
**Bilge**
- Reduced the error log spam when in orbit after selecting Bilge
## Version 2.2.4
**Bilge**
- Reduced the chance of the starting tide to be a high tide from 75% to 15%
## Version 2.2.3
**Bilge**
- NEW MECHANIC: Tides
## Version 2.2.2
**All moons:**
- Fixed an issue with the preview videos not appearing when in orbit

 **Kanie and Bilge:**
 - Reduced the video's file size

**Acheron:**
- Overhauled the entire east side of the moon (west side coming soon)
## Version 2.2.1
- Experimental update, changed file from MP4 to M4V
## Version 2.2.0
**All Moons**
- Added preview videos on the terminal monitor when in orbit

## Version 2.1.7
- Readme Update!
## Version 2.1.6
**Bilge:**
- Changed the space under the catwalk stairs under the platform to be less jarring to look at
## Version 2.1.5
**Acheron:**
- Fixed the ladder
- Added masked as default indoor enemies
## Version 2.1.4
- Prevoius patch didnt change anything because I'm fucking STUPID
## Version 2.1.3
- Removed BMX.LobbyCompatbility depedency
## Version 2.1.2
- Reduced the chance of a reverse anomaly to appear from 35% to 30%
- Changed the Pilot Computer notification text so it doesn't differenciate which anomaly has occured

## Version 2.1.1
- Added BMX.LobbyCompatbility as a depedency

## Version 2.1.0
**Kanie:**
- Fixed ship offmesh links
- Changed the density of the water on the lake

**Chronos:**
- NEW MECHANIC: Time Anomalies
- Removed one of the Fire Exits
- Fixed ship offmesh links
- Added JLL as dependancy

## Version 2.0.3
**Bilge:**
- Updated NavMesh around the entire map
## Version 2.0.2
**All moons:**
- Updated README files (sorry Sniper)<br>
**Kanie:**
- Reverted the skybox to default
- Changed the fog colour inside the interiors to light-green from navy-blue
## Version 2.0.0
**Kanie:** 
- Fixed an issue where the Butler spawning would case a shit-ton of errors in the console
- Fixed a collider issue on the hangar zone
- Removed AI nodes on the hangar zone
**Acheron:**
- Added NavMesh Modifiers to bridges, making the enemies on them an actual threat

***NEW MOON ADDED: 3-Bilge***

## Version 1.0.6
**Kanie:**
- Attempting to fix an console spamming Navmesh issues
## Version 1.0.5
**Chronos:**
- Added a lore-accurate skybox
## Version 1.0.4
**Kanie:**
- Massive weather overhaul
- Reduced outside enemy spawns
- Increased inside enemy spawns
## Version 1.0.3
**Kanie:**
- Ambience overhauled
- Added better looking shader to the water pond area
- Fixed the Ogopogo spawning (Biodiversity mod)
## Version 1.0.2
**All Moons:**
- Fixed reverb triggers<br>
**Acheron:**
- Added reverb triggers
- Fixed a ladder clipping issue
## Version 1.0.2
**Acheron:**
- Added an additional way to enter the Fire Exit path
- Updated several tags / layers around the map
## Version 1.0.0
Initial Release