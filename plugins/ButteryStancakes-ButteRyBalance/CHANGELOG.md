# v0.6.5
- Added `No Turrets in Caverns` setting (since "No signal!" blocks these turrets from radar view)
- Fixed `No Keys in Caverns` not working half of the time
- Cadaver Growths
  - Fixed some timing discrepancies with "growth bursts" (this will, overall, make Cadavers grow a teensy bit slower)
  - A setting to *harshly* reduce spread rate (it is recommended to disable `Increase Power Level` if you use this)
- Cruiser
  - Fixed stamina usage from typing in chat while in the driver seat
  - A setting to disable orbit regen (so weed killer is necessary to reach maximum durability again after taking damage)
  - A setting to disable the self-righting force added in v70
    - This should make it less prone to getting stuck on hills
	- But it will take more work to rock/push it when it's stuck
	- This might also make it harder to jump the car up slopes
- Options to configure how likely vain shrouds are to grow on each moon at the end of each day
# v0.6.4
- Fixed `Treat Blizzard Like Fog` setting for Forest Keepers being non-functional ever since v80 (thanks [SillyFilly](https://thunderstore.io/c/lethal-company/p/SillyFilly/))
- Updated for compatibility with latest version of [Scandal's Tweaks](https://thunderstore.io/c/lethal-company/p/Scandal/Scandals_Tweaks)
# v0.6.3
- Adjusted behavior from v0.6.2 so that Old Birds aren't quite as stupid about chasing players they already saw in the Cruiser
# v0.6.2
- When using `Patch Enemy Protection` (with [Scandal's Tweaks](https://thunderstore.io/c/lethal-company/p/Scandal/Scandals_Tweaks)), Old Birds that are behind the car will no longer see you in the seats
- Removed `No Roadkill` setting for kidnapper fox ([CruiserImproved](https://thunderstore.io/c/lethal-company/p/DiggC/CruiserImproved/) no longer enables the car to kill the fox)
- Moderately reduced the stamina cost for rocking the Cruiser
# v0.6.1
- Additional Cruiser changes (these didn't quite make the cut in v0.5.0!)
  - `Turbo Boosts` setting (reduce max turbos, or disable them altogether)
  - `Patch Enemy Protection` setting
    - When this setting is enabled, several interactions which erroneously grant invincibility to players in the context of the Cruiser will be fixed
    - For example, Forest Keepers will now be able to grab players directly off the roof of the truck, or out of the seats (which is normally blocked when the backdoor is closed, even if that player isn't hiding in the back)
    - If you also have [Scandal's Tweaks](https://thunderstore.io/c/lethal-company/p/Scandal/Scandals_Tweaks) installed, Old Birds and baboon hawks will be able to see players sitting in the front seats (like other enemies)
- Fire exit fixes
  - New Offense/Dine fire exits having correct interaction settings now (text/timer)
  - Duplicate fire exits should no longer generate in interiors (for certain mod packs) when `Proportional Fire Exits` enabled
- Some bugfixes which all clients need (which I couldn't include in [Buttery Fixes](https://thunderstore.io/c/lethal-company/p/ButteryStancakes/ButteryFixes/) since it's client-side)
  - Fixed some circumstances causing RNG (mainly enemy spawns) to reset mid-round, instead of *only* at the start of a new day
  - Fixed Cadavers' "spore coughs" frequency for non-severe infections being broken (which fixes itself only after being sprayed with weed killer)
# v0.6.0
- Fire exits (**EXPERIMENTAL** changes, all disabled by default)
  - A setting to adjust how fire exits generate
    - Fire exits will be distributed throughout the interior, dependent on the number of fire exits, proportional to distance from main entrance
	- ex: A moon with 1 fire exit will always place a fire exit in the furthest 51-100% of possible fire exit spawns
	- ex: A moon with 3 fire exits will have main entrance, a fire exit at 26-50%, a fire exit at 51-75%, and a fire exit at 76-100%
	- This setting also is not compatible with [Fairer Fire Exits](https://thunderstore.io/c/lethal-company/p/MikuOreo/Fairer_Fire_Exits/) and will automatically disable itself if both are enabled
  - A setting to restore Offense's v9 fire exit
  - A setting to restore Dine's v49 and v56 fire exits
- `Adjust Scrap Weights` no longer impacts chemical jugs, stop signs, or yield signs
- `Adjust Weapon Weights` setting
  - Increases the weight of the shovel
  - Makes stop signs and yield signs weigh less than the vanilla shovel (to incentivize risking the scrap value)
- A setting to disable Butler's player search (running around the interior with broom stashed) in singleplayer
- Cruiser changes should no longer apply at all with [Version-55 Company Cruiser](https://thunderstore.io/c/lethal-company/p/Scandal/Version55_Company_Cruiser/) installed
- A setting to reduce weed killer's damage (when spraying Cadaver-infected players)
# v0.5.0
- Jetpack nerfs
  - Jetpack now "warms up" to full speed after first taking off
  - Jetpack now has variable speed/handling based on weight
    - At 52lbs (just jetpack) it has vanilla speed, but with slightly worse acceleration/turning
	- Heavy weights significantly drop speed, but make it easier to control directional movement
- Cruiser nerfs
  - Now costs $700
  - Sharply reduced HP regen, to make weed killer more of a necessity
  - Takes increased damage from collisions with enemies and walls
  - Now takes damage from crashing into trees again (but not snowmen)
  - Items on top of the Cruiser, or in the back with the door open, are now lost when entering orbit
  - "Rocking" the car now costs stamina
- Fixed a lobby crash which resulted from certain seeds setting invalid item discounts
- Fixed an error with `No Keys in Cavern` which would sometimes prevent keys from spawning during a round
- Adamance now punishes those with hubris
# v0.4.2
- A setting to reduce Cadaver frequency on Adamance
- Restored the settings to disable vains on Titan and Embrion
- `Dineshaft` setting now also increases the number of scraps which spawn in mineshaft for `DontChange` and `Consolidate` settings
- A setting to buff stun grenade effectiveness against some enemies
- Fixed discount distribution (thanks [MakuAureo](https://thunderstore.io/c/lethal-company/p/MikuOreo/))
  - Fixed discounts being "wasted" by overwriting existing discounts on items
  - "Later items" like Cruiser and belt bags are more likely to be chosen for discounts
- Added settings to customize Jetpack/Cruiser prices (and bumped Cruiser back up to $400 by default)
- Maneater and Cadaver Blooms can now be targeted outside by Old Birds and Baboon Hawks
- Keys no longer spawn inside cavern tiles on mineshafts
# v0.4.1
- Community wishlist additions!
  - Restored some options removed in v0.4.0
    - Shrink Rend interior
	- Adjust Embrion spawns
  - An option to make Vow foggier again (like before v72)
  - Adjustments for March's outdoor spawns
  - Reduced HP for Backwater Gunkfish
  - Input buffer for shovels/traffic signs
- An option to reduce night vision beta back to values in v80 beta
- Improved the `scan` command's accuracy when using `Consolidate` option on Dine
  - Values displayed will still not be correct without [Lethal Fixes](https://thunderstore.io/c/lethal-company/p/Dev1A3/LethalFixes/), or [Buttery Fixes](https://thunderstore.io/c/lethal-company/p/ButteryStancakes/ButteryFixes/)' `ScanImprovements` setting
# v0.4.0
- v81 compatibility
  - Removed several outdated options, and disabled many others (by default)
  - I *strongly* recommend re-doing your config, as this was a pretty major overhaul
- Infestations
  - Fixed several bugs which made enemies break spawn rules on days after an infestation had occurred
  - Thumper infestations now increase max count from 4 to 8
  - New snare flea infestations
  - New coilhead infestations
  - New Backwater Gunkfish infestations
- Hoarding bugs: Option to reset annoyance (from player proximity) when entering chase
- Kidnapper fox: Option to grant immunity to Cruiser (which is the case in vanilla, but only as a result of a bug, which [CruiserImproved](https://thunderstore.io/c/lethal-company/p/DiggC/CruiserImproved/) fixes)
- Spore lizard: Option to reduce power level from 1 to 0.5 (like Backwater Gunkfish)
- Cadaver Growths: Option to increase power level from 2 to 4
- Option to restore spike traps in mineshafts
- Increased pro-flashlights back to $32
# v0.3.2
- Infestation rework now requires [Spawn Cycle Fixes](https://thunderstore.io/c/lethal-company/p/ButteryStancakes/SpawnCycleFixes/) to be installed
- Added thumper infestations
- Dine's `Consolidate` option now spawns 40% as many items worth 1.75x each
  - When transporting fewer items, 1:1 value is just too strong. Similarly, just 50% spawns still made items too dense.
  - This is still abnormally high compared to other moons, Artifice included, so it should still feel worth visiting
- Added a setting to make the Cruiser instakill Forest Keepers again
- Added requested setting to disable coil-heads' recharge mechanic from v60
# v0.3.1
- `AddV73Extra` setting for Dine
  - Increases item spawns from 22-25 to 28-44, to offset low value items
# v0.3.0
- Updated for v73
- Added a setting to remove spike traps from spawning beside entrances
- Added settings to restore snowmen on Rend, Dine, and Titan
- Added several new scrap "presets" to Dine:
  - `DontChange`: Vanilla (or other mods) take priority
  - `Rollback`: Same as the "Buff Scrap" option from v0.2.4
  - `AddV73`: v72's spawn pool plus the new v73 items
  - `Consolidate`: v73's spawn pool, but half as many items spawn worth double value each
# v0.2.4
- Removed [YesFox](https://thunderstore.io/c/lethal-company/p/Dev1A3/YesFox/) dependency and vain shroud settings
  - v1.1.5 now supports per-moon overrides so you should set them up there instead
# v0.2.3
- v70 compatibility
  - Removed TZP buff (TZP was buffed even further in vanilla)
- Fixed oversight where `Kill Switch` did not prevent interior settings (except `Shrink Mineshafts`) from taking effect
# v0.2.2
- Fixed maneaters not crying when they spawn outside on custom moons (until players enter the building)
- Fixed Old Birds being unable to fly when `Restore Mech Riding` is enabled
# v0.2.1
- Migrated Forest Keepers' `Forget Out-of-Sight Players` setting to [Buttery Fixes](https://thunderstore.io/c/lethal-company/p/ButteryStancakes/ButteryFixes/) (it's a host-sided bug fix)
- Fixed butlers' `Squishy` setting not properly syncing between players in multiplayer
- Fixed some RPC errors due to a typo (my bad!)
# v0.2.0
- Restored mech riding! From v64
- Migrated foggy weather rework to [Chameleon](https://thunderstore.io/c/lethal-company/p/ButteryStancakes/Chameleon/)
  - The setting in this mod now just reduces the maximum allowed thickness of the fog
  - Using both together will give you the same results as before
- Adjustments to infestations rework
  - Added Barber infestations
  - 2 infestation enemies spawn immediately before landing, like vanilla
- Adamance's `Buff Scrap` setting no longer applies to mineshaft
- Dine adjustments:
  - Increased outdoor power level to 10
  - Sharply reduced Forest Keeper chance
- Adjustments to Assurance, Vow, March, and Offense loot
  - Added bees and gold bars to Offense
- Adjustments to Rend enemy pool
- Fixed random objects (boulders) spawning where they make it impossible to use the entrances
- Fixed crouch state not syncing with other players (lets you hide from Old Birds and Forest Keepers in multiplayer)
- Fixed an exploit with negative luck furniture
# v0.1.0
- Initial pass on moon balance
- Several new options for enemies and items
- Reworked foggy weather
- Reworked infestations
- Oh hey, [a wiki](https://thunderstore.io/c/lethal-company/p/ButteryStancakes/ButteRyBalance/wiki/)!
# v0.0.1
- VERY early release
- Stay tuned for more!