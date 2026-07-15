## Version 4.7.5
- Fixed compatibility issues between the Mine Cooldown Animation/Zap Gun Rework and Breaker Hazard Shutdown which could cause mines to get stuck in their flashing green animation

## Version 4.7.4
- Fixed issues with new GoodItemScan update
- Fixed issues launching without GoodItemScan
- Scan highlights now check scan node directly to determine colour (should fix issues with mismatching colour highlights)
- Added a fix for turrets continuing to fire after disabled (compatible with zap gun tweaks)
- Fixed longstanding issue with Snare Flea tweaks causing them to attack faster (this issue is almost as old as the mod itself!)

## Version 4.7.3
- Fixed Broadcast Death Notification not enabling in all circumstances

## Version 4.7.2
- Added some safety to SSS patching
- Fixed incorrect name placement when head cams are disabled

## Version 4.7.1
- Fixed Scanned Item Highlights disabling motion blur (updated some rendering stuff to account for v80 changes)

## Version 4.7.0
- Updated for compatibility with v81, including various small changes:
    - Radar exit pathfinding tweaked to reflect changes in vanilla code, and is now independent of ButteryFixes (which no longer significantly affects pathing)
    - Removed some now-redundant fixes to monitor transitions
    - Zero weight config now accounts for utility slot
    - Reorganized and recompiled code to fit vanilla changes (mainly changes to item networking and interior generation)
- Cleaned up some existing tweaks:
    - Lingering lightning fix now addresses a few more edge cases and fixes GeneralImprovements HUD inidcators appearing before static actually starts
    - Caught some errors on masked enemies being destroyed after their masks have been taken off via Gimme That Mask
    - Fixed death notification still playing (for clients) even when a player is killed by a mask
    - Ship removal options for cameras/monitors are now less invasive (also fixes some issues with v80)
    - Shotgun modifications now check the ammo ID of the gun to account for possible modded overrides
- The Blackout options have been reworked a bit:
    - The apparatus and breaker box affecting hazards are now in General Tweaks, along with apparatus spawning changes (to avoid confusion)
    - New option for Blackout weather to shut down power and disable hazards
- Major changes and additions to head cam tweaks:
    - Config section overall reorganized, with no more "low angle" toggle, and instead just angles and offsets to move the camera (now vanilla default is facing forward)
    - There are now two options for seeing your own cam: one which just shows the cam feed, and another which shows you the high poly model (due to some changes in v81, you actually see a low poly model by default when your own feed is turned on)
    - Improved name text box will now be active from the very start, without needing you to switch the radar once to get it to start working
    - When seeing your own high poly model is enabled, dying shouldn't reset it and make you invisible anymore
    - New option to turn the camera around to face you while you are sprinting
- Scanned item highlights has been given some improvements and moved out of Technical config into General Tweaks (thank you to all the people testing it!):
    - Scan highlights now have a subtle fade-in transition
    - No longer causes errors with TestAccountVariety Hypercube (let me know about any other edge cases)
    - Rewritten scan behaviour to fit with the latest version of GoodItemScan (should hopefully perform better)
    - Can be toggled into a "Performant" mode, which renders less layers and disables the fade in effect

## Version 4.6.1
- Fixed some issues with the Improved Name Text Box player cam tweak that slipped under the radar (no pun intended)

## Version 4.6.0
- Some fixes:
    - Fixed issues with disabling player cams across all clients (where a black box would still appear on the screen)
    - Fixed Better Dust Clouds effect persisting into spectator after a player dies and interacting strangely with reverb triggers around the ship
    - Fixed possible True Blackout errors under unsual circumstances
- A few new features and extensions to existing ones:
    - Added a new experimental tweak to have the radar exit line path you to the closest exit (rather than always the main entrance), compatible with ButteryFixes' improvements
    - Added an (also experimental) player cam tweak which will actually render your own model on the player cam (as an alternative the vanilla static image or the option to not show it at all), this may not be compatible with mods that significantly change the player model
    - Added a tweak which will reset lightning effects when an item is taken indoors (so the particle and sound effects will stop immediately)
    - Expanded the Ship Monitor Fixes (previously Monitor Transition Fix) to also remove the black bars on the top and bottom of the video feed (especially noticeable if you use LethalSponge)
    - Earth Leviathan Quicksand should no longer generate quicksand when a worm isn't outside
    - Scan highlights will now stick to their object if it's moved rather than lingering in place (most noticeable with soccer balls)
