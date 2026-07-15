# Changelog

## 1.8.0 (04/07/2026)



* Adjusted the door triggers to match the size of the door

## 1.7.9 (04/07/2026)



* Fixed the chud key visual.

## 1.7.8 (04/07/2026)



* Removed redundant code in the physics region logic.

## 1.7.7 (04/07/2026)



* Hopefully fixed an issue where you would be unable to interact with a seat if you tried interacting with an occupied seat.

## 1.7.6 - 2026/7/03



* Fixed an issue with the player zone.

## 1.7.5 - 2026/6/28



* Fixed the untwist animation not playing after stalling the engine.

## 1.7.4 - 2026/6/27



* Fixed radio track resetting timestamp when toggling the radio on/off.
* Numerous audio adjustments and polish.

## 1.7.3 - 2026/6/27



* Fixed some issues post-explosion.
* Fixed some issues with the item hashset.

## 1.7.2 - 2026/6/24



* Added a config to enable or disable mirror rendering.

## 1.7.1 - 2026/6/24



* More physics region adjustments, ack, sorry.
* Fixed the vehicle-display color not changing for the special variant.
* Lowered the volume of various sounds.

## 1.7.0 (23/06/2026)



* Another re-write for the physics regions. AAAAAACK.

## 1.6.9 (23/06/2026)



* Hopefully fixed the stupid fucking physics region bug I am so fucking sick and tired of this shit that keeps breaking.

## 1.6.8 (20/06/2026)



* The JLL-Blower fan component can no longer push the player if enclosed inside of the vehicle (like with Gusty Weather)

## 1.6.7 (16/06/2026)



* Hopefully fixed some fuck-ass issues with the physics regions.

## 1.6.6 (16/06/2026)



* Fixed an issue with the roof-rain audio continuing when it shouldn't. Hopefully.
* The car can no longer kill the kidnapper-fox.

## 1.6.5 (04/06/2026)



* Fixed issues with player-ignition animations.
* Minor HP-Buff.
* Slightly increased boost-force.

## 1.6.4 (31/05/2026)



* Fixed log-spam from player zone sync.

## 1.6.3 (30/05/2026)



* Actually fixed a desync with the hood.

## 1.6.2 (29/05/2026)



* Fixed ignition animation being uncancellable

## 1.6.1 (28/05/2026)



* Fixed radio music, for real.
* Hopefully fixed the stupid fucking ignition animation this fucking time I'm so sick of this.

## 1.6.0 (27/05/2026)

From now on, I will be using Semantic versioning.

* Added a player-handbrake animation when disengaging and engaging the handbrake.
* Tons of code clean-up and optimisations, under the hood internally and to the vehicle zones + physics region, also optimised fog exclusion zones.
* Improved quality of mirrors slightly.
* Improved durability, the ScanVan can now bear the brunt of collisions a bit more and the damage dealt to the player should be a bit more fair.
* Increased hopping force slightly.
* Removed the Utility Compartment for now, due to items getting stuck, sorry for this.
* Auto re-centering wheel now works based on whether the vehicle is moving or not and the speed at which it recenters is based on vehicle velocity.
* Fixed enemy protection checking the wrong thing in some instances.
* Replaced some of the default radio songs with new ones.
* Increased sideways traction in snowy conditions.
* Fixed an error with the radio when no custom music is installed but the DMCA config is turned off.
* Fixed the player-steering animation being reversed.
* Hopefully fix player collisions once and for fucking all.
* Hopefully fixed radio not changing song automatically.

## 1.5.2 (14/05/2026)



* Fixed a radio index error.

## 1.5.1 (13/05/2026)



* Adjusted some of the colliders near the utility compartment.
* Hopefully fixed high-speed collisions with players.

## 1.5.0 (12/05/2026)



* Tweaked clutch behaviour further. If it feels "too unfair" please let me know.
* Increased maximum inclination compensation. (you can now hill-start on maps like Amantia with very steep hills.)
* Tweaked some networking methods.

## 1.5.0 (12/05/2026)



* Tweaked clutch behaviour further. If it feels "too unfair" please let me know.
* Increased maximum inclination compensation. (you can now hill-start on maps like Amantia with very steep hills.)
* Tweaked some networking methods.

## 1.4.9 (11/05/2026)



* Tweaked clutch behaviour further.
* Fixed car going mach-5 when off the clutch in gear.

## 1.4.8 (11/05/2026)



* Improved incline-compensation.
  * The truck was supposed to give a "torque boost" on inclines, but due to an oversight in the math, it was mostly reliant on clutch engagement. This has been fixed and should be less frustrating.
