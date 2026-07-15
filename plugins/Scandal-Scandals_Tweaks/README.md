# Scandals Tweaks


This is just a general-purpose mod that contains some useful universal patches, scripts, etc. that my mods can depend on and use from. Not everything is "useful" for mods, but they don't hurt to have bundled in here.
If anything in here interests you, feel free to use it!

Please note that on its own, this mod does not really serve any real purpose, I may split this up into two-seperate mods (utilities, and general-fixes) in-case any of the general-fixes interest people, but for now, this is the way it is.

### Scripts
- AudioMixerFixer (basic script, allows adding audios to an array that should use the correct vanilla SFX audio-mixer, and will apply the correct mixer at runtime)
- VehicleSeatAnimator (a slightly more universal script for my custom-vehicles for easier implementation, requires overriding in-code)

### Patches
- PlayAudioAnimationEvent NullRef "fixes" (do not attempt to play an audio if it is missing)
- Fix external-forces not fading when sat in a vehicle (prevent being launched upon exiting a vehicle)
- Fix items being unscannable when attached to a PlayerPhysicsRegion (vehicle, elevator, radmech, etc) (CruiserImproved)
- Fix untagged interactables from carrying the last valid interactable the player looked at. (CruiserImproved)
- Alters the generic TerminalNode text regarding buying vehicles to say "vehicle" rather than "Cruiser" or "Company Cruiser" (minor visual nitpick, as custom vehicles do not have custom terminal nodes for these situations)
- Patchable method to 'Allow'/'Fix' Old-Birds and Baboon-Hawks not seeing players in vehicles. (by default, use vanilla behaviour)