![Football Image](https://i.imgur.com/HGMqQkE.png)

### This mod adds [Football from mazingDOG Comics](https://www.webtoons.com/en/canvas/mazingdog-comics/list?title_no=720821) as an entity in Lethal Company.

- She wants to play **Simon Says**.
- Just do as she says.
- New scrap item: **Toy Train**.

> ### IMPORTANT NOTICE: AI generated content of this mod is not allowed.
> Any AI-generated art, descriptions, or related content involving this character and other mazingDOG's creations is **strictly prohibited**.

## CREDITS
- Original Character by [**MazingSand**](https://www.webtoons.com/en/creator/283s9)
- Programming by [**Kittenji**](https://www.twitch.tv/kittenji)
- 3D Modeling by [**Puck**](https://www.fiverr.com/s/93KNbe)
- Mod created in collaboration with [**WireAddict**](https://twitter.com/wireaddicts) for his friend [MazingSand](https://www.webtoons.com/en/creator/283s9)

### Language

| Language | Key | Voice Actor | Translator |
|----------|-----|-------------|------------|
| English* | `en` | [**Shishishiena**](https://www.fiverr.com/s/zgkzQz) | Kittenji |
| Spanish  | `es` | [**Gullny**](https://youtube.com/@gullny2250) | Kittenji |
| French   | `fr` | **Lunadrico** | **Aserikor** |

> Unfortunately, I am not taking translations for this mod as for now, I am too busy with work and real life things.

### Music Attribution

| Title | Author |
|-------|--------|
| LSDJ Shop | Kittenji (Me) |
| [Opia](https://shirobon.bandcamp.com/track/opia) | [Shirobon](https://linktr.ee/shirobon) |
| [On The Run](https://shirobon.bandcamp.com/track/on-the-run) | [Shirobon](https://linktr.ee/shirobon) |
| [Shibuya](https://shirobon.bandcamp.com/track/shibuya-2) | [Shirobon](https://linktr.ee/shirobon) |
| [Chiptuna](https://shirobon.bandcamp.com/track/chiptuna) | [Shirobon](https://linktr.ee/shirobon) |
| [This Love](https://shirobon.bandcamp.com/track/this-love) | [Shirobon](https://linktr.ee/shirobon) |
| [Fight for You](https://shirobon.bandcamp.com/track/fight-for-you) | [Shirobon](https://linktr.ee/shirobon) |
| [Pure](https://shirobon.bandcamp.com/track/pure) | [Shirobon](https://linktr.ee/shirobon) |
| [My First LSDJ](https://soundcloud.com/derris-kharlan/my-first-lsdj) | [Derris-Kharlan](https://soundcloud.com/derris-kharlan) |
| [Love Is Insecurable Remix](https://youtu.be/nM3QwNDSvbo) | [FLIPPENDO](https://youtube.com/@flippendo_chiptune) |
| [paranoia](https://youtu.be/VgrnEVnZ4xU) | [KENTENSHI](https://linktr.ee/kentenshii) |
| Blip Shards (DS-10) | Jredd |
| Vex | Lunar Synthetic |


## SUPPORT
Join the [**LC Modding**](https://discord.gg/XeyYqRdRGC) server to report bugs or incompatibilities on the **Football Entity** thread under `#mod-releases`


<details><summary>Available Config Variables</summary>

| Settings | Value Type | Default Value | Description | Acceptable Values |
|-|-|-|-|-|
| **General** | - | - | - | - |
| `Language Key` | `String` | `en` | Changes the language for the displayed messages and voice. | `en` `es` `fr` |
| `Streamer Mode` | `Boolean` | `False` | Disables the playable music in this mod with an 8Bit version of the Drop Ship store song. | - |
| **Spawn Rarity Per Risk Level** | - | - | - | - |
| `Risk Level D` | `Int32` | `3` | Spawn rarity for moons with a Risk Level of 'D' | - |
| `Risk Level C` | `Int32` | `4` | Spawn rarity for moons with a Risk Level of 'C' | - |
| `Risk Level B` | `Int32` | `6` | Spawn rarity for moons with a Risk Level of 'B' | - |
| `Risk Level A` | `Int32` | `12` | Spawn rarity for moons with a Risk Level of 'A' | - |
| `Risk Level S` | `Int32` | `24` | Spawn rarity for moons with a Risk Level of 'S' | - |
| `Risk Level S+` | `Int32` | `30` | Spawn rarity for moons with a Risk Level of 'S+' | - |
| `Risk Level SSS` | `Int32` | `40` | Spawn rarity for modded moons with a Risk Level of 'SSS'. | - |
| `Risk Level Other` | `Int32` | `18` | Spawn rarity for moons with an unkown Risk Level or any other Risk Level. | - |

</details>


## CHANGELOG

- **v1.1.14**
    - Recompiled for v81

- **v1.1.13**
    - Fixed support for v73

- **v1.1.12**
    - Fixed entity not being able to initiate interaction when inside the ship sometimes.
    - Improved v70 compatibility.

- **v1.1.10**
    - Fixed some broken assets on the UI.
- **v1.1.9**
    - Recompiled for version 64.
    - Entity will be destroyed if navigation nodes do not exist on the map.

- **v1.1.8**
    - Recompiled for version 56.
    - This patch attempts to fix an issue with walking animations not playing correctly in some cases. If the issue still persist, another mod is creating this behaviour.

- **v1.1.7**
    - Fixed an issue that prevented Football from choosing another target after winning.

- **v1.1.6**
    - Improved v50 compatibility.
    - Reworked the "Don't Speak" action. This hopefully fixes an issue during validation and should work properly.

<details>
  <summary>Older Versions</summary>

- **v1.1.5**
    - Added **French** language support contribution. Translated by **Aserikor**, voice provided by **Lunadrico**

- **v1.1.4**
    - Fixed songs unexpectedly playing after entity spawn on target player.

- **v1.1.3**
    - Added full **Spanish** voice lines and translation. Voice actor: [**Gullny**](https://youtube.com/@gullny2250)
    - Fixed entity sometimes being visible on spectator view.

- **v1.1.2**
    - Fixed a minor problem with the ship's lever.
    - Added full support for LethalConfig.
    - Added a button in LethalConfig to preview the voice for the currently selected language.

- **v1.1.1**
    - Adjusted the rarity of some Simon Says events.
    - Fixed minor AI navigation problem.
    - Attempted to make player switching more consistent.
    - If she targets you again after winning, you have 30 seconds of peace.

- **v1.1.0**
    - Implemented multi language support. At the moment, you can just switch the display text from English to Spanish using the config. I plan to make this more accessible for everyone, for now I haven't found a Spanish voice actor willing to contribute.
        > Contact me on the discord if you want to add support for your language...
    - Spectators can now **listen** to the orders the haunted player is receiving.
    - You can now use text chat for "Don't Speak".
    - Request new target if current haunted player wins the Simon Says event.
    - Excluded shotgun from a Simon Says check. (Was too overpowered)
    - Every time that you win Simon Says, it will increase the task count by one for next time (Only on current moon landing).
    - Fixed "Don't Move" action failing when using BadAssCompany.

- **v1.0.0**
    - Initial Release, have fun!
    - Added compatibility with CustomEmotesAPI (BadAssCompany, TF2Emotes and other dependants)

</details>