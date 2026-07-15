## 0.4.5
- Added `Give Butlers a taller player hit collider` config toggle, which increases the height of Butlers player hit collider to allow them to have more vertical reach. This is to stop players sitting on the Mansion doorframe to avoid danger, amongst other high areas
- Added `Give Jesters a taller player hit collider` config toggle, same as Butler one
- Added `Hide warning display tips` config toggle, which hides all warning display tips (yellow display tips)
- Added `BetterSaves auto rename` config toggle, which automatically renames new saves to the lobby name. Requires [LCBetterSaves](https://thunderstore.io/c/lethal-company/p/Pooble/LCBetterSaves/) to be installed
- Added `BetterSaves start credits fix` config toggle, which sets BetterSaves starting credits to 60 rather than 30. Requires [LCBetterSaves](https://thunderstore.io/c/lethal-company/p/Pooble/LCBetterSaves/) to be installed

## 0.4.4
- Fixed `Enable texture fix for Toy cube` missing asset
- Fixed `Disable utility slot` targeting a method that doesn't exist because of spelling mistake
- Changed `Jester Warmup` to prewarm audio only once
- Changed `Ambient music warmup` to prewarm audio only once


## 0.4.3
- Fixed `Enable player blood effects`, I forgot to undo something
- Changed `Jester Warmup` to prewarm the animator and audio only


## 0.4.2
- Project restructure (again)
- Added `Ambient music warmup` config toggle, which warms up ambient music tracks that can stutter when played for the first time
- Added `Fix utility slot item icon size` config toggle, which scales item icons down to fit the utility slot properly
- Added back in `Hide invite friends button` config toggle, which hides the invite friends button in the pause menu
- Added `Hide credits button` config toggle, which hides the credits button in the main menu
- Added `Remove item slot fade` config toggle, which removes the fade popout of the item slot frame when swapping item slots
- Added `Normalise helmet light brightness` config toggle, which makes helmet light brightness match the held flashlight brightness
- Added `Trigger deadline ejection at 0 days` config toggle, which starts the ejection sequence when reaching 0 days left
- Added `Mute fear audio` config toggle, which removes the sound that plays when the player's fear state changes
- Added `Replace DawnLib hotloadUI images` config toggle, which replaces DawnLib's hotloading player images with a custom image from vanilla
- Added experimental `Fix zero scale item` config toggle, which attempts to fix NaN errors. Not sure if this works. Thanks to [pacoito](https://thunderstore.io/c/lethal-company/p/pacoito/) for writing this patch and letting me use it here
- Fixed `Teleporter item pickup block` blocking item pickup for every client instead of only the player being teleported
- Fixed `Hide join button` displacing the host button
- Fixed `Hide join button` and `Hide credits button` leaving gaps between main menu buttons
- Fixed and moved `Disable item inspection` to the Gameplay config category
- Moved `Jester Warmup` to run after the level finishes generating
- Rewrote some EladsHUD tweaks, far more optimised
- Removed `Prevent softlock from disabled watcher`
- Removed `Keep unlocks extra ship upgrades toggle`
- `Prevent a harmless error on player join` no longer experimental
- Added a warning to the `Disable custom VFX on moons` description in regards to custom weather effects incompatibility (Planned to deal with later)


## 0.4.1
- `Items to change the control tip text of` config now accounts for 'Cookie pan' by default
- Added `Lower size of Butler obstacle avoidance` config toggle to help them fit through tighter spaces and open doors properly (from '1.6' to '1.4', thanks <a href="https://thunderstore.io/c/lethal-company/p/ButteryStancakes/">ButteryStancakes</a> and Leubes for telling me to edit NavMeshAgent instead of the Butler's collider
- Added `Prevent check dead players cheese` config toggle, which displays the 'No one can hear you' popup when sending a chat message when everyone is dead
- Added `Prevent a harmless error on player join` config toggle, which fixes a vanilla bug that causes harmless errors to be thrown when players join a lobby in relation to steam profile pictures. This is experimental because I don't have two steam accounts to test this with
- Added `Player scan node red` config toggle, which sets the player scan node to be red for <a href="https://thunderstore.io/c/lethal-company/p/ShaosilGaming/GeneralImprovements/">GeneralImprovement</a>'s 'Scan players'
- Removed 'Reparent items to furniture on load' as it now belongs to a separate mod with better implementation, <a href="https://thunderstore.io/c/lethal-company/p/mr_hat/BasedDecorPlacement/">BasedDecorPlacement</a>


## 0.4.0
- Rewrote the README in markup, in preperation for future screenshots
- Rebundled assets for v81
- Fixed `Disable planet reel video on ship monitors` not working for non-hosts/clients
- Added config to hide the lobby command in the terminal when using <a href="https://thunderstore.io/c/lethal-company/p/mattymatty/LobbyControl/">LobbyControl</a>
- Removed experimental warnings from `Enable player volume saving`, `Jester Warmup` and `Reparent items to furniture on load`
- Removed 'LCUltrawide V80 Fix' as the mod is now updated


## 0.3.9
- Added surface tolerance config to item furniture reparenting
	- MisideItems compatibility also updated
	- I am considering moving this tweak into its own mod
- Remade toy cube material tweak, also seems to have fixed it vibrating when the ship is moving (?)
- Reduced duplicate methods billion fold (hopefully i didnt mess anything up)
- Removed Reposition inventory slots config


## 0.3.8
- 'FPS Uncap' no longer touches vsync
- 'Disable utility slot' now also disables the hotkey as well
- Added config to hide the ship monitor's planet preview
- Added config to enable compatibility between <a href="https://thunderstore.io/c/lethal-company/p/EladNLG/EladsHUD/">EladsHUD</a> and V80's utility slot
- Added config to fix <a href="https://thunderstore.io/c/lethal-company/p/LethalCompanyModding/LCUltrawide_Community/">LCUltrawide Community</a> resetting its resolution to vanilla under certain condition
- Removed 'Hide Invite Friends from pause menu' config for the time being


## 0.3.7
- Fixed 'Add clock to death screen' for V80 - not compatible with v73
- Added config to change scan node of anything
- Added config to uncap FPS from 250
- Added config disable utility belt - not compatible with v73
- Removed config to set code rebirth snail cat scan node colour to red
- Removed config to set UsualScrap's store items scan node colour to blue
- State of Other Mod tweaks unknown for the time being


## 0.3.6
- Fixed BetterSaves text changing back after deleting a save when 'Change better saves text' is enabled
- 'Mirror decor fps cap' now also prevents the camera from rendering when not on the ship
- 'Disable local player shadow' now also turns off shadows for items in your hand
	- This will not enable the shadows of items that already have no shadow
- Added an experimental config to enable player volume saving
	- This also kind-of works with LAN, mostly because I had no other way to test it outside of debugging logs, online mode untested but should work, experimental because of this
	- Compatible with global voice slider, saves the global voice slider value as well. Will overwrite any individual player volume save data
	- This does not run every frame, it runs every 0.1 seconds as long as you are in orbit and will disable itself when landing
	- Volume only saves to file when exiting the pause menu
- Added config option to set all of <a href="https://thunderstore.io/c/lethal-company/p/etherealemil/UsualScrap/">UsualScrap</a>'s store item scan nodes to blue


## 0.3.5
- Fixed spelling mistakes and stuff in code
- Recreated Diversity Watcher softlock fix and ImmersiveVisor hurricane weather compatibility tweaks
- Added config to warm up the Jester at the start of the day
	- This checks if the moon you are on has Jesters in its spawnable enemies at the start of the game, then spawns one in, immediately starts its windup, then immediately despawns it. I consider this experimental because I honestly haven't been to measure this well outside of logs because my PC is strong
- Added config to give Radmechs/Old Birds a larger hit collider
	- As an unavoidable consequence, this causes Old Birds to grab you way easier, usually when trying to run between the legs. This tweak shouldn't really be used unless they're made killable via another mod, where the hitbox matters
- Added config to customise the extra unlockables that <a href="https://thunderstore.io/c/lethal-company/p/ButteryStancakes/KeepUnlocks/">KeepUnlocks</a> can save after being fired
- Added config to set a framerate cap for <a href="https://thunderstore.io/c/lethal-company/p/quackandcheese/MirrorDecor/">MirrorDecor</a>'s camera
- Added config to remove <a href="https://thunderstore.io/c/lethal-company/p/VELD/Enhanced_Monsters/">Enhanced Monsters</a>'s version text in the main menu.
- Added config to give <a href="https://thunderstore.io/c/lethal-company/p/XuXiaolan/CodeRebirth/">Code Rebirth</a>'s snail cats red scan nodes
- Added experimental config to reparent items to furniture on save load
	- This tweak essentially does what Matty Fixes does with the Storage Cabinet fix, except for all furniture storage rather than only the storage cabinet. This tweak can run without Matty Fixes and only DawnLib technically, but it looks really awful without Matty Fixes' ItemClippingFix and OutOfBounds patch, so I've set it up to not run without <a href="https://thunderstore.io/c/lethal-company/p/mattymatty/Matty_Fixes/">Matty Fixes</a> installed
	- This will not reparent items properly on decor/unlockables that have been set up incorrectly in Unity Editor, similarly to Matty Fixes
	- This has explicit compatibility with <a href="https://thunderstore.io/c/lethal-company/p/mr_hat/MisideItems/">MisideItem</a>'s drawers


## 0.3.4
- Fixed 'Teleporter item pickup block' preventing item pick up until game restart if two people press the teleporter button at the same time
- Fixed lightning border lingering on HUD until a new target was selected and non-hosts not running initial logic at the start of the day
- Fixed player turning invisible if emoting and toggling flashlight on and off when using 'Disable local player shadow' and now uses caching
- Added config to fix hoarder bugs trying to grab the man eater
- Added config to blacklist hoarder bugs and other enemies from picking up certain items
- Added config to change the 'Friends only' lobby option in lobby creation menu to say 'Private'
- Removed 'Terminal decor string prefix ("* ")' as it's now handled in <a href="https://thunderstore.io/c/lethal-company/p/ButteryStancakes/ButteryFixes/">ButteryFixes</a>


## 0.3.3
- Changed when 'Disable custom vfx on moons' executes so it also affects non-hosts (whoops)


## 0.3.2
- Added moon filter to 'Disable custom vfx on moons'
- Added nullchecks to 'Enable condensation on visor during flooded'
- Changed footprint pool to be allowed to be set to 0


## 0.3.1
- Fixed ship window shutters being inconsistent
- Fixed 'Hide legacy control button inside control settings' only working in the main menu
- Added config to hide "Join crew" and "Join LAN game" in main menu


## 0.3.0
- Added some missing configs to README and made some stuff more consistent
- Added config to hide 'Invite Friends' button in the pause menu (forgot to add this to changelog in 0.2.8)
- Added config to set chat colon colour to blue and prevent the colon from changing colours when using <color> html attributes in chat messages
- Added config to automatically close the shutters of <a href="https://thunderstore.io/c/lethal-company/p/TestAccount666/ShipWindows/">ShipWindows</a> when the ship takes off
- Added config to prevents <a href="https://thunderstore.io/c/lethal-company/p/bcs4313/Lethal_Nuke/">Lethal Nuke</a>'s particle effect from looping
- Split ImprovedLobby and BetterSaves text edit config into two separate configs
- Changed 'Close ship doors when lever is pulled' to only close doors on game start rather than lever pulled to avoid an incompatibility with malfunctions
- Removed 'Move main menu image down' tweak


## 0.2.9
- Fixed lightning border persisting around an item frame when dropping the conductive item


## 0.2.8
- Restructured the internals of the entire project and cleaned up a lot of code
- Remade 'Hide player arms' to be less expensive (I was lazy when I made this last time)
- Added config to block item grabbing whilst being teleported
	- This is to prevent GrabInvalidated if you pick up an item just before you get teleported
- Added config to block VFX and volumes on moons
	- This is primarily for custom moons with strong post processing effects. I tested vanilla moons, but if this interferes with some custom moons in an undesired way, I will add a customisable filter
- Added config to silence ear ringing audio clip and muffled audio effect when firing the shotgun
- Added config to silence live lightning static audio when entering the facility
- Added an event driven lightning warning for item slots:
	- Compatibility tested with:
		- <a href="https://thunderstore.io/c/lethal-company/p/s1ckboy/LethalHUD/">LethalHUD</a>
		- <a href="https://thunderstore.io/c/lethal-company/p/Evaisa/LethalThings/">LethalThing</a>'s utility belt
		- <a href="https://thunderstore.io/c/lethal-company/p/FlipMods/HotbarPlus/">HotbarPlus</a>
	- <a href="https://thunderstore.io/c/lethal-company/p/FlipMods/ReservedItemSlotCore/">ReservedItemSlots</a>	
	- Should work out of the box with most item slot mods
	- Uses an image component instead of a sprite renderer component, allowing the border to not be placed in front of everything on the screen
	- Doesn't update every frame
- Added config to change <a href="https://thunderstore.io/c/lethal-company/p/Pooble/LCBetterSaves/">BetterSaves</a> and <a href="https://thunderstore.io/c/lethal-company/p/Dev1A3/LobbyImprovements/">LobbyImprovements</a> text in the create lobby menu:
	- 'ImprovedLobby' -> 'Lobby'
	- 'BetterSaves' -> 'Save Files'
- Added config to enable compatibility between <a href="https://thunderstore.io/c/lethal-company/p/Woecust/Immersive_Visor/">ImmersiveVisor</a> and <a href="https://thunderstore.io/c/lethal-company/p/Magic_Wesley/Wesleys_Weathers/">Wesleys Weathers</a>, rain drops now show on the visor whilst Hurricane is the active weather
- Changed 'Hands full text preset' config to a list of presets
- Added a null check to 'Disable local player shadow' tweak
- Removed FairAI quicksand fix
- Removed PocketRooms teleport fix
- Removed GeneralImprovement's lightning warning "fix"


## 0.2.7
- Disable local player shadow:
    - Further refined logic
	- Compatibility added for <a href="https://thunderstore.io/c/lethal-company/p/FlipMods/TooManyEmotes/">TooManyEmotes</a>
	- Compatibility added for <a href="https://thunderstore.io/c/lethal-company/p/Command293/LocalFlashlight/">LocalFlashlight</a>
- Added config to hide player arms in first person
- Added <a href="https://thunderstore.io/c/lethal-company/p/debit_card_debit/">debbicar</a> into the credits


## 0.2.6
- Fixed MoreCompany's cosmetic button in the main menu not changing to orange when respective config is toggled
- Added config to change terminal decor string prefix ("* ") to match tools and ship upgrades listings
- Added config to change the Toy cube's (rubix cube) texture to match that of a solvable rubix cube in real life
- Reworked flashlight/helmet light shadow remover - no longer disables any shadow except for the local player. Combined all three config options into one as there is no longer any side effect
- Removed experimental config for NaN/Infinity errors on broken colliders


## 0.2.5
- Fixed death screen clock breaking in-game clock
- Even more README mistakes


## 0.2.4
- Fixed doors not closing on client after the first game when using 'Close ship doors when lever is pulled'
- Added config to hide the 'show legacy controls' button from control settings, something that is only present when <a href="https://thunderstore.io/c/lethal-company/p/Rune580/LethalCompany_InputUtils/">LethalCompany InputUtils</a> is installed
- Added config to add a clock at the top left when spectating
    - This is basically a direct clone of the in-game clock minus the border, I want to give this more options in the future
- Added config to completely hide the HUD (except tooltips) when on the terminal
- Added config to turn the 'Would you like to leave the game?' text orange instead of light blue
- Added config to change <a href="https://thunderstore.io/c/lethal-company/p/notnotnotswipez/MoreCompany/">MoreCompany</a>'s pause menu cosmetic button from green to orange
- Added config to prevent <a href="https://thunderstore.io/c/lethal-company/p/MelanieMelicious/Pocket_Rooms_MelanieMelicious/">Pocket Rooms</a> teleporting all players when rapidly entering and exiting
- Added an untested and experimental config to destroy objects that start to spam the console with NaN/Infinity collider calculation errors
- Some README mistakes


## 0.2.3
- Config to close ship doors when pulling lever is no longer restricted by celestial tint and has been moved to the ship config category


## 0.2.2
- Added config to close ship doors when pulling the lever, for use alongside <a href="https://thunderstore.io/c/lethal-company/p/sfDesat/Celestial_Tint/">Celestial Tint</a>'s 'ship door access'
- Added config to customise the position, rotation, size and opacity of hands full text
    - I suggest checking the README for some presets to copy and paste in, as this doesn't update at runtime at the moment
- Added config to customise the position of the inventory


## 0.2.1
- Reworked FairAI quicksand error fix for latest FairAI version
- GeneralImprovement's lightning warning fix
    - Now also hides HotbarPlus lightning warning when entering the facility
    - Added 2 extra triggers to hide lightning warnings when entering the facility
    - Silenced a couple of debug logs
    - Fixed non-host inventory slots not having GI's lightning warning
- Added config to destroy the magic crate from XuXiaolan's <a href="https://thunderstore.io/c/lethal-company/p/XuXiaolan/MZCoMagicShipping/">MZCoMagicShipping</a> after use and on load
    - This will destroy still if you purchase it from the store and don't open the crate before reloading the save
- Added config to customise LOD bias
- Added config to enable a fix to stop IntegrityChaos's <a href="https://thunderstore.io/c/lethal-company/p/IntegrityChaos/Diversity/">Diversity</a> from softlocking your game when disabling the watcher


## 0.2.0
- Fixed GI lightning warning fix not applying if inventory slots were never changed from 4


## 0.1.9
- Fixed accidental dependency on EladsHUD
- Fixed NullRefException spam related to GI lightning warning fix


## 0.1.8
- Fixed stamina percentage remaining visible and overlapping with oxygen percentage if disabled through EladsHUD
- Tweaked behaviour of GeneralImprovements lightning warning UI fix to hopefully be a bit more in-line and consistent with HotbarPlus lightning warning UI
- Added config to adjust the percentage at which the oxygen bar becomes visible
- Added config to fix in-game quit game UI elements being green rather than orange
- Added config to adjust blood decal size of player blood effects
- Lowered position of handsfull by a few more units. Will maybe provide a superior implementation that scales with inventory slots in the future
- Removed some accidental debug log triggers


## 0.1.7
- Did what 0.1.5 was supposed to do


## 0.1.6
- Added back in config to hide EladsHUD weight UI
- Fixed oxygen and insanity bars only reappearing at 100% if autohide was on


## 0.1.5
- Fixed half of vanilla HUD being toggled off regardless of config values


## 0.1.4
- Rewrote a lot of code, reorganised and optimised a ton of things
- Fixed space between LethalConfig not working (last minute typo lol)
- Fixed EladsHUD stamina bar visual anomalies with the 10% fix
- Added config to enable blood splatters from players
    - This is NOT clientside
- Added config to reposition the 'full hands' text to below the inventory
    - Conflicts with the compass if you have it on. Might add more options to this in future, I can't decide where to put it
- Added config to fix GeneralImprovements lightning static warning
    - Fixed lightning UI animation appearing over pause menu
    - Fixed lightning UI animation appearing permanently when entering the facility
    - Fixed lightning static audio continuing to play when entering the facility
    - Added compatibility with LethalThing's Utility Belt
    - No visual compatibility with ReservedItemSlots yet
- Added config to fix the out of place alignment of LethalThing's Utility Belt
- Added config to hide EladsHUD stamina notch
- Added config to trigger EladsHUD health bar visibility to appear when gaining HP
- Added config to trigger EladsHUD stamina bar visibility when weight value changes
- Added config to hide EladsHUD stamina/oxygen/insanity numbers and percentages respectively
- Added config to configure the percentage at which the EladsHUD stamina bar begins to start the delay timer
    - Oxygen and insanity equivalent will come in a later update (they work a bit differently)
- Added config to autohide EladsHUD oxygen and insanity bars
- Added config to hide EladsHUD + Oxygen percentage dividers


## 0.1.3
- Added category in config for EladsHUD
- Added config to reorganise EladsHUD when using InsanityDisplay and Oxygen
- Added config to hide the weight from EladsHUD
- Added config to fix EladsHUD stamina bar not fully depleting to 0%
- Added config to autohide stamina bar after a delay
- Added config to rename the 'LethalConfig' button to 'Lethal Config'
- Added config to move the main menu logo down


## 0.1.2
- Fixed an error when quitting to the main menu when the flooded helmet condensation is on
- Added config to hide MoreCompany's cosmetic button in the main menu
- Added config to hide LethalConfig's button in the main menu
- Removed some leftover debug loggers



## 0.1.1
- Added config to hide weight on UI
- Added config to enable helmet condensation during flooded weather
- Removed configs for ship cameras, look at ScienceBird's <a href="https://thunderstore.io/c/lethal-company/p/ScienceBird/ScienceBird_Tweaks/">ScienceBird Tweaks</a> mod if you require something like this


## 0.1.0
- Fixed an incompatibility between TooManyEmotes and hiding control tips
- Added config to adjust any item name in the control tips
    - This also toggles a fix for stun grenade and homemade flashbang control tips magically changing
- Added category in config for ship tweaks
- Added config to disable the door monitor screen
- Added config to disable the interior and exterior ship cameras respectively
- Added config to hide leftover charge station scan node when moving it in build mode


## 0.0.9
- Added category in config for tweaks that target other mods
- Moved DawnLib config toggle to other mods config category
- Added config to fix footprint smearing in FlipMod's <a href="https://thunderstore.io/c/lethal-company/p/FlipMods/MoreBlood/">MoreBlood</a> mod
- Added config to silence quicksand errors in TheFluff's <a href="https://thunderstore.io/c/lethal-company/p/TheFluff/FairAI/">FairAI</a> mod
- Silenced harmony reflection warnings on startup for NicheTweaks


## 0.0.8
- Added config to hide compass
- Added config to hide control tips
- Added config to hide DawnLib's achievement popup and mute the sound
- Updated BepInEx dependency version
- Tried to make README a bit more readable


## 0.0.7
- Added config to disable item inspection
- Removed config to hide achievements from DawnLib in main menu. DawnLib can do this now in its config


## 0.0.6
- Made the global volume slider update for players who join late
- Added config to remove invisible bump left by exploded landmines


## 0.0.5
- Fixed ship leaving icon not being hidden when hide clock is enabled
- World ending spelling mistake... (in changelog)


## 0.0.4
- Added compatibility with GeneralImprovements in regards to flashlight shadows still appearing
- Added config to hide handheld flashlight shadow
- Added config to keep dropped flashlight shadow
- Added config for a global voice volume slider
- Added config to toggle and control the delay time of dropship items before they can be grabbed
- Removed the broken player volume saver - sorry


## 0.0.3
- Removed config to hide LegendWeathers Majora Moon countdown timer since it got added into LegendWeathers
- Removed a leftover debug logger


## 0.0.2
- Added config to hide DawnLibs achievements tab. This does not disable the achievements system, only the button
- Added config to hide LegendWeathers Majora Moon countdown timer. This does not disable the timer and it will still crash into the map at 3pm


## 0.0.1
- Release
