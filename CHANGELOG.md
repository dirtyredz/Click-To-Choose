# Changelog

## 1.0.0

First release.

- Customization option tiles (hair styles and similar) no longer select (preview/apply) on mouse
  hover; a click applies the option. Moving the mouse across the grid, or over to the character to
  rotate it, no longer changes your look, and the chosen option stays selected.
- Scope: `ItemListButton` tiles under a `CustomizationBaseScreen` only. Colour swatches, other
  menus and shops keep the stock hover behaviour. Keyboard and gamepad navigation are unchanged.
- Implemented as one Harmony prefix on `MilkInputModule.HandlePointerExitAndEnterSelect`.
- Config: `General.Enabled` (default `true`), `General.VerboseLogging` (default `false`).
- Tested with BepInEx 6.0.0-be.793 (Unity IL2CPP, win-x64).