* Improved stalling behaviour. 
  * Previously, you were able to easily set off in say, fourth gear, and do a bunch of other weird things. The clutch behaviour has been tweaked, and many of this weird behaviour should no longer be possible.
  * The stall threshold has also been corrected to be below the minimum engine RPM, and is also no longer reliant on wheel-speed difference.

## 1.4.7 (10/05/2026)



* Fixed vehicle-information-display not being on upon reload.
* Fixed window stickers being two sided. (black backing face inside)

## 1.4.6 (10/05/2026)



* Hopefully for the last time, fixed an issue with the player ignition animations. I'm so sick of these.
* Fixed various issues with the ignition and reloading the save file with an attached truck.

## 1.4.5 (10/05/2026)



* Added the ability to override the cabin-light to be permanently on.

## 1.4.4 (09/05/2026)



* Fixed ignition voice alert never playing.
* Fixed compression on some audios.

## 1.4.3 (08/05/2026)



* Minor refactor to item-safety code to hopefully prevent items being unfairly deleted.
   * Sidenote: I don't even think this is something on my end. I had something similar happen with the V55-Cruiser during a run and the car didn't even get magnetised and everything got deleted.
   * I'll investigate this more thoroughly at some point to see if it's an issue with another mod.

## 1.4.2 (08/05/2026)



* Fixed clutch-slip being able to go near zero.
* Fixed clutch-slip not affecting reverse.

## 1.4.1 (07/05/2026)



* Reduced damage taken on the gearbox to a flat rate of 1.
* Transmission health is now also part of the health-meter.

## 1.4.0 (07/05/2026)



* Added "transmission health".
  * A gear, a grind, for all the weary learner drivers, does the clutch exist?
  * Can be healed with weed-killer.
* Fixed radio animation not playing properly.
* Fixed initial radio volume being negative.

## 1.3.9 (07/05/2026)



* Updated landmine related patching.

## 1.3.8 (06/05/2026)



* Temporarily undid 1.3.7, apologies. I will come up with a better system for this in the future however.

## 1.3.7 (06/05/2026)



* A gear, a grind, for all the learner drivers, does the clutch exist?

## 1.3.6 (06/05/2026)



* Only apply voice effects when required.

## 1.3.5 (06/05/2026)



* Yet Another Hotfix: use 'perspective player' instead of just local player when checking walkie-talkies.

## 1.3.4 (06/05/2026)



* Hotfix: only apply walkie-talkie fix if in vehicle.

## 1.3.3 (05/05/2026)



* Fixed car ignition being uninteractable after reloading a lobby with the engine on.
* Fixed issues with talking into a walkie-talkie while the receiving user is in the truck.
* Fixed issues with spectating players and audio muffling.

## 1.3.2 (01/05/2026)



* Fixed car being on wrong side of magnet.
* Fixed seats being uninteractable upon reload.

## 1.3.1 (28/04/2026)



* Added a 1 second cooldown to the ignition trigger after starting the car.
* Fixed a NullRef spam on the player-zones.
* Added a side-compartment.
* Fixed items on the roofrack not saving.
* The windshield can now regenerate in orbit.
* Fixed skidding effect RPC spam.
* TerminalConflictFix is now a soft dependancy, but not required. This should prevent the 'scan' command and typing 'scanvan' causing issues in the terminal.
* Updated README.

## 1.3.0 (25/04/2026)



* 1.2.9 Hotfix: added missing reset states for 'important' alerts.

## 1.2.9 (25/04/2026)



* Optimised bundle size (Thank you JacuJ!!)
* Refactored some voice alert code to hopefully prevent client desyncs.

## 1.2.8 (24/04/2026)



* Fixed engine knocking continuing after destruction.

## 1.2.7 (24/04/2026)



* Fixed "thank you" alerts never playing for anything apart from 'important' alerts.

## 1.2.6 (23/04/2026)



* Hotfix to hopefully fix voice alerts not playing when they should, and not resetting when they should.

## 1.2.5 (23/04/2026)



* Optimised headlights (thank you Zagster!)

## 1.2.4 (23/04/2026)



* Fixed ignition key animation and effects.
* Fixed a dashboard indicator light getting stuck on.

## 1.2.3 (23/04/2026)


* Attempted hot-fix to prevent radio-desync.
* Fixed radio-volume desync.

## 1.2.2 (23/04/2026)


* Slightly refactored ignition-key animation code to hopefully prevent desyncs.
* Fixed shifting into a gear that doesn't exist for clients.
* Fixed ignition hold prompt getting 'stuck'.

## 1.2.1 (23/04/2026)


* Fixed fuel-alert spam.
* Fixed truck-sound manager error spam.
* Refactored some of the alert code to hopefully prevent unwanted 'infinite loops'.

## 1.2.0 (22/04/2026)


* Updated dashboard symbols.
* Fixed internal name being 'CruiserXL'. You may need to reconfigure your user-config and keybinds, apologies, but going forth all new configs, or keybinds, will be under 'ScanVan'.
* Added a 'reverse gas pedal' key. Unbound by default. (request)
* Added a symbol and light to the window buttons when the headlamps are on.
* Adjusted some of the voice alert thresholds.

## 1.1.9 (20/04/2026)


* Added basic audio muffling for the trucks audios.
* Added an experimental system to muffle player voices based on whether they're inside the truck or not. Please report to me if this causes problems.
* ImmersiveVisor compatibility (no on-screen rain when in truck)
* Updated README.
* Added missing changes to changelog.
* Updated window opening+closing SFX.
* Added a roof-rain SFX.
* Eyeless Dogs will no longer hear the vehicle on the magnet if it is at an idle-rpm (i.e. in neutral)
* Fixed a Landmine patch error, apologies for this.
* Fixed Wesleys Hurricane and Forsaken weather leaking into the truck.

## 1.1.8 (19/04/2026)


* LethalMin support has been implemented, sorry this took so long.
* Moved cabin light trigger to the roof.
* Fixed some visual problems.
* Fixed radio timestamp not syncing properly.
* Increased hopping force slightly.
* "Keys in the ignition" and "Headlamps on" alert now are tied to driver-door state.

## 1.1.7 (19/04/2026)


* Car no longer gets launched as much from explosions.
* Voice alert volume can now be reduced significantly. (But never muted)
   * Volume can be adjusted ingame, but only applies for each new alert that begins playing.

## 1.1.6 (19/04/2026)



* Made old-birds seeing players in the cab a host-only optional config. On by default.

## 1.1.5 (18/04/2026)



* Fixed dually rear tyre ring texture.
* Removed rear arch wheel colliders to allow grabbing 'stuck' items.

## 1.1.4 (18/04/2026)



* Added audio cue for when the engine stalls.
* Fixed manual icon.
* Controller inputs have been unbounded due to controller support not working, please be understanding that this is a headache but I will look into it when I can.
* Added config to disable smooth steering inputs.
* Lowered Center Of Mass slightly.
* Reworked how the ignition triggers work, added tooltips.
* Added a keybind for the magnet like in BetterVehicleControls.
* Non-drivers cannot yank the handbrake if there is a driver in the seat.

## 1.1.3 (16/04/2026)



* Hotfix for key animation when the vehicle is stalled.

## 1.1.2 (16/04/2026)



* Updated the ignition key animation + key model.
* Increased EVA volume slightly, the radio will also now mute while the EVA is talking.
* Removed unused shift-triggers that caused immense warning log spam upon ownership transfer. (These were harmless however)

## 1.1.1 (15/04/2026)



* Removed the on-display hints.
* The clutch is now explained on the last page in the manual.

## 1.1.0 (14/04/2026)



* Readded missing lightning patch.

## 1.0.9 (14/04/2026)



* Fixed changelog versioning.

## 1.0.8 (14/04/2026)



* Fixed EVA alerts requeuing when they shouldn't.
* Added circuit-bee protection.
* Fixed Puma protection (maybe..)
* Fixed issues with disconnecting while seated.
* Fixed shift gear keybind naming in users keybinds.
* Adjusted hints for better clarity.
* Added a hint for stalling for the first time.

## 1.0.7 (12/04/2026)



* Fixed side and lift-gate alerts being swapped.

## 1.0.6 (12/04/2026)



* Corrected changelog.


## 1.0.5 (12/04/2026)



* Updated dependancy strings
* Fixed some stuff


## 1.0.4 (12/04/2026)



* Fix warning spam.
* Adjusted the clutch tip.
* The truck will now start on the key if it is stalled.

## 1.0.3 (12/04/2026)



* Attempted yet another hotfix for seat bug.

## 1.0.2 (12/04/2026)



* Attempted hotfix for seat bug.

## 1.0.1 (11/04/2026)



* Hotfix for a HUDManager error.
* Stop remove key prompt appearing if the key is not in.

## 1.0.0 (11/04/2026)



* Initial Release.