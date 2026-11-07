# TESTING

No test project: every code path reads Unity/game types a console runner cannot exercise.

## Automated (fast gate)

1. `dotnet build src/ClickToChoose.csproj -p:SkipDeploy=true -p:FarmTogether2GamePath=<ref>` succeeds.
2. `.\pack.ps1` produces `dist/ClickToChoose-<version>.zip` with `BepInEx/plugins/ClickToChoose/ClickToChoose.dll`.
3. One launch on ANU through `tools/anu/run-test.ps1`: `LogOutput.log` shows
   `Click To Choose <version> loaded; patch applied: MilkInputModule.HandlePointerExitAndEnterSelect`
   and no Harmony/BepInEx errors.

## Owner check (cannot be automated)

On the character customization screen (hair styles):

1. Hover across the hair-style grid: nothing changes (the tile may highlight).
2. Click one: it applies.
3. Move the mouse across the grid and drag/rotate the character: the chosen style stays.
4. Arrow keys / gamepad d-pad still move through the tiles and preview them as before.
5. Open a shop or settings screen: hover behaves as in the stock game.
