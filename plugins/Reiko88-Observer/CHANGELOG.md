## 1.0.0

* Initial release

## 1.0.1

* README formatting

## 1.0.2

FEATURES

* Made scrap anger threshold customisable in config
* Made the global siren volume customisable in config

BUG FIXES

* Fixed an issue where enemy could be killed in dormant state before first chase
* Fixed a bug that disabled the chasers ability to call up the elevator on mineshaft interior
* Updated the descriptions in the config
* Scrap listener now updates out of chase so target player can be switched
* Fixed a bug where the chaser couldn't be killed with high damage weapons such as the shotgun
* Fixed an issue where changing spawn weights on moons wouldn't work

ADJUSTMENTS

* Decreased intensity of Spectre light
* Lowered volume of siren slightly
* Increased detection trigger for chase sequence
* Increased chaser turn rate to make chase animation smoother
* Reduced some logging clutter

Bug report and feature suggestion credits! from modding discord:
@giganticevan @medical @Quanez @Auto cone @Mr.SaltedBeef @Dedicate.



## 2.0.0



**FEATURES/IMROVEMENTS:**



* Multiple chasers can now spawn during a day with one Observer acting as their 'puppet master'
* Moved from LethalLib to DawnLib to support future updates
* Now VR compatible



**Observer spectre:**

* Revamped appearance - detailed base texture, normal maps and emissions
* Observer Speakers - The spectre now has speakers attached to it's front

  * The air raid SFX are played from these speakers instead of an invisible one
  * The spectre will randomly play haunting sound effects. These are supposed to represent the recordings the observer has witnessed/heard throughout it's existence
  * The random SFX sometimes contain the Observer's voice that has been corrupted and instead is used to lure/taunt players
* New VFX (thanks to jon4reZ)

  * New smoke cloud VFX that doesn't clip through the cloak of the observer spectre.
  * New air raid sound VFX that cause nearby players screens to shake a little.
* New air raid animations
* New powering up and down animations
* Lowered pitch of air raid to avoid people being falsely copyright flagged
* Now doesn't disappear during air raid, instead 'powers down'



**Chasers:**

* Added new chaser models/appearances

  * Bracken Chaser **-** Employee who had neck snapped by bracken, with bullet wounds
  * Cadaver Chaser **-** Employee who died to a cadaver infestation
* Chasers have unique 'dead' poses depending on appearance

  * Fallen onto knees
  * Twisted limbs
  * Led on back
* Reduced height of chasers
* Improved current animations

  * improved running animation
  * improved stab/hit animation to support two handed weapons
* Chasers can now use different weapons with new animations to match

  * Shovel
  * Yield sign
  * Stop sign
* Chasers can now drop different items depending on what they are using (e.g. drops shovel when attacking with one)
* New SFX for the chasers voice and death
* New reanimation VFX (thanks to jon4rez)
* Chasers can now break into the ship when the door is closed similar to the giant sapsucker



**BUG FIXES:**

* fixed a bug where the chaser would run through the ship door
* fixed an issue where the chaser was avoidable by walking in circles
* fixed a bug where there was a lag stutter as the air raid started
* fixed a bug where players could kill the chaser when not in chasing state
* fixed a bug where chaser movement could be de-synced for non-host
* fixed a visual bug where chaser weapon would clip into floor when dormant
* fixed a bug where the stun length for the chaser was very long

