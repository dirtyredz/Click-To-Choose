# ARCHITECTURE

## The mechanism (evidence)

All findings come from the generated interop signatures plus a Cpp2IL ISIL disassembly of
`GameAssembly.dll` (see the workspace guide `09-exploring-the-assembly.md`). Class.method names below
are from the interop; behaviour is read from the ISIL.

1. **`UnityEngine.EventSystems.MilkInputModule`** is the game's input module (a `PointerInputModule`).
   Its `ProcessMove(PointerEventData)` calls **`HandlePointerExitAndEnterSelect(PointerEventData,
   GameObject newEnterTarget)`**, a copy of Unity's `HandlePointerExitAndEnter` with one added step: for
   each transform the pointer enters it does `GetComponent<Selectable>()` and, if the Selectable's
   navigation mode is not `None` (`[selectable+40] != 0`, the same test `Selectable.OnPointerDown` uses),
   calls `EventSystem.SetSelectedGameObject`. So **hovering any navigable UI element selects it**.
2. **`ItemListBaseScreen.setCategory`** builds the option tiles (`ItemListButton`) and, per tile, wires
   `UISelectionNotifier.add_OnSelection` to `<setCategory>b__53_1`, which does a virtual call to
   `ItemListBaseScreen.SelectItem()`, and a `UnityEvent.AddListener` closure (`<setCategory>b__0`) that
   calls `SubmitItem(tile.definition, true)` (the click/apply path).
3. **`CustomizationBaseScreen.SelectItem`** (and `CustomizationAvatarScreen.SelectItem`, which calls it,
   then `CharacterCustomization.SetJewelry` etc.) refreshes the character preview via `UpdatePreview`.
   Net effect: hover -> EventSystem selection -> `OnSelect` -> `UISelectionNotifier` -> `SelectItem` ->
   the character changes. Gamepad navigation reaches the same `SelectItem` via
   `UIGridGroupNavigation` -> `Selectable.Select`, which is why we must not touch selection itself.

Ruled out: `UIPointerHandler.OnPointerEnter` (only invokes an `Action`), `UIButtonTween` /
`UISelectedElementToCenter.OnPointerEnter` (visual / bookkeeping only), `Selectable.OnPointerEnter`
(stock, state transition only).

Not verified at runtime: that is the owner check in [TESTING.md](../TESTING.md). The `SelectItem`
-> preview step is inferred from the call names in the ISIL, not from IL bodies.

## The patch

`src/game/CustomizationHoverSelectPatch.cs`: Harmony **prefix** on
`MilkInputModule.HandlePointerExitAndEnterSelect`. When the entered object is under both an
`ItemListButton` and a `CustomizationBaseScreen` (`src/game/CustomizationTileScope.cs`) it calls
`HandlePointerExitAndEnter` (Unity's stock exit/enter, no select) and returns `false`. Anything else
returns `true` and the game's own method runs. Any exception falls back to the game's method.

Why this seam: it is the one place hover turns into selection; patching `SetSelectedGameObject` would
also hit clicks and gamepad; the scope test keeps shops, menus and settings on stock hover.
