using System;
using HarmonyLib;
using UnityEngine;
using UnityEngine.EventSystems;

namespace ClickToChoose
{
    /// <summary>
    /// The game's input module (MilkInputModule) is Unity's pointer-enter handling plus one extra step: every
    /// Selectable the pointer enters (navigation enabled) becomes the EventSystem's selected object. On the
    /// customization screens each option tile's UISelectionNotifier turns that selection into
    /// ItemListBaseScreen.SelectItem (preview/apply), so merely hovering a tile changes the character.
    ///
    /// For a pointer entering an option tile inside a CustomizationBaseScreen we run the stock Unity enter/exit
    /// handling instead (hover highlight tweens keep working) and skip the select. A click still selects the
    /// tile through Selectable.OnPointerDown and runs the tile's onClick; keyboard/gamepad navigation never goes
    /// through this method. Everything else in the game keeps the stock behaviour.
    /// </summary>
    [HarmonyPatch(typeof(MilkInputModule), nameof(MilkInputModule.HandlePointerExitAndEnterSelect))]
    internal static class CustomizationHoverSelectPatch
    {
        private static bool Prefix(MilkInputModule __instance, PointerEventData currentPointerData, GameObject newEnterTarget)
        {
            if (!Plugin.Enabled.Value || !CustomizationTileScope.IsCustomizationTile(newEnterTarget))
                return true;

            try
            {
                __instance.HandlePointerExitAndEnter(currentPointerData, newEnterTarget);
                if (Plugin.VerboseLogging.Value)
                    Plugin.Logger.LogInfo($"hover-select suppressed on '{newEnterTarget.name}'");
                return false;
            }
            catch (Exception e)
            {
                // Never leave the pointer state half-handled: fall back to the stock behaviour.
                Plugin.Logger.LogError($"stock enter/exit failed, using game behaviour: {e}");
                return true;
            }
        }
    }
}
