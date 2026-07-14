# Changelog

## 2.2.1 -  2026/7/5



- Lowered the nav-mesh blocker to not overlap with the nav-mesh in the bed

## 2.2.0 -  2026/7/4



- Adjusted the door triggers to match the size of the door
- Fixed the car bouncing around due to a low friction material
- Fixed radio font
- Adjusted steering speed
- Removed momentum calculation from the auto-centering steering
- Lowered hop force slightly
- Lowered center of mass slightly

## 2.1.9 -  2026/7/4



- Removed redundant code in the physics region logic

## 2.1.8 -  2026/7/4



- Hopefully fixed an issue where you would be unable to interact with a seat if you tried interacting with an occupied seat

## 2.1.7 - 2026/7/03



- Fixed a bug with the player zone

## 2.1.6 - 2026/6/28



- Added missing soft deps for LethalMin and ImmersiveVisor

## 2.1.5 - 2026/6/28



- Added keybinds for the gas, brake, jump, etc

## 2.1.4 - 2026/6/27



- Audio adjustments and general polish
- Fixed an issue when using CruiserTunes
- Adjusted radio behaviour

## 2.1.3 - 2026/6/24



- More physics region adjustments, ack, sorry
- Minor model adjustments and fixes
- Fixed changelog version

## 2.1.2 - 2026/6/23



- Another re-write for the physics regions, meow

## 2.1.1 - 2026/6/23



- Hopefully fixed the stupid fucking physics region bug I am so fucking sick and tired of this shit that keeps breaking
- Fixed the Hauler having broken jump force, woops

## 2.1.0 - 2026/6/20



- The JLL-Blower fan component can no longer push the player if enclosed inside of the vehicle (like with Gusty Weather)
- The pickup will now save you while entering orbit if you are on or inside of it, this was due to backwards logic, likely from me copying some stuff over from the Version55 Company Cruiser

## 2.0.9 - 2026/6/20



- Hopefully fixed some fuck-ass issues with the physics regions
- Fixed pickup being on the wrong side of the magnet for clients
- The pickup is now muted while in orbit

## 2.0.8 - 2026/6/16



- Fixed an issue with the roof-rain audio continuing when it shouldn't. Hopefully
- The car can no longer kill the kidnapper-fox, but can now kill other 'small' enemies
- Added an auto-centering config for the wheel like the ScanVan, the vehicle must be moving and the center speed is dependant on vehicle velocity

## 2.0.7 - 2026/5/31



- Fixed player zones not syncing properly

## 2.0.6 - 2026/5/30



- Actually fixed a desync with the hood

## 2.0.5 - 2026/5/29



- Fixed a potential desync with the hood

## 2.0.4 - 2026/5/29



- Fixed ignition animation being uncancellable

## 2.0.3 - 2026/5/28



- Hopefully fixed the stupid fucking ignition animation this fucking time I'm so sick of this

## 2.0.2 - 2026/5/28

- Fixed windshield-wiper animation clipping through the windshield

## 2.0.1 - 2026/5/28

- Fixed false-advertisement pricing
- Fixed culling mask on the side-mirrors

## 2.0.0 - 2026/5/27

Hello, ScandalTheVandal hi-jacking this message.
After months of work, this is a labour of love, and I hope you guys enjoy this =)

- Updated for v81+
- Completely overHAULed the entire pickup.
   - This includes new animations, an improved model, various fixes, tons of code re-write, much improved physics, and much more!

## 1.1.2 - 2026/2/8

- Added sittable 5th seat between the two rear ones, great for MoreCompany
- Chime for driving away with one of the side doors open
- Fixed manual
- Fix key mesh being the wrong mesh

## 1.1.1 - 2026/2/1

- Fixed issue causing hauler to permanently break when loading a save with one magneted to ship
- Removed redundant patch files
- Fixed issues caused by modded damage triggers

## 1.1.0 - 2026/1/31

- Undeprecated
 - Finally fixed out-of-date networking problems relating to v73 unity version change, which solves issues such as back seats causing the car to fly
- Implemented multiple QOL stuffs with the assistance of ScandalTheVandal:
 - Protect seated players from getting hit by the giant kiwi bird
 - Protect seated players from getting bit by mouthdogs
 - Protect seated players from getting grabbed by radmechs
 - Fix visual issues caused by vanilla interactable objects that messed with animations
 - Improve network syncying for various things, including car health & wheel speed
 - Better collision
 - Mute audio in orbit
 - Wheel physics improvements
 - Hauler no longer passively heals while in orbit
 - Some other things

 In addition, Scandal is now a maintainer of the project and is currently working on a major overHaul.

## 1.0.5 - 2025/8/22

- (Probably) fixed instability at high angular velocity causing the vehicle to fly off
- Removed extra wheel colliders causing instability
- Added collider to prevent the giant bird from erroring

## 1.0.4 - 2025/8/3

- Raised the vertical driver camera position component to better allow you to see over the hood
  - *Note: this makes the sunroof button a little harder to see. Not interested in changing the whole vehicle mesh for this right now though.*
- Added a config for vehicle health, changed default health from 200->100
  - *This stat only reflects small amounts damage. If you drive into a wall at full speed, you will always explode.*
- Fixed being able to trigger the chime sound when not seated in the driver seat
- Removed glare on the windshield
- Increased headlight range, intensity, and width, and angled them toward the ground more
- Added a few more game objects to hide when the vehicle blows up

## 1.0.3 - 2025/7/9

- Quick fix for incorrect giant patch code

## 1.0.2 - 2025/7/9

- Reduced the cost of the hauler 600 -> 530
- Fixed a prefix patch with incorrect logic causing giants to never eat you outside of the car
- Adjusted the front collider zone to *hopefully* improve jank when colliding into seemingly flat surfaces
- Driver override animations are now visible to other clients
- Reduced the texture resolution of the mirrors by half
- Added a config to disable the side mirror rendering (clientside only)
- Fixed Collider layer objects being visible in mirrors

## 1.0.1 - 2025/7/1

- Removed the LobbyCompatibility dependency
- Fixed the license being blank

## 1.0.0 - 2025/6/30

- Feature complete
- Currently, driver animations don't sync to non-drivers. I am trying to fix this, but it may not be possible.
- Traction control light currently only shows for the server host due to an oversight in Cruiser code
