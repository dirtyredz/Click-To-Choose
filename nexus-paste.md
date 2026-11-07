# Click To Choose — Nexus page source

**Nexus page:** not yet published

The description field is **SCEditor with a BBCode source**, so the block below is the literal
value to set. Every paragraph is a single unbroken line, because the editor turns every wrap in a
pasted paragraph into a `<br>`.

Style reference: Moonlight Peaks [15-page-style.md](../../../Moonlight%20Peaks/15-page-style.md). Mechanics:
[13-nexus-page-standard.md](../../../Moonlight%20Peaks/13-nexus-page-standard.md). Copy source: [NEXUS.md](NEXUS.md).

## Other fields

| Field | Value |
|---|---|
| Name | `Click To Choose` - no subtitle, per the standing decision in 13-nexus-page-standard.md |
| Game | Farm Together 2 (domain `farmtogether2`, gameId 7911) |
| Version | 1.0.0 |
| Category | Gameplay - confirm it exists in the Farm Together 2 category list |
| Tags | Quality of Life, User Interface - confirm both exist in the fixed per-game tag list before saving |
| Requirements | BepInEx 6 bleeding edge, Unity IL2CPP (win-x64), build 793 or newer |
| Short description | Hovering a hair style should not change your look. Pick character options with a click, so you can move the mouse and rotate your character freely. |

## Description source

```bbcode
[size=6][color=#F7D994]🖱️  Click To Choose[/color][/size]
[color=#C7A25B][i]Hovering a hair style should not change your look. Pick character options with a click, so you can move the mouse and rotate your character freely.[/i][/color]
[color=#C7A25B]💾 Save-safe  ·  🔧 One Harmony patch  ·  🖱️ Click to apply  ·  🎨 Configurable[/color]
[color=#7A6A9B]────────────────────────────────────────[/color]
[quote]🖱️  [color=#F7D994][b]The promise.[/b][/color] Moving your mouse never changes your look. Only a click does.[/quote]

[size=5][color=#F7D994]🖱️  What it does[/color][/size]
[color=#D4D4D8]In Farm Together 2's character customization, simply moving the mouse over a hair style selects it. So you cannot sweep the mouse across the grid, or over to your character to rotate them, without your look changing underneath you, and the style you actually chose can end up swapped for whichever tile the cursor last crossed.

Click To Choose makes the option tiles apply on click only. Hover still highlights the tile, a click applies it, and rotating your character afterwards leaves your choice alone.

Everything else behaves as it did. Keyboard and gamepad navigation still move through the tiles and preview them the normal way, colour swatches keep the stock hover behaviour, and every other menu is untouched.[/color]

[size=5][color=#F7D994]✨  Main features[/color][/size]
[list]
[*][b]Click to apply[/b] — hair styles and other option tiles on the customization screen apply when you click them, not when you hover
[*][b]Rotate freely[/b] — move the mouse over the character and turn them without the style changing
[*][b]Your choice sticks[/b] — the tile you clicked stays selected
[*][b]Keyboard and gamepad unchanged[/b] — navigating with arrow keys or the d-pad still previews tiles as before
[*][b]Scoped to customization[/b] — shops, settings and other menus keep the game's own behaviour
[*][b]One master switch[/b] — turn it off in the config file to get stock behaviour back
[*][b]Save-safe[/b] — one Harmony patch that decides whether a hover-select runs; nothing is written to your save
[/list]

[size=5][color=#F7D994]📋  Requirements[/color][/size]
[list]
[*][b]BepInEx 6 bleeding edge (Unity IL2CPP, win-x64)[/b], build 793 or newer. Tested with 6.0.0-be.793
[/list]
[color=#D4D4D8]Farm Together 2 is an IL2CPP game, so BepInEx 5 and the Mono builds of BepInEx 6 will not load it. PC/Steam only.[/color]

[size=5][color=#F7D994]📥  Installation[/color][/size]
[b]🟢 With Vortex[/b]
[color=#D4D4D8]Open the Files tab, click the Vortex button, and enable the mod. This needs the Farm Together 2 support extension for Vortex.[/color]

[b]🔧 Manually[/b]
[list=1]
[*]Install [b]BepInEx 6 bleeding edge (Unity IL2CPP, win-x64)[/b] into your Farm Together 2 folder, if you do not have it already. The BepInEx folder sits beside FarmTogether2.exe.
[*]Launch the game once, then quit. This creates the BepInEx/plugins folder.
[*]Download Click To Choose from the Files tab and extract the archive over your Farm Together 2 folder, so the file ends up at BepInEx/plugins/ClickToChoose/ClickToChoose.dll
[*]Launch the game.
[/list]
[color=#D4D4D8]To uninstall, delete BepInEx/plugins/ClickToChoose. Nothing is written to your save, so there is nothing else to clean up.[/color]

[size=5][color=#F7D994]🎛️  Configuration[/color][/size]
[color=#D4D4D8]Settings are written to BepInEx/config/com.dirtyredz.farmtogether2.clicktochoose.cfg on first launch. There are two, and the defaults are meant to be left alone.[/color]
[list]
[*][b]General.Enabled[/b] (default true) — set to false to bring back the game's own hover-selects behaviour
[*][b]General.VerboseLogging[/b] (default false) — logs every suppressed hover-select, for diagnosing problems only
[/list]

[size=5][color=#F7D994]🤝  Compatibility[/color][/size]
[color=#D4D4D8]One Harmony prefix on one method ([i]MilkInputModule.HandlePointerExitAndEnterSelect[/i]), and it only acts when the pointer is over an option tile on a customization screen. It does not touch UI layout, inventory or saves. No known conflicts.[/color]

[size=5][color=#F7D994]💜  Shout outs[/color][/size]
[list]
[*][b]Milkstone Studios[/b], for Farm Together 2 and a farm worth sharing.
[*]The [b]BepInEx[/b] and [b]HarmonyX[/b] teams, without whom none of this scene exists.
[*][b]My Mate[/b], for being my inspiration.
[/list]
```
