# PizzaProbability

> **NOTE:** This is a reupload of [PizzaProbability](https://thunderstore.io/c/lethal-company/p/TrippyTree/PizzaProbability/) updated for the newest version of the facility meltdown. This package will be deprecated the moment an update for PizzaProbability and released.

PizzaProbability is a simple mod that adds chance to the [FacilityMeltdown](https://thunderstore.io/c/lethal-company/p/loaforc/FacilityMeltdown/) mod.

With PizzaProbability, a meltdown is no longer guaranteed to occur when the apparatus is pulled.

By default, there is a 50% chance that pulling the apparatus will result in a meltdown.

All values can be configured globally or per moon. Likewise, you can disable meltdown entirely for specific moons.

## Apparatus Value
PizzaProbability adjusts the apparatus value based on meltdown occurrence.

To encourage removal, a safe apparatus is worth between 1-3x its original value. However, an unsafe apparatus is worth 2-4x its original value.

## Escape Music
PizzaProbability also improves interoperability between [FacilityMeltdown](https://thunderstore.io/c/lethal-company/p/loaforc/FacilityMeltdown/) and [PizzaTowerEscapeMusic](https://thunderstore.io/c/lethal-company/p/BGN/PizzaTowerEscapeMusic/).

- [PizzaTowerEscapeMusic](https://thunderstore.io/c/lethal-company/p/BGN/PizzaTowerEscapeMusic/) was not created with meltdown chance in mind.
- Consequently, escape music plays every time the apparatus is pulled, even if a meltdown doesn’t occur.
- **PizzaProbability patches [PizzaTowerEscapeMusic](https://thunderstore.io/c/lethal-company/p/BGN/PizzaTowerEscapeMusic/) to fix this behavior.**

To enable escape music, you must install [PizzaTowerEscapeMusic](https://thunderstore.io/c/lethal-company/p/BGN/PizzaTowerEscapeMusic/). PizzaProbability does not provide escape music on its own.

Please note that [PizzaTowerEscapeMusic](https://thunderstore.io/c/lethal-company/p/BGN/PizzaTowerEscapeMusic/) doesn't provide meltdown music by default. To enable it, add `,Meltdown` to `Scripts` in [PTEM](https://thunderstore.io/c/lethal-company/p/BGN/PizzaTowerEscapeMusic/)'s config.

\[bgn.pizzatowerescapemusic.cfg\]\
`Scripts = Default,Meltdown`

## Extra Music
Considering Zeekerss’ roots in ROBLOX content creation, I couldn’t pass up the opportunity to add escape music from 2 popular (albeit unrelated) ROBLOX games. This music can be enabled by using the optional `Meltdown` script for [PizzaTowerEscapeMusic](https://thunderstore.io/c/lethal-company/p/BGN/PizzaTowerEscapeMusic/). This music only plays under very specific criteria, but if you’d prefer not to hear it, you can use the `MeltdownAlt` script instead.

PizzaProbability also adds 2 additional tracks from Pizza Tower and 3 additional tracks from The Noise Update.

See the **Escape Music** section above to learn how to enable one of these scripts.

- Tsunami (Jay Cosmic Remix) – featured in Pinewood Computer Core. `Meltdown` `Meltdown++` `MeltdownTsmi` `DefaultTsmi`
- The Opened Way (Shadow of the Colossus) – featured in Flood Escape. `Meltdown` `Meltdown++` `MeltdownSotC`
- Unexpectancy (Part 3 of 3) – featured in Pizza Tower. `Default+` `Meltdown+` `Meltdown++`
- Pizza Time Never Ends!! – featured in Pizza Tower. `Default+` `Meltdown+` `Meltdown++`
- Distasteful Anchovi – featured in Pizza Tower (The Noise Update). `Default+` `Meltdown+` `Meltdown++`
- World Wide Noise – featured in Pizza Tower (The Noise Update). `Default+` `Meltdown+` `Meltdown++`
- I Need A Noise – featured in Pizza Tower (The Noise Update). `Default+` `Meltdown+` `Meltdown++`

Credit goes to the U.M.I YouTube channel for their [meltdown music template & tutorial](https://www.youtube.com/watch?v=D5hKkSLlEhk).

## Extra Scripts

Please read the **Escape Music** and **Extra Music** sections above before proceeding to this section.

Only one `Default` script can be enabled. Likewise, only one `Meltdown` script can enabled. One `Default` script MUST be enabled.

For the best experience, I recommend using `Default+` and `Meltdown++`.

\[bgn.pizzatowerescapemusic.cfg\]\
`Scripts = Default+,Meltdown++`

### `DefaultOff`
- An alternative to [PTEM](https://thunderstore.io/c/lethal-company/p/BGN/PizzaTowerEscapeMusic/)'s `Default` script.
- When paired with any `Meltdown` script, escape music only plays during a meltdown event.
- Use this script when you don't want escape music to occur when players vote to leave.

### `Default+`
- An enhanced alternative to [PTEM](https://thunderstore.io/c/lethal-company/p/BGN/PizzaTowerEscapeMusic/)'s `Default` script.
- Unlike [PTEM](https://thunderstore.io/c/lethal-company/p/BGN/PizzaTowerEscapeMusic/)'s `Default` script, all players hear the same music. There is no RNG.
- Selects music based on moon, weather conditions and time of day.
- Includes 5 extra music tracks from Pizza Tower and The Noise Update.

### `Meltdown`
- An improved alternative to [PTEM](https://thunderstore.io/c/lethal-company/p/BGN/PizzaTowerEscapeMusic/)'s `Apparatus` script.
- Selects music similarly to [PTEM](https://thunderstore.io/c/lethal-company/p/BGN/PizzaTowerEscapeMusic/)'s `Default` script.
- Includes meltdown sound effects.
- Includes 2 extra music tracks inspired by ROBLOX that play under very specific criteria.

### `Meltdown++`
- Similar to the `Meltdown` script listed above.
- Includes the enhancements and extra music tracks provided in the `Default+` script.

**Other Scripts**

- `MeltdownAlt` Identical to the `Meltdown` script listed above. Excludes the 2 ROBLOX inspired music tracks.
- `Meltdown+` Identical to the `Meltdown++` script listed above. Excludes the 2 ROBLOX inspired music tracks.
- `DefaultTsmi` An alternative to [PTEM](https://thunderstore.io/c/lethal-company/p/BGN/PizzaTowerEscapeMusic/)'s `Default` script that only plays Tsunami (Jay Cosmic Remix).
- `MeltdownTsmi` An alternative to the `Meltdown` script that only plays Tsunami (Jay Cosmic Remix).
- `MeltdownSotC` An alternative to the `Meltdown` script that only plays The Opened Way (Shadow of the Colossus).

## Troubleshooting

Out of respect for the developer of [FacilityMeltdown](https://thunderstore.io/c/lethal-company/p/loaforc/FacilityMeltdown/), please do not bring issues to them until you've verified that the issue(s) are not caused by PizzaProbability. Please extend this respect to the developer of [PizzaTowerEscapeMusic](https://thunderstore.io/c/lethal-company/p/BGN/PizzaTowerEscapeMusic/) as well.

If [FacilityMeltdown](https://thunderstore.io/c/lethal-company/p/loaforc/FacilityMeltdown/) or [PizzaTowerEscapeMusic](https://thunderstore.io/c/lethal-company/p/BGN/PizzaTowerEscapeMusic/) updates, it's very possible that PizzaProbability could need an update as well.

Please be patient as I'm not a developer. PizzaProbability was originally made for personal use.

If you run into issues, you can use [this form](https://forms.gle/oXMJ9UGu2scHqLzM8) to contact me.