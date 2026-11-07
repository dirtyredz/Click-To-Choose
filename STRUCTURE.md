# STRUCTURE - Click To Choose

<!-- Last full review: never -->

Standalone mod repo nested in the Farm Together 2 workspace (`mods/ClickToChoose`, gitignored by the root).

## Layout

- `src/` - `Plugin.cs` (BepInEx entry point) and `ClickToChoose.csproj`
- `src/game/` - Harmony patch and game-type queries (`CustomizationHoverSelectPatch`, `CustomizationTileScope`)
- `src/core/` - the mod's own constants (`ModIdentity`); no game types
- `docs/` - the living-doc set

## Components

| Component | Responsibility |
|---|---|
| `Plugin` | config binding, `PatchAll`, load log |
| `CustomizationHoverSelectPatch` | prefix that swaps hover-select for stock enter/exit on option tiles |
| `CustomizationTileScope` | "is this hovered object an option tile on a customization screen?" |
| `ModIdentity` | GUID, display name, game exe |

Shared, synced from the workspace `tools/`: `pack.ps1`, `Directory.Build.props` (do not edit here).

## Renaming (the name is final; this recipe is for reference only)

1. `src/ClickToChoose.csproj`: rename the file and `<ModName>`.
2. `src/core/ModIdentity.cs`: `Guid`, `Name`.
3. Replace `namespace ClickToChoose` in the four `.cs` files; the docs/README mention it too.
4. `pack.ps1` derives the zip and plugin folder from the csproj name.
