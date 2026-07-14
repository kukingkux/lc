# v1.2.2
- Fixed an extremely rare bug which could cause random monsters to spawn outside (ignoring normal spawn rules) once every Old Bird on the map woke up
# v1.2.1
- Added a config setting to make Cadaver Growths remove their power level if they are completely exterminated, and thus unable to regrow for the rest of the day (thanks [cookiecaker](https://thunderstore.io/c/lethal-company/p/cookiecaker/))
- IndoorEnemySpawnPlacementRandom is now also used to determine how long enemies remain inside vents
# v1.2.0
- Now uses vanilla's unused IndoorEnemySpawnPlacementRandom for placing enemies in vents
# v1.1.4
- Added error handling to prevent spawns being totally canceled when playing custom moons with broken spawnlists
# v1.1.3
- Fixed vent spawn times getting "double adjusted" (which made inside enemies spawn much closer to the hour than usual)
# v1.1.2
- Removed fixes that were implemented into vanilla
  - Species fix (for Dine and rare enemies)
  - Weed power fix
# v1.1.1
- Fixed certain species being blocked from spawning on specific moons
- Removed `Limit Spawn Chance` (v80 made the "rule" too inconsistent)
# v1.1.0
- Refactored for v81's spawn system
- Incorporated [Vent Spawn Fix](https://thunderstore.io/c/lethal-company/p/ButteryStancakes/VentSpawnFix/) as a built-in feature
# v1.0.0
- Initial release