- New mod tweaks:
    - With TwoRadarMap and LethalElements, solar flare weather will cause the terminal's radar map to display "No Signal" (since the glitching effect does not extend to the terminal)
    - Fix for the missing icon on ShipWindows' shutter switch (causing it to appear as a white square)
    - GeneralImprovements lightning HUD overlay will disappear when an item is taken indoors
    - Re-added the LLL Ship Lever Fix since there's still a quirky case not covered by LLL, but it's disabled by default and may still cause issues with mods affecting routing such as RandomMoonFX
- Some other misc. additions:
    - Changed Rend's terrain mask to allow it to support all decals (mainly quicksand with the Earth Leviathan Quicksand tweak), for now it's all manual, so let me know if any other moons need this compatibility change
    - Added a debug option which will attempt to detect and resolve transforms/colliders failing catastrophically with "Infinity or NaN value" errors, even if this doesn't fix it, it might still give some useful logs so be sure to send them to me!

## Version 4.5.0
- Fixed zap gun tweak incompatibility with SpikeTrapFixes by rearranging some object structure
- Fixed interior cam removal incompatibility with Cruiser Additions by no longer removing the cam model (camera feed still turned off)
- Hopefully fixed shotgun ejecting spooky ammo with Wesley's Moons installed
- Improved stretched hand icon tweak to also fix hand icons in the interior
- Slightly increased material brightness on floodlights
- Added tweak to fix the main monitor transition when taking off (video feed and ship icon no longer appear on the screen during the transition)
- Added a fix for a networking bug with maneaters that would cause them to sometimes skip their windup animation when attacking after switching targets
- Added some fixes for issues with older moons:
    - Ganimedes' terrain will now support decals
    - Quicksand on Aquatis will now correctly display its custom quicksand texture (instead of a translucent white square due to the asset being corrupted)
    - That same custom "sandy" quicksand texture will also be used for quicksand on Ganimedes and Orion (mainly for earth leviathan quicksand compatibility since I don't think either of those support rain)
    - (If you know of an unmaintained legacy moon that would benefit from custom sandy quicksand, let me know! I might make this a configurable list later)
- Added a tweak which will enable shadow casting for the sun on all moons, which should reduce instances of the ship being extremely bright on the inside (this is off by default for potential performance concerns)

## Version 4.4.10
- Added ship removal options for some cameras and monitors
- Probably fixed issues with floodlight rotation/brightness during Blackout weather
- Fixed scan highlights breaking the zap gun and mapper tools

## Version 4.4.9
- Fixed issue which would cause BiggerShip to interfere with the compatibility patch for ClaySurgeonOverhaul (which meant scan highlights would once again break with ClaySurgeonOverhaul if BiggerShip was also installed)

## Version 4.4.8
- Muted Scrap List now silences the heartbeat of the new heart scrap item
- When a player is killed by a mask, the Broadcast Death Notification tweak won't play the notification sound (similar to how masked players aren't teleported by the Auto Teleport tweak)
- When a masked enemy is completely destroyed, Gimme That Mask will no longer drop a mask (also fixes the issue where duplicate masks would spawn after being killed by an Earth Leviathan)
- Added a safeguard to prevent masks spawning multiple times in general
- Fixed incompatibility of a few tweaks with DawnLib (specifically the dynamic occupancy sign and ship removals)
- Some prevention of null reference exceptions when certain tweaks are given bad data
- Removed LLL Ship Lever Fix which is now included in the updated LLL build
- Interally updated some assemblies
- Updated dependency version

## Version 4.4.7
- Recompiled and updated netcode patching for V73
- New dependency to fix Unity update breaking everything without certain soft-dependent mods (thank you very much Hamunii!)

## Version 4.4.6
- Fixed starting moon config breaking for moon names with a single number (e.g. Dine)

## Version 4.4.5
- Fixed some player cam tweaks not working upon reloading/restarting a save file

## Version 4.4.4
- Possibly fixed some more errors/incompatibilities with player cam tweaks

## Version 4.4.3
- Fixed some errors with the player cam rewrite

