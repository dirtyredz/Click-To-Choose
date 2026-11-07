# Releasing Click To Choose

Not published yet (pre-release `0.0.1`, no GitHub remote). The first release is `1.0.0`: set `<Version>` in
`src/ClickToChoose.csproj`, add the CHANGELOG entry, run `.\pack.ps1`, upload `dist/ClickToChoose-1.0.0.zip`
(layout `BepInEx/plugins/ClickToChoose/ClickToChoose.dll`; Vortex routes it via the FT2 extension).

Pre-release checklist:

- [ ] Owner check in [TESTING.md](TESTING.md) passed on the current build
- [ ] Final name chosen (STRUCTURE.md "Renaming"), GUID in `ModIdentity.cs` fixed for good
- [ ] Fresh-install run on ANU: plugin loads from `plugins/ClickToChoose/`, no Harmony errors
- [ ] CHANGELOG has one entry for the version; `VerboseLogging` defaults to `false`
- [ ] Nexus page from [NEXUS.md](NEXUS.md); public repo decided by the owner
