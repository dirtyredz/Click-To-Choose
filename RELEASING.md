# Releasing Click To Choose

The shared rules live in the Moonlight Peaks guide
[12-versioning-and-release.md](../../../Moonlight%20Peaks/12-versioning-and-release.md) (same process here). This file is
what is specific to this mod, and where it currently stands.

## Packaging

```powershell
.\pack.ps1      # honours -p:FarmTogether2GamePath via the FarmTogether2GamePath env var
```

Produces `dist/ClickToChoose-<version>.zip` laid out as Nexus and Vortex expect:

```
BepInEx/plugins/ClickToChoose/ClickToChoose.dll
```

This is **not** the dev deploy path (`plugins/FarmTogether2Mods/ClickToChoose`). `pack.ps1` builds with
`SkipDeploy=true`. The version comes from the csproj `<Version>` only; `Plugin.cs` derives the same
value via `ModBuildInfo.Version`. Vortex routes the archive through the FT2 extension
(`dirtyredz/FarmTogether2Vortex`).

The game is not installed on Valhalla: run `tools/get-game-reference.ps1` once, then
`$env:FarmTogether2GamePath = "<workspace>\.tmp\game-ref"` before `.\pack.ps1`.

## No test project, on purpose

Every code path reads Unity/game types (`MilkInputModule`, `ItemListButton`, `CustomizationBaseScreen`), so a
console runner could not exercise anything real. Verification is manual - see [TESTING.md](TESTING.md).

## Pre-release checklist (1.0.0)

- [x] **Version set in the csproj** (`1.0.0`); `Plugin.cs` derives it via `ModBuildInfo.Version`
- [x] **CHANGELOG** has exactly one entry for this version
- [x] **Diagnostics off** - `VerboseLogging` defaults to `false`
- [x] **Save-safe** - no save reads or writes; the patch only decides whether the game's hover-select runs
- [x] **Final name chosen** - Click To Choose; GUID in `ModIdentity.cs` is fixed for good
- [x] **Owner check in game** - TESTING.md passed on the current build, 2026-11-07
- [x] **Public repo** - https://github.com/dirtyredz/Click-To-Choose
- [x] **Zip contents** - only `BepInEx/plugins/ClickToChoose/ClickToChoose.dll`
- [x] **Nexus copy** - [NEXUS.md](NEXUS.md) and [nexus-paste.md](nexus-paste.md) written in the Moonlight Peaks style

Publishing 1.0.0 (2026-11-07):

- [x] **Published** - https://www.nexusmods.com/farmtogether2/mods/21 (page 21, main file 40,
      4136 bytes = the packed zip; verified via Nexus GraphQL: published, version 1.0.0, Miscellaneous)
- [x] **Category / tags** - FT2 has one category, Miscellaneous; tags Quality of Life + User Interface
- [x] **Gallery image** - `assets/nexus-gallery-1.png`, AI-generated (Astra / Codex image tool),
      illustrative only; the page's AI-usage field covers it. Replace with real screenshots.
- [ ] **Screenshots** - real in-game shots still to add (owner); see the shot list in [NEXUS.md](NEXUS.md)
- [ ] **Fresh-install run on ANU** of the packed 1.0.0 zip via Vortex (the install-pack script run)

## Tagging

Per guide 12: the release is one commit (csproj bump + CHANGELOG + release code), then an annotated tag
`v1.0.0` at that commit, pushing branch and tag, and the tag is the record of what shipped. The tag is
created before the upload.

## Open decisions

- **Scope.** Colour swatches deliberately keep the stock hover behaviour (see DECISIONS.md). Widen the
  scope in a later release if players report swatches applying on hover too.