## Version 4.4.2
- Improvements to player cam tweaks:
    - Rewritten to be compatible with TwoRadarMaps (and by extension also makes [Live Reaction](https://thunderstore.io/c/lethal-company/p/mborsh/Live_Reaction/) compatible with TwoRadarMaps)
    - If using Live Reaction and your own cam is disabled, the "LIVE REACTION" text won't be added to the name
    - Changed the default values for the player cam angle and position change to work better with certain MoreCompany cosmetics (now at a more steep angle)
- Blacklisted radar boosters from the scan highlights feature, since it has a lot of components that might cause strange behaviour or other issues
- Fixed inventory weight tweak to account for tulip snakes attached to the player (won't zero out weight if an item is dropped while a tulip snake is attached)
    
## Version 4.4.1
- Fixed an edge case where hazards coming off of cooldown would still turn on even if a hazard shutdown had occurred right after they were disabled
- Fixed an incompatibility with the moon Conflux by disabling all interior scrap behaviours on it
- Moved the sun fading animation reset later so it will not be visible while taking off

## Version 4.4.0
- Fixed some issues with the experimental scan highlights feature
    - Now compatible with GoodItemScan
    - Shader no longer bugs out when used with ClaySurgeonOverhaul
    - Scan highlights linger less when an item is taken into a belt bag
    - Overall made compatibility with weird/modded scrap a bit better, so a few more items might recieve highlights now (though anything with a complicated animated mesh likely won't, e.g. monster plushies)
- A bunch of small new miscellaneous tweaks:
    - Allow placement of ship furniture even when above the fear threshold
    - Option for the sun to fade to black from sundown to nighttime (it's a little half-baked at the moment but it still might be a nice alternative in some cases)
    - Configurable apparatus enemy spawn parameters (% chance to raise minimum spawns per hour and what number to set the minimum spawns to)
    - Screech/creaking sound effect muted when a spike trap is disabled/on cooldown
    - Scrap blacklist for items not allowed to appear on a "single item day" (when only one type of scrap spawns)
    - Sapsucker eggs will scream (like on the company desk) when maneaters start trying to eat them
    - Fix for the [Hands full] tooltip displaying even on interactions you can perform with your hands full
    - Wires behind the ship monitors are now in the removal list
    - New Player Cam option to increase the clipping/render distance of the body camera
    - More options for sun behaviour during Blackout weather, so you can have only the sun be turned off, or have everything except the sun be turned off (default is all lights and the sun), though note that when the sun is enabled on Blackout it will always look eclipsed (I'll probably find a workaround for this later)
- Major quality of life changes for config handling:
    - Any old entries still in your config file will now have their values transferred to the equivalent new options if the new option isn't already set with a non-default value (i.e. if you set a config that got re-named and forgot to set the value on this new config, that will now automatically transfer over)
    - A new option in Technical config to remove all orphaned config entries after joining a game (this will only happen one time, so it basically acts like a config "button")
- Some fixes:
    - Dynamic occupancy sign will no longer break with mods that remove the vanilla posters
    - Gimme That Mask should cause less errors on de-sync (but I haven't solved any de-sync issues at their core, I'm unsure if it can be caused by SBT alone or if it's another mod breaking it)
    - Unrelated to above, the networking behaviour of Gimme That Mask might be slightly better now that I've fixed an oversight
    - Removed some warning spam from the experimental radar name text box tweak
    - Tiny Teleporter tweak should work with the inverse teleporter more consistently across clients
- Other random stuff:
    - Some additions and removals for compatibility with Wither's latest update
    - Removed JLL noisemaker fix from config and README since it's a really obscure incompatibility (caused by BetterMonitor) which doesn't really need its own toggle
    - Changed the wording and positioning for a some Blackout config to make it a little bit more clear and readable
    - Added a tweak which sets carry weight to zero when no items are left after dropping one (unsure whether problems with weight are entirely mod incompatibilities or if they're fixed elsewhere, so this is a quick patch sitting in Technical config for now)
    - Added a patch for QualityCompanyFork to avoid errors on saving (this is a tiny patch for an old unmaintained mod, so it has no config or README entry)

## Version 4.3.3
- Added option to hide all player cams from the radar screen

## Version 4.3.2
- Fixed Old Halloween Elevator Music compatibility issues with outdoor mineshaft elevators
- Actually fixed Thunderstore README formatting (I think)

## Version 4.3.1
- Hopefully fixed Thunderstore breaking README formatting

## Version 4.3.0
- Added some tweaks for the v70 player cam:
    - Adjustable angle and position
    - Option to disable the placeholder image shown when viewing your own cam
    - Experimental option for improving the name display on player cams to better handle longer names (compatible with "Live Reaction")
- New experimental tweak for creating highlights on scanned objects (not thoroughly tested or optimized yet, but feel free to report issues), this can be found in Technical config for now
- Made some fixes for fridge and microwave colliders
- Updated ShipWindowsBeta patches to now use the main branch ShipWindows
- Adjusted Blackout audio cue to be more audible on landing
- Probably fixed errors getting thrown with certain materials during True Blackout
- Fixed some weird mod incompatibilities causing floodlights/panel buttons to not initialize correctly
- Addressed some issues with the recently added Fixed Ship Objects failsafe
- Reduced some redundant code running for Tiny Teleporter tweak
- Fixed ship removals sometimes not happening when reloading a save
- Removed my historic first tweak, Diversity Computer Begone, since it's done better by other mods and will soon be redundant with the upcoming Diversity update
- Adjusted some config to be better future-proofed

## Version 4.2.10
- Fixed Zap Gun Rework incompatibilities with some altered spike trap designs (e.g. PlayZone)

## Version 4.2.9
- Added new v70 furniture into Fixed Ship Objects' default vanilla items to fix
- Vanilla objects are no longer excluded by Fixed Ship Objects whitelist (oops)
- Added a fallback object parenting attempt to Fixed Ship Objects in case a network object spawns too late
- Fixed incorrect default value for rotating floodlight brightness (caused brightness to get set incorrectly after Blackout weather)
- LLL Lever Fix now also fixes the lever being interactable shortly after pulling it and during the transition between days
- Removed Wesley Tape Insert Fix (seems to have been solved in the base mod)
- Probably fixed issue with CustomStoryLogs that made it break things with Wesley's Moons tapes (as a temporary measure before this actually gets fixed in CustomStoryLogs)

## Version 4.2.8
- Fixed everything breaking when interior names contained special characters

## Version 4.2.7
- Mini rewrite for Auto Teleport Bodies to fix some issues:
    - Fixed teleport de-sync on clients when a player dies by mask
    - Fixed the unrecoverable body notification config being generally broken
    - Even when multiple players die at once they should all be teleported one at a time with a new queue system
- Occupancy sign now updates when players disconnect (rather than just when they connect)
- Added some extra safety checks to the Old Elevator Jingle tweak so it shouldn't error out when it ends up in an unintended situation

## Version 4.2.6
- Fixed Auto Teleport Bodies using inverse teleporter
- Auto Teleport Bodies now plays the teleporter's animation
- Fixed Global Death Notification not playing if existing HUD audio was playing
- Fixed Dynamic Occupancy Sign showing 1 less than the actual amount of players
- Improved Stretched Hand Icon Fix to work on more moons and for interact triggers inside the ship
- Smoke Particle Fix now also includes the smoke trail from jetpacks

## Version 4.2.5
- Fixed disabling lethal doors also disabling zappable doors

## Version 4.2.4
- New tweak fixing stretched out hand interact icons on modded moons
- New tweak which will attempt to fix and replace broken items with null properties (from moons or interiors which didn't register their items properly)
- Changed the formatting on the fancy panel tooltip configs (I forgor what special characters you could use)
- Fixed one of the unused button functions not being hooked up correctly
- Cleaned some more leftover logs

## Version 4.2.3
- Made the disabled mine sound effect configurable between a click (new default value), a beep (original sound), or nothing
- Added another mod tweak for the ShipWindowsBeta shutter allowing you to choose what sound effects (not voice lines) will play when it's switched (if any)
- Slightly increased volume of death notification audio
- Fixed teleporters de-syncing and teleporting multiple players due to strange patch interactions
- Fixed Tiny Teleporter tweak not working on clients
- Consistent Catwalk Collision will no longer throw errors if it can't find a valid catwalk to replace
- Cleaned up some logs

## Version 4.2.2
- Added various clientside mode and null checks to prevent the game from entering unintended states (notably with the fancy ship panel)

## Version 4.2.1
- New blackout configuration options:
    - Ignore emergency exit lights
    - Ignore guidance poles
    - Only blackout sun (blackout weather)
    - Also potentially fixed some errors
- New ship additions option which adds the "body unrecoverable" notification whenever a teleport fails (same implementation as auto-teleport, but independent of it)
- Added a bit of delay to the auto-teleport and made it so players dying to masks are ignored completely
- Slight changes to the blackout sound effect
- Rewrote some old bad code for Big Screw tweak
- Fixed some things breaking when LLL isn't installed
- Fixed Earth Leviathan default surfaces to actually include all surface tags now
- Fixed bizarre patch incompatibility with RandomMoonFX
- Config and README clarifications around ShipWindowsBeta tweak

## Version 4.2.0
- Lots of new small tweaks/fixes:
    - Taking damage will no longer cause you to briefly stand up due to the animation
    - Opening the belt bag interface will clear any scan nodes currently on your screen
    - Cruiser exhaust and other smoke particles will no longer be visible through fog from very far away
    - When (vanilla) bridges collapse, any items on them will now fall as well
    - When starting a hold interaction before you've moved your cursor over the trigger, the hold tip will now still display
    - Scrap items of various types that make noise can all be muted by a config list (including masks, the clock, items the animate when you pick them up, and Wesley's radioactive barrels)
    - The starting moon can be configured to something other than Experimentation
    - New option in the technical/debug config section which disables all noisy red warning pop-ups
    - Mod tweak for ShipWindowsBeta which fixes the shutter not closing when going into orbit
    - Mod tweak fixing the ship lever remaining interactable while routing with LLL installed

- New tweaks for enemies:
    - Ability to override the list of "natural surfaces" which earth leviathans use to determine what they can burrow through
    - Option for earth leviathans to spawn quicksand where they enter and exit the ground
    - Fix for coilheads' sightlines not working correctly when clients are in mineshaft elevators
    - Maneater can be adjusted to exit its transformation animation and immediately chase if it's hit
    - Maneater door opening speed can be increased
    - Tulip snake laughing triggering eyeless dogs can be disabled

- The rotating floodlight has been expanded with more features and joined by some other "ship upgrades":
    - Some config options for the floodlight can now be changed in-game via the ship's button panel (rotation speed and player targeting)
    - Floodlight player targeting now has a maximum distance
    - These additional buttons also include a reset switch to restore the floodlight back to its natural position
    - As a separate option, the whole button panel can be made interactable (though the buttons and knobs don't do anything yet), with dynamic lights that trigger on certain events and configurable tooltips
    - Option for the "maximum occupancy" poster in the ship to update dynamically if more than 4 players join (and is settable to any value in config)
    - A subtle audio notification can be sent out to all players when somebody dies
    - Bodies can be automatically teleported after death, with bodies unable to be teleported displaying a special notification instead of the normal "body collected" message

- Changes and overhauls to existing tweaks:
    - Shotgun unloading is totally rewritten and now integrated with LCAmmoCheck (ported with author's permission), so you now have the ability to check loaded shells with an animation by pressing reload with no shells to load, and if you continue holding it, your current shells will be ejected
    - The shotgun rewrite should also make things generally much more stable, and thus the hacky force registering config and edge cases have been removed (hopefully it'll be fine)
    - Visual feedback for holding to eject shotgun shells
    - Ship removals now includes an option to remove the clipboard manual from the cruiser
    - When any True Blackout effect occurs, a global sound effect will play as well (configurable)
    - Fixed Ship Objects now has a configurable list for modded items, allowing you to enable or disable specific modded furniture rather than all-or-nothing
    - Gimme That Mask now correctly identifies when masked enemies are wearing tragedy instead of comedy masks (with object fetching also being handled much more cleanly now), and now also supports for the oni masked enemies from Seichi

- Some tools for interior scrap generation analysis and adjustment:
    - Config section allowing you to spawn an additional amount of scrap whenever an interior generates (config will appear after joining a lobby)
    - Logging option which will calculate the "scrap density" of an interior, based on the total area of its tiles and amount of scrap spawned (as well as various other parameters)

- Totally overhauled and reorganized the config

## Version 4.1.6
- Fixed potential errors when triggering blackout via power outage

## Version 4.1.5
- Fixed spike trap light animation not working due to mistake in last update

## Version 4.1.4
- Hopefully solved issues with lag on landing when the floodlight is set to rotate when landed
- Added some more safety checks around handling mines
- Cleaned up some logs

## Version 4.1.3
- Added config option for Blackout to ignore any lights associated with animators, which leaves light animations like the Facility Meltdown red alarm lights (mostly) on
- Fixed ship floodlight start-on-landing logic: no longer dependent on the clock (delay after landing is very slightly shorter), and thus now works on the company moons or moons where time doesn't pass
- Fixed some broken soft-dependencies which meant certain mods wouldn't be patched if the mod loading order wasn't correct
- Cleaned up internal shotgun logic, only effect in-game is less Unity log spam when reloading or ejecting shells

## Version 4.1.2
- Added multiple safety checks and a config option to avoid shotgun shell unloading desyncs due to incompatibilities with some groups of mods

## Version 4.1.1
- Fixed breaker box hazard blackout config not doing anything
- Fixed potential incompatibilities with shotgun tooltip implementation
- Fixed unintentional behaviour where ship floodlight could be queued to start on the next moon while still on the previous one
- Ship floodlight rotation now starts a little earlier on landing
- Changed default value of WeatherTweaks announcement change to true (as originally intended)

## Version 4.1.0
- New Rotating Floodlight features:
    - Now turned on and off by button in the ship
    - Experimental option for floodlight to track players

- Significant True Blackout improvements:
    - Only darkens emissives it needs to (shouldn't darken transparent glass on lights anymore)
    - Includes generally more emissive textures
    - Light switches and their associated lights are now disabled on Rend, Adamance, and Artifice
    - Artifice building lights are now turned off
    - No longer misogynistic with LC Office (bathroom signs of both genders are now darkened)
    - Now works with all lights in Generic Interiors' Tower and Liminal Facility
    - Temporarily worked around Experimentation railway light animators with RebalancedMoons (until this gets fixed in that mod)

- New config option for hazards to also be activated/deactivated by breaker power

- Selective Scrap Keeping features should now be compatible with SelfSortingStorage's Smart Cupboard

- Shotgun tooltips are handled a little more cleanly internally, and config no longer misleadingly shows the keybind

- Fix for vanilla issue where stepping on a deactivated landmine and then exiting the interior would cause it to explode

- Fixes for 4.0.0 issues:
    - Shotgun should no longer cause errors when interacted with by an enemy or while not being held
    - Fixed mine explosion animation occurring too early
    - Generally cleaner handling for apparatus induced blackout and mine animators (might fix any issues that were happening with those)
    - Fixed some error spam with Pause Menu Flicker Fix
    - Fixed some rotating floodlight config not doing anything

# Version 4.0.0
- New overhaul for the zap gun and map hazards (mostly suggested by AdjectiveNounNumber):
    - Ability to temporarily stun turrets, mines, and spike traps with the zap gun (equivalent to using the terminal code), with stun time scaling with length zapped for (all values configurable)
    - New animations/audio indications for when mines or spike traps are on cooldown
    - Ability to hold open the closed facility doors while zapping
    - Big facility doors kill both players and enemies when closed (configurable)
    - Other configurable changes to the zap gun (e.g. battery life, entity priority)
    - Fixed zap gun tutorial overlay (should work consistently across clients and sessions now) and optional dynamic animation guiding where your mouse should go

- Completely rewritten True Blackout weather (thanks to xameryn), with additional integration for the apparatus:
    - Vastly improved performance, more thorough algorithm for determining which lights to darken, tons of configuration options for what to exclude, configuration for spotlight properties during a blackout, and more
    - Option to trigger a blackout (not including the sun) when an apparatus is pulled
    - Option to disable all traps/map hazards when the apparatus is pulled

- New options for keeping scrap items (written by xameryn):
    - Items with zero value are kept upon all players dying
    - Configurable list of items to keep after all players die (by default contains shotgun, but list needs to be enabled)
    - By default, any kept items will have their scrap value set to zero
    - Customizable flavour text when scanning zero'd scrap value items in the ship (e.g. items you want to keep as aesthetic collectibles for your ship after gambling them)

- New tweaks for the shotgun:
    - Improved/customizable shotgun safety tooltip
    - Added ammo indicator
    - Ability to unload shells from the shotgun by holding down reload with no shells in your inventory/a full gun
    - Tooltip will update dynamically when you are able to reload, able to eject shells, or neither
    - Option to be able to pick up the shotgun and/or shells in orbit

- New gameplay tweak for masked enemies to drop masks upon death (picking it up right off their face!)
- New highly configurable ship tweak which has the floodlight rotate while on a moon (added by xameryn)
- Tweak fixing button flickering in the pause menu
- Tweak fixing items not being set to "in the ship" on clients
- New mod tweak adjusting the wording of the transition weather notification in WeatherTweaks

- Some fixes:
    - Dust Clouds rework shouldn't trigger Dust Clouds in unintended situations as much (if at all)
    - Fixed Tiny Teleporter tweak not working
    - General overhaul of README and internal organization

## Version 3.1.8
- Set soft dependencies so tweaked mods should always be detected now
- Fixed SSS Terminal Formatter tweak not working with item names containing a space

## Version 3.1.7
- Removed some logs I forgot about

## Version 3.1.6
- Greatly simplified Fixed Ship Objects code to run less frequently and only parent objects individually (may fix issues related to objects getting stuck in the parenting process)
- Cut some unnecessary debug logs

## Version 3.1.5
- Fixed teleporter cord removal not working if using alternate fix mode

## Version 3.1.4
- Added a config option to enable the simplified Fixed Ship Objects logic (separate from Client-side Mode)
- Changed Falling Rotation Fix default value to OFF after reports of potential issues

## Version 3.1.3
- Added README and license to GitHub along with some other clean-up
- Properly registered DLL version
- Added Client-side Mode config option which determines LobbyCompatibility status and disables a bunch of networked behaviours
- Added some client-side alternative handling for Fixed Ship Objects which doesn't require a network prefab

## Version 3.1.2
- Added LobbyCompatibility

## Version 3.1.1
- Issues with mod loading when mods associated with mod tweaks that are not installed should be fixed

## Version 3.1.0
- Added some misc. patches for Wesley's Moons, JLL, and LLL:
    - Ability to send the host's unlocked moons directly to clients, so all players will have the same moons unlocked
    - Fixed some noisemaking items sometimes not working (e.g. Wesley's story audio logs) due to either an incompatibility or issue with JLL
    - Added prototype fix for clients being unable to interact with the tape player or story log machine
- Made default behaviour of Fixed Ship Objects to only fix most vanilla furniture, with an option to fix all furniture
- Optimized the code a bit so failed parenting of modded furniture should be less laggy while loading in and produce less errors
- Updated skip tape interact icon

## Version 3.0.1
- Fixed Wesley Tape Skip breaking story log machines (oops :3)

## Version 3.0.0
- Generalized ship object parenting fixes into one tweak which should apply for all furniture/unlockables
- Added various tweaks to Dust Clouds, now in their own category "Better Dust Clouds"
    - Increased dust cloud thickness to make it an actual hazard (config adjustable)
    - Audio to go along with Dust Clouds weather
    - Also includes previous tweak Dust (Space) Clouds
- Added Self Sorting Storage/Terminal Formatter tweak adding compatibility between the two, so items in the smart cupboard are counted when determining ship equipment stock
- Added Wesley's Moons tweak allowing you to skip a video tape by interacting with the cassette loader again
- Adjusted big screw tweak to work under more circumstances (e.g. dropping from gift box, being taken out of Self Sorting Storage cupboard)
- Added debug mode for personal testing purposes

## Version 2.1.1
- Added options to remove various items from the ship
- True Blackout tweak now supports "BlackoutIgnore" override (ignores light objects with parents named "BlackoutIgnore")
- Fixed teleport button parenting so the buttons won't linger after a run ends
- Fixed client-side exceptions with Fixed Suit Rack tweak
- Fixed some potential exceptions with fall rotation fix if inventory becomes desynced

## Version 2.1.0
- Added various ship-related tweaks:
    - Fixed Suit Rack
    - Larger Lever Collision
    - Begone Bottom Collision
    - Tiny Teleporter Collision
- Dust Space Clouds tweak will now also fix "DustyClouds"
- More re-organization of config and README

## Version 2.0.0
- Added Fixed Teleporter Button tweak
- Added Fall Rotation Fix tweak
- Added MrovWeathers True Blackout tweak
- Added Snare Flea balance tweaks
- Adjusted default values so no unwanted gameplay changes should be present on install
- Overhauled README

## Version 1.0.1
- Edited README

## Version 1.0.0
- Initial release