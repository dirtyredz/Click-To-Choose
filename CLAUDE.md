# CLAUDE.md - working in Click To Choose

Standalone git repo nested in the Farm Together 2 workspace; treat **this** repo as active. Orientation:
[README.md](README.md), [STRUCTURE.md](STRUCTURE.md), [docs/ARCHITECTURE.md](docs/ARCHITECTURE.md),
[docs/GOTCHAS.md](docs/GOTCHAS.md), [TESTING.md](TESTING.md), [RELEASING.md](RELEASING.md).

- Layout is a contract: `Plugin.cs` beside the csproj, patches/game queries in `src/game/`, game-free
  code in `src/core/`. Namespace stays flat (`ClickToChoose`).
- `pack.ps1` and `Directory.Build.props` are synced from `../../tools/` (`sync-mod-files.ps1`); do not hand-edit.
- Version lives only in `src/ClickToChoose.csproj` `<Version>`; bump only when publishing; never in `Plugin.cs`.
- Commit identity: `dirtyredz <dirtyredz@live.com>`. No push/remote yet.
- Build: see README. The game is not on Valhalla; use `tools/get-game-reference.ps1`.
- Workspace rules (ANU test rig, one game launch at a time): `../../CLAUDE.md`.
