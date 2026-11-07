# Nexus Page Copy

> **Pasting into the upload form? Use [nexus-paste.md](nexus-paste.md), not this file.**
> The copy here is wrapped for reading, and the editor turns every wrap into a `<br>`.
> Style: Moonlight Peaks [15-page-style.md](../../../Moonlight%20Peaks/15-page-style.md). Structure/mechanics:
> [13-nexus-page-standard.md](../../../Moonlight%20Peaks/13-nexus-page-standard.md). Section order:
> [14-description-review.md](../../../Moonlight%20Peaks/14-description-review.md).

Reference copy for the mod page, plus the shot list.

**Name:** Click To Choose (no subtitle)
**Game / domain:** Farm Together 2, Nexus domain `farmtogether2`, gameId 7911
**Version:** 1.0.0 (from the csproj)
**Category:** Gameplay *(assumption: mirrors Form Lock, a behaviour-only quality-of-life mod; confirm it exists in
the Farm Together 2 category list at upload time)*
**Tags:** Quality of Life, User Interface *(assumption: confirm both exist in the fixed per-game tag list before
saving; drop any that do not)*
**Requirements:** BepInEx 6 bleeding edge, Unity IL2CPP (win-x64), build 793 or newer
**Nexus page:** not yet published
**Source:** https://github.com/dirtyredz/Click-To-Choose (MIT)

---

## Summary (one line, shows in listings)

Hovering a hair style should not change your look. Pick character options with a click, so you can move the mouse and rotate your character freely.

---

# Paste-ready page copy

## Title emoji

🖱️ - a mouse cursor, because the whole mod is about what the mouse does and does not do.

## At-a-glance strip

💾 Save-safe  ·  🔧 One Harmony patch  ·  🖱️ Click to apply  ·  🎨 Configurable

## Promise panel

🖱️ **The promise.** Moving your mouse never changes your look. Only a click does.

## Field: What it does

In Farm Together 2's character customization, simply moving the mouse over a hair style selects it. So you cannot sweep the mouse across the grid, or over to your character to rotate them, without your look changing underneath you, and the style you actually chose can end up swapped for whichever tile the cursor last crossed.

Click To Choose makes the option tiles apply on click only. Hover still highlights the tile, a click applies it, and rotating your character afterwards leaves your choice alone.

Everything else behaves as it did. Keyboard and gamepad navigation still move through the tiles and preview them the normal way, colour swatches keep the stock hover behaviour, and every other menu is untouched.

## Field: Main features

- **Click to apply** - hair styles and other option tiles on the customization screen apply when you click them, not when you hover
- **Rotate freely** - move the mouse over the character and turn them without the style changing
- **Your choice sticks** - the tile you clicked stays selected
- **Keyboard and gamepad unchanged** - navigating with arrow keys or the d-pad still previews tiles as before
- **Scoped to customization** - shops, settings and other menus keep the game's own behaviour
- **One master switch** - turn it off in the config file to get stock behaviour back
- **Save-safe** - one Harmony patch that decides whether a hover-select runs; nothing is written to your save

## Field: Requirements

**Required**

- **BepInEx 6 bleeding edge (Unity IL2CPP, win-x64)**, build 793 or newer. Tested with 6.0.0-be.793

Farm Together 2 is an IL2CPP game, so BepInEx 5 and the Mono builds of BepInEx 6 will not load it.

PC/Steam only.

**Compatibility**

One Harmony prefix on one method (MilkInputModule.HandlePointerExitAndEnterSelect), and it only acts when the pointer is over an option tile on a customization screen. It does not touch UI layout, inventory or saves. No known conflicts.

## Field: Installation instructions

**With Vortex**

Open the Files tab, click the Vortex button, and enable the mod. This needs the Farm Together 2 support extension for Vortex.

**Manually**

1. Install **BepInEx 6 bleeding edge (Unity IL2CPP, win-x64)** into your Farm Together 2 folder, if you do not have it already. The BepInEx folder sits beside FarmTogether2.exe.
2. Launch the game once, then quit - this creates the BepInEx/plugins folder.
3. Download Click To Choose from the Files tab and extract the archive **over your Farm Together 2 folder**, so the file ends up at `BepInEx/plugins/ClickToChoose/ClickToChoose.dll`.
4. Launch the game.

To uninstall, delete `BepInEx/plugins/ClickToChoose`. Nothing is written to your save, so there is nothing else to clean up.

## Field: Configuration

Settings are written to `BepInEx/config/com.dirtyredz.farmtogether2.clicktochoose.cfg` on first launch. There are two, and the defaults are meant to be left alone:

- `General.Enabled` (default `true`) - set to `false` to bring back the game's own hover-selects behaviour
- `General.VerboseLogging` (default `false`) - logs every suppressed hover-select, for diagnosing problems only

## Field: Shout outs

- **Milkstone Studios**, for Farm Together 2 and a farm worth sharing.
- The **BepInEx** and **HarmonyX** teams, without whom none of this scene exists.
- **My Mate**, for being my inspiration.

*(No Mod Nook / Mod Menu paragraphs: those settings menus are Moonlight Peaks mods and do not apply to Farm Together 2.)*

---

## Screenshot shot list

None captured yet. Capture on the current build, on the character customization screen.

| # | Shot | Must show |
|---|---|---|
| 1 | `01-hair-grid-hover.png` | Cursor over a hair-style tile (highlighted) while the character still shows the previously chosen style |
| 2 | `02-hair-grid-clicked.png` | The same tile after a click, now applied to the character |
| 3 | `03-rotate-keeps-style.png` *(optional)* | Character mid-rotation with the chosen style intact |
| - | Thumbnail, 16:9 | composed at 16:9 (stretched, not cropped, by the listing tile) |
| - | Title banner | wide format, in the gold/plum look of the Moonlight Peaks mods |
