# Changelog

**<details><summary>Version 2.9.3</summary>**

* Fixed a tiny but **critical** issue. (_Nyoooooooooom!_)
  * **NOTE:** `CircusFacility` is still not working...

</details>

**<details><summary>Version 2.9.2</summary>**

* Fixed a couple tiny issues.
  * **NOTE:** `CircusFacility` is still not working...

</details>

**<details><summary>Version 2.9.1</summary>**

* Recompiled for `v80`!
  * **NOTE:** `CircusFacility` is currently not working, it has not been rebuilt just yet...

</details>

**<details><summary>Version 2.9.0</summary>**

* Snow and ice have melted, leaves began growing once more, and jolly decorations have been taken down. Jolly season around the circus has promptly come to an end!
  * _Christmas was just a week ago, right...?_
* Pulling the Apparatus now causes a few minor things to happen around the place.
* Improved balloons in various ways:
  * Entering the facility now completely disables balloons (both from rendering and physics calculations).
  * Balloon strings are now frozen when not observed (position updates for their start and end points are paused).
  * Dropship balloons are now hidden when idle (up in the sky), and are no longer blocked by a `Collider` above the dropship.
  * Shooting balloons with a `Shotgun` now works a bit more reliably.
  * Slightly lowered translucency of balloons.
* Made a few visual adjustments:
  * Changed lighting and sky to be a bit more like `v1.0.1` Bozoros.
  * Lowered compression settings for the skybox to reduce some artifacting.
  * Increased tile size on the cobblestone path terrain layer.
* Tweaked some weather compatibility stuff:
  * Readded `Snowfall`/`Blizzard` compat stuff (from [LethalElements](https://thunderstore.io/c/lethal-company/p/pacoito/LethalElementsTheta)), for it is no longer snowy by default.
  * Increased number of `Puffers` during `Toxic Smog` (also from [LethalElements](https://thunderstore.io/c/lethal-company/p/pacoito/LethalElementsTheta)).
  * Made [Black Fog](https://thunderstore.io/c/lethal-company/p/DemonMae/Black_Fog_Weather) weather a bit more dangerous when in effect, if certain [ememies](https://thunderstore.io/c/lethal-company/p/Magic_Wesley/Wesleys_Ememy_Variants) are present.
  * Added basic compatibility for a few additional weathers, though mostly just having announcements and the fireworks show play during them.
* Added two new dice effects for [Emergency Dice](https://thunderstore.io/c/lethal-company/p/slayer6409/Emergency_Dice_Updated)!
  * One may or may not be a bit _fishy_ 🐟, the other requires [PlayZone](https://thunderstore.io/c/lethal-company/p/LethalMatt/PlayZone) being installed.
  * Also made the `Santa is here!` dice effect a bit more festive by spawning a few presents from Santa himself.
* Set every `AudioReverbTrigger` around the ship to only activate upon entering them.
* Made Ferris wheel sync up a lot better between host and clients.
* Did some minor refactoring to the project plugin.
* Did an assortment of various other tiny tweaks.
* Updated for the latest [itolib](https://thunderstore.io/c/lethal-company/p/pacoito/itolib) version.

---

* `CircusFacility` changes:
  * Adjusted `Tile` tags and `Doorway` entrance/exits to make it less likely to fail to generate at smaller dungeon size multipliers.
    * Generation is a bit different than before, as a result.
  * Removed LOD fade effect from the stair tile, which was a bit jarring at times.
  * Removed `OutOfBoundsAdjuster` in favor of LethalLevelLoader's `IsDynamicOutOfBoundsTriggerEnabled` setting.

</details>

**<details><summary>Version 2.8.0</summary>**

* **Happy Holidays!** Snowy season has ~~(finally)~~ begun around the circus!
  * _Spooky season stuck around for a bit longer than intended..._
* Brought back last year's snowy theme, updated and remastered!
  * Reworked a lot of systems internally using new _Technology™_, but everything should feel pretty much the same as how you may remember it.
  * If you weren't around for last year's snowy theme, you may read the list of changes from Bozoros `v2.2.0` if you'd like to know what to expect!
* Various other small, miscellaneous adjustments.
* Updated for the latest [itolib](https://thunderstore.io/c/lethal-company/p/pacoito/itolib) version.

</details>

**<details><summary>Version 2.7.0</summary>**

* **Happy Halloween!** Spooky season has ~~(finally)~~ begun around the circus!
  * _It'll be here for a bit until snowy season shows up..._
* There have been reports of mysterious **gravestones** appearing around the place, displaying some strange engravings and unnerving visitors.
  * _We have no idea who's responsible for digging these holes OR what they've buried in them..._
* Popcorn stands around the place now offer something a bit more **sweet**.
* Littering around the circus has been rampant as of late, we would greatly appreciate if visitors lend a helping **hand** to our cleaning crew.
* There was recently a shipment of **TZP-Inhalant** that fell into the lake after crashing into a tree, which appears to have affected the water's coloring.
  * _We would greatly advise against going for a swim at this time..._
* Balloons are reportedly a bit more **animated** than usual.
* Fixed `Up! Up! Up! Banana!` [Emergency Dice](https://thunderstore.io/c/lethal-company/p/slayer6409/Emergency_Dice_Updated) roll not being properly networked.
  * Now it also spawns banana peels for more than just the player who rolled it.
* Tent music is now muted at the start of the firework show.
* Adjusted dropship item landing locations.
* Several more small, miscellaneous adjustments.
* Updated for the latest [itolib](https://thunderstore.io/c/lethal-company/p/pacoito/itolib) version.

---

* `CircusFacility` changes:
  * Adjusted collider sizes to make it easier to pick up small items that fall on top of a seat.
  * Adjusted collider sizes for the round table placeable surface, so any placed small items can actually be retrieved from it.
  * Tweaked player positions for all interactable seats.

---

* **NOTE:** Update is admittedly a bit smaller in scope than I ([pacoito](https://thunderstore.io/c/lethal-company/p/pacoito)) would've liked, and I'm not that great at the art side of things, but I hope this'll suffice. There's also a couple ideas I wasn't able to implement in time, but I do plan on adding them in the coming weeks!

</details>

**<details><summary>Version 2.6.1</summary>**

* Recompiled for LC `v73`.

</details>

**<details><summary>Version 2.6.0</summary>**

* The circus has been unusually **Foggy** lately, which unfortunately means the fireworks show may need to be postponed during times of heavy fog. We're very sorry for the inconvenience!
  * _Added [BarberFixes](https://thunderstore.io/c/lethal-company/p/ButteryStancakes/BarberFixes) as a dependency for no particular reason..._
* Our cannon technician appears to have forgotten their ladder after concluding with routine cannon maintenance. We would like to remind everyone that the human cannonball stunt in our performance shows is carried out by trained professionals.
  * > _We will not be held responsible for any injuries that may arise from unauthorized access into the cannon._
* Added 4 guaranteed `Goofy Puffer` spawns at the start of each round.
  * Similar to older versions of Bozoros, but with randomized spawn locations!
  * Removed Spore Lizards from the daytime enemy spawns, now that their spawning is handled through other means (and can go above the vanilla cap of 2).
  * Has a config setting to disable the spawners, if intending to tweak spawns through other means.
* Improved a few things visually:
  * Dialed back most texture compression settings a bit, though while still maintaining reasonable sizes.
  * Tweaked material properties for most props (e.g. making them a bit more metallic, or fixing a couple misconfigured normal maps).
  * Enabled shadows for the lamp light sources, and added a sound effect for when they are toggled.
  * Removed all instances of tent support beams clipping into other tents.
  * Restored water fountains during the fireworks show!
  * Made benches able to be sat upon!
* Reworked various systems internally:
  * Changed how banana peels are injected into levels and interiors.
    * Should hopefully address some cases where the banana peel multiplier config settings weren't being applied.
  * Simplified balloon path selection a bit.
  * Changed Popcorn hives to be manually spawned, instead of using natural moon spawns and teleporting them.
    * Removed Circuit Bees from the daytime enemy spawns, and lowered the daytime enemy power level to account for the missing bee spawns.
    * Also tweaked other daytime enemy weights.
* Improved NavMesh around all the various map props and circus tents.
* Replaced moving `NavMeshLinks` in the Ferris wheel with `OffMeshLinks`.
  * The moving `NavMeshLinks` were causing enemies to have pathing issues (stutter-step) due to the NavMesh being constantly updated as it rotated.
  * Big thanks to [Zaggy1024](https://github.com/Zaggy1024) for looking in-depth into the pathing-related crashes/issues and addressing them in [PathfindingLib](https://thunderstore.io/c/lethal-company/p/Zaggy1024/PathfindingLib)!
* Various general optimizations:
  * Disabled `Read/Write` flag for all assets that didn't need it (which was nearly all of them).
  * Tent music now only plays when in close proximity to it, instead of all the time.
    * Also did this for the Mysterious Shard ambient sound effect.
  * Optimized firework particles a bit.
    * Mainly just enabled culling for them, and reduced emissions a fair bit for the burst sparkles to bring total amount of particles down.
  * Enabled static flag for almost all props to make them eligible for occlusion culling.
* Added support for [Blue](https://thunderstore.io/c/lethal-company/p/Generic_GMD/Blue) weathers, and made a couple things become more blue during them.
* Added support for [Black Fog](https://thunderstore.io/c/lethal-company/p/DemonMae/Black_Fog_Weather) weather, the fireworks show should start as normal after the fog goes away!
  * <details><summary><b>(Spoiler):</b></summary>
      <i>There may also be special guests, should you happen to have <a href="https://thunderstore.io/c/lethal-company/p/Magic_Wesley/WesleysInteriors">Wesley's Interiors</a> installed...</i>
    </details>
* Fixed `WesleyIntegration` erroring out when enabled without having the full [Wesley's Moons](https://thunderstore.io/c/lethal-company/p/Magic_Wesley/Wesleys_Moons) bundle.
  * Also made the enhanced potassium for [Alcatras](https://thunderstore.io/c/lethal-company/p/Magic_Wesley/Alcatras) not require the `WesleyIntegration` setting to be enabled.

---

* `CircusFacility` changes:
  * Added interactability to several tile props:
    * Couches, chairs, and stools can now be sat upon!
    * Scrap can now be placed on top of the round tables.
  * Added interactability to the `Bozo-Apparatus`:
    * `[Q]` can now be pressed to toggle its ambient sound effect while plugged-in.
    * `[LMB]` can now be pressed to play its sound effect when being unplugged.
  * Went through every tile and restructured/organized their hierarchies:
    * Replaced all tile props with prefab and prefab variants.
    * Improved NavMesh for all tiles and their props.
    * Fixed a few `OffMeshLinks` that were not actually doing anything.
    * Disabled `Read/Write` flag for all meshes that don't need to generate NavMesh.
    * Optimized a couple lights that had default fade distances.
  * Did several generation changes:
    * Set certain `Doorways` as entrances and exits to tweak overall dungeon shape a bit.
    * Modified generation to now begin and end with either the `DoubleDoorRoom` or `SmallRoomLounge` tiles.
    * Changed all large rooms to be injected instead of either spawning at set points (nodes), or as branch caps.
    * Enabled immediate repeats for a few hallway tiles.
    * Made `TwistedHallway` tile slightly more rare.

</details>

**<details><summary>Version 2.5.5</summary>**

* Added some basic (**opt-in**) compatibility with [Wesley's Moons](https://thunderstore.io/c/lethal-company/p/Magic_Wesley/Wesleys_Moons)' progression mode!
  * <details><summary><b>Details (spoiler):</b></summary>
    <ul>
      <li>Locks immediately routing to Bozoros, and adds a pretty <b>cursed</b> way to unlock it.</li>
        <ul><li><i>A proper Bozo videotape is still planned...</i></li></ul>
      <li>Adds a select few videotapes to Bozoros' scrap spawn pool.</li>
      <li>Adds several goofy items to Bozoros' scrap spawn pool.</li>
      <li>Enhances potassium levels when using <a href="https://thunderstore.io/c/lethal-company/p/Magic_Wesley">Alcatras</a>' <code>Banana launcher mode</code>.</li>
    </ul>
    </details>
* Fixed weather effects not applying when **not** using [WeatherRegistry](https://thunderstore.io/c/lethal-company/p/mrov/WeatherRegistry).

</details>

**<details><summary>Version 2.5.4</summary>**

* Finally got around to making a `v70` contour map for the ship radar!
* Adjusted import configuration for `AudioClips`, should be a bit more optimized.
* Added object pooling for the Tulip Snake confetti particle effects.
* Fixed Stormy weather clouds not showing up.
  * Not sure when or why they were disabled...
* Fixed `Santa Butler` skin not actually applying...
* Added a few custom Bozoros-themed effects for [Emergency Dice](https://thunderstore.io/c/lethal-company/p/slayer6409/Emergency_Dice_Updated)!
* Updated for the latest [itolib](https://thunderstore.io/c/lethal-company/p/pacoito/itolib) version.

---

* `CircusFacility` changes:
  * Added default weights for Hyx and Cosmocos.

</details>

**<details><summary>Version 2.5.3</summary>**

* Fixed extremely loud ambience sound effect due to a corrupted file.
  * Not sure how this happened, sorry about that!

</details>

**<details><summary>Version 2.5.2</summary>**

* Fixed accidental bouncy castle space program; it was not meant to be used for space expeditions.
  * _Comically bouncy castle may return soon, however..._
* Did a bit of refactoring to the project plugin.
* Updated [itolib](https://thunderstore.io/c/lethal-company/p/pacoito/itolib) version.
  * Includes a couple small performance tweaks for Bozo features!

</details>

**<details><summary>Version 2.5.1</summary>**

* Updated [itolib](https://thunderstore.io/c/lethal-company/p/pacoito/itolib) version.

</details>

**<details><summary>Version 2.5.0</summary>**

* Migrated (almost) all scripted stuff to my own library, [itolib](https://thunderstore.io/c/lethal-company/p/pacoito/itolib)!
  * A lot of scripts have received some tweaking and/or refactoring in the back end, but it should all be functionally the same.
* Recompiled and rebuilt project for `v70`.
  * **NOTE:** Contour map for Bozoros has not yet been made, but is planned.
* A **bouncy castle** has magically appeared out of nowhere...
* Small bug fixes/adjustments:
  * Fixed `BananaMultiplierInside` setting not actually applying when any interior that wasn't `CircusFacility` generated in Bozoros.
  * Fixed `Santa Butlers` neither wielding nor dropping their signature `Candy cane` weapon,
  * Lowered a bunch of lights' fade distances, which were previously set to the default value of `10000`.
  * Tweaked NavMesh stuff around the Ferris wheel.
* Changes to spawn weights:
  * Added `v70`'s new creature to the daytime enemy spawning pool.
  * Toned down `Turret` spawn curve a bit.

</details>

**<details><summary>Version 2.4.1</summary>**

* Fixed a couple weird things.

</details>

**<details><summary>Version 2.4.0</summary>**

* .srehtaew elbaliava fo tsil eht ot `sreffuP yfooG` deddA
* .gniliec eht no `elbillug` etorW
* .`enirboreH` devomeR

</details>

**<details><summary>Version 2.3.8</summary>**

* Fixed _different_ error message showing up during startup.
  * This one did not actually cause anything, and was just there due to me messing with `ExtendedMod` merge settings.
* Fixed Ferris wheel varying speeds for certain weathers not applying.
  * Also improved its position syncing across clients (again).

---

* `CircusFacility` changes:
  * Fixed Twisted Hallway wall texture not scrolling.
    * I forgot to switch it back after I finished adjusting some stuff in it...

</details>

**<details><summary>Version 2.3.7</summary>**

* Fixed error during startup caused by calling something too early to initialize one of the special moon compatibilities.

</details>

**<details><summary>Version 2.3.6</summary>**

* Fixed rare(?) error whenever the `CircusFacility` AssetBundle happened to load before Bozoros' `ExtendedMod` AssetBundle, breaking a lot of stuff.
  * Banana peels would not be able to spawn, and landing on Bozoros would straight up crash the game.
  * I didn't hear this issue be reported until encountering it myself, sorry if it affected anyone!
* Fixed banana peels not actually spawning in other interiors, with the `BananaMultiplierInside` setting set to its default value of `1`.
* Improved Ferris wheel position syncing across all clients, though it might still be slightly off.
* Adjusted NavMesh inside the Ferris wheel, but enemies pathing inside is still a bit jank.
* Added networking to the sound of a player getting _conked_ by the Ferris wheel, it will now be heard by nearby players as well.
* Made the Ferris wheel spin a little bit faster during `Stormy` weather.

---

* `CircusFacility` changes:
  * Adjusted some steam valve spawn locations.
  * Added configuration settings to toggle special moon compatibilities for specific moons.
  * Reduced size even more by switching to blank references for some prefabs I did not realize LethalLevelLoader replaced.

---

* **PS:** Massive thanks for 1 million downloads! The milestone was surpassed a while back actually, and while this isn't the planned larger (very late) celebratory update, there was a pretty critical issue that needed addressing first.

</details>

**<details><summary>Version 2.3.5</summary>**

* Added option for banana peels to only drop the player's held item (and made it default), as a middle ground between being fun and being mildly annoying.
* Fixed locked Ferris wheel window tooltips not being thematic.
* Fixed balloons not being rideable when playing with a controller... probably...
  * Can't actually test if it works as for some reason the game won't detect my controller, but I changed the grab requirement to holding the `Jump` action.
* Fixed icy lake not showing up during `Snowfall` in the newest [LethalElements](https://thunderstore.io/c/lethal-company/p/v0xx/LethalElementsBeta) versions (again).

---

* `CircusFacility` changes:
  * Added `Pandoramus` and `StarlancerZero` to the default moon spawn weights for _no particular reason..._

</details>

**<details><summary>Version 2.3.4</summary>**

* Slipping on a banana peel now causes players to drop their items!
  * Can be toggled off via the `BananaDropsItems` setting.
  * Also lowered indoor potassium level curve a bit due to this.
* Made banana peels able to spawn on other interiors that generate on Bozoros.
* Fixed players slipping on a banana peel into a pit not counting as having 'landed', causing them to remain rotated at a 60° angle when respawning (backslash pose).
  * I couldn't fully reproduce this issue during testing for some reason, the player's rotation seemed to always correct itself a few seconds after respawning, but it should be fixed in any case.
* Increased audible distance for the banana peel's `AudioSource`.
* Added the client-sided `ReduceMotionSickness` setting.
  * Currently only toggles the player's camera turning when crossing the Twisted Hallway, but will likely affect more stuff in the future!
* Fixed the `Bozo-Apparatus` not waking up dormant Old Birds.
* Fixed a specific tent's LOD causing it to change its texture upon getting closer.
* Stormy effects (cloudy sky and loose balloons) should now appear during [CodeRebirth](https://thunderstore.io/c/lethal-company/p/XuXiaolan/CodeRebirth)'s `Tornado` weather (it was still set as `Windy`).
* Added some compatibility for [CrowdControl](https://thunderstore.io/c/lethal-company/p/CrowdControl/CrowdControl_LethalCompany)'s weather switching to allow it to properly toggle special weather effects (e.g. tent fires and confetti particles during `Eclipsed`).
  * A bit jank but _should_ be fine for the most part.

---

* `CircusFacility` changes:
  * Fixed `BananaMultiplierInside` setting only applying when landing on Bozoros specifically.
  * Adjusted the [CircusMimic](https://thunderstore.io/c/lethal-company/p/x753/Mimics) prefab to fix a couple small inconsistencies it had with the real fire exits.

</details>

**<details><summary>Version 2.3.3</summary>**

* Fireworks show is no longer enabled by default, causing it to play regardless of weather (whoops).
* Added LODs to the banana peels, and enabled culling for them.

---

* `CircusFacility` changes:
  * Renamed secure doors to make them compatible with [Piggy's Variety Mod](https://thunderstore.io/c/lethal-company/p/Piggy/Piggys_Variety_Mod)'s Tesla Gates.

</details>

**<details><summary>Version 2.3.2</summary>**

* Added a **banana peel** hazard!
  * Spawns both outside and inside (only in `CircusFacility` at the moment), with a bit of spawn configurability for each.
  * _Comedic relief included!_
* Various performance fixes/optimizations:
  * Removed unnecessary `AudioReverbTriggers` near entrances.
    * Players standing near entrances when **not** using [LethalPerformance](https://thunderstore.io/c/lethal-company/p/DiFFoZ/LethalPerformance) (which you _should_ be using!) will no longer cause major lag spikes. This includes the fire exit in the Ferris wheel, too.
    * Thanks for the help with this, [Zaggy1024](https://github.com/Zaggy1024)!
  * Made the remaining `AudioReverbTriggers` only trigger twice every second, instead of once every frame.
    * Not sure if this could actually cause any issues, but it seemed fine during testing...
  * Enabled animation culling for the Ferris wheel.
  * Enabled static batching for a couple map objects.
  * Added LODs to the rotating parts of the Ferris wheel.
  * Switched all `MeshColliders` to use their highest level LOD instead of their base mesh.
* Fixed compatibility with [WeatherRegistry](https://thunderstore.io/c/lethal-company/p/mrov/WeatherRegistry) `v0.4.0` and above.
  * **NOTE:** Older versions will not work properly with this release.
* Fixed compatibility with [WeatherTweaks](https://thunderstore.io/c/lethal-company/p/mrov/WeatherTweaks)' combined and progressing weathers... ~~probably~~.
  * Combined and progressing weathers are handled dynamically, so there might be some goofy combined effects (e.g. `Eclipsed + Rainy` having tents on fire while it's raining), or possible leftover effects when it switches to another weather.
  * **NOTE:** Not _all_ possible weather combinations were fully tested, but the only real issue I encountered was during `None > Blackout` (from [MrovWeathers](https://thunderstore.io/c/lethal-company/p/mrov/MrovWeathers)), where riding the Ferris wheel or crossing the Twisted Hallway during the switch to `Blackout` causes your player to be **deactivated**. Stay clear of those areas at `6:00 PM`!
* Fixed special `Snowfall` and `Blizzard` weathers compatibility with the newest [LethalElements](https://thunderstore.io/c/lethal-company/p/v0xx/LethalElementsBeta) versions.
  * Grass is once again properly replaced with snow, and the icy lake is back to being _precarious_ during `Snowfall`!
  * Made snow color blend in better, too.
* Made `Toxic Smog` weather a purple color instead of green, specifically matching Spore Lizards' spore cloud color.
  * The lake is also poisonous!
* Made time-based events a bit more robust, so any mods that skip ahead in the day or change weather in the middle of the round (that aren't [WeatherTweaks](https://thunderstore.io/c/lethal-company/p/mrov/WeatherTweaks)) won't trigger the fireworks show immediately anymore.
* Made slight adjustments to the cannon's `12:00 PM` firing event.

---

* `CircusFacility` changes:
  * Moved a couple scrap spawn locations slightly.
  * Reduced radius of a specific Hazard spawn point that could result in a Turret spawning inside a fire exit door.
  * Adjusted depth weight for props in rooms set to spawn at specific depths.
  * Fixes for the `Bozo-Apparatus`:
    * Fixed clients pulling the apparatus not 'counting', which caused its plugged-in audio to continue playing, and prevented the alert from showing up (though lights still went out).
    * Fixed the `Bozo-Apparatus` playing its plugged-in audio in the ship when reloading the lobby.
    * Fixed the `Bozo-Apparatus` not being able to spawn in the double door room at all.
      * Due to switching dungeon generation to start at that specific room, its path depth can only ever be `0`, so it could never spawn it with the previous curve.

</details>

**<details><summary>Version 2.3.1</summary>**

* Added compatibility for [LethalLevelLoader](https://thunderstore.io/c/lethal-company/p/IAmBatby/LethalLevelLoader) `v1.4.0`.
  * Moon assets should now be dynamically loaded!

---

* `CircusFacility` changes:
  * Adjusted tile bounds for every single tile, as an attempt to fix the blocked Main entrance some were having.
    * **NOTE:** I have extensively tested generating the interior, both on this version and the previous one, and couldn't get a blocked Main entrance to generate once, so I can't actually verify if it's fixed or not...

</details>

**<details><summary>Version 2.3.0</summary>**

* Snow has melted, the lake has begun to thaw, festive decorations have been taken down, and all Nutcracker statues have found their home... Thank you for visiting Bozoros this festive season, we hope you enjoyed the show!
  * **NOTE:** A few aspects of the winter theme still remain during [LethalElements](https://thunderstore.io/c/lethal-company/p/v0xx/LethalElementsBeta)' `Snowfall` and `Blizzard` weathers!
* After a long period of downtime due to maintenance, the **Ferris Wheel** is once again open to the public!
  * Feel free to hop on and catch a ride, entrance is free as long as you're here!
  * > _We will not be held responsible for any injuries that may arise from unsafe guardrails, or unclear danger zones near the attraction._
* Due to fire safety concerns, a fourth **Fire Exit** has been installed to help evacuate visitors in case of emergencies.
  * _Wait, they put it WHERE...?_
* Added decorative balloons back to the dropship, and tweaked its overall appearance to be a bit more thematic.
  * Also added an optional scan node to it with some flavor text!
* Removed `Rainy` weather and readded `Stormy` as a possible weather.
* Greatly lowered confetti particle effect intensity during `Eclipsed` weather.
  * Should still look pretty similar, but with substantially fewer particles!
* Water is now extra green during [LethalElements](https://thunderstore.io/c/lethal-company/p/v0xx/LethalElementsBeta)' `Toxic Smog` weather.
  * _Who poisoned the water supply?_
* Lowered volume and range of grabbable balloons' `AudioSources` a bit.
* Made `Santa Butlers` only spawn on moons with the `Jolly` tag by default, but also removed the moon's `Jolly` tag.
  * The skin will still be available for any moons that may want to have `Santa Butlers` visit them!
  * **NOTE:** You will most likely still see them around in Bozoros since they previously also had the `Fun` tag by default, so you'll have to update their configuration manually, or regenerate your `EnemySkinRegistry` config.
* Fixed `Popcorn` ~~hive~~ value being a lot lower than intended.
* Fixed floating Santa hats manifesting next to the ship whenever a [RossButler](https://thunderstore.io/c/lethal-company/p/XuXiaolan/RossButler) would spawn.
* Fixed [CircusMimics](https://thunderstore.io/c/lethal-company/p/x753/Mimics) showing up in other moons after landing, reloading the lobby, and routing to a different moon.
* Changes to spawn weights:
  * Removed Butlers from the outside spawning pool.
  * Slightly increased outside spawning weight for Barbers.
  * Slightly increased outside spawning weight for Circuit Bees.

---

* `CircusFacility` changes:
  * Made branch paths 1-2 tiles longer.
  * Made the `Twisted Hallway` more rare, and no longer able to generate in branch paths.
  * Modified generation to inject the entrance tile right in the middle of the dungeon instead of starting from it, to create the illusion of more than one main path generating!
  * Tweaked archetype lengths a bit, and did other miscellaneous adjustments to room generation.
  * Made further attempts to reduce chances of multiple fire exits spawning in the same room, or close to the other entrances.
  * Turned puddles into decals to blend in a bit better on certain non-flat surfaces.
  * Fixed breaker boxes being comically large... it was quite funny, but unintended.
  * Fixed the `Bozo-Apparatus` disappearing after reloading the lobby.

</details>

**<details><summary>Version 2.2.5</summary>**

* **Happy new year!**
  * I was planning on releasing this update a week ago (which is why there's a bunch of `Snozoros`-related fixes), but got distracted by a couple fun ideas...
  * If no further (critical) issues show up, this'll most likely be the last update before Christmas decorations are taken down.
    * _It'll be around for an extra week or so, festive season's still ongoing!_

---

* Turned asset replacements into proper items, registered via `LethalLevelLoader`.
  * `Candy canes` now persist on lobby reload, and can drop on other moons as well.
  * `Coal pieces` are no longer a `Plastic Cup` in disguise, which was arbitrarily chosen as the item to replace due to its scale.
* Made `Candy cane` blood particle effects a bit jollier.
* Made `Grinch Particles` appropriately green.
* Made Santa once again slightly more lenient in regards to whose name is put on the naughty list.
* Tent and Ferris wheel lights are now green during [LethalElements](https://thunderstore.io/c/lethal-company/p/v0xx/LethalElementsBeta)' `Toxic Smog` weather.
* `Popcorn` ~~hive~~ value now scales depending on its distance from the ship, similar to how it's _supposed_ to work in vanilla.
* Fixed hives not being correctly relocated on clients, which caused them to be a bit off from where they were supposed to be.
* Fixed Santa's gifts disappearing when going into orbit without dropping them on the ship at least once.
* Fixed Snowmen and Nutcracker statues spawning inside walls/tents (probably).
  * Adjusted their `width` property to spawn further away from NavMesh edges.
  * Removed NavMesh inside tents.
* Fixed balloons sometimes reappearing for a split second after popping.
* Fixed dropship flames not showing up once again.
* Changes to spawn weights:
  * Slightly raised inside spawning weight for Butlers.
  * Slightly lowered outside spawning weight for Circuit Bees.
  * Added Coil-heads to the inside spawning pool, with a pretty low weight.
  * Lowered weight for regular `Facility` interior a bit.

---

* `CircusFacility` changes:
  * Added a custom rainbow Apparatus to the interior.
    * _Bozo-ratus?_
  * Added a new, very ordinary hallway tile that has nothing weird going on in it.
  * Moved `Catwalk` surfaces into the `Room` layer, since they're replaced with a wooden floor and thus should be able to be spray painted.
  * Tweaked dungeon generation a fair bit:
    * Disabled repeats for almost all loot room tiles, so there's only one to find.
    * Made some larger tiles spawn very close to the middle, so most of their doorways have a path generated.
    * Made larger tiles no longer able to directly connect to other larger tiles.
    * Made the dungeon itself a tad larger, and increased branch length by `1`.
      * Let me know if the interior feels a bit too large now, trying out stuff here and feedback is appreciated!
    * Modified fire exit spawns a bit as an attempt to lower chances of several spawning very close to each other.
    * Tweaked spawn weights for some larger tiles to generate at the end of branch paths.
  * Reorganized the hierarchy of nearly every tile pretty drastically.
    * A lot of prop spawns (e.g. lights, shelves, wooden pallets, etc.) have been modified as a result.
    * There could also be a few things that might feel a bit _off_, but I've tried to keep everything pretty much the same.
  * Compressed some stuff a bit further.

</details>

**<details><summary>Version 2.2.4</summary>**

* Added vanilla `SnowmanSimpleAI` script to the custom Snowman prefabs that can spawn around the map. They can now turn and laugh!
  * _Why do they need to be on the `MoldSpore` layer...?_
* Fixed softlock caused by reloading the lobby while landed on Bozoros.
  * Added some (redundant) null checks for good measure, but they're really not necessary.
* There is no longer a `ReflectionProbe` during [WeatherTweaks](https://thunderstore.io/c/lethal-company/p/mrov/BetaWeatherTweaksBeta)' `Blackout` weather.
  * _Spooky!_
* Toned down brightness of the moon prefab's lighting.
* Switched to using `LethalLevelLoader`'s `LethalLevelLoaderNetworkManager` to register the balloon prefab on the network.
  * `LethalLib` should no longer be a required, undeclared dependency.

---

* `CircusFacility` changes:
  * Found a couple more vanilla assets to compress that I missed.
    * _AssetBundle size decreased even further!_
  * Removed wooden boards from the back side of door blockers.
    * They were poking through certain walls, and I'm pretty sure the player can't see them at all in the first place.

</details>

**<details><summary>Version 2.2.3</summary>**

* Added windy/blizzard ambiance sounds during `Rainy` weather.
* Tweaked outside ambiance to actually play the forest ambient noises that have been supposed to be playing this whole time.
  * I now understand `AudioReverbTriggers` ~5% more.
* Drastically reduced range of Mysterious Shard `AudioSource`, for it could previously be heard all the way from the main entrance.
* Made quicksand/mud actually look like snow, with a blue tint to differentiate it from walkable ground.
* Nerfed Santa's gifts a lot, for he could sometimes be _quite generous_.
  * Scrap spawn weights are now being taken into account (instead of just picking any item in the pool), and there's a maximum value each present can have.
  * Made Santa slightly less forgiving in regards to choosing whose name gets put on the naughty list.
  * Santa also found his (magic) broom.
* Fixed purchased balloons only spawning for the host.
  * I'd moved the balloon prefab to a subdirectory without updating the direct paths I was using to load them, so they were simply not being registered on the network and couldn't spawn for clients.
* Switched to using `LethalLevelLoader` to load certain assets, instead of having the additional `bozorosstuff` AssetBundle.
  * I am also no longer using direct paths to load assets...
* Made balloon stands easier to interact with.
* Added a notification for the local client when purchasing a balloon, with brief instructions on how to operate it.
  * Should only show up once per session, until closing and reopening the game.
  * Added the client-sided `BalloonInstructions` config setting to turn this notification off, if you're already balloon-certified.
    * I recommend leaving it on if exporting a profile to share with others though, since it might be useful for any new players that join.
* Painted terrain in a few places to make dirt blend a bit better with the snow.
* Bozoros' enemy skins are no longer enabled globally by default, and should actually only show up on moons with their respective tags.
  * Probably still need to remove them from the global list manually, I don't think it retroactively removes config entries if the default values change.
* Improved compatibility with [WeatherTweaks](https://thunderstore.io/c/lethal-company/p/mrov/BetaWeatherTweaksBeta) somewhat:
  * Tent and Ferris wheel lights now turn off during `Blackout` weather.
    * It's still pretty easy to see through the dark due to emissive materials.
  * Firework show is no longer canceled during `Cloudy` weather.
  * `Rainy > Eclipsed` weather is currently treated as `Rainy + Eclipsed` due to the weather switching not working.
    * Likewise, `Eclipsed > None` is simply `Eclipsed`.
* Fixed moon prefab showing up much closer to the ship when joining a lobby or loading a save file while orbiting Bozoros.
  * _Boooo!_
* Changes to spawn weights:
  * Lowered outside spawning weight for Butlers.
  * Reduced maximum spawn limit for Butlers.

---

* `CircusFacility` changes:
  * Added missing collider on door blockers.
    * Turrets could _very rarely_ target you through the wooden boards, through certain walls.
    * I _think_ [CodeRebirth](https://thunderstore.io/c/lethal-company/p/XuXiaolan/CodeRebirth)'s laser turrets also went through them, but I'm not 100% sure.
  * Made footstep sounds for surfaces actually sound how they're supposed to (mostly wood).
  * Did some repairs to the floor at the main entrance.
  * Lowered brightness of the chandelier at the main entrance.
  * _Fire Exits are hungry now?_

</details>

**<details><summary>Version 2.2.2</summary>**

* I've been informed having the terrain in the `Terrain` layer is not a requirement for snowy footsteps, and also causes some issues. It's now set back to the `Room` layer.
  * Thanks, [s1ckboy](https://thunderstore.io/c/lethal-company/p/s1ckboy)!

</details>

**<details><summary>Version 2.2.1</summary>**

* Reverted some "compatibility" (~~extreme jank~~) stuff for WeatherTweaks' combined and progressive weathers, which was breaking events altogether with WeatherRegistry installed...
  * There will be **weird stuff** happening if you land on Bozoros while on a combined or progressive weather at the moment.
  * Modded weathers work just fine with how I currently have them.
* Removed `Stormy` weather, for it didn't make much sense to have lightning without rain.
  * Moved `Stormy` weather particle effects to `Rainy`, which now has both the balloons and blizzard effects!
  * The fireworks show also no longer plays during `Rainy` weather.
* Changed terrain tag from `Grass` to `Snow` and moved it to the `Terrain` layer, so snowy footsteps actually show up.
  * Side effect: Hitting the ground with a shovel no longer makes a sound, but it's really not that important.
* Moved every `AudioSource` for the icy lake to the `Master` mixer group and reduced their range a bit.
  * Don't think this'll fix their sounds mysteriously being global... Not sure what's going on with that, as Spatial Blend is set to `1` for them all.
* Removed collision from the moon preview prefab while in orbit.
  * Forgot when exactly I added this, but I was testing some stuff and left it there...

</details>

**<details><summary>Version 2.2.0</summary>**

* Snowy season is here, just in time for the holidays!
  * _Be sure to stick around until late for an extra special, jolly firework show!_
* Snow has covered up all grass around the circus, you may even stumble across a wild Snowman!
  * _We don't know who's making them, but they keep showing up..._
* The firework show's water fountains will not be operational for the time being, as the lake has frozen over completely!
  * _We're not actually sure if it's fully frozen... Tread lightly!_
* Candy Canes and Nutcracker statues now adorn the circus.
  * The Candy Canes are purely decorative. _They may appear tasty but we strongly advice against licking them!_
  * The Nutcracker statues appear to have been purchased en masse from a factory by a nearby Toy Store, but they were sent to the wrong address. _You may see them from time to time while we're still transporting them to their rightful owners!_
* There have been reported sightings of a **red-clothed individual** acting suspicious around the circus and stealing Candy Canes.
  * _We've been unable to verify their identity as they keep evading security, but be on the lookout and stay safe!_

---

* The `CircusFacility` interior has returned!
  * There have been too many changes/adjustments/tweaks/fixes to list since the `v1.0.1` release, but it's kept the same essence!
  * Some things may be a bit off or different, as it was rebuilt from the ground up. Feedback is welcome in case there's anything to improve!
  * A few minor things (e.g. an additional Hazard spawn point here and there) were intentionally added.

---

* Switched to using pure `EnemySkinRegistry` as a dependency, no longer using `EnemySkinKit`.
  * `Clown Giants` and `Goofy Puffers` that spawn in other maps will now also have their custom names!
  * It's still a completely optional dependency, if enemy skins are not desired.
* Miscellaneous tweaks/fixes:
  * Balloons now properly despawn when leaving Bozoros.
  * The interior no longer becomes red during Eclipsed.
  * Added some more Vain Shroud spawning locations around the map.
  * Added "Jolly" tag to the moon.
* Changes to spawn weights:
  * Lowered inside spawning weight for Brackens.
  * Lowered outside spawning weight for Old Birds and Barbers.
  * Raised inside ~~and outside~~ spawning weight for Butlers.
  * Raised outside spawning weight for Circuit Bees.

</details>

**<details><summary>Version 2.1.2</summary>**

* Accidentally inverted the `StreamerFriendly` setting when I re-did some config stuff... Sorry about that.
* Readded the dropship's thruster flame, took it out while testing possible replacements and forgot about it.
* Beehives are no longer being classified as _Popcorn_ on other moons.

</details>

**<details><summary>Version 2.1.1</summary>**

* Actually included the updated Bozoros `.dll` file... I should've looked at the file dates.

</details>

**<details><summary>Version 2.1.0</summary>**

* Balloon stands are now open! Make sure to grab a balloon or two for you and your friends, they make for great gifts!
  * _Watch out for any strong winds, though they may lead you somewhere useful!_
* Management has heard frequent complaints from visitors regarding bee infestations. Rest assured, circus staff is now working hard to keep hives out of all general areas!
  * _Be sure to celebrate with some Popcorn!_
* Tweaked sky volume profile during Stormy and Eclipsed weather to stop using volumetric clouds and be substantially more haunting, respectively.
* Configuration file changes:
  * Made config settings for particle effects affect more than just the maximum number of particles.
    * Now the intensity multiplier also applies to both emission rate and burst amount for the root `ParticleSystem`, as well as any children it may have.
  * Fixed audio/volume settings not actually applying, which was also preventing `StreamerFriendly` mode from being turned off.
    * Also changed most default volume settings back to `1`, since they've been adjusted from within the map to be roughly the same volume.
  * Added a couple more configuration settings.
* General map changes:
  * Added missing collision to every part of the rollercoaster rail.
  * Put up a second ladder on the other side of the lake to get on top of the rollercoaster rail from that side.
    * Ladders are now also about 4 times faster to climb, to encourage their use a bit.
  * Moved a tent slightly forward to stop a support beam from piercing right through it.
  * Moved a support beam in front of one of the fire exits a bit to the right, to stop it from being in the middle of the road.
  * Opened up an additional narrow passage to get to one of the fire exits behind the ship.
  * Readded Goofy Puffers as Daytime enemies, and up to 8 can now spawn. _Yippee!_
* Miscellaneous map fixes:
  * Implemented an ethically dubious solution to Tulip Snakes throwing a bunch of `SetDestination()` errors after diving into the lake.
    * [LostEnemyFix](https://thunderstore.io/c/lethal-company/p/JacobG5/LostEnemyFix) by [JacobG55](https://github.com/JacobG55) is also highly recommended in case any other enemies are also causing this issue.
  * Made sure all `OutsideAINode` points are correctly placed on top of surfaces, and are not too close to any map prop.
    * Should hopefully fix most '`Failed to create agent because it is not close enough to the NavMesh`' warning spam, though some modded enemies might still just inherently cause it.
  * Adjusted an `AudioReverbTrigger` outside the ship's door to stop audio from becoming echoey while on the catwalk.
  * Fixed left side of the bench texture not fully matching how the other side looked.
  * Vanilla assets used in the map are also now being compressed to shave off a bit more from the AssetBundle size.
  * Rainbow lighting for the water fountains disabled for now.
    * The rainbow lights were causing my game to flash a black screen every so often while staring at the water fountains, not sure if that's only happening on my computer but I'm temporarily disabling it just in case.

</details>

**<details><summary>Version 2.0.3</summary>**

* Made further improvements to the NavMesh, mostly targeting compatibility with [2-sToRy sHiP](https://thunderstore.io/c/lethal-company/p/MelanieMelicious/MelanieMelicious_2_sToRy_ShIp__works_w_Wider_Ship_Mod) by [MelanieMelicious](https://thunderstore.io/c/lethal-company/p/MelanieMelicious).
  * Revoked enemies' unauthorized access into the ship (through the walls) when using the 2-story ship.
  * Changed object collection from a specified volume back to every object within the current hierarchy, **but** added massive `NavMeshModifierVolume` boundaries (set to `Not Walkable`) outside the expected play area to stop the NavMesh from generating there.
  * Voxel size further lowered to `1.17` voxels per Agent radius (previous value was `1.4`).
  * Tile size lowered to `27` world units, (previous value was `76.8`).
  * Despite the two changes above, loading times increased a bit with the `Regenerate Navmesh` setting enabled, but the end result is a lot better.
* Made the Cruiser actually collide with and take damage from map props by including them all in the `Room` layer.
  * Driving full speed into, say, a popcorn stand now has disastrous consequences. _Don't fall asleep at the wheel!_
  * This change apparently also made map props visible on the ship map, though the map screen is still pretty dark when the sun goes down.
* Adjusted some visuals and general lighting.
  * Lamps now turn on a bit earlier, at `2:00 PM`.
  * Increased lamp light range and intensity to `12` units and `9000` Lumen, respectively.
  * Increased popcorn stand light range and intensity to `1` unit and `1000` Lumen, respectively.
  * Disabled volumetric lighting from all light sources, which were giving the map's fog a weird tint.
  * Rebaked reflection probe using lighting at `12:00 PM` as its base, which affects all reflective surfaces (e.g. water surface and rollercoaster steel).
    * Still not sure how I feel about the new water, so it's subject to change based on feedback. Looks great during the `10:00` event, though!
* Raised Ferris Wheel very slightly and adjusted NavMesh areas within.
  * Medium and small-sized enemies can now properly path underneath it.
  * Players should have less trouble taking cover under the gondola in the center, though it might still be a bit janky.
* Improved NavMesh surrounding the lake a bit more.
* Fixed custom Goofy Puffer and Clown Giant names applying only for the host.
  * Names are selected locally, so having a matching list of names in the `ClownGiantNames` and `GoofyPufferNames` settings is needed to see the same names as other clients.
* Made circus ambiance no longer persist when leaving Bozoros.
  * Bozoros sound effects should no longer play when at the Company when it was the last moon routed to.
  * Might make this a config setting, since the Company having the same ambiance as the last moon routed to _is_ a vanilla thing.

</details>

**<details><summary>Version 2.0.2</summary>**

* Defined area underneath the ship as a NavMesh obstacle to avoid.
  * Small to medium-sized enemies should no longer be able to path under the ship for surprise attacks through the ground.
* Fixed an _extra sneaky_ misconfigured `AudioReverbTrigger` that was **not** throwing errors.
  * All of them should now match the pre-`v2.0.0` Bozoros configuration, hopefully all audio issues are fixed!
* Set announcer voicelines to deactivate immediately after finishing their audio, to avoid playing more than once.
  * For some reason this was happening on my personal modpack, but I couldn't find the mod responsible for it...
* Removed accidentally-duplicated clear weather `AnimationClip`.
  * I don't think it was actually causing any issues, but it's gone regardless.

</details>

**<details><summary>Version 2.0.1</summary>**

* Simplified NavMesh a lot and rebaked it once more.
  * There are no longer surfaces on top of the tents for enemies to stand on (they shouldn't have been able to get up there normally in the first place).
  * Changed object collection from all objects to only objects within a specified volume, which is within the expected play area instead of the entire terrain.
  * Voxel size lowered to `1.4` voxels per Agent radius (previous value was `3`).
  * Loading times should be drastically improved when using [2-sToRy sHiP](https://thunderstore.io/c/lethal-company/p/MelanieMelicious/MelanieMelicious_2_sToRy_ShIp__works_w_Wider_Ship_Mod) by [MelanieMelicious](https://thunderstore.io/c/lethal-company/p/MelanieMelicious) with the `Regenerate Navmesh` setting enabled.
  * So far I haven't noticed any issues with it, but if enemies start having difficulty pathing I can further tweak the NavMesh parameters.
* Fixed sneaky misconfigured `AudioReverbTrigger` that was throwing errors when the ship was leaving.
  * It was hiding in a separate location from the other `AudioReverbTrigger` instances near the ship.
  * I don't think it was actually causing any issues, but having no errors is typically good!
* Adjusted illumination of the Bozoros moon preview outside the ship when orbiting.
  * Not visible unless using a mod that adds windows to the ship, or allows players to open the ship door in space.
* Removed Key from the scrap spawn pool (`LethalLevelLoader` was removing it automatically, but this gets rid of the warning it was throwing).
  * Keys are still able to spawn.

</details>

**<details><summary>Version 2.0.0</summary>**

---

* **NOTE:** Removed `CircusFacility` interior for now, it'll likely be uploaded as a separate mod once it's fully updated.
* **NOTE #2:** [BozorosTweaks](https://thunderstore.io/c/lethal-company/p/pacoito/BozorosTweaks) by [me](https://github.com/pacoito123) is no longer needed and will be deprecated after this update. I'm not sure if it actually breaks anything, but it should be disabled to prevent any potential issues.

---

* Rebaked NavMesh and defined almost every environment object as an obstacle to path around.
* Scattered a considerable number of additional `OutsideAINode` points across the map (there were only **10** before, now there's **156**).
  * Allows enemies to both spawn in and pathfind to more areas.
  * Should solve most pathing-related issues enemies (especially modded ones) were having.
* Improved colliders for circus tents.
  * Circular tents now simply use the `MeshCollider` they've always had.
  * Rectangular tents no longer have a sky-high `BoxCollider` players could crash into when flying over the map.
* Smoothed edges around the lake and improved NavMesh around it a bit.
  * Enemies should no longer occasionally go for a swim when pathing around the lake.
* Added spot for the Cruiser to land on when dropped off by the dropship.
  * [CompanyCruiserFix](https://thunderstore.io/c/lethal-company/p/DiFFoZ/CompanyCruiserFix) by [DiFFoZ](https://github.com/DiFFoZ) is no longer needed for the Cruiser to arrive.
  * Made trees and speaker poles breakable when rammed into by the Cruiser.
  * _The Company Cruiser is now legal on Bozoros!_
* Clown Giants and Goofy Puffers (Bozo-Lizards) are now enemy skin variants, using [EnemySkinKit](https://thunderstore.io/c/lethal-company/p/AntlerShed/EnemySkinKit) by [AntlerShed](https://github.com/Yinigma).
  * By default, if they're the only skins installed, they have a `100%` chance of spawning on moons with either the `Fun` or the `Circus` tag.
  * They can be configured to show up on different moons, or be turned off entirely if so desired. This dependency is also completely optional.
  * Due to this change, Giants and Spore Lizards now spawn naturally, and their spawn rates can be adjusted through LethalLevelLoader configuration or other mods.
  * Clown Giants are now also properly killable and their AI no longer breaks, since the enemy skin simply modifies the vanilla Forest Giant.
* Miscellaneous map changes:
  * Added a couple more firework spawning locations for the `10:00 PM` event.
    * _Truly dazzling!_
  * Added ambient music to the fire exit near the Ferris wheel.
  * Added a couple colliders to the food truck, near the bell.
  * Patched two holes players could walk through to get to the outer parts of the map.
  * Increased tree LOD distance to make texture swaps less noticeable when approaching trees.
  * Modified ship scan node to be slightly more accurate.
* Optimization changes:
  * Increased total size of occlusion area to help with performance.
  * Enabled compression for all textures and meshes to reduce AssetBundle size by around `55 MB`.
* Updated configuration file:
  * Relocated configuration file to `LethalMatt.Bozoros.cfg`, settings will need to be reconfigured.
  * Changed `StreamerFriendly` setting to be enabled by default.
  * Added `GoofyPufferNames` setting, a comma-separated list of names that are randomly selected for Goofy Puffers that spawn on Bozoros.
  * Added `ClownGiantNames` setting, a comma-separated list of names that are randomly selected for Clown Giants that spawn on Bozoros.
* Updated general map properties:
  * Added number `823` to moon name to match vanilla naming standards (also for compatibility with [Archipelago](https://thunderstore.io/c/lethal-company/p/APLC/APLC)).
    * _May_ have to update custom enemy and scrap spawning configs to use the new name `823 Bozoros`, but I'm not sure.
  * Added tags `Fun`, `Funny`, `Circus`, `Clown`, `Lake`, and `Paid`.
  * Added spike traps to the hazard spawn pool.
  * Added enemies from `v50` and above to the enemy spawn pools.
    * [BarberFixes](https://thunderstore.io/c/lethal-company/p/ButteryStancakes/BarberFixes) by [ButteryStancakes](https://github.com/ButteryStancakes/BarberFixes) is highly recommended to avoid any potential issues with multiple Barbers.
  * Added certain scrap items from `v61` to the scrap spawn pool.
  * Increased difficulty rating to `B+` due to the added enemies and hazards.
  * Increased routing price to `300 scrap` to match the difficulty rating.
  * Balancing might be a bit rough, it'll likely be adjusted over time, and I'm looking for feedback on this.

> Update brought to you by [pacoito](https://github.com/pacoito123)!

</details>

**<details><summary>Version 1.0.1</summary>**

* Fixed issue where Bozoros would load before LethalLevelLoader.
* Fixed issue where interior First Time Audio would fail to load and give a log warning.

</details>

**<details><summary>Version 1.0.0</summary>**

* Bozoros is now out of beta!
* Added a new Circus Interior. Should be familiar as it is a reskin of the vanilla factory.
* Removed Giants from outdoor spawn pool and added Penny and Teller; the two guardian Clown Giants.
* Added 4 Bozo-Lizards: Steve, Krusty, Ronald, and Arthur.
* Removed lake from Navmesh so Giants and Lizards don't walk into it and drown.
* Attempt to fix eclipse object texture not loading.
* Added new water fountains to EOD firework show.
* Replaced textures and music on Item Ship drop to fit thematically.
* Added fire effects to the eclipse atmosphere.
* Added a new music track for the firework show.
* Tweaked enemy spawns for indoors and outdoors. Good luck!
* Added a config file to change various audio volumes, pfx amounts, streamer-friendly music, and Circus Interior settings.
* Compressed audio and limited texture resolutions to decrease filesize and loading times.
* Fixed a floating lamppost by the ferris wheel.

</details>

**<details><summary>Version 0.9.9</summary>**

* The park is now open! Default ticket price is 100.
* Added cotton candy and balloon stalls.
* Added new music track to CircusTypeAmbience Insanity Music.
* Adjusted base volume of many insanity queues.
* Changed firework music to a DMCA-free original track. (Will be available again when config file update happens.)
* Removed invisible colliders leftover from rollercoaster support beams.

</details>

**<details><summary>Version 0.1.8</summary>**

* Added a set of Ambience sounds for both outside, indoors, and increased insanity.
* Fixed some collider issues in a few places.
* Minor adjustments to a few spawn rates, including increase in Nutcrackers and outdoor Lizards.
* Fixed some spawn points that were producing errors.
* Increased texture resolution of several textures (for HDLethalCompany users).
* Decreased dungeon size from 2 to 1.8 for performance.

</details>

**<details><summary>Version 0.1.7</summary>**

* Fixed missing skybox

</details>

**<details><summary>Version 0.1.5</summary>**

* Added a service bell to BigTop Burger.
* Added popcorn machines at various corners of the map.
* Updated planet preview prefab.
* New icon and README update.

</details>

**<details><summary>Version 0.1.4</summary>**

* BigTop Burger is now open for business on the south end of Bozoros!
* Bumped up emission of many textures to be slightly more visible in shadows.

</details>

**<details><summary>Version 0.1.3</summary>**

* Added trash and recycle bins. Keep Bozoros clean!
* Added a Big Shot cannon at the far side of the lake.
* Updated lake reflection probe.
* Made most level objects static, this should boost performance.

</details>

**<details><summary>Version 0.1.2</summary>**

* Added benches and balloons all over the map.
* Stopped enemies from spawning over the lake.
* Confetti removed from storms; replaced by rogue balloons! All weather types now have unique reasons to visit.

</details>

**<details><summary>Version 0.1.1</summary>**

* Fixed material missing on Fire Exits.
* Added a lake between the ship and the ferris wheel to discourage darting to and from the fire exit there.
* Map now has a baked reflection probe.

</details>

**<details><summary>Version 0.1.0</summary>**

* Added loudspeaker prop at various points on the map.
* Added unique voiceover announcements for fireworks for all three weather types.
* Timed point lights during clear days that turn off for the firework show.
* Adjusted heights of rollercoaster support beams to prevent them from clipping into the interiors.

</details>

**<details><summary>Version 0.0.9</summary>**

* Decreased max particle count for confetti from 10,000 to 8,000.
* Constrained confetti volume and fireworks to the same positions at all time in the world.
* Added a kill trigger for confetti underneath the ground to prevent confetti in interiors.
* Shifted fog color towards a dark blue instead of off-red.
* Disabled fireworks during weather events.
* Removed Foggy weather type.
* Replaced MouthDog enemy spawns with Sandworm
* Added Spore Lizards to outside spawns.
* Added a preview video to the ship monitor prior to landing.
* Added a real info description of the moon in the terminal.
* Updated README screenshots.

</details>

**<details><summary>Version 0.0.8</summary>**

* Attempt to fix colliders that go into interior.

</details>

**<details><summary>Version 0.0.7</summary>**

* The Trickster rollercoaster comes to Bozoros, the most thrilling ride in the star cluster. Prepare to ascend to great heights and maximum g-forces while plummeting several stories down to the ground. A drop just high enough could mean your DOOM. Scared yet?

</details>

**<details><summary>Version 0.0.6</summary>**

* Ladies and Gentleman; patrons of Bozoros!
The IN YOUR HEART Firework Spectacular show is now in season! This fabulous celebration of Worthikids and BigTop Burger can only be viewed at 10pm on clear weather days. Thank you for visiting our park and remember, watch out for giants!

</details>

**<details><summary>Version 0.0.5</summary>**

* Tweaked volumetrics of point lights to be less intense.
* Confetti now rains down during special weather events!

</details>

**<details><summary>Version 0.0.4</summary>**

* Big adjustments to Skybox and Daytime Volumes.

</details>

**<details><summary>Version 0.0.3</summary>**

* Fixed AudioReverbTriggers with default Forest Ambience for now.
* Enabled Read/Write access for meshes.

</details>

**<details><summary>Version 0.0.1</summary>**

* Initial release. Expecting things to not work correctly and a lot of art is still missing. Just wanted to get this out into the world for a fun journey.

</details>
