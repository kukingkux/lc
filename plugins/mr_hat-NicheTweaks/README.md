# NicheTweaks

### Audio
<details>

#### Silence ringing ear audio from shotgun blast
- If true, silences the ear ringing audio and muffled audio sound effect from shotgun blasts.

#### Silence lightning static audio
- If true, silences live lightning static that plays from a conductive item being targeted when entering the facility.

#### Mute fear audio
- If true, stops the fear ambience and heartbeat audio driven by the local player's fear level.
</details>

### Decals
<details>

#### Decal draw distance override
- If true, breaks the decal draw distance and causes decals to always be rendered. Will impact performance, not recommended without LethalSponge.
	- Compatibility tested with [LethalSponge](https://thunderstore.io/c/lethal-company/p/Scoops/LethalSponge/), it is highly recommended to use this mod if you want to use this setting. You can control the decal distance using 'decalDrawDist'. 100 is plenty with the amount of fog in Lethal Company.

#### Enable footprint pool override
- If true, overrides the number of footprint decals allowed to exist.

#### Footprint pool size
- Number of footprints that are allowed to be present before the oldest footprints start culling visually. Increasing this will impact performance.

#### Enable player blood effects
- Enable blood effects when players take damage.
	- Has networking
</details>

### Gameplay
<details>

#### Fix hoarder bug trying to grab man eater
- If true, prevents hoarder bugs from trying to pick up man eaters.

#### Enable grabbable to enemies item blacklist
- If true, enables grabbable to enemies item blacklist.

#### Give Radmechs a larger hit collider
- If true, gives the Radmech/Old Bird enemies a larger hitbox, mainly for use with mods where they are no longer immortal. However, as an unavoidable consequence, they can now grab you far easier, making them more difficult. Can also be used to just make them more difficult.

#### Give Butlers a taller player hit collider
- If true, increases the height of Butlers player hit collider to allow them to have more vertical reach. This is to stop players sitting on the Mansion doorframe to avoid danger, amongst other high areas.

#### Give Jesters a taller player hit collider
- If true, increases the height of Jesters player hit collider to allow them to have more vertical reach. This is to stop players sitting on the Mansion doorframe to avoid danger, amongst other high areas.

#### Lower size of Butler obstacle avoidance
- If true, resizes Butler's NavMeshAgent obstacle avoidance radius from 1.6 to 1.4 to help them fit through tighter spaces and open doors properly.

#### Disable utility slot
- If true, disables the utility slot on the HUD and prevents items from using the utility slot.

#### Prevent check dead players cheese
- If true, displays the 'No one can hear you' popup when sending a chat message when everyone is dead.

#### Eject at zero days without ship loot
- If true, triggers the deadline firing sequence as soon as the crew reaches 0 days left when no ship scrap value is found.

#### Disable item inspection
- If true, disables the ability to inspect items in your hand.

#### Fix zero scale items/NaN errors
- EXPERIMENTAL | If true, attempts to fix NaN errors. Not sure if this works. Thanks to [pacoito](https://thunderstore.io/c/lethal-company/p/pacoito/) for letting me use their code.
</details>

### QoL
<details>

#### Enable global voice volume slider
- If true, enables the global voice volume slider in the player list.
	- Compatibility tested with [MoreCompany](https://thunderstore.io/c/lethal-company/p/notnotnotswipez/MoreCompany/).

#### Enable player volume saving
- If true, enables player volume saving
	- Compatible with global voice slider, saves the global voice slider value as well. Will overwrite any individual player volume save data.
	- This does not run every frame, it runs every 0.1 seconds as long as you are in orbit and will disable itself when landing.
	- Volume only saves to file when exiting the pause menu.

#### Enable dropship pickup delay
- If true, adds a short delay to items dropped by the dropship before they can be grabbed.
	- This solely exists because grabbing an item too fast out of a dropship causes the item to bug out. Not much testing done, please let me know if this affects anything beyond dropship items.

#### Dropship pickup delay time

- Time in seconds before dropped items can be picked up.
	- This doesn't apply to items you or others drop.

#### Enable teleporter item pickup block
- If true, block item grabbing whilst you are being teleported.
	- This is to prevent GrabInvalidated if you pick up an item just before you get teleported

#### Remove landmine invisible bump
- Removes the invisible bump left by landmines after exploding.

#### Jester Warmup
- If true, silently plays and stops the Jester's audio clips so they are decompressed before first real playback to prevent an in-game lag spike

#### Ambient music warmup
- If true, silently plays and stops ambient music so they are decompressed before first real playback to prevent an in-game lag spike

#### Normalise helmet light brightness
- If true, matches the helmet light intensity to the flashlight's held light intensity when a flashlight is pocketed.

#### Uncap fps
- If true, removes the 250 fps cap.

#### Prevent a harmless error on player join
- If true, fixes a vanilla bug that causes harmless errors to be thrown when players join a lobby
</details>

### Ship
<details>

#### Disable leftover charge station scan node
- If true, hides the leftover scan node of the charge station inside the ship. This only affects cases where moving the station in build mode leaves a stranded scan node.

#### Close ship doors when lever is pulled
- If true, closes the ship doors when the lever is pulled.

#### Disable planet reel video on ship monitors
- If true, disables the planet reel video on the ship monitor.
</details>

### UI
<details>

*All options below have had compatibility tested with [LethalHUD](https://thunderstore.io/c/lethal-company/p/s1ckboy/LethalHUD/).*

#### Hide clock from HUD
- If enabled, hides the clock from the HUD.

#### Add clock to death sceen
- If true, adds clock to death screen.

#### Hide weight from HUD
- If true, hides the weight from the HUD.

#### Hide chat from HUD
- If true, hides the chat from the HUD.
	- Remains hidden even if you type in it.

#### Set chat colon colour set to blue
- If true, sets the colon in the chat to blue and prevents the colon from changing colours when using \<color> html attributes in chat messages

#### Hide weight from HUD
- If true, hides the weight from the HUD.

#### Hide compass from HUD
- If true, hides the compass from the HUD.

#### Reposition hands full text
- If true, enables repositioning of the hands full text.

<details>
<summary>Previews/Presets</summary>
<br />
<details>
<summary>Default/NoChange</summary>

![](https://i.imgur.com/V7m5eBW.png)
</details>

<details>
<summary>Below inventory</summary>

![](https://i.imgur.com/kBgCemU.png)
</details>

<details>
<summary>Above inventory</summary>

![](https://i.imgur.com/eOm2xXW.png)
</details>

<details>
<summary>Top of screen</summary>

![](https://i.imgur.com/fchz6eY.png)
</details>

<details>
<summary>Above vanilla stamina/health UI</summary>

![](https://i.imgur.com/ajdc74u.png)
</details>

<details>
<summary>Below chat</summary>

![](https://i.imgur.com/Eh01zv2.png)
</details>

<details>
<summary>Above tooltips</summary>

![](https://i.imgur.com/oZUOses.png)
</details>
</details>

#### Item lightning warning
- If true, warns the player which item is about to be struck by lightning with a visual indicator.

<details>
<summary><strong>Extra info</strong></summary>

- Compatibility tested with:
	- [LethalHUD](https://thunderstore.io/c/lethal-company/p/s1ckboy/LethalHUD/)
	- [LethalThing](https://thunderstore.io/c/lethal-company/p/Evaisa/LethalThings/)'s utility belt
	- [HotbarPlus](https://thunderstore.io/c/lethal-company/p/FlipMods/HotbarPlus/)
	- [ReservedItemSlots](https://thunderstore.io/c/lethal-company/p/FlipMods/ReservedItemSlotCore/)
- Should work out of the box with most item slot mods
- Uses an image component instead of a sprite renderer component, allowing the border to not be placed in front of everything on the screen
- Doesn't update every frame
</details>

#### Remove item slot fade
- If true, removes the fade popout of the item slot frame when swapping item slots.

#### Hide HUD at terminal
- If true, hides the HUD whilst at the terminal.

#### Enable condensation on visor during flooded
- If true, shows helmet condensation during Flooded weather.
	- Flooded is missing a visor overlay called helmet condensation, which is present during rainy or stormy weather if you look up in the rain.

#### Fix quit game highlight colours
- If true, changes the green highlights and corners of the in-game quit menu to be highlighted orange like the rest of the game.

#### Hide join button
- If true, hides the join crew button in the main menu.

#### Hide invite friends button
- If true, hides the invite friends button in the quick menu.

#### Hide credits button
- If true, hides the Credits button in the main menu.

#### Fix utility slot item icon size
- If true, fits the item icon to the utility slot.

#### Change friends only text to private
- If true, changes the `Friends only` lobby option in lobby creation menu to say `Private`.

#### Hide control tips from HUD
- If true, hides the control tip labels (top right of HUD).

#### Customise control tip item name
- If true, enables replacing of item control tip text.
	- This was originally created to change the control tip text to match the scan node texts, but now you can just make it anything you want instead. Check the config for more info on how to use this.
	- This also toggles a fix for stun grenade and homemade flashbang control tips changing unexpectedly.

#### Scan node colour overrides
- Allows the change of scan node types for certain things, using GameObject names.

#### Hide warning display tips
- If true, hides all warning display tips (yellow display tips).
</details>

### Visuals
<details>

#### Disable film grain effect globally
- If true, attempts to globally disable film grain where it may be present.

#### Disable custom VFX on moons
- If true, disables all visual effects on moons, primarily for use with custom moons.
	- This essentially disables film grain as well.

#### Disable local player shadow
- If true, disables shadow casting for the local player only. Very useful for modded flashlights with very high intensities.
	- Compatibility tested with most modded flashlights.

<details>
<summary><strong>Preview Images</strong></summary>

![](https://i.imgur.com/6i3PSPo.png)
![](https://i.imgur.com/usjnDqP.png)
</details>

#### Hide player arms
- If true, hides the player arms.

#### Enable texture fix for toy cube
- If true, changes the texture of Toy cube (rubix cube) scrap to a texture of a rubix cube that is actually solvable.

#### Enable LOD bias override
- If true, enables custom LOD distance.
	- This exists to prevent the visible pop-in to your liking. Increasing this will decrease performance.
</details>

### Other Mods
<details>

#### Hide and mute DawnLib achievement popups
- If true, hides [DawnLib](https://thunderstore.io/c/lethal-company/p/TeamXiaolan/DawnLib/)'s achievement popups and sounds.
	- This shouldn't disturb earning achievements.

#### Replace DawnLib hotloadUI images
- If true, replaces DawnLib hotloading player Steam images with a vanilla image. Requires [DawnLib](https://thunderstore.io/c/lethal-company/p/TeamXiaolan/DawnLib/) to be installed.

#### Fix MoreBlood footprint smearing
- If true, enables fix for [MoreBlood](https://thunderstore.io/c/lethal-company/p/FlipMods/MoreBlood/)'s footprint smearing.

#### Hide MoreCompany main menu button
- If true, hides the [MoreCompany](https://thunderstore.io/c/lethal-company/p/notnotnotswipez/MoreCompany/) cosmetic button in the main menu.
	- This does not disable cosmetics and the menu can still be accessed in-game via the pause menu.

#### Hide MoreCompany crew count in create lobby menu
- If true, hides the [MoreCompany](https://thunderstore.io/c/lethal-company/p/notnotnotswipez/MoreCompany/) crew count in the create lobby menu.

#### Change MoreCompany cosmetic button icon to orange
- If true, changes the [MoreCompany](https://thunderstore.io/c/lethal-company/p/notnotnotswipez/MoreCompany/) cosmetic button in the pause menu from green to orange.

#### Change ImprovedLobby text
- If true, changes text on the create a lobby screen from `ImprovedLobby` -> `Lobby`. Requires [LobbyImprovements](https://thunderstore.io/c/lethal-company/p/Dev1A3/LobbyImprovements/) to be installed.

#### Change BetterSaves text
- If true, changes text on the create a lobby screen from `BetterSaves` -> `Save Files`. Requires [BetterSaves](https://thunderstore.io/c/lethal-company/p/Pooble/LCBetterSaves/) to be installed.

#### BetterSaves auto rename
- If true, automatically renames new saves to the lobby name. Requires [LCBetterSaves](https://thunderstore.io/c/lethal-company/p/Pooble/LCBetterSaves/) to be installed.

#### BetterSaves start credits fix
- If true, sets BetterSaves starting credits to 60 rather than 30. Requires [LCBetterSaves](https://thunderstore.io/c/lethal-company/p/Pooble/LCBetterSaves/) to be installed.

#### Hide legacy control button inside control settings
- If true, hide legacy control button inside control settings. Requires [LethalCompany InputUtils](https://thunderstore.io/c/lethal-company/p/Rune580/LethalCompany_InputUtils/) to be installed.

#### Hide LethalConfig main menu button
- If true, hides [LethalConfig](https://thunderstore.io/c/lethal-company/p/AinaVT/LethalConfig/)'s button in the main menu.
	- This does not disable LethalConfig and the menu can still be accessed in-game via the pause menu.

#### Enable Utility Belt UI alignment fix
- If true, aligns Utility Belt item slots to the middle for consistency purposes. Requires [LethalThings](https://thunderstore.io/c/lethal-company/p/Evaisa/LethalThings/) to be installed.

#### MZCoMagicShipping crate never respawns
- If true, the magic crate does not respawn and is single use only. Requires [MZCoMagicShipping](https://thunderstore.io/c/lethal-company/p/XuXiaolan/MZCoMagicShipping/) to be installed.

#### Immersive visor works with hurricane
- If true, Immersive Visor shows rain drops on the visor during hurricane weather. Requires [ImmersiveVisor](https://thunderstore.io/c/lethal-company/p/Woecust/Immersive_Visor/) and [Wesleys Weathers](https://thunderstore.io/c/lethal-company/p/Magic_Wesley/Wesleys_Weathers/) to be installed.

#### Ship window shutters close on departure
- If true, ship window shutters close when the ship doors close on departure. Requires [ShipWindows](https://thunderstore.io/c/lethal-company/p/TestAccount666/ShipWindows/) to be installed.

#### Lethal nuke fix
- If true, prevents lethal nuke's particle effect from looping. Requires [Lethal Nuke](https://thunderstore.io/c/lethal-company/p/bcs4313/Lethal_Nuke/) to be installed.

#### MirrorDecor FPS cap
- Sets the FPS cap for the mirror furnitures camera. Requires [MirrorDecor](https://thunderstore.io/c/lethal-company/p/quackandcheese/MirrorDecor/) to be installed.

#### Remove EnhancedMonsters version number
- If true, removes EnhancesMonsters' version number from Lethal Company's version number text in the main menu. Requires [Enhanced Monsters](https://thunderstore.io/c/lethal-company/p/VELD/Enhanced_Monsters/) to be installed.

#### Player scan node red
- If true, sets the player scan node to be red for GI's 'Scan players'. Requires [GeneralImprovements](https://thunderstore.io/c/lethal-company/p/ShaosilGaming/GeneralImprovements/) to be installed.
</details>

### [EladsHUD](https://thunderstore.io/c/lethal-company/p/EladNLG/EladsHUD/) (Soon to be discontinued in NicheTweaks)
<details>

#### V80 utility slot compatibility
- If true, allows the utility slot to be seen when using EladsHUD in Lethal Company V80.

#### Reorganise EladsHUD
- If true, moves InsanityDisplay's percentage down to be in line with Stamina and Oxygen. Requires [InsanityDisplay](https://thunderstore.io/c/lethal-company/p/Confusified/InsanityDisplay/) and [Oxygen](https://thunderstore.io/c/lethal-company/p/consequential/Oxygen/) to be installed and configured accordingly.

<details>
<summary><strong>Preview Images</strong></summary>

![](https://i.imgur.com/Kf9AZMg.png)
![](https://i.imgur.com/8HES8Fj.png)
</details>

#### Fix stamina bar 10% cap
- If true, fixes stamina bar being unable to deplete to 0% properly.

#### Disable stamina notch
- If true, hides the notch on the stamina bar that's present during stamina drain.

#### Hide weight
- If true, hides weight UI.

#### Trigger health bar popup on heal
- If true, will show health bar when health increases as well rather than when only decreasing.

#### Autohide stamina/oxygen/insanity bar
- If true, automatically hides [stamina](https://thunderstore.io/c/lethal-company/p/EladNLG/EladsHUD/)/[Oxygen](https://thunderstore.io/c/lethal-company/p/consequential/Oxygen/)/[Insanity](https://thunderstore.io/c/lethal-company/p/Confusified/InsanityDisplay/) bar when at configured value for a period of time.
- All bars have the following config options:
	- Configurable time until fade
	- Configurable number/percentage visibility
	- Configurable starting percentage before fading timer starts (not done for insanity bar)

#### Hide percentage dividers
- If true, hides the percentage divider UI elements. These are the small dots between each percent number. Requires [Oxygen](https://thunderstore.io/c/lethal-company/p/consequential/Oxygen/) to be installed.

</details>


# Future plans
- Screenshots for README
- Swap from imgur to catbox

# Credits
[Sniper1.1](https://thunderstore.io/c/lethal-company/p/Sniper1_1/) for pointing me in the right direction in regards to flashlights and their shadows.

[Moroxide](https://thunderstore.io/c/lethal-company/p/Moroxide/) for being able to click fast enough during testing for the ghosting dropshit items (I can't)

[debbicar](https://thunderstore.io/c/lethal-company/p/debit_card_debit/) for their Toy cube (rubix cube) texture

[pacoito](https://thunderstore.io/c/lethal-company/p/pacoito/) for letting me use their code for `Fix zero scale items`

[zeeblo lite](https://www.youtube.com/watch?v=1c4Ut7nINkI)'s very useful modding tutorial

ChatGPT for answering so many questions about C# and Unity that it would drive any human insane
