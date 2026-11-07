using UnityEngine;

namespace ClickToChoose
{
    /// <summary>Decides whether a hovered object is an option tile on a customization screen.</summary>
    internal static class CustomizationTileScope
    {
        public static bool IsCustomizationTile(GameObject hovered)
        {
            if (hovered == null) return false;
            // Tiles are ItemListButton prefabs; only those under a CustomizationBaseScreen (avatar, farmhand,
            // pet, vehicle, fairy, emote) count, so shop and other ItemListBaseScreen lists keep stock hover.
            return hovered.GetComponentInParent<ItemListButton>() != null
                && hovered.GetComponentInParent<CustomizationBaseScreen>() != null;
        }
    }
}
