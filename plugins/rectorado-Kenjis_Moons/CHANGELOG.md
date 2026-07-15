# 1.6.4
### Row
- Fixed fans re-enabling randomly after finishing it's animation
- Fixed fans enabling after the shut-down announcement *(Note: If a fan is in the middle of the animation, it may take a second to shut down after the shut-down announcement)*
- Added missing dependency to the standalone release
### Dejection
- Fixed some pipes' materials having a "Yield Sign" when light hit them.
# 1.6.3
### Manuland
- Added Radiation compat
### Alacrity
- Added Downpour compat
### Allure
- Added Downpour compat
# 1.6.2
### Taldor
- Fixed the moon wrongly generating Subsidence's config
# 1.6.1
### General
- fixed the fish
### Ascension
- Fixed a bug that prevented people from leave the moon and interact with anything
### Nostalgia
- Fixed TVs not being synced

# 1.6.0 - Anniversary Update

I'm going to take a second here to say thank you to all of you, this past year has been a blast learning and exploring and sharing new worlds with you all. I have made some lovely new friends and learned a lot along the way. Thank you for sticking with me through all of this, I wouldn't be making stuff if it wasn't for the support and love you've shown me, so without further ado: happy birthday Taldor, and for many more new worlds to explore. See you all on the next one over!



### General

* New Moon added: 34-Alacrity
* Rebalanced most moons scrap ammount (most of them are slight adjustments to make them fairer in average).

  * Taldor ↓
  * Kiri ↓
  * Kiln ↓
  * Manuland ↓↓
  * Dejection ↓↓
  * Ascension ↑
  * Thrive ↓
  * Allure ↓
  * Row ↑
* Updated dependencies.
* Properly rebaked occlussion culling in most moons to help performance a bit in lower end computers. This might make the bundle slightly bigger.
* Cleaned up scenes and extensively checked textures and models compressions to bring down a bit the filesize on some moons.
* Tweaked LODs, View distances and Lights in several moons to further help performance in lower end computers.
* Updated README for it to be a bit less cluttered.
* Added a new wiki section on the mod's thunderstore page with some extra info on the moons.
* All moons now have a custom radar map and intro video.

### Allure

* Added a bit of new foliage.
* Swapped to terrain and added different footsteps.
* Added custom sand footsteps.
* Fixed a couple of untagged surfaces.
* Tweaked the appy event internally.
* (Painfully) Fixed the layering on the trees being wrong in some cases.
* Now has weights for Generic's storehouse

### Row
*One of the biggest complains that people had, and I did too because i didn't meassure well enough, was how big and **EVIL** the moon was, so I took some time to re-think the gameplay loop without touching too much of the terrain. It's still a bit evil and worthy challenge, but a bit less... whatever it was. I hope you like it!*

* Now features: **Flooded** that changes the gameplay loop in a way that makes sense for this moon.
* Revamped the layout for a smoother gameplay experience.
* Reworked how the midday event works.
* Made several changes on how the mortar works, now it should feel a bit less oppresive.
* Moved main closer to the ship.
* Added a new rare scrap spawn.
* Foggy weather now correctly affect the whole playable area.

### Kiri

* Main entrance now has a wooden SFX instead of the metal one.
* Redone the "slight snow" particle effect.
* The "slight snow" particle effect will not be there when the weather is Rainy/Stormy/Forsaken (Wesley's Weathers)
* Now features a new ambience track.
* Added some emmissive textures to the main building's windows.
* Fixed doors not opening from the interior side.

### Manuland

* Main entrance now has a wooden SFX instead of the metal one.
* Foggy weather now correctly affects the whole playable area.
* Added some tasteful grass around.
* Fixed doors not opening from the interior side.
* Reduced filesize.

### Dejection

* Properly added different footsteps sounds.
* Changed the size of some trees.
* Fixed the ambiance tracks having a bit of doppler effect.
* Tweaked colliders on some sections of the map for them to feel a bit less evil.
* Added some off-mesh links
* Reorganized AI node placements and rebalanced exterior.
* Changed a couple stretched textures.
* Increased route price to 300.
* Tied legacy story content to the Taldor Saga config.

### Taldor

- Completely overhauled from the ground up to be closer to the what I envisioned when I started making moons. 

*I was really scared of doing this since some people has grown fond of Taldor as it was, but I think now, after a year of learning, it was the perfect time to do it. I tried to convey the feeling and concept of the Taldor we all know and love into this update. I hope you all like this new version of my very first moon and that it grows on you like the old version did. But worry not, the old version is not dead, it will live on in the Taldor Saga pack and as a standalone release.*

### Subsidence (Legacy Taldor)

* Fixed and re-worded the screen text next to the main entrance.
* Added a tiny fancy light on that terminal.
* Added custom sand footsteps.
* Changed skybox.
* Fixed the sun changing to a blue color when stormy.
* Tied legacy story content to the Taldor Saga config.

*Note: Subsidence is not part of this pack anymore since it's considered legacy content, this will be the last major content update this moon will receive, any fixes will be reflected on the moon's standalone release changelog.*

### Ascension

* Tweaked the ground fog.
* Increased route price to 600.
* Tied legacy story content to the Taldor Saga config.
* Reduced filesize.

### Hollowed

* Tweaked some off-mesh links.
* Changed tree materials slightly.

### Lua

* Now features a new ambience tracks.
* Tweaked skybox slightly for it to be centered.
* Optimized some colliders.
* Reduced filesize
* Fixed some objects not having collission.

### Kiln

* Fixed networked prefabs not being registered properly.
* Changed the a bit the outside/inside graphical ambience, now features heatwaves! (Thanks Skelaah!)
* Tweaked the particles for the valves.
* Now has weights for Generic's storehouse.

### Nostalgia

* Fixed one of the outside spawners not working.
* Added a tiny new hazard to this moon.

### Thrive

* The waterfall next to the ship should now be heard from a logical distance.
* Completely changed all of the trees with new custom trees specifically made for thrive (Thank you Beanie).
* Tweaked the day-night lighting a bit.

### Taldor Saga

* Replaced CustomStoryLogs with LLL's logs to future proof it. (This means any logs gathered in the middle of a save will be reset, sorry)
* Tweaked the content and writting in some of the logs.
* Taldor was change into Subsidence to ensure the legacy experience of the pack.
* The "Taldor Suit" was removed from the pack, as it will feature in a separate optional suits/cosmetics pack.
* Added a "Taldor Saga" config (on by default in the "Taldor Saga" moonpack) to deactivate all of the legacy story related content.

<sub>Note: This config's purpose is mainly for me to have more control over the content in the main pack without compromising this pack, if you're playing the Taldor Saga I suggest to not deactivate it.</sub>

* Updated dependencies.

## 1.5.10

### Allure (Pack only)

* Fixed apparatus disappearing after re-routing / re-opening a savefile



## 1.5.9

### Manuland \& Kiln

* Fixed Networked objects not being visible by the clients (No more ghost manuls in the manor)



## 1.5.8

Shameful README update

## 1.5.7

### All moons

* Added diffusion profiles to missing moons

### Thrive

* Reduced filesize

### Manuland

* Manul rotation engaged



## 1.5.6

### Taldor

* Lowered the water trigger to better match the water.
* Removed the pink glow on the water

### Hollowed

* Now the desaturation is only active outside
* Lowered the exposure so the lights inside the ship won't feel as blinding



## 1.5.5

### All Moons

* (HOPEFULLY) Fixed custom items and spawnable objects having weird behaviour on LCVR. (If it is still broken, i'll tackle this issue at a later date since it is not a priority of mine right now)
* Tweaked the moons with new foliage for them to be less floaty and more grounded.
* Added new ship navmeshes that vanilla ship have.

### Taldor

* Reduced the tilt even more again.

### Thrive

* Fixed a lighting issue when transitioning from day to night.

### Row

* The fan will not push you out of a vehicle anymore BUT the wind may push the vehicle. Drive carefully!
* Tweaked some pipes placements.
* It should be easier to climb certain rocks.
* Moved one of the fire exits closer to the ship.

### Dejection

* Tiny graphical overhaul.

### Nostalgia

* Fixed the sky doing a flash-bang when switchig to the nighttime sky

## 1.5.4

### Taldor

* Reduced the interior tilt, since it made some stairs inaccesible.

## 1.5.3

### Thrive

* (Hopefully) Fixed worms throwing log errors when they touched some decoration.
* Added the LogTranslator.
* Tweaked some parts of the terrain where you could get easily stuck.
* Rebalanced monster spawn curves
* Updated difficulty level from S to S+
* Fixed some parts of the navmesh generating inside buildings.
* Restored the Sun (I forgot it was not there!)
* Fixed some out of bounds trees to not allow Feiopars to jump to them.

### Manuland

* Fixed the global volume not having proper diffusion profiles.

## 1.5.2

### All moons

* Added OpenXR Compatibility (LCVR)
* Updated READMEs for parity between them

## 1.5.1

* Fixed Readme's images

### Thrive

* Tweaked balancing

## 1.5.0 - One with Nature

### New Moon added: 154-Thrive

### All moons

* Fixed Fire Exits making you look to the left when exiting them
* Updated a number of plants with a vanilla-like shader for parity (No new plants were added)
* Tweaked the Sun on most of the moons for it to not cull

## 1.4.15

* Fixed "2 Luas" appearing on the terminal

## 1.4.14

### All moons

* Fixed AudioReverb errors due to missing references

### Kiln

* Fixed pipes event not working.
* Fixed interior embers not spawning.

### Taldor

* Reduced one of the ambience radius that could be heard in the interior.

### Manuland

* Fixed interior manuls not spawning.

## 1.4.13 (v80 Update)

### All moons

* All moons have been re-built on V80, thus making them **not compatible with earlier versions**.
* Changed entrance doors to have them animated, like in vanilla.
* Added some of the new types of navmesh (like water) so there's better interaction with newer content.
* Rebalanced moons, including some of the new enemies on moons where they'd fit.
* Added different fog colors for "Foggy" weather in moons that support it, like in vanilla.
* Optimized sounds and ambiance files for a couple of moons (made the file smaller, fixed loops...).
* Added new ambiance sounds to several moons.
* Added some misc stuff to some moons.

### Ascension

* Changed the main entrance to be closer, making the way a bit shorter.
* Tweaked the elevator animation to start a bit faster going up and going down.
* Added a new fire exit.
* Tweaked the balance around these changes.

### Taldor

* Made the interior slightly more tilted so it is more noticeable.

### Lua

* Tweaked some NavMeshes so OldBirds would not get where they shouldn't.
* Rearranged landing zone to be a bit more cruiser friendly.
* Added a couple of containers around the surface to help avoid OldBirds when coming back from fire exits.

## 1.4.12

* Updated dependencies (April fool's over)

## 1.4.11

* Added AAACompany as a dependency, since its value brings the feel of a 69.99$ game to this moonpack
* (This is not a v80 update)
* Fixed readme

## 1.4.9

### Kiln

* Tweaked the lava material and emissive
* Tweaked moon's prefab material to be way less "shiny"
* Tweaked some pipes so they wont go through the cruiser when attached to the ship

### Lua

* Reduced the distance where certain fog walls render

### Row

* Tweaked the ground fog, so the foggy weather wouldn't cut at certain parts of the moon

### Allure

* Optimized and added new LODs
* Tweaked some lights
* Fixed navmesh around the Lighthouse and bridge

### Dejection

* Changed the skybox and overall daytime lighting because of it
* Tweaked outside power balance

### Manuland

* Added *Valley* and *Mansion* content tags
* Optimized some lights and volumetrics
* Tweaked enemy curves

## 1.4.8

### All moons

* Fixed Log Translators not logging properly

## 1.4.7

### General/Misc

* Added a new discord server link for my mods + general stuff.
* Added Log Translators to all moons (Wesley's Moons compatibility)

### All moons

* Scrap and interior rebalance on most "difficult" moons, they should now be a bit more rewarding for their difficulty, because of this some difficult moons have been also rebalanced in difficulty.
* Fixed custom scrap from certain moons to not have the correct weights.

### Taldor

* Fixed navmesh around the ship

### Allure

* Added some details
* Moved the positions and intensities of certain lights to avoid some confusion on the pathing
* Updated volumetrics for overcast weathers (eg Stormy or Rainy)
* Fixed the appy room's door to not be synced between clients when opened from the inside

### Ascension \& Dejection

* Updated route prices to balance the risk-reward and be on par with other moons
* Dejection's fog has been tweaked a bit.
* Ascension's skybox has been updated.

### Taldor Saga Moons

* Updated icons to be on par with other moons

## 1.4.6

### Allure

* Actually fixed the appy disappearing after reload

## 1.4.5

### Allure

* Fixed the custom appy disappearing after reload

## 1.4.4

### Manuland

* Fixed the ticked windows disappearing after last update

## 1.4.3 (patch of shame)

* Deleted a placeholder moon that was mistakenly bundled with the files

## 1.4.2

### Allure

* Tweaked dungeon size and inside/outside power
* Fixed the grey door trigger not properly teleporting the player

## 1.4.1

* Updated Allure to 1.0.1

## 1.4.0

* Added a new moon: 72 Allure
* Improved foilage textures on all of the moons
* Updated Lua to 1.1.3
* Updated Manuland to 1.0.3
* Fixed custom scrap not spawning on the moons

## 1.3.2

* Updated Manuland to 1.0.1
* Updated Nostalgia to 1.2.3

## 1.3.1

* Updated Kiri to 1.1.10
* Updated Nostalgia to 1.2.2

## 1.3.0

* Added a new moon: 25 Manuland
* Updated Kiri to 1.1.9
* Updated Taldor to 1.5.4
* Updated Kiln to 1.0.8
* Updated Nostalgia to 1.2.1
* Updated Dejection to 1.2.3
* Updated Lua to 1.1.2
* Updated Hollowed to 1.0.4
* Updated Ascension to 1.3.3
* Updated Row to 1.1.7

## 1.2.10

* Updated Kiri to 1.1.8

## 1.2.9

* Updated Row to 1.1.6
* Updated Kiri to 1.1.7
* Updated Taldor to 1.5.3

## 1.2.8

* Updated Taldor to 1.5.2

## 1.2.7

* Updated Kiri to 1.1.6

## 1.2.6

* Updated Ascension to 1.3.2

## 1.2.5

* Updated Row to 1.1.5

## 1.2.4

* Updated Hollowed to 1.0.3

## 1.2.3

* Updated Kiln to 1.0.7
* Updated Hollowed to 1.0.2

## 1.2.2

* Updated Nostalgia to 1.2.0

## 1.2.1

* Updated Hollowed to 1.0.1
* Fixed README

## 1.2.0

* Added a new moon: 164 Hollowed
* Updared Kiln to 1.0.6
* Updated Kiri to 1.1.5
* Updated Dejection to 1.2.2
* Updated Ascension to 1.3.1

## 1.1.12

* Updated Nostalgia to 1.1.5

## 1.1.11

* Updated Row to 1.1.4

## 1.1.10

* Updated Kiln to 1.0.6 (shame on me)

## 1.1.9

* Updated Kiln to 1.0.5
* Updated Nostalgia to 1.1.4

## 1.1.8

* Updated Kiln to 1.0.4

## 1.1.7

* Updated Row to 1.1.3

## 1.1.6

* Updated Nostalgia to 1.1.3

## 1.1.5

* Updated Row to 1.1.2

## 1.1.4

* Updated Nostalgia to 1.1.2

## 1.1.3

* Updated Kiln to 1.0.3

## 1.1.2

* Updated Kiln to 1.0.2

## 1.1.1

* Updated Kiln to 1.0.1
* And the excuse to do a shameful readme update

## 1.1.0

* Added a new moon: 113-Kiln
* Updated Kiri to 1.1.4
* Updated Taldor to 1.5.2

## 1.0.5

* Updated Row to 1.1.1

## 1.0.4

* Updated Kiri to 1.1.3

## 1.0.3

* Updated Dejection to 1.2.1

## 1.0.2

* Updated Kiri to 1.1.2

## 1.0.1

* Updated Nostalgia to 1.1.1

## 1.0.0

* First Release

