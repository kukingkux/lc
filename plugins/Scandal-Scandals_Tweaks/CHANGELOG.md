# Changelog

## 1.3.0 (12/07/2026)



* Temp hotfix to fix a bug with other animations like the terminal, etc.

## 1.2.9 (06/07/2026)



* Emergency hotfix to fix a bug where the players animator wouldn't get returned, apologies.

## 1.2.8 (06/07/2026)



* Removed another redundant trigger reset, altered some patches to only run on the local client instead.

## 1.2.7 (06/07/2026)



* Removed a redundant stop animation trigger reset, to hopefully fix issues with the terminal, charger etc.

## 1.2.6 (04/07/2026)



* Fixed a missing check on the vehicle-seat component that wasn't returning animations correctly.

## 1.2.5 (04/07/2026)



* Hopefully fixed an issue where you would be unable to interact with a seat if you tried interacting with an occupied seat.

## 1.2.4 (03/07/2026)



* Hopefully fixed an issue where you could request to sit in multiple seats.

## 1.2.3 (27/06/2026)



* Fixed an index out of the range exception bug.

## 1.2.2 (24/06/2026)



* Re-wrote the voice patch. I don't know how to properly test this unfortunately, so hope-and-pray.

## 1.2.1 (20/06/2026)



* Added a transpiler to JLL, to allow two things:
* Prevent blow-back while in the ship, since JLL has no way to set this, and it causes issues such as Gusty-Weather by Kenji to blow you while in the ship, so just assume "never push in ship".
* The ability for creators to patch and add their own conditions for whether a player can be pushed, like when in a vehicle for example.

## 1.2.0 (11/06/2026)



* Refresh player voice effects upon lobby-reload to hopefully fix an issue with vehicles such as the ScanVans voice muffling.

## 1.1.9 (27/05/2026)

From now on, I will be using Semantic versioning.

* Updated shared-asset-bundle.
* Consolidated some patches.
* Transpiled GiantKiwi for easier patching for my vehicles.
* Some other stuff I forgot but isn't really important to list.

## 1.1.8 (13/05/2026)



* Updated shared-asset-bundle.

## 1.1.7 (09/05/2026)



* Fixed inverted statement causing backwards knockback behaviour.

## 1.1.6 (07/05/2026)



* Consolidated Landmine patching.

## 1.1.5 (02/05/2026)



* Hopefully fixed 'stop animation' bugs.

## 1.1.4 (01/05/2026)



* Fixed baboon patching.

## 1.1.3 (28/04/2026)



* Updated shared assets bundle.

## 1.1.2 (21/04/2026)



* Removed redundant patches.
* Fixed Plugin GUID.

## 1.1.1 (21/04/2026)



* Updated patch namespacing.
* Added Wesleys Weathers as global references.
* Updated bundle.

## 1.1.0 (19/04/2026)



* Updated bundle.

## 1.0.9 (19/04/2026)



* Added a patchable method to allow or disallow Old Birds to see through vehicles. (I.e. for seated players only)

## 1.0.8 (12/04/2026)



* Corrected changelog.

## 1.0.7 (12/04/2026)



* Hopefully fix terminal bug?

## 1.0.6 (12/04/2026)



* Rebuild shared-bundle for V81.
* Corrected some stuff.

## 1.0.5 (09/04/2026)



* Consolidated landmine patches.
* Corrected description.

## 1.0.4 (31/03/2026)



* Updated for V80.
* Al.

## 1.0.3 (29/03/2026)



* Removed redundant test patch.


## 1.0.2 (29/03/2026)



* Actually fixed external forces not fading while seated.
* Added missing changelog to this mod.

## 1.0.1 (27/03/2026)



* Added a shared-asset bundle for all my vehicle needs.

## 1.0.0 (23/03/2026)



* Initial Release.