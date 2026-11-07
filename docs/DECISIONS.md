# DECISIONS

## 2026-11-07 - Prefix on MilkInputModule.HandlePointerExitAndEnterSelect, scoped to customization tiles

Chosen: skip the game's hover-select by running the stock `HandlePointerExitAndEnter` for pointer targets
under `ItemListButton` + `CustomizationBaseScreen`.
Rejected: patching `EventSystem.SetSelectedGameObject` (also hit by clicks and gamepad, needs a
re-entrancy flag); patching `ItemListBaseScreen.SelectItem` (gamepad navigation uses it, and it cannot tell
hover from navigation); disabling hover-select globally (changes every menu).
Not chosen yet: scoping to `ItemListButton` tiles only leaves colour swatches / selectors on stock hover;
widen the scope if the owner sees those apply on hover too.
