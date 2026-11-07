# DECISIONS

## 2026-11-07 - Prefix on MilkInputModule.HandlePointerExitAndEnterSelect, scoped to customization tiles

Chosen: skip the game's hover-select by running the stock `HandlePointerExitAndEnter` for pointer targets
under `ItemListButton` + `CustomizationBaseScreen`.
Rejected: patching `EventSystem.SetSelectedGameObject` (also hit by clicks and gamepad, needs a
re-entrancy flag); patching `ItemListBaseScreen.SelectItem` (gamepad navigation uses it, and it cannot tell
hover from navigation); disabling hover-select globally (changes every menu).
Not chosen yet: scoping to `ItemListButton` tiles only leaves colour swatches / selectors on stock hover;
widen the scope if the owner sees those apply on hover too.

## 2026-11-07 - Name, version and repo for the first release

Name: Click To Choose (code identifier `ClickToChoose`, GUID `com.dirtyredz.farmtogether2.clicktochoose`, fixed
for good). Version `1.0.0` per the Moonlight Peaks rule that the first published version is 1.0.0; the
`0.0.1` dev builds are folded into the 1.0.0 CHANGELOG entry. Public repo
`dirtyredz/Click-To-Choose` (Moonlight Peaks repo names are hyphenated Title Case: Mod-Nook, Plant-Peek).
Nexus page copy: NEXUS.md (reference) and nexus-paste.md (BBCode, paste-ready), following the Moonlight
Peaks standard (guides 12-15). Colour swatches stay on stock hover (still the open scope question above).
