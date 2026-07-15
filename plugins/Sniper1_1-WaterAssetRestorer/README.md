
# WaterAssetRestorer
Moon and interior devs are likely familiar with how poorly the water assets rip when trying to design their levels. I made this tool to attempt to restore some at runtime. ([My thread in the LC Modding Discord](https://discord.com/channels/1168655651455639582/1245084720614604873))

This mod works by searching through a moon after it is loaded to replace the following material names, so all you need to do is ensure your water material names match one of the ones listed below. It'll be broken in your project but assuming the name can be matched, it'll be replaced in-game.
| Mat name | description |
|----------|-------------|
| Flooded&GordionWater | The water on Gordion/flooded weather |
| PoolWater | The water in the mansion pool tile |
| CaveWater | The water in the cave water tile |
| MarchWater | The water on March |
| VowWater | The water on vow |

---

### Before 

![Without](https://imgur.com/Z06aUeJ.png)

### After 

![with](https://imgur.com/FLS6tVR.png)

## Credits

- The developers of this mod's dependencies as it literally could not exist without them.
- [Audio Knight](https://www.youtube.com/@knightofaudio) on YouTube for a handy starting tutorial.
- [Nomnomab's project patcher](https://github.com/nomnomab/lc-project-patcher) to access vanilla LC through Unity.
- Debugging tools like [Imperium](https://thunderstore.io/c/lethal-company/p/giosuel/Imperium/) and [UnityExplorer](https://thunderstore.io/c/lethal-company/p/LethalCompanyModding/Yukieji_UnityExplorer/).
- Thunderstore for hosting this mod as I wouldn't know how to distribute without it.