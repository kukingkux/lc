## Version 2.0.3
- Recompiled scripts for v81 (and hopefully resolving some issues with giant sapsuckers), not thoroughly tested and the moon itself hasn't been rebuilt yet

## Version 2.0.2
- Rewrote custom footstep script to no longer unintentionally change footstep sounds in the interior
- Removed unintended sound effect from a flickering light
- Possibly addressed issues with a certain texture change not consistently applying on all clients

## Version 2.0.1
- Recompiled and updated netcode patching for V73 (unsure how well it works since public release of LLL still isn't updated, so I can't test it yet)

# Version 2.0.0

<details>
<summary><b>Event Rework [SPOILERS]</b></summary>
<br/>

**The apparatus insertion event has been significantly expanded and fleshed out, the biggest changes are:**

- A new endemic creature will be awakened after triggering the event on Wither, making the escape more dramatic and perilous

- Improved apparatus insertion: new sound effects, textures, models, animations, and lights to make the process overall much more polished

- Overhauled alarm sequence:
	- Lights in the interior and at its three entrances are now also included
	- Lights now pulse their intensity in time with the horn
	- The pipe in the interior now ruptures, filling it with steam
	- The event must now be shut down manually using one of two breakers on the map
	- Large spikes will emerge from the ground outside

- A 4th more valuable withered item reward can now be found by those able to traverse the new obstacles and reach it

- The dog is green now

---

</details>

- Exterior environment changes:
	- Terrain has been entirely remodelled and repainted to look a bit sharper and bumpier, so cliffs are more well-defined and large mountains and cliffsides look appropriately "rocky"
	- Spread out the transition between forest and desert over a longer distance
	- Significant changes to distant terrain features: consolidated protruding spikes into a few large abstract structures, added more mountaineous terrain, completely overhauled the desert rock formations to better resemble a mesa
	- Some new decorative props on the map: a few around the forest enclosure, a pipeline spanning the lake, and more detail to the power poles and wires
	- The desert enclosure is now behind a garage door which needs to be opened from the inside (default state is configurable)
	- Internally restructured the rock assets so all the areas with rocks have been slightly touched up, and the arrangement of rocks near cliffsides has been changed completely
	- Changed the distant lit up towers: moved one to better match the new terrain, glow colour is more yellow, and all towers now contain actual models for their light sources

- Interior renovations:
	- New structural supports and wall decor
	- General reorganization of the main room furniture
	- Improved lighting overall (including various new lights and a new animated lighting sequence)
	- Lights are now tied to the true interior's power (e.g. breaker, apparatus)
	- Existing posters have been redrawn, given 3D meshes, and an improved paper texture, with many new posters (and some other drawings) added as well
	- Added a pulley system to transport players and items to the upper catwalk (2 people required to operate)
	- Some other features related to the new reworked map event

- Elevator improvements:
	- New buttons and control panel models/lights
	- New textures
	- Remade most of the music tracks to have less awkward cuts, more variety, and end nicely when the elevator goes up
	- Fixed vanilla issue with elevators where music wouldn't play correctly if the elevator's button was pressed too quickly after it stops

- Other general changes:
	- Improved Dust Clouds weather when it occurs on Wither (displays as "Dust Clouds" instead of "DustClouds", is much thicker, and comes with audio), this is a feature ported from my other mod [ScienceBird Tweaks](https://thunderstore.io/c/lethal-company/p/ScienceBird/ScienceBird_Tweaks/) (which does the same thing, but on every moon)
	- The moon's lore description has been updated
	- New preview video recorded to reflect the current state of the map
	- Moon description shortened a bit to better fit on the main screen
	- New custom planet model when orbiting the moon
	- New custom sun texture (and the sun no longer appears so small in the sky)
	- Remade a bunch of decal textures to display nicer and look less harshly cut off
	- Custom sandy footstep sounds for the desert
	- Exiting the inside now acts more like exiting the true interior, with a faster hold time and hover tip which says "exit"
	- A few new door sound effects
	- Made the "condemned" sign into an actual modelled sign instead of a flat decal
	- Some new scan nodes for important map objects
	- Some small improvements to the main structure like additional foliage and cleaning up some messy decals
	- Mine spawns are now less variable (~0-30 > 10-20)

- v70 compatibility:
	- Custom contour map which visualizes elevation with shading
	- Extensive custom radar sprites to visualize all the different structures and areas on the moon
	- Any weird artifacts on the radar when using the 1.X.X versions of this moon in v70 are gone
	- Added the giant sapsucker as a relatively rare daytime spawn (lowered baboon hawk spawns a bit to compensate)

- Tweaks and fixes:
 	- Removed all of the map's baked lighting, replacing it with shadowless lighting (this should hopefully not impact performance much)
	- Greatly reduced unusual behaviour with shadows on certain lights (especially spotlights) where shadows wouldn't be cast at all or would cast a fixed state leaving behind phantom shadows
	- Generally better [Blackout](https://thunderstore.io/c/lethal-company/p/mrov/MrovWeathers/) compatibility (and [True Blackout](https://thunderstore.io/c/lethal-company/p/ScienceBird/ScienceBird_Tweaks/) compatibility)
	- A few tweaks to clean up the nav mesh (baboon hawks should no longer congregate on the catwalk during eclipses, navigation should be generally a bit smoother)
	- Lots of small adjustments and fixes to materials and models across the map to fix subtle visual issues like visible seams or weird texture mapping
	- Fixed all the stretched hover icons on the map
	- Fixed item dropship music starting before it's landed
	- Fixed some incorrect normals on small spotlight objects and door knobs
	- Fixed incorrectly set normal maps on some decals
	- Fixed fragile catwalk sometimes being able to be triggered two times at once
	- Fixed Lethal Elements snow not working on Wither's terrain (though it will have some weird borders)

- Configuration:
	- Added "vanilla plus" mode which will disable all map elements related to Wither's special event
	- A bunch of new options related to new features of this update
	- Fixed possible compatibility issues with certain mod names in the apparatus rotation/position config
	- Improved some config formatting

- Internal/meta changes:
	- Rewrote almost every script for the map, hopefully resolving what few issues remained with them
	- Cleaned up lots of unneeded logs
	- Streamlined the way events occur in the map and eliminated unneeded animated object triggers
	- Created a dedicated lights manager to control the states of dynamic lights on the map
	- Removed some unneeded dependencies
	- Added LCMaxSoundsFix as a dependency (especially needed with this update)
	- Updated the README with new screenshots and banner

## Version 1.4.3
- Some balance changes:
	- Reduced eclipse spawns from 4 to 3 (matching Titan), and added this to the table in the README
	- Reduced all trap spawns slightly and significantly reduced turret spawns to account for the high mines interior weight
- Properly set LobbyCompatibility as a soft dependency so it will always be detected

## Version 1.4.2
- Fixed reverb triggers having unintended effects on Dust Clouds weather
- Added LobbyCompatibility
- Added README and LICENSE to GitHub
- Properly registered version in DLL

## Version 1.4.1
- Added default offsets for Distinct Moon Variety apparatuses
- Cleaned up some leftover JLL stuff
- Added some safety catches for fall rotation adjustments

## Version 1.4.0
**Major rework of all scripts to support config options and fix some issues:**
- Apparatus event now compatible with Facility Meltdown
- Adjusted rotation scripting so *hopefully* apparatus rotation issues should be rare
- Migrated config over from JLL to my dedicated assembly
- Any detected modded apparatuses are added to a config section where their rotation and position in the slot can be adjusted if there's an issue (I'll add default offsets for any misaligned apparatuses that I know of, right now I only know of the Egyptian apparatus from Tolian's Tomb)
- Various properties of the apparatus event are now adjustable (scaling values for reward scrap, maximums and minimums, etc.)
- Added scaling factor for the reward based on the value of the apparatus
- Added option to only allow the dying apparatus to be used in the map's event
- Fragile catwalk hazard is now adjustable

**Other changes:**
- Reduced turret spawns a bit
- Reduced old bird spawns (from very low to extremely low)
- Adjusted some content tags to work better with mods like Celestial Tint
- Alarm horn is now a tiny bit louder and reaches a bit further away
- Rumbling sounds and shaking can now be felt "inside"
- Improved the red lighting during the alarm sequence
- Changed footsteps sounds in the desert to something slightly softer
- Fixed an issue where grab tooltip would remain even after inserting
- Adjusted some parts of the lighting to work better with mrov's Blackout weather

## Version 1.3.0
- Added built-in RuntimeIcons support for event scrap items
- Removed the "night vision" lighting from certain parts of the map, clearing up an irritating glow
- Fixed a longstanding issue where players would incorrectly be transitioned to the interior while outside (which caused the sky to suddenly go dark)
- Fixed some very minor incorrect footstep sounds
- Fixed some light flickering at the small forest enclosure
- Fixed an occasional (but seemingly harmless) network error on save load, replacing it with a warning log
- Adjusted some baked lighting and mesh seams on the main structure
- Made the withered phone sound effect audio slightly quieter

**Rewrote event-related items to catch many potential issues:**
- Item RNG functions should now be initialized correctly, preventing an issue where picking them up would break your inventory permanently
- Items can no longer be picked up until they've all finished falling
- Items will no longer continue rotating even after hitting the ground
- Randomized scrap values of the items are now based on seed and should be more resilient to desyncs

**Improved the apparatus insertion process of the special event:**
- Apparatus insertion now animates (relatively) smoothly
- After inserted, the apparatus now reflects the visual appearance of the apparatus used
- Added a subtle ongoing sound effect after it's inserted

## Version 1.2.5
- Slightly adjusted some baked light on the cliffside
- Rain sound effects are now properly muffled when in the desert-side enclosure

## Version 1.2.4
- Possibly fixed a networking issue

## Version 1.2.3
- Fixed issues with apparatus insertion due to scrap radar icons
- Fixed some assembly errors on script initialization

(thank you Lunxara)

- Scrap values *might* be always consistent across clients now (🤞)

## Version 1.2.2
- Added basic compatibility for mrov's WeatherRegistry and related mods, so weather is accurately updated when exiting the interior (other issues with WeatherRegistry may still exist, though)
- Fixed radar icon for apparatus not syncing across clients
- Rewrote network code again to possibly reduce the occurrence of scrap value desyncs
- Corrected brick texture

## Version 1.2.1
- Fixed lightning occurring in unintended areas
- Fixed some wall texture issues

(thank you narpeh and purpletheproto)

- Adjusted some event sound effects
- Added DustClouds to weather rotation

## Version 1.2.0
- **Rewrote item handling code to fix a critical bug where event items from Wither would not save nor preserve when moving between moons** (sorry this slipped past me for so long, and thank you to purpletheproto on Discord for reporting it)
- Item is properly removed from inventory when inserting apparatus (HUD drop tip doesn't linger)
- Adjusted and added more sound effects and visual effects around apparatus event
- Added many custom assets for items related to the apparatus event (now considered special "Wither" items)
- Made quicksand hazard signs less glaring
- Slightly adjusted desert fog hue

## Version 1.1.2
- Updated README
- Added exception for modded apparatuses

## Version 1.1.1
- Added support for modded apparatuses (e.g. Wesley's Interiors)

## Version 1.1.0
- Fixed main entrance facing you the wrong way
- Fixed scrap sound effects related to the apparatus event not stopping on all clients when dropped
- Adjusted apparatus event rewards to be more random and generally better
- Rewrote some netcode related to the apparatus event **(this has introduced an inconsistent bug where scrap values related to this event are set differently some clients, please report this if it happens)**

## Version 1.0.0
- Initial release