## v1.1.1
- Removes Zeekerss v80 check for agent on navemesh which throws and error every frame allowing the code to continue to my patch that prevents errors and handles enemy reloacation and removal.

## v1.1.0
- Now checks if agent is on navmesh and only counts errors when not on nav mesh or links.
- Reasonable has been reduced down to 8 from 16 erros before triggering the kill code.
- Added new option to attempt relocation instead of killing when an enemy errors. This option will search 50 units for a navmesh and will kill if it cannot be found in that range. This is now the default.

## v1.0.0 Release 
- Initial Release