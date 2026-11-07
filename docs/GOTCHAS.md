# GOTCHAS

- **The game selects on hover, everywhere.** `MilkInputModule` selects any navigable Selectable the
  pointer enters. Fixing one screen means scoping the patch (see `CustomizationTileScope`), not
  disabling the module behaviour.
- **Click still selects.** `Selectable.OnPointerDown` selects the tile, so `SelectItem` (preview) still
  runs on a click, then `onClick` runs `SubmitItem`. That is intended.
- **Protected-looking methods are public in the interop.** `MilkInputModule.HandlePointerExitAndEnter`
  (the stock one) is callable directly; no reflection needed.
- **IL2CPP patches hit native code.** If a game update inlines or renames `HandlePointerExitAndEnterSelect`
  the patch fails at load (check `LogOutput.log` for Harmony errors) instead of silently doing nothing.
- **Build needs the reference DLLs.** The game is not installed on Valhalla; run
  `tools/get-game-reference.ps1` and pass `-p:FarmTogether2GamePath=<repo>\.tmp\game-ref`.
