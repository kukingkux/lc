# Spawn Cycle Fixes
Fixes various bugs with the spawn cycle, making enemy spawns more consistent and fair.

Now supports [Vent Spawn Fix](https://thunderstore.io/c/lethal-company/p/ButteryStancakes/VentSpawnFix/)'s "indoor enemies can spawn in groups of 2+" feature.

This has no relation to [Lost Enemy Fix](https://thunderstore.io/c/lethal-company/p/JacobG5/LostEnemyFix/) or [NestFix](https://thunderstore.io/c/lethal-company/p/PureFPSZac/NestFix/) and should work with both.

## List of Changes

All changes can be toggled on/off, though most are enabled by default.

<details>
<summary><b>Fixed double spawns occurring at the start of new days</b></summary>

- In vanilla, the day starts at about 7:39 AM, and the monster spawning cycle begins immediately by assigning enemies to vents.
- However, the second spawn wave, the first which actually includes outside/daytime enemies, does not occur until after all the vents are empty.
  - When the first spawn wave assigns nothing to the vents, the second spawn wave occurs immediately on the next frame (at 7:40 AM)
  - Otherwise (such as during infestations, or just plain bad RNG), outside/daytime enemies get delayed until all enemies spawn from the vents - this can occur as late as 8:00 AM, and causes a noticeable delay in eclipse surface spawns.
- This mod standardizes the first spawn wave to follow the format of other spawn waves; all 3 classes of monster spawn, and the next wave occurs after 2 in-game hours.

</details>

<details>
<summary><b>Fixed time-of-day inconsistencies for spawn waves</b></summary>

- Spawn waves ("batches" internally) are intended to occur once every 2 hours
- The first occurs at 7:39 AM. Then there's another at 9:00 AM, 11:00 AM, 1:00 PM, etc. until 11:00 PM, when spawns are "complete".
- However, spawn waves are unable to occur when there are still enemies inside of vents waiting to pop out.
- Zeekerss wrote some code to limit vent timers to occur before the next spawn wave.
  - For example, a spawn wave at 9:00 AM should only assign indoor spawn times between 9:10 AM and 10:59 AM, ensuring the vents will be empty by 11:00 AM.
- However, due to a logic error, the spawn timers are off by one hour.
  - In the example given above, a 9:00 AM wave actually assigns vent times between 10:10 AM and 11:59 AM.
  - When monsters are still in the vents past 11:00 AM, the 11:00 AM spawn wave gets postponed until the last monster exits the vents.
  - The next spawn wave will still be attemped at 1:00 PM, but since the 11:00 AM wave can set timers as late as 1:59 PM, that wave can get delayed too.
  - The odds of waves getting delayed is actually worse than a coin flip - effectively, there are 50 results that would be "on time" and 59 that are "late"
- This mod just corrects this off-by-one error, meaning spawn waves always occur exactly on-the-dot each day.
- This bug also caused spawn curves to be sampled from the wrong time of day; for example, a 9 AM spawn wave would use the spawn counts from 10 AM.
  - This interaction is also fixed by this mod.

</details>

<details>
<summary><b>Old Birds no longer spawn once all dormant ones have awoken</b></summary>

- There is an unused flag in the game that seems intended to prevent Old Birds from spawning in future waves once all the ones present on the map have woken up.
- However that flag isn't actually used, allowing Old Birds to continue spawning at random for the entire day.
- When such an Old Bird spawns, it will immediately be despawned (as no nest exists for it to occupy) but this still means 1 less actual enemy will spawn during that wave.
  - This is actually desirable for "natural spawns" (before power level from killed enemies is taken into account), to ensure these all spawn in the same order and time-of-day based on the seed.
  - However, once these deterministic spawns are complete, Old Birds will still continue wasting slots for "bonus enemies" that spawn with the refunded power level, which makes later waves inconsistent.
- This mod now blocks Old Birds from being selected in place of other enemies, *only after* all of the seed-determined enemies are spawned, which should provide "the best of both worlds"

</details>

<details>
<summary><b>Old Birds spawned from apparatus now impact maximum spawns</b></summary>

- Currently, when the apparatus is unplugged, all Old Birds on the map immediately wake up.
- However, none of those Old Birds add to the "current number of Old Birds spawned" counter, or add to outdoor power level.
- This allows monster spawns to overflow past their normal limits.
  - Under absolute worst conditions, this means you can have up to 40 Old Birds at once on Embrion!
- This mod makes Old Birds add their normal spawn values when they are woken up by the apparatus.
  - Overflow still can occur, but only if the action of unplugging the apparatus itself *directly* causes overflow - and then no future spawns will occur until the power level drops back to normal levels.

</details>

<details>
<summary><b>Mask hornets can now occupy power level</b></summary>

- Due to mask hornets having special spawn circumstances, their power level is currently ignored completely - butlers dying spawn the hornets themselves, and also clear out space for more enemies to spawn.
- While disabled by default, this mod will let you force mask hornets to apply their power level upon spawning.
- In vanilla, mask hornets are 2 power level, just like butlers. So killing butlers will effectively not free up any power level.
- This should be consistent with mods that change enemy power levels if you are interested in making adjustments to the exact values.

</details>

<details>
<summary><b>Challenge moons no longer have different spawns after several attempts</b></summary>

- Vanilla spawns extra monsters per wave, if all players survive for 5 days in a row while collecting a certain amount of money for each of those days.
- Due to an oversight this "streak" mechanic still exists during challenge moon gameplay, which changes the amount of monsters that spawn when you are in the middle of a streak.
- Additional spawns means greater potential for nutcrackers, butlers, etc. which increase the amount of loot available per day.
  - Effectively you have to waste 5 "sub-optimal" attempts just to get favorable loot spawns going forward, and you'd have to repeat this process any time a player dies.
- This also means you are punished for killing players (for the additional $15 in bodies) at the end of an attempt.
- This mod changes so much about spawns that it practically invalidates challenge moons anyway, but fixing this felt "right" anyway, so there you go

</details>

<details>
<summary><b>Vent placement is now seeded differently</b></summary>

- All classes of enemy spawns define 2 random seeds - a "spawn random" and a "placement random"
- The spawn random is used to decide enemy counts per wave, which species are selected, etc.
- Placement random is used to decide where each enemy will spawn in the actual playable space.
- Inside spawns *do* define a "placement random" - but in vanilla, this is totally unused. The "spawn random" is still used for assigning enemies to vents.
- Now, with this mod, inside spawns will use "placement random" to select vents. "Spawn random" is still used for all other calculations.

</details>

<details>
<summary><b>Cadaver Growths free up power level after extermination</b></summary>

- When spawning from a vent, Cadaver Growths occupy power level just like normal enemies do.
- However, as Cadavers can't be "killed" and their "AI" runs all the logic for player infection, they never despawn or subtract their power level during a round.
- Now, with this mod, if every single Cadaver is exterminated with weed killer (thus preventing any future growth), its power level will be subtracted to free up room for other spawns again.

</details>

## Compatibility

`Consistent Spawn Times` applies the bulk of new changes I implemented into this mod. If you only want the settings from [Buttery Fixes](https://thunderstore.io/c/lethal-company/p/ButteryStancakes/ButteryFixes/) back, then you can disable that one setting and everything else will work as it did before.

For __Buttery Fixes__ users, the `Mask Hornets Power` setting works here exactly the same as it did when it was in that mod, so copy over your config for that.

I renamed `UnlimitedOldBirds` to `Limit Old Birds`, so if you previously had that setting enabled, you will want to *disable* the corresponding setting from this mod.

⚠ **IMPORTANT** ⚠ **reminder:** If you are still using [Lethal Quantities](https://thunderstore.io/c/lethal-company/p/BananaPuncher714/LethalQuantities/), enabling `Limit Old Birds` will completely block Old Birds from spawning, due to a bug with that mod!

For __Vent Spawn Fix__ users, indoor group spawns will "just work". You are free to disable any settings you don't want to use.

## Credits

Thanks to [cookiecaker](https://thunderstore.io/c/lethal-company/p/cookiecaker/) for the icon