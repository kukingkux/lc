
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