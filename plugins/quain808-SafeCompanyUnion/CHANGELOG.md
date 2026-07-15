## Changelog

### 1.18.8

#### Changed:

- Disabled Surfaced's Super Scary Mode

### 1.18.7

#### Removed:

- LandFromOrbit and Coralation (temporarily)
- Lunas Moons

### 1.18.6

#### Changed:

- Updated dependencies

### 1.18.5

#### Changed:

- Reduced Tesla Gate global spawn weight: 2 -> 1
- Reduced Rolling Chair global spawn weight: 30 -> 20
- CodeRebirth:
  - Updated all configs to include new defaults
  - Lowered spawn curves of some hazards and enemies
- Lowered maximum Missile Turrets: 4 -> 2

#### Added:

- DeviousTraps

### 1.18.4

#### Changed:

- Surfaced:
  - Disabled Horseshoot crab
  - Lowered spawn weights:
    - Bruce: 70 -> 15
    - BellCrab: 50 -> 10
    - Urchin: 90 -> 10
    - Clownhorn Fish: 50 -> 20
  - Enabled Super Scary Mode ;)
- CodeRebirth:
  - Lowered AirControlUnit spawn chance by ~10%
  - Set GREG vanilla & custom spawn weights to ~10%
  - CutieFly:
    - Reduced spawn weight by ~50%
    - Reduced max spawn count: 6 -> 4
  - SnailCat:
    - Restored previous Snail Cat names
    - Reduced max spawn count: 6 -> 3
- Enabled Soul Devourer on all modded moons at a low spawn weight of 5
- Biodiversity:
  - Set all developer scrap to 7 spawn weight
  - Lowered Junk Radar spawn chance: 80% -> 50%
  - Enabled Junk Radar on more moons

#### Added:

- Camera Overhaul

### 1.18.3

#### Added:

- BepInEx MonoMod Debug Patcher

### 1.18.2

#### Changed:

- Darkened LoadingScreen text background
- LunarConfig:
  - Removed old creature spawning overrides to allow new creatures to spawn
  - Updated drivability rating for new moons
- Chameleon:
  - Configured new moons for mineshaft interior cave variants and manor interior window variants
- CustomOutsideObjects:
  - Disabled Mangrove
  - Disabled Snowmen till festive season
  - Configured for new moons
- Disabled Advance Features' performance report UI
- ButteryFixes:
  - Completely destroyed bodies will display 'No signal!' on the radar
  - Renamed 'Golden Cup' to 'Golden Goblet'
  - Enabled Cadaver HUD
- UsualScrap:
  - Disabled built-in item icons.
  - Lowered global spawn weights:
    - Padlock: 30 -> 20
    - Crowbar: 30 -> 13
    - Candy Dispenser: 30 -> 11
    - Fuel Cylinder: 20 -> 9
    - Radioactive Cell: 20 -> 9
    - Rose: 30 -> 11
    - Sizeable Scissors: 20 -> 11
    - Vintage Candy: 20 -> 16
    - Walking Cane: 15 -> 8
    - All capsules: 15 -> 5
    - Tickets: 40 -> 12
    - Golden ticket: 5 -> 3
- Disabled warnings for Coroner via AsyncLoggers as a mitigation for log spam

#### Added:

- DestroyTemporaryEffects
- LethalError

#### Removed:

- LethalElementsThetaV81

### 1.18.1

#### Added

- FairAI

### 1.18.0 (unstable beta)

#### Changed:

- Updated at long last to v81! 🎉
- Enabled Advance Features' performance report UI
- Enabled CruiserTunes' random song sorting
- Adjusted various settings in NicheTweaks, including:
  - Enabled a volume slider per-player
  - Enabled auto-renaming save files to lobby name
  - Removed LethalConfig's button from the main menu
- Somewhat restore configuration parity of Surfaced from older modpack versions
- Reduced weight of clear weather: 3000 -> 2000
- Prevented the following mods from loading:
  - TwitchChatAPI
  - LethalSettings
- Reduced the volume of Teto Fumo: 0.7 -> 0.4
- CodeRebirth:
  - Reduced volume of Zort instruments: 1-> 6
  - Reduced spawn change of Redwood Titan and disabled spawning on Kiln
- Configured NightOfTheLivingMimic to hopefully behave like MirageRevive
- Adjusted the following settings in darmuhsTerminalStuff:
  - Lever command text: 'PULLING THE LEVER!!' -> 'Engaging the ship's lever.'
  - Enabled command history (use up & down arrow keys)
  - Reverted v1.17.0 modpack change of taking the player to the Home screen each time

#### Added:

- Surfaced
- Observer
- DunGenReferenceFixer
- Scandals Tweaks
- DestroyItemInSlotFix
- BetterSprayPaint v80Fix
- DoctorNoYap
- TerminalUtils
- MaterialAssetRestorerCore
- LightsOut
- UniqueItemSounds
- BetterMenuSong
- loaforcsSoundAPI
- Casino v81 Patch
- LethalCasinoTweaks
- TKronix Scripts
- UniTask
- Vehicles:
  - Vandal Electronics Scanvan
    A van packed full of features. Manual controls.
  - Company Hauler
    A tanky 5-seater pickup truck. No boost.
  - NuclearCruiser
    A highly-explosive variant of the Company Cruiser. 15% chance.
- Moons:
  - MrSaltedBeef:
    - 43Coralation
  - SkelaahsWildMoons:
    - Fracture
  - Beanies Moons:
    - Ingression
    - Solitude
    - Desperation
    - Nephrite
  - Kenjis Moons:
    - Thrive
    - Subsidence
    - Alacrity

#### Removed:

- BetterEmotes
- Loadstone (implemented in vanilla)
- ClaySurgeonOverhaul
- RebalancedMoonsBeta
- LLLHotreloadPatch
- RagdollDesyncFix (fixed in vanilla)
- FeedFish
- YesFox (added back into vanilla)
- v73dcfix (fixed in vanilla)
- ReverbTriggerFix (fixed in vanilla)
- Spiner (client-side animation issues)
- Haunted Harpist (log spam)

#### Replaced:

- VentSpawnFix -> SpawnCycleFixes
- FacilityMeltdown (TeamXiaolan) -> FacilityMeltdown (loaforc)
- TestAccountFixes -> InventoryFix
- ImmortalSnail -> ImmortalSnailFork
- NoVoidDeath -> AlwaysInBounds
- MissileTurretsFork (HQ_Team) -> MissileTurretsFork (Nikki)
- AdditionalNetworkingExperimental -> AdditionalNetworking
- Standalone moons of Beanibe -> Beanies Moons
- LethalElementsTheta -> LethalElementsThetaV81
- MirageRevive -> NightOfTheLivingMimic
- NavMeshInCompany -> NavMeshInCompanyRedux

<details>
<summary><b>Older versions</b></summary>

### 1.17.5

#### Changed:

- 2 Story Ship updated, fixing the issue of the ship becoming bugged on party wipe
- Enabled `sync_radar_names` in LobbyControl
- Reduced Maxwell's volume: 50 -> 35
- Blacklisted Prototax from being attacked by Bees, the Driftwood Menace, and Shockwave Gal as it seems stubbornly unkillable

#### Removed:

- abandonedcompanyassetsfork ~~(this was the cause of invisible items in reserved slots after teleporting)~~

#### Replaced:

- PizzaProbabilityFixed -> PizzaProbabilityUpdated

### 1.17.4

#### Changed:

- Fixed some interiors only spawning their custom scrap: disabled moon/interior spawnable item configuration in LunarConfig
- Removed Handlamp from reserved slot as it does not stay lit when deselected
- Removed Handlamp from allowed teleportation list to keep things consistent

### 1.17.3

#### Changed:

- Fixed regular items not being added to the allowed teleportation list
  - **Items will not be visible in your reserved slot until dropping them & picking them up again!**
- Disabled CodeRebirth Halloween skins
- Re-enabled BetterVehicleControl's automatic gearbox
- Disabled AdvanceTweaks' performance report

### 1.17.2

#### Changed:

- Actually enabled changes to the Prototax
- Fixed Spiner not spawning due to not being configured to spawn in LunarConfig
- Reduced Leaf Boy hp: 3 -> 2

#### Added:

- TetoFumoMod & NeruFumoMod

### 1.17.1

#### Changed:

- Fixed terminal moon display

### 1.17.0 | v73

```
This release merges with SafeCompanyUnionExpansion.
```

#### Changed:

- Updated everything to v73! 🎉
- Terminal:
  - Enabled terminal autocomplete (press `tab` when typing)
  - Experimentally set the terminal to always bring you to the home page on entering it
- Experimentally disabled BetterVehicleControl's automatic gearbox
- Allowed more flashlight variants to be carried in the flashlight slot
- Allowed inversing with walkie-talkies and flashlight variants (will drains the battery by 15%)
- Enabled notification when trying to teleport unrecoverable bodies
- Reduced The Doctor's spawn weight: 10 -> 7
- Lowered fake air horn scrap's spawn weight: 5 -> 4
- Lowered Shy Guy's painting scrap spawn weight: 8 -> 6
- Decreased number of ads
- Nerfed Haunted Harpist:
  - Attack damage: 30 -> 25
  - Max speed: 7 -> 5
  - Attack cooldown: 3 -> 4
- Lethal Things:
  - Hacking tool can now hack some hazards and behaves differently
  - Increased price of Rocket Launcher: 300 -> 400
  - Additional Rocket Launcher ammo can be purchased (Missile)
  - Disabled Flaregun & Flaregun ammo
- CodeRebirth:
  - Added 2 SnailCat names
  - Roughly halfed frequency of crashing Oxyde ship
  - Disabled Emerging Cacti on Wither and Pareidolia
  - Disabled Tornado weather
- Disabled DawnLib achievements
- Disabled 10 cosmetics (mostly those with similar alternatives)
- Configured the following mods for all current moons:
  - CustomOutsideObjects
  - WeatherRegistry
    - New weathers: Earthquake, Hurricane, Blood Moon
    - Clear weather is hopefully more common
  - Chameleon
  - LunarConfig
    - Added cruiser drivability text to each moon
    - Replaced vanilla Facility and Mineshaft with Wesley's Expanded Facility and Expanded Mineshaft
    - Prototax are now killable (3hp)

#### Added:

- Enemies:
  - Spiner
- Items:
  - Lethal Nuke
  - abandonedcompanyassetsfork
- Cosmetics & Suits:
  - Gradient Suits
  - BeeCosmetic
- Fixes & Improvements:
  - LoadingInfo
  - OrbitRecharge
  - ReviveDesyncPatch
  - NoVoidDeath
  - Advance Features
  - NicheTweaks
  - FontUpdate
  - ImprovedLethalThings
  - LethalScrollFix
  - V73dcfix
  - TypeLoadExceptionFixer
  - BetterBetterTeleporter
  - V70PoweredLights Fix
  - BetterCruiserSync
- Moons & Interiors:
  - Most things from SafeCompanyUnionExpansion
  - Luna's Moons
  - Kenji's Moons
  - 5 Halycon
- Dependencies/Libraries:
  - MonkeyInjectionLibrary
  - Interactive Terminal API
  - StaticNetcodeLib
  - LunarConfig
  - WaterAssetRestorer
  - SolidLib
  - Combined Weathers Toolkit

#### Removed:

- DisableLethalThingsDartScanNodes (unneeded)
- UniversalShipLaunch (unneeded)
- VileVendingMachine (broken)
- Surfaced (somewhat broken)
- ShockwaveDrone (broken)
- Remnants (to try Abandoned Company Assets)
- MoreBlood (leaves too many footprints in snow)
- BetterRealisticSuits
- TerminalConflictFix (DawnLib has a native implementation)
- LethalMoonUnlocks
- Recede
- NotezyLib
- Lunar Lights
- Silence moon
- Some of Beanie's Moons
  - Solitude
  - Symbiosis
  - Desperation
  - Nephrite

#### Replaced:

- FacilityMeltdown -> FacilityMeltdown (of TeamXiaolan)
- PizzaProbability -> PizzaProbabilityFixed
- LethalElements & LEBWeatherFix -> LethalElementsTheta
- NetworkMetricsFix -> ChuxiaFixes
- AdditionalNetworking -> AdditionalNetworking_Experimental
- Piggys Variety Mod -> PiggysVarietyMod
- FairAI -> FairAIFork
- GamblingMachineAtTheCompany -> GamblingMachineAtTheCompanyFork
- MissileTurrets -> MissileTurretsFork

### 1.16.19

**Added:** (to ensure latest versions)

- Wesleys Ememy Variants
- JLL

**Changed:**

- Increased Cabinet's warning duration: 1.5s -> 5s

### 1.16.18

**Added:**

- Wesleys Weathers

**Replaced:**

- RuntimeIcons CodeRebirth with RuntimeIcons BetterRotations

**Changed:**

- Updated DawnLib (scrap saving bug resolved)
- Enabled terminal tags for moons in LethalMoonUnlocks (if installed)
- Increased price of Recede: 1 -> 50

### 1.16.17

**Added:**

- itolib

### 1.16.16

Note: currently scrap will not save correctly on reloading the lobby.

**Added:**

- Chillax Suits
- RuntimeIcons CodeRebirth
- MoreAds
  - Some unobtainable items (e.g. bugged LethalThings items) and ship walls are now blacklisted from ads

**Changed:**

- Blacklisted Flooded weather from Recede
- Forgot to mention last update that Oxyde will now unlock the intended way

### 1.16.15

Note: there may be some issues currently. Try restarting the game if you can't land or players can't join.

**Added:**

- UniversalShipLaunch (anyone can now pull the lever!)
- CorrectDeathPenalty
- Fairer Fire Exits (fire exits should spawn deeper into the interior)
- RestoreMapper (to replace LethalThings' Remote Radar)
- CoronerIntegrations (death messages compatibility for many mods)
- DawnLib

**Removed:**

- CodeRebirthLib

**Changed:**

- Disabled Boomba (it truly is not functional after all)
- Autonomous Crane's will now deactivate for 1 to 2 mins
- Updated some CodeRebirth entity blacklists
- Configured LethalMoonUnlocks to behave similar to Selene's Choice if installed

### 1.16.14

**Removed:**

- ModlistHashChecker

### 1.16.13

**Added:**

- CoilHeadStare
- ModlistHashChecker

**Removed:**

- LobbyCompatibility
- SmartItemSaving

**Changed:**

- Reduced chance of an Autonomous Crane: 30% -> 10%
- Reduced price of Pickle on a Stick: 400 -> 100
- Significantly reduced spawn weights of the Industrial Fan hazard
- Blacklisted snowy weathers from The Iris
- Bozoros will now appear in regular rotation with Selene's Choice
- Disabled Cleaner Drone Gal

### 1.16.12

**Removed:**

- SCP939

**Changed:**

- Reduced Masked spawn chance: 1% -> 0.5%

### 1.16.11

**Changed:**

- Actually generated config for SmartEnemyPathfinding
- Enabled Terminal Gal
- Disabled Cruiser Gal
- Increased price of Cleaner Drone Gal: 200 -> 500
- Decreased Flare Gun price and ammo price: 100 -> 20 & 20 -> 5

### 1.16.10

**Added:**

- SmartEnemyPathfinding (Masked will now follow players through Fire Exits and use custom elevators)
- LegendWeathers (Majora Moon weather)

**Removed:**

- LooseJesterSpring as the result was often unintentional and unfair
- Moved Magnet Switch as it is redundant with 2 story ship

**Changed:**

- Lowered Redwood Titan's spawn weight: 15 -> 10
- Disabled ScienceBirdTweak's experimental item scan
- Lowered Maxwell's volume: 100 -> 60
- Lowered The Doctor's spawn weight: 50 -> 20
- Capped max Autonomous Cranes to 1

### 1.16.9

**Added:**

- BetterRealisticSuits
- ClownSuit

**Removed:**

- men stalker due to performance concerns and strange behaviour
- SneakoChair

**Changed:**

- Disabled Vermin
- Enabled ScienceBirdTweak's experimental item scan
- Masked will now be targeted by vanilla turrets
- Increased the rarity of Boom Traps, Bear Traps, Functional Microwaves, and Laser Turrets

### 1.16.8

**Removed:**

- fiufki's Scrap Beta as default weights are too high

### 1.16.7

**Changed:**

- Switched back to using SuitSaver instead of KeepMySuitOn
- Increased lobby timeout: 120000ms -> 150000ms

### 1.16.6

**Removed:**

- AlwaysHearActiveWalkies (causes desyncs)

### 1.16.5

**Added:**

- NetworkMetricsFix

**Changed:**

- Updated Chameleon's manor window style and mineshaft wall texture lists to include moons from the expansion pack
- Scarlet Devil Mansion interior will now use vanilla fire exits (so it is easier to discern mimics)
- Decreased spawn weight of Tesla Gates: 0.7 -> 0.3 (not entirely sure how weight works in this context)
- Reduced outside enemy detection range for interior doors: 30 -> 15

### 1.16.4

**Changed:**

- Updated MikuFumoMod

### 1.16.3

**Added:**

- The Rolling Chair
- MikuFumoMod

**Changed:**

- Configured CustomOutsideObjects for custom moons included in the expansion pack (would previously only spawn on vanilla moons)
- Enabled Minion suit
- Potentially fixed non-default font being used in the terminal for some players
- Nerfed Haunted Harpist:
  - Attack damage: 45 -> 30
  - Attack cooldown: 2 -> 3
  - Max speed: 8 -> 7
  - Max chase acceleration: 50 -> 40
- Replaced SuitSaver with KeepMySuitOn to fix suit resetting when using a paid suit. You will need to select your suit again when using a new profile
- First pass through of balancing Poltergeist:
  - Power regen per second: 5 -> 3
  - Audio playing cost: 40 -> 100
  - Pester cost: 20 -> 35
  - Ship door cost: 30 -> 50
  - Manifest cost: 60 -> 50
  - Removed some enemies from the pester blacklist: Prototax, Harp Ghost, Piper Ghost, & Doctor's Corpse
- Facility Meltdown:
  - Disabled explosion always triggering on ship departure
  - Updated the blacklist of enemy spawns during a meltdown

### 1.16.2

**Added:**

- AutoScroll
- Black Fog Weather

**Removed:**

- EnemyFix (likely not needed anymore)
- TeleportDecline

**Changed:**

- Replaced ShipLoot with ShipLootCruiser
- Updated readme slightly
- Adjusted some weather weights & blacklisted Snowfall and Blizzard weather from Bilge and Thallasic
- Prevented some enemies from being pestered with Poltergeist
- Set Poltergeist power settings to default
- Added some Snail Cat names
- Potentially prevented a NRE with the Immortal Snail when killing a player
  - Enabled FairAI's `Immortal affected` setting

### 1.16.1

**Changed:**

- Changed the ship's layout
- Prevented Autonomous Cranes from spawning on Noctis
- Prevented Emergency Flare Ammo from spawning as a Remnant item
- Potentially fixed Remnant items unable to be stored in Belt Bags
- Unlocked Oxyde by default when using Selene's Choice as otherwise Oxyde will lock after reloading the save
- Added Artifice as a treasure moon in Selene's Choice
- Disabled interior Old Birds for Grand Armory
- Adjusted weights for the following interiors: Vehicle Hangar, Dam, Deepcore Mines, Greenhouse, Fractured Complex, Atlantean Citadel, Toy Store, and Art Gallery
- Updated moon weather filters to include new moons in the expansion
- Fixed Heatwave having a blacklist set instead of a whitelist
- Reduced default weight of Tornado weather: 100 -> 20

### 1.16.0 - Hello again :D It's been a while!

_This updates adds a lot so things may not be balanced!_

**Added:**

- UniversalRadar (all moons will now have a contour map!)
- LEBWeatherFix (Toxic Smog weather enabled once again)
- RebalancedMoonsBeta
- EnhancedLockpicker
- BetterEmotes
- TheDoctor
- HauntedHarpist
- TheCabinet

**Changed:**

- Replaced Scopophobia with the updated fork
- Replaced ExperimentalEnemyInteractions with NaturalSelection
- Replaced fiufki's Scrap with fiufki's Scrap Beta
- Customised loading screen
- Disabled Mantis Shrimp
- Reduced max seamines: 5 -> 4
- Updated NaturalSelection's blacklists
- Updated Mirage item blacklists
- Reduced Jester pop chance on hit: 70% -> 50%
- Reduced spawn curves of Wooden Crates, Metal Crates, AC Units, and Bear Traps
- Disabled trash cans as they can block doorways

### 1.15.0 (Updated for v70)

**Added:**

- DiFFoZTweaks
- Minecraft Steve Suit
- SCP939
- ColorfulEnemyVariety
- Unioniforms
- UnlockOnStart to unlock default suits

**Removed:**

- UsefulZapGun in favour of solely using ScienceBird Tweaks
- RebalancedMoonsBeta till it is updated
- EnhancedLockpicker (broken)
- BetterEmotes (somewhat broken)
- RebalancedMineshaft (broken - softlocks lobby)
- LethalCompanyVR (not yet fully compatible)
- ExtraEnemyVariety
- PintoBoy (intermittent issues, _maybe_ due to LethalSponge)
- SnatchinBracken
- LethalHands (broken)
- LethalFashion (broken)

**Changed:**

- Adjusted weights of most custom enemies to spawn based on moons in the expansion pack (support for Wesley's Moons to be added later)
- Adjusted weights of new interiors added in the expansion pack
- Tweaked weather weights once again to make more sense
- Lethal Sponge:
  - Disabled ApplyMapCameraQualityOverrides (changes monitor colour)
  - Increased Security camera cull distance: 20 -> 150
- Disabled Toxic Smog weather (somewhat broken)
- Replaced ShipWindowsBeta with the stable release
- Added an emotes prompt to the terminal
- Suits:
  - Removed directly included Magenta, Deadpool, Green and Grey, and Minecraft Steve suits
  - Disabled Betty, Zort, and Delilah
- Boosted FeedFish reward probability by 15%
- Disabled Remote Radar and Axe store items
- Limited equipped cosmetics to 15
- Enabled Scrap-E's trash cans
- Various other things

### 1.14.20

- Doubled LobbyControl's connection timeout in an attempt to prevent black foggy screens occuring: 60000ms -> 120000ms
- Downgraded CustomStoryLogs to 1.4.6 to fix issues with tape skipping on Galetry.

### 1.14.19

- Added LandFromOrbit.
- Enabled Tower interior as its tiles now have more variation.
- Reduced Grand Armoury interior weight on Titan: 300 -> 100. Also adjusted some other interior weights.
- Reduced Men Stalker spawn weight: 10 -> 7
- Fixed an issue where scrap would be saved on crew wipe. This was intended with Wesley's Moons, but no longer!
  - To revert this behaviour, uncheck `Despawn remnant items on party wipe` in Remnants' config or install a mod like [SaveOurLoot](https://thunderstore.io/c/lethal-company/p/MrHydralisk/SaveOurLoot/)/[SafeSoloScrap](https://thunderstore.io/c/lethal-company/p/ButteryStancakes/SafeSoloScrap/).

### 1.14.18

- Removed Zap Gun override from No Console Spam that caused issues with opening facility doors.
- Added:
  - Men Stalker as it has been revamped (spawn weight of 10).
- Enabled:
  - Useless but _clicky_ buttons on the ship's control panel.
  - Dynamic occupancy sign.
  - Earth Leviathan's now create quicksand where they emerge and re-enter the ground (will disable if too prominent).
- Increased Zap Gun price due to its many new uses: 400 -> 500
- Added a line in the terminal showing how to purchase windows.

### 1.14.17

- Replaced modpack icon and loading image with that created by a great asset! ;)
- Disabled Tower interior.
- Increased weight of Pool Rooms interior by 50.
- Disabled some enemies from setting off mines/sea mines if they usually don't visibly touch them. Also, Brackens no longer trigger any mines.

### 1.14.16

- Added:
  - LoadingScreen for displaying a loading window when the game is booting.
  - A loading image.
- Disabled:
  - LethalPerformance's "Cache entrance teleport" in case it conflicts with EntranceTeleportOptimizations.
  - FacilityMeltdown for 3 specific Wesley moons.
  - LethalSponge's volumetric compensation for Cosmocos.

### 1.14.15

- Increased Defibrilator uses: 4 -> 5
- Enabled button for rotating ship's floodlights.

### 1.14.14

- Corrected changelog.

### 1.14.13

- Potentially fixed frozen terminal radar map.
- Added TerminalConflictFix due to `filter none` resulting in trying to purchase `filter0` (darmuh's implementation does not resolve this).
- Added ExperimentalEnemyInteractions once again! :D
  - Circuit Bees will now act aggressively to other creatures.
  - Earth Leviathans will target creatures.
  - Hydrogeres will damage creatures.
  - Mostly I have configured the above from a gameplay perspective.

### 1.14.12

- Removed SpectatorDeathCause. Usually the displayed deaths weren't correct.
- Added ScienceBirdTweaks (this might conflict/break things):
  - Wesley's Moon unlocks and tape audio should now be fixed. You can also skip tapes.
  - Switched to this mod's methods of disabling hazards with the Zap Gun.
  - Facility doors can now crush you and enemies!
  - Removing the apparatus will disable some hazards.

### 1.14.11

- If interior desyncs were an issue, they should now be resolved.
- SnatchinBracken:
  - Added a 25% chance for insta-kill
  - Reduced seconds before auto-kill: 60 -> 45
  - Enabled stuck force kill
- Reset TerminalFormatter config as I had mistakenly changed values last update.
- Set cost of purchasing moveable ship objects to 10 credits.

### 1.14.10 - 1 year on & 30k downloads! :D 🎉I hope you've had fun!

- Enabled Mimic (fire exit) colour blind mode.
- Mirage:
  - Reduced Masked revive chance on player death: 20% -> 15%
  - Reduced chance for a Masked's item to be a store item: 50% -> 30%
  - Enabled some store items for use
- Capped Soul Devourer at 1 max spawn (forgot to mention, but spawn weight is now 10).
- Added:
  - RagdollDesyncFix
  - ReservedFlashlightSlot (use `F` to toggle flashlight)
- Reverted LethalPerformance to 1.0.1 to avoid bugs with the current version.
- Readme:
  - Corrected wrong inventory fix button shown
  - Explained reserved slot controls
  - Added a link to the LC Modding Discord server in the Readme.

### 1.14.9

- Updated dependencies.

### 1.14.8

- Disabled Darmuh's Terminal Stuff Fun Commands
- Reduced chance of navigation malfunction: 7.5 -> 4

### 1.14.7

- Added EntranceTeleportOptimizations
- Reduced Poltergeist ghost volume: 0.5 -> 0.3
- Increased spawn weight of Pool Rooms on Valley and Marsh tags.

### 1.14.6

- Removed ExperimentalEnemyInteractions as blacklists do not seem to apply regardless of True/False setting.
- Somehow I never added LethalSponge back in 1.14.0? Anyhow, it is here now.
- Lowered TeslaGate volume and spawn weight: 1 -> 0.7
- Lowered Soul Devourer spawn weight: 33 -> 15
- Halved Bear Trap spawn weight: 10 -> 5

### 1.14.5

- Merged SafeCompanyUnionFixes into this package due to contained mods frequently downloading with incorrect versions :P

### 1.14.4

- Notably, updated RebalancedMoonsBeta which fixes clients unable to join.
- Removed MirrorDecor due to performance concerns.
- Added ExperimentalEnemyInteractions once again.
  - Will remove if too performance-intensive.
  - Enemy blacklists will probably need further adjustment depending on what feels fun/balanced.
- Lowered some item weights.

### 1.14.3

- Biodiversity updated!
  - New entities:
    - Coil Crab
    - Boom Bird
  - Leaf Boys and Prototaxes have been re-enabled as their bugs were fixed!
- Added LLLHotReloadPatch as a direct dependency.
- Increased LobbyControl connection timeout: 20s -> 1min
- Updated Readme
  - Added a section on keybinds
  - Updated troubleshooting section
- Prevented a few newer store items spawning through Remnants and Code Rebirth Crates.

### 1.14.2

- Disabled _many_ cosmetics (sorry!) that were duplicates or didn't fit in that well, freeing up a bit of RAM.

### 1.14.1

- Updated the Readme
- Configured Mirage's scrap list for Masked.
- _Actually_ removed FairGiants.
- Configured ShipWindowsBeta.
- Buffed Aloe slightly.
- Updated weather weights to new defaults.
- Added the Soul Devourer enemy.

### 1.14.0

- Replaced:
  - ShipWindows with ShipWindowsBeta.
  - LethalElements with LethalElementsBeta.
- Added:
  - Atlas for prettier skyboxes.
  - UsualScrap for useful items!
  - TerrasScrap.
  - fiufki's Scrap.
- Configured LC Office interior.
- Disabled ExtraEnemyVariety's festive skins.

### 1.13.16

- Halved spawn weights of all monster plushies and the scavenger plushie.
- Enabled spawning of masked, nutcracker and jester plushies on all moons.
- Decreased spawn weights of the Country Road Creature and its scrap.
- Disabled "scary door" feature of the Rubber Rooms interior.

### 1.13.15

- Lowered Halls of Flesh interior weight: 60 -> 20
- Updated dependencies (new emotes!)
- Reverted Coil Head's power level: 2 -> 1
- Added Orbits (for better vanilla planet preview videos)

### 1.13.14

- Removed CoilHeadStare due to incompatibility with LethalEmotesAPI.

### 1.13.13

- Removed Celestial Tint to try ButteryFixes' Planet Preview.
- Added DisplayWeightInKilograms (apologies to those in the US & UK).
- Downgraded Wider Ship to 1.3.14 for use with non-beta ShipWindows.
- Decreased weights of PremiumScraps' scrap.
- Adjusted some FairAI configs.
- LethalThings:
  - Decreased weights of scrap.
  - Disabled Pinger as it is non-functional.
  - Enabled Rocket Launcher as the ammo bug has been fixed.
  - Enabled Boombas to experiment.

### 1.13.12

- Added:
  - ButteRyBalance.
  - YesFox (added due to above mod, may disable later)
  - Atomic's Cosmetics.
  - RebalancedMineshaft.
- Removed:
  - fiufki's Scrap (temporarily).
  - Terra's Scrap (temporarily).
  - FairGiants (handled by ButteRyBalance)
  - StandaloneBlindPup.
  - men stalker due to performance concerns.
- Decreased spawn weights of CodeRebirth items.
- Disabled Jetpacks from spawning in Wooden Crates.
- Decreased spawn weights of all Premium Scraps items.
- Decreased weight of Halls of Flesh interior: 90 -> 60
- Decreased meltdown chance: 50% -> 33%
- Disabled the janitor enemy's trash cans.
- Reduced Redwood's spawn weight: 30 -> 20
- Disabled a certain furniture.
- Capped Football's spawn weight: 20 -> 15.

### 1.13.11

- Disabled Cruiser Gal.
- Decreased CountryRoadCreature's spawn weights.
- Changed default Poltergiest manifest keybind (other controls _may_ be incorrect - this will be fixed with testing)

### 1.13.10

- Disabled Carnivorous Plant as in certain conditions it is unfair.
- Enabled the Rubber Rooms interior.
- Decreased Snow Globe scrap spawn weight: 30 -> 20
- Lowered Redwood Titan's spawn weight: 50 -> 30
- Increased Janitor's spawn weight: 10 -> 20
- Shockwave Gal:
  - Decreased propeller volume: 0.75 -> 0.5
  - Decreased number of attacks: 10 -> 5
- Disabled some CodeRebirth player models.
- Removed:
  - SpectateEnemies.
- Added:
  - LethalHands (use `J` to toggle).
  - Poltergiest.

### 1.13.9

- Removed BetterMenuSong due to NRE.
- Disabled RubberRooms interior.
- Fixed incorrect dynamic tag usage.
- Adjusted some interior weights.
- Disabled a fire exit on Titan.

### 1.13.8

- Updated Readme
- Added Useful Zap Gun.
- Disabled CodeRebirth's Laser Turret due to a bug making it only affect the host.
- Disabled FairAI for the Aloe and menstalker.
- Replaced WeatherTweaksBeta with the stable release.
- Reduced OpenBodyCams framerate (30fps -> 15fps) to nerf it and improve performance.
- Lowered menstalker's spawn weight (20 -> 13) to make it a rarer and more unexpected monster.
- Lowered Urchin's spawn weight: 20 -> 10
- Removed:
  - MolesterLootBug_Fork as it doesn't really add to gameplay.
  - OuijaBoard due to limited usefulness and incompatibility with Remnants.

### 1.13.7

- Re-added RebalancedMoonsBeta as interior desyncs have been fixed.
- Regenerated LehtalLevelLoader's config. Adjusted several interior weights.

### 1.13.6

- Removed RebalancedMoonsBeta till interior desyncs are fixed.

### 1.13.5

- Disabled TestAccountFixes' ItemGrab fix due to potential issues.
- Reduced spawn weights of each of PiggyVarietyMod's bulb and chemical scrap: 30 -> 15
- Removed NaturalSelection for now due to NREs in log and reported issues.
- Disabled shorter animation shake of BetterSprayPaint.
- Disabled HorseShootCrabs as their max spawn configuration doesn't work.

### 1.13.4

- Added RebalancedMoonsBeta to make the vanilla moons a bit nicer.
- Disabled scanning exploded landmines.
- Removed ImmersiveScrap in favour of TerrasScrap.
- Added PremiumScraps to spice things up a bit.
- Added ClaySurgeonOverhaul.
- Added CustomOutsideObjects to make moons a bit more dynamic.

### 1.13.3

- Actually included the updated configs (insert facepalm)

### 1.13.2

- Added MrovWeathers.
- Disabled Big Berthas being set off by enemies.
- Reduced wooden and metal crate spawn weight: 3 -> 1.
- Moved door switch back to regular position thanks to new config :D
- Added ClownHornFish and Tulip Snakes to Shockwave Drone Girl's blacklist.
- Removed Diversity due to performance issues.
- Removed BlackoutHazards due to reported issues.
- Made the interior ship walls solid.
- Increased rare moon threshold to 800 credits.
- Disabled new CodeRebirth Gals.

### 1.13.1

- Added LethalCompanyVR back! (Ladder animations and sounds are fixed)
- Switched to LethalRichPresenceExperimental
- Changed weather weights:
  - Windy: 100 -> 35
  - Solar Flare: 25 -> 35
  - Heatwave: 25 -> 35
  - Cloudy: 25 -> 80
- Increased scrap value multiplier in Windy weather: 1 -> 1.2
- Added some logical weather to weather weights (e.g. higher chance of DustClouds after Windy)
- Enabled blacklist on CodeRebirth wooden crates to prevent broken items spawning.

### 1.13.0

- Added CodeRebirth!
  - Will fine-tune feature configs at a later date.
- Added DisableLethalThingsDartScanNodes for better performance with LethalThings.

### 1.12.11

- Disabled Shisha due to experiencing issues that may stem from it.
- Updated to use new SoundAPI.

### 1.12.10

- Ensuring that a config generated correctly.

### 1.12.9

- Changed Remnants items to behave more like regular tools.
- Reduced Remnants items spawning: 2-8 -> 0-4.
- Trialing a wider ship! (Added Wider Ship Mod)
- There is now a chance 20% chance for a silly coil head skin (Added A Rather Silly Coil Head)
- Replaced WeatherTweaks with WeatherTweaksBeta.
  - Two new weathers: Blackout and Cloudy
- Reduced Solar Flare and Heatwave weather weights: 100 -> 25
- Decreased Slaughterhouse interior weight on Rend and Dine: 300 -> 150

### 1.12.8

- Updated dependencies.
- Added CoilHeadStare once again.

### 1.12.7

- Updated dependencies. Masked no longer spin on the radar.
- Increased LethalPerformance atlas texture resolutions to prevent log spam.
- Increased charger electrocution damage: 20 -> 30
- Disabled LeafBoy for now.
- Increased player threshold health for Aloe triggering: 60% -> 70%
- Increased Aloe default modded moon spawn weight: 2 -> 10
- Disabled TestAccountFixes' AutomaticInventory fix
- Decreased max amount of Shisha: 3 -> 2
- Decreased Masked spawn chance: 2% -> 1%

### 1.12.5-1.12.6

- Updated dependencies. MirageRevive should now function correctly.

### 1.12.4

- Updated dependencies.
- Lowered beehive from tree decor chance: 2% -> 1%
- Disabled Prototax till global sound issue is fixed.
- Added:
  - Remnants following compatibility update.
  - StandaloneBlindPup as it is no longer insta-kill. Will remove if encountered too frequently.
  - Natural_selection.
  - FashionableCompany.
  - BlackoutHazards -> Turrets and Spike traps will now disable when the apparatus is pulled.

### 1.12.3

- Updated dependencies as mod manager refuses to download correct version.

### 1.12.2

- Removed Remnants due to issues saving vanilla items when placed on the new furniture.
- Replaced Zombies with Mirage revive.
- Decreased maximum MissileTurrets to 4.

### 1.12.1

- Prevented several store items from spawning via Remnants (some to prevent buggy LethalThings items, and others for balancing).
- Adjusted interior weights of those in the Expansion pack to be more balanced.

### 1.12.0

- Added:
  - Scavenger Plushie
  - Missile Turrets
  - MelanieMelicious Utility Furniture Pack
  - Remnants
  - ImmersiveScrap (some issues were fixed)
- Removed InsanityDisplay as it is not that useful.
- Disabled halloween themes and enemy skins.
- Configured the Storehouse and Slaughterhouse interiors.
- Reduced size of PoolRooms interior: 2.5 -> 1.8
- Reduced Horseshoot Crab spawn weight: 12 -> 6
- Disabled Diversity's speaker voicelines.

### 1.11.11

- Added latest versions of all dependencies to the modlist - no more black screen.

### 1.11.10

- Removed RemoveInteriorFog as v68 reduces the chance to 2% from 80%.
- Removed Emergency_Dice_Updated due to severe lag.

### 1.11.9

- Reenabled Toystore's Halloween theme for the next while.
- Added RemoveInteriorFog.

### 1.11.8

- Added back Diversity.
- Disabled Diversity's menu music.
- Disabled Chameleon's always rainy March.
- Trialing enabling LimitSpawnChance in ButteryFixes.
- Disabled Toystore's Halloween theme.

### 1.11.7

- Disabled BepInEx's console.
- Enabled Diversity's posters as they are now compatible with 2 story ship.
- Removed Diversity itself till the sound issue is fixed.
- Regenerated Mirage's config to try and combat high Masked enemy spawns.
- Decreased Masked spawn chance: 5% -> 2%
- Removed SnazzySuits as the clown suit is not usable.
- Disabled Emergency_Dice_Updated's effects in the chat and adjusted some other settings.
- Decreased max ImmortalSnails: 4 -> 3
- Decreased ImmortalSnail weight: 45 -> 40

### 1.11.6

- Replaced MolesterLootBug with MolesterLootBug Fork.
- Reduced chance of Hoarding Bug grabbing you: 50% -> 30%
- Enabled SirenHead spawning on Seichi.

### 1.11.5

- Removed LCVR due to ladder animation bug.
- Added SpectateDeathCause.
- Set more moons for SirenHead spawning.

### 1.11.4

- Added back Locker & Malfunctions.
- Reconfigured Locker, Malfunctions and LethalFixes.
- Decreased Masked spawn chance: 7% -> 5%

### 1.11.3

- Removed TerminalClock.

### 1.11.2

- Added & configured darmuhsTerminalStuff.
- Added CountryRoadCreature.
- Set OpenBodyCams to 30fps.
- Reconfigured SirenHead's possible spawn moons.

### 1.11.1

- Removed Locker & Malfunctions as they currently have issues.
- Turns out I never removed NoMoreCompanyLogo, but it's updated now.
- Disabled some setings of EmergencyDice.

### 1.11.0

- ~~Removed LCVR till it updates.~~
- Removed NoMoreCompanyLogo till it updates.
- Removed ProblematicPilotry as the random dropship location isn't great for gameplay.
- Added OpenBodyCams.
- Added JesterDoorSlam.
- Added dependency for TVLoader so the new version is used.
- SnazzySuit's clown suit squeaks once again.
- Enabled showing Emergency_Dice_Updated's effects in the chat.

### 1.10.5

- Regenerated Surfaced's config to try and fix spawning issues.
- Regenerated several other duplicated configs.
- Decreased blood pool scale: 4 -> 3
- Updated spectate-able enemies.
- Removed some unused config files.
- Decreased LooseJesterSpring's pop chance: 100% -> 70%

### 1.10.4

- Regenerated WeatherRegistry's config.
- Changed Shisha to only spawn on fitting moons.
- Added Maggie & Crystal Ray to Facility Meltdown's entity blacklist.
- Made ClownHornFish and HorseShootCrab rarer.

### 1.10.3

- Disabled LethalThing's Dartboard (must have not done so previously :P)
- Disabled CruiserAddition's magnet switch.
- Disabled Emergency_Dice_Updated's friends option as it can spawn unfinished enemies.
- Enabled FeedFish's recover fed bodies to incentivize use.
- Updated FairAI's config.
- Updated README issues section.

### 1.10.2

- Updated dependencies.

### 1.10.1

- Changed the probability of a random dropship location from 100% to 60%.
- Enabled DontMovePosters in ShipWindows to prevent posters appearing where they shouldn't.

### 1.10.0

- Added MelanieMelicious 2_sToRy_ShIp.
- Disabled Diversity's posters.

### 1.9.21

- Disabled Emergency Dice ship turret.
- Lowered Masked spawn chance to 7.
- Replaced ImmersiveScrap with fiufkis Scrap.
- Disabled Biodiversity's Wax Soldier.
- Added Moved Magnet Switch.
- Added SneakoChair.

### 1.9.20

- Added TVRandomizer.

### 1.9.19

- Enabled Mirage recording whilst dead.
- Lowered spawns of Surfaced creatures.
- Lowered spawn chance of Football.

### 1.9.18

- Regenerated Mirage config and lowered spawn chance to 8.
- Added & configured Zombies to replace Mirage's removed feature.

### 1.9.17

- Set BetterMenuSong to use old rendition.

### 1.9.16

- Added BetterMenuSong.

### 1.9.15

- Set to ignore !less-suits.txt so default suits are loaded.

### 1.9.14

- Enabled vanilla enemy skins and disabled some less fitting ones.

### 1.9.13

- Enabled ScarletDevilMansion on Seichi.

### 1.9.12

- Removed Peepers.
- Removed Symbiosis.
- Removed DynamicInteriorVariety as interiors have now been configured with content tags.
- Added & configured Diversity.
- Configured Emergency_Dice_Updated.
- Decreased Masked spawn chance 15% -> 10%.

### 1.9.11

- Removed LethalCasinoChameleonPatch as it was patched by LethalCasino.
- Once again configured Emergency_Dice_Updated.
- Disabled Cruiser_Addition's scrap.
- Disabled CruiserTune's song notification.

### 1.9.10

- Regenerated Emergency_Dice_Updated's config.

### 1.9.9

- Added SnazzySuits.
- Unlocked all suits.

### 1.9.8

- Added LethalCasinoChameleonPatch.
- Regenerated Emergency_Dice_Updated's config.
- Removed StandaloneBlindPup.

### 1.9.7

- Removed FacelessStalker.
- Added men stalker.
- Added MirrorDecor.
- Configured ScarletDevilMansion for Rockwell.
- Removed RealisticRecharging (handled by LethalThings).
- Lethal Things:
  - Made Maxwell not evil.
  - Disabled Utility Belt purchase.
  - Disabled Boomba until fixed.
  - Disabled Dart board until fixed.

### 1.9.6

- Update readme regarding VR.

### 1.9.5

- Added RndmTunes.

### 1.9.4

- Set max seamines to 5.
- Decreased spawn weights of Surfaced's creatures.

### 1.9.3

- Added Chameleon.

### 1.9.2

- Added MoreBlood.

### 1.9.1

- Added NoMoreCompanyLogo.

### 1.9.0

- Switched from LateCompany to LobbyControl.

### 1.8.35

- Added CoronerMimics.

### 1.8.34

- Added BetterSprayPaint.

### 1.8.33

- Added Biodiversity.

### 1.8.32

- Added back SnatchinBracken.
- Added ExtraEnemyVariety.
- Migrated CompanyCruiserFix and CruiserImproved to SafeCompanyUnionFixes.

### 1.8.31

- Actually added StandaloneBlindPup.

### 1.8.30

- Added PizzaProbability ~~and StandaloneBlindPup~~.
- Removed Gnomes due to various issues.
- Decreased ShockwaveDrone spawn weights.

### 1.8.29

- Added FacilityMeltdown.
- Removed CoilHeadStare.

### 1.8.28

- Added RevisitStingers back as it has updated.

### 1.8.27

- Updated dependencies.

### 1.8.26

- Updated readme.

### 1.8.25

- Removed SnatchinBracken and RevisitStingers due to incompatibility with v60.
- Reduced ClownHornFish and HorseShootCrab spawn weights.

### 1.8.24

- Disabled Rocket Launcher due to ammo not saving.
- Disabled Toy Hammer due to various issues.

### 1.8.23

- Disabled shutter voiceline on moon transit.
- Disabled SmartItemSaving item rotation and falling as these are handed by MattyFixes.

### 1.8.22

- Added SmartItemSaving and StopBeesOpeningDoors.
- Disabled random ship landing location due to incompatibility with Lethal_Doors_Fixed.
- Enabled Tomb interior on Atlas Abyss.

### 1.8.21

- Added FacelessStalker.
- Allowed purchasing of cruiser if first was destroyed.
- Regenerated LLL config and reconfigured interior spawning.

### 1.8.20

- Removed GeneralImprovements due to performance hit whilst in ship. Potentially caused other issues too.

### 1.8.19

- Fixed missing Coroner files - my bad :P
- Updated readme

### 1.8.18

- Added TeleportDecline.
- Reset PiggysVarietyMod's scrap to default values.

### 1.8.17

- Adjusted Surfaced spawn weights (made all creatures rarer).
- Added and configured GeneralImprovements.

### 1.8.16

- Added LethalElements.
- Disabled Cruiser Addition's magnet rotation as there is no benefit with ProblematicPilotry.

### 1.8.15

- Decreased spawn weights of Urchins, Mantis Shrimp, and Bruce.
- Removed LobbyCompatibility due to inabilty to join game after rehosting if a mod was updated.
- Fixed misconfigured SirenHead spawning & enabled on Zeimalt.
- Added CruiserAdditions.

### 1.8.14

- Set FairAI to check for players inside interior first.

### 1.8.13

- Added LoreFriendlyTelevision.

### 1.8.12

- Added EnhancedLockpicker, DynamicInteriorVariety and ProblematicPilotry.
- Made PoolRooms rarer.
- Decreased weights of gnomes and gnome items once again.

### 1.8.11

- Added GoodItemScan and BetterEXP.

### 1.8.10

- Removed Herobrine and SCP1507 in favour of trying Surfaced.
- Added Piggys Variety Mod (weapons disabled)

### 1.8.9

- Configured WeatherRegistry to increase scrap value the same as WeatherMultipliers did.
- Added CruiserImproved, Symbiosis.

### 1.8.8

- Added Coroner.

### 1.8.7

- Removed FacelessStalker due to inability to kill players.

### 1.8.6

- Enabled ScarletDevilMansion interior spawning on Polarus and Auralis.
- Enabled Tomb interior spawning on Etern and Junic.

### 1.8.5

- Moved all interiors and moons to a separate pack.

### 1.8.4

- Replaced MetalRecharging with RealisticRecharging to hopefully allow Emergency_Dice_Updated to function.
- Re-added PintoBoy. Set its offset to 0 through MattysFixes to combat floating.
- Testing enabling Emergency_Dice_Updated ship door malfunctions.
- Updated FairAI config.

### 1.8.3

- Removed WesleysInteriorsAddon.

### 1.8.2

- Removed additional mods.
- Added CompanyCruiserFix, ScarletDevilMansion.

### 1.8.1

- Made PoolRooms rarer.

### 1.8.0

- Attempted to update the pack for v56. List of removed mods in the readme.
- Added BetterVehicleControls and PintoBoy.
- Reset colour of insanity meter to default.
- Decreased max. number of SCP1507 to 20.

### 1.7.6

- Removed Ganimedes and StarlancerWarehouse to decrease RAM usage.
- Removed AdditionalSuits.
- Moved CullFactory to SafeCompanyUnionFixes.
- Added SCP1507.
- Removed cost of SnazzySuits suits.

### 1.7.5

- Added LethalFashion for automatic unlocking of base game suits.

### 1.7.4

- Added suits: Reptilian Suit, Dead Space Isaac Clarke Engineering Suit, and SnazzySuits.
- Added cosmetics: RandomCosmetics, Pups Cute Cosmetics & TooManyHats.
- Added KickWithoutBan.

### 1.7.3

- Moved AsyncLoggers to SafeCompanyUnionFixes.

### 1.7.2

- Replaced ShipWindows with the new fork by TestAccount666.

### 1.7.1

- Migrated vanilla gameplay fixes to a separate modpack.

### 1.7.0

- Added TestAccountFixes.
- Added NestFix.
- Added InsanityDisplay.
- Added NiceChat.
- Added BetterBreakerBox.

### 1.6.1

- Added WesleysInteriorsAddon.

### 1.6.0

- Added ButteryFixes.
- Added MeleeFixes.
- Added JetpackFixes.
- Added EnemySoundFixes.

### 1.5.1

- Lowered Football spawn rarity for S, S+ and SSS risk moons.
- Enabled SirenHead spawning on Infernis.

### 1.5.0

- Added Loadstone.
- Added WeatherTweaks.
- Added LethalRichPresence.
- Added LooseJesterSpring.
- Added RevisitStingers.
- Added SpiderWebFix.
- Added ShockwaveDroneEnemy.

### 1.4.3

- Enabled FacelessStalker page spawning on modded moons.
- Lowered Football spawn rarity for S+ and SSS risk moons.
- Adjusted SirenHead spawn rarity and enabled spawning on appropriate modded moons.

### 1.4.2

- Lowered ImmortalSnail spawn chance again.
- Enabled Mirage voice recording whilst dead.
- Regernated Faceless Stalker config.
- Added ImmersiveScrap.

### 1.4.1

- Added suits from AdditionalSuits & Fashion Company.

### 1.4.0

- Lowered ImmortalSnail spawn chance.
- Renamed and removed some included suits.
- Added TooManySuits for better suit management in future.
- Added SCP Foundation Suit.
- Added 1000 Quota Stare Suit.

### 1.3.12

- Replaced FloodedLevelsFixed with LethalFixes.

### 1.3.11

- Added BepInEx Faster Load AssetBundles Patcher.
- Added Wesleys Interiors.

### 1.3.8

- Reinstated TerminalFormatter.
- Added TerminalDisplaySync.

### 1.3.7

- Added TerminalConflictFix to address issues that could arise.

### 1.3.6

- Reinstated Wesleys Moons due to their quality and variety.

### 1.3.5

- ~~Removed Wesleys Moons due to size.~~

### 1.3.4

- Added Wesleys Moons.

### 1.3.3

- Replaced More_Emotes with BetterEmotes for better VR support.
- Removed Symbiosis due to log spam.
- Tidied dependency list.

### 1.3.2

- Added FeedFish.

### 1.3.1

- Replaced WeatherMultipliers with MeteoMultiplier.

### 1.3.0

- ~~Removed TerminalFormatter dependency due to potential difficulties viewing moons.~~
- Reverted LLL dependency to v1.2.1 due to company moon routing bug.
- Moons: Added Ganimedes and StarlancerMoons.
- Interiors: Added LC_Office, PoolRooms, and StarlancerWarehouse.

### 1.2.16

- Added VileVendingMachine.

### 1.2.15

- Added Lethal Doors Fixed.

### 1.2.14

- Disabled Stench of Death from Symbiosis.

### 1.2.13

- Added SnatchinBracken and MolesterLootBug.

### 1.2.12

- Removed Herobrine config so it won't overwrite specified names when the pack is updated.

### 1.2.11

- Added TerminalFormatter to mitigate not being able to route to the company building.

### 1.2.10

- Added AlwaysHearActiveWalkies to further improve walkie-talkie usabilty.

### 1.2.9

- Added Black Mesa Half Life Moon & Interior.
- Disabled Rebelious Coilheads in Emergency Dice.

### 1.2.8

- Updated FacelessStalker config.

### 1.2.7

- Added LobbyCompatibility to help with troubleshooting mods no longer in the pack.
- Added ReservedWalkieSlot to promote their use.

### 1.2.6

- Removed ItemClippingFix in favour of adding Matty Fixes.
- Added Celestial Tint.
- Added LethalLevelLoader (no custom moons/interiors added yet).
- Updated dependencies.
- Inverted changelog order.

### 1.2.5

- Changed Emergency Dice config to disable locking ship doors, invisible mines, and exploding a random player.
- Added Symbiosis.
- Added Monster Plushies.

### 1.2.4

- Added EnhancedRadarBooster.

### 1.2.3

- Removed LC-API dependency.

### 1.2.2

- Added performance improvements via AsyncLoggers.
- Added ItemClippingFix.
- ~~Removed Herobrine.~~

### 1.2.1

- Updated dependencies.
- Reduced chances of blue and red gnomes spawning.
- Reduced chance of gnome scrap spawning.

### 1.2.0

- Added Terminal Clock.
- Added ShipWindows.
- Added Emergency Dice.
- Added custom MoreSuits suits.

### 1.1.8

- Added Scopophobia.

### 1.1.7

- Added FacelessStalker.
- Decreased page spawn chance.

### 1.1.6

- Updated dependencies.

### 1.1.5

- Updated dependencies.
- Removed Piggys Variety Mod due to incompatibility with More Emotes.
- Disabled Lockers from spawning on Adamance.

### 1.1.4

- Updated dependency list.
- Lowered spawn rate of red gnomes.

### 1.1.3

- Configured SirenHeads to spawn on Adamance.
- Added more cosmetics via PigeonsCosmeticsAddon.

### 1.1.2

- Properly configured FairAI.

### 1.1.1

- Added Piggys Variety Mod, which adds Tesla Gates

### 1.1.0

- Balance changes via WeatherMultipliers, FairAI, and FairGiants
- Added CullFactory for optimisation.

### 1.0.4

- Updated Football, LethalCasino.

### 1.0.3

- Added Football.

### 1.0.2

- Updated icon.

### 1.0.1

- Fixed title.

### 1.0.0

- Migrated existing modpack.
</details>
