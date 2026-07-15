# CHANGELOG



<h1>1.2.7</h1>
Fixed an incorrect blocker selection that, in a very specific situation, could result in the fire exit being blocked (even though it looked really cool, like the ceiling had collapsed in front of the fire exit after you entered)<br><br>
Adjusted the blockers on the tunnel tiles so that they won't clip into other tiles in certain configurations<br><br>
<h1>1.2.6</h1>
Slightly adjusted the position of a decal in the entrance tile so it doesn't block the view if you're using ImmersiveEntrance<br><br>
<h1>1.2.4</h1>
I forgot to restore some settings the connectors had when converting to v81:<br><br>
Fixed a couple of tiles that had door sockets with connectors that shouldn't have had connectors, resulting in connectors spawning in a way that looked broken<br><br>
Fixed a couple of tiles that had door sockets with missing connectors<br><br>
Added back in connector priorities for certain tiles, so the connector spawns would look more even with the level geometry<br><br>
Made connectors with doors less common for big doorways<br><br>
<h1>1.2.3</h1>
Fixed a couple propsets where I didn't restore their min/max correctly in v81, making some rooms too empty<br><br>
Falling wire spools can kill enemies now<br><br>
<h1>1.2.2</h1>
Hey so I deleted the global prop list while debugging the previous issue, meaning there were no fire exits, breaker boxes, vents, or steam valves. They're back now<br><br>
<h1>1.2.1</h1>
One tile had connectors set but no prefab selected, which upset some mods<br><br>
Oops, there was also a tile that had no door sockets<br><br>
<h1>1.2</h1>
v81 compatibility. I haven't tested it with v73, use it with that at your own risk (LLL will probably just fallback to a different interior)<br><br>
Added the animation to the entrance<br><br>
Added indirect lighting to the lights<br><br>
Adjusted some lights, due to the addition of indirect lighting and the game's overall lighting level changing with v81<br><br>
Dying to falling spools will now list your cause of death as crushing, instead of fan<br><br>
Spool rooms can now directly repeat, because why not<br><br>
Fixed a bunch of ground tags so they make the correct footstep sounds<br><br>
Added soothing red lights to make the jumping puzzle room less stressful<br><br>
<h1>1.1.12</h1>
Changed the texture type of all normal maps to actually be normal maps. Thanks go to Sire Boom on the LC modding Discord for this tip<br><br>
Changed the reflectivity of the wire spools and some other copper textures to not be blasting you with the full power of the sun<br><br>
Fixed a bunch of props that were either floating above the ground or clipping into it<br><br>
Fixed a couple of textures that were stretched and looked bad<br><br>
Got rid of that annoying diagonal line that was on exactly one wall in the entire interior<br><br>
Fixed a instakill pit so that it instakills you instead of letting you sit on the bottom until you moved, at which point you just fell over<br><br>
Fixed the lever activation hitbox in the jumping puzzle room moving into the shortcut hallway and becoming an invisible box that blocked movement<br><br>
Fixed the normals on a broken valve<br><br>
<h1>1.1.11</h1>
I saw a misaligned steam valve while playing, and found that 2 of the 44 possible steam valve spawns would be misaligned if that particular arrangement on those particular tiles spawned, so I moved them back. You're welcome<br><br>
Adjusted a prop arrangement on the vertical ramp tile that players could get trapped behind<br><br>
<h1>1.1.10</h1>
For some reason, the previous update made the shortcut door in the jumping puzzle room decide not to be network sync'd anymore. I don't know why that happened, and I don't know why what I did fixed it, but it works again<br><br>
<h1>1.1.9</h1>
Updated for v73! Which is pointless because it already worked!<br /><br />
General navmesh cleanup, should be a lot fewer places (hopefully none) where monsters can't reach you even if they're on the same floor as you<br /><br />
Monsters can no longer phase through the bulkhead door in the jumping puzzle room<br /><br />
Sliiiightly increased the size of the invisible colliders on the pipes in the jumping puzzle, because I'm tired of being killed by my own creation<br /><br />
All doors have been redone once again, monsters should now properly interact with them and pass through them<br /><br />
Additionally, while the doors can never spawn locked, they can now be locked if you use a mod that lets you lock doors<br /><br />
The sizes of crates and some spools have been reduced in almost every tile where they appear, to stop things from feeling quite so cramped, and to also, again, make navmeshes cleaner<br /><br />
Crate and barrel stacks can now spawn in the tunnels portion of the interior, to give you cover against monsters<br /><br />
<h1>1.1.8</h1>
Finally realized that the reason you could be shot through the big yellow pipes is because I forgot to check the box to generate colliders on them, so I fixed that. Maybe now SOME PEOPLE will stop complaining about my map being broken<br /><br />
<h1>1.1.7</h1>
Fixed an issue that appeared after itolib updated how PlayerLauncher works, which caused the river in the river room to instantly accelerate the player to an unreasonable speed and completely ruin the bit I was trying to do<br /><br />
Adjusted the vertical sprayers in the jumping puzzle room so they won't make me drop my shovel if I once again decide to bring it while doing the jumps for some reason<br /><br />
<h1>1.1.6</h1>
Remember when I said the previous update would be the final one?<br><br>
I lied<br><br>
Fixed an issue where enemies could phase through the connector walls that had doorways<br><br>
Cleaned up a bunch of stuff involving navmeshes, enemies should be able to navigate the map better now<br><br>
<h1>1.1.5</h1>
Final (???) update, unless something breaks<br><br>
Added scrap spawn back to main entry tile<br><br>
Rebalanced scrap spawns causing an ungodly amount of loot to spawn in the tunnels, it should be a bit more evenly distributed throughout the interior now<br><br>
Added appropriate surface tags to the two new tiles<br><br>
Fixed messed up textures in apparatus room<br><br>
<h1>1.1.4</h1>
Launchers in the jumping puzzle will no longer fling you in different directions depending on the rotation of the tile<br><br>
The vertical launchers in the jumping puzzle no longer have horizontal flinging force<br><br>
<h1>1.1.3</h1>
Fixed some texture issues with the tunnel tiles and made all their normal maps play nice with each other<br><br>
<h1>1.1.2</h1>
Fixed creepy sounds once again<br><br>
Fixed animated [REDACTED] in the [REDACTED] room being actual instances of what they are, including slowing you down and, presumably, triggering certain enemies if they were spawned in the interior<br><br>
All the lights around the apparatus will go off now when you pull it<br><br>
Added a radar box for the fan blockers in the interior<br><br>
Adjusted the 'nothing should spawn here' box for the fan blockers, because I saw an unreachable item spawn at one point<br><br>
Adjusted the doors in the jumping puzzle room so that you will always enter from the 'start' of the room. Fire exits can still put you on the other end, of course<br><br>
Cleaned up a LOT of redundant textures and compressed some audio, shrinking the size of the file pretty significantly<br><br>
As a result of the previous point, a LOT of materials have had missing normal maps added<br><br>
<h1>1.1.1</h1>
Certain fire exit spawns should no longer send you to the void if you try to enter the interior through them<br><br>
Changed tile weights, tilesets, and archetypes to prevent an excessive number (3+) of the vertical tiles appearing one after another<br><br>
Fixed missing creepy sounds from the [REDACTED] room<br><br>
<h1>1.1</h1>
Remade the tunnel tiles. They are smaller and more mazelike now<br><br>
There will be fewer open paths from the entry tile; you will no longer find five ways to go with four of them being 20-foot long tunnels leading to dead ends<br><br>
Proper endcaps have been added to the tilesets.<br><br>
Overall size of interior, branches and so on have all been adjusted as a result of the tunnel tile change<br><br>
Added two new tiles, one for each section of the interior<br><br>
Steamvalves can now spawn in the tunnel section<br><br>
Itolib is required now, this will allow the [REDACTED] to launch you rather than gently nudging you<br><br>
All tiles are now compatible with the radar changes from v70<br><br>
Big thanks to bsl on the LC modding Discord for passing along the info that the floors under the water effect need to be tagged as 'grass' to allow you to enter more than one 'box' of water per day. As a result, you can once again drown in water in the interior, rather than instantly dying<br><br>
Turrets will not spawn on certain tiles that don't provide enough cover<br><br>
<h2>1.0.10</h2>
Fixed the connectors on the apparatus tile rotating incorrectly<br><br>
<h2>1.0.9</h2>
Fixed an issue with the water. TLDR; if you use water in the interior, apparently only the first bit of water a player goes into counts, and all the others have no effect. So now only the jumping puzzle has real 'drownable' water, all the rest is an instant kill<br><br>
<h2>1.0.8</h2>
I really hate how keys and locked doors work. Keys and locked doors can no longer spawn in this interior<br><br>
Bricks are now 70% less likely to levitate<br><br>
Fixed the big version of the tile connector being misaligned<br /><br>
Fixed an issue where enemies could pass through certain small parts of tiles walls, letting them sneak around doors<br><br>
<h2>1.0.7</h2>
Updated the layers on, I don't know, like everything. Should prevent turrets from firing through crates and other objects, some connector walls, things like that<br><br>
Added two more fire exit spawns<br><br>
<h2>1.0.6</h2>
The... 'overabundance' of scrap spawns around the apparatus has been reduced to a more reasonable number<br><br>
The grate that can spawn in the center of the large halls 3-way tile now has a navmesh that enemies can walk on<br><br>
<h2>1.0.5</h2>
Added JLL as a dependency<br><br>
Added a new, somewhat rare type of blocker to both small and large tile connector sockets<br><br>
The two jumping tiles now have 1-2 pieces of scrap as guaranteed spawns<br><br>
Cleaned up damage/death triggers with JLL, they should now produce the appropriate death animations and causes of death as well as the fans and electric arc still killing enemies<br><br>
The sparking wires in the entry now do less DPS<br><br>
Fixed all the typos I added to the changelog and readme in the last update<br><br>
<h2>1.0.4</h2>
Spray paint should work on all interior surfaces now<br><br>
Re-added concrete/catwalk tags to walkable surfaces, which had gotten lost during endless reimporting of the tile models<br><br>
Random bricks are now found in the appropriate tiles<br><br>
<h2>1.0.3</h2>
Enemies can now die to the fans in the entryway, as well as any arcs of high-voltage electricity you might find<br><br>
Fixed loot being scannable through some walls<br><br>
Fixed the inside bits of the frames on the fan blockers in the entrway having missing textures/planes<br><br>
<h2>1.0.2</h2>
Water spray effect is now affected by lighting<br><br>
Rebalanced weights for vanilla moons<br ><br>
Added weights for custom moons: Sorrow, Phaedra, Hydro, Valunarion, Synthesis<br><br>
<h2>1.0.1</h2>
Entrance teleporter changed to be compatible with LethalPerformance<br>
<h2>1.0.0</h2>
Initial release