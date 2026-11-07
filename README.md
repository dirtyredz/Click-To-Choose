# Click To Choose (working name)

A BepInEx 6 IL2CPP mod for **Farm Together 2**: on the character customization screens an option
(hair style, outfit piece, colour tile, ...) is applied only when you **click** it. Hovering still
highlights a tile, but no longer selects it, so you can move the mouse across the grid to rotate or
inspect your character without the preview changing underneath you.

Keyboard and gamepad navigation are untouched: they select tiles the normal way.

## Install

Extract the release zip over the game folder (`BepInEx/plugins/ClickToChoose/ClickToChoose.dll`).
Requires BepInEx 6.0.0-be.793 (Unity IL2CPP, win-x64).

## Config

`BepInEx/config/com.dirtyredz.farmtogether2.clicktochoose.cfg`

| Setting | Default | Meaning |
|---|---|---|
| `General.Enabled` | `true` | `false` restores the stock hover-selects behaviour |
| `General.VerboseLogging` | `false` | log each suppressed hover-select |

## How it works

One Harmony prefix on `MilkInputModule.HandlePointerExitAndEnterSelect`; see
[docs/ARCHITECTURE.md](docs/ARCHITECTURE.md) for the evidence and [docs/GOTCHAS.md](docs/GOTCHAS.md)
for the traps. Manual verification: [TESTING.md](TESTING.md).

## Build

```powershell
# one-time: copy interop/core DLLs from ANU (the game is not installed on Valhalla)
powershell -NoProfile -ExecutionPolicy Bypass -File ..\..\tools\get-game-reference.ps1
dotnet build src\ClickToChoose.csproj -p:SkipDeploy=true -p:FarmTogether2GamePath="<repo>\.tmp\game-ref"
.\pack.ps1   # honours the FarmTogether2GamePath environment variable too
```

Status: pre-release (`0.0.1`); no public repo yet. MIT licensed.
