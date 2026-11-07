using System.Linq;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;

namespace ClickToChoose
{
    [BepInPlugin(ModIdentity.Guid, ModIdentity.Name, ModBuildInfo.Version)]
    [BepInProcess(ModIdentity.GameExe)]
    public sealed class Plugin : BasePlugin
    {
        internal static ManualLogSource Logger;
        internal static ConfigEntry<bool> Enabled;
        internal static ConfigEntry<bool> VerboseLogging;

        public override void Load()
        {
            Logger = Log;
            Enabled = Config.Bind("General", "Enabled", true,
                "Customization screens apply an option only on click. Set false to get the stock hover-selects behaviour back.");
            VerboseLogging = Config.Bind("General", "VerboseLogging", false,
                "Log every hover-select that is suppressed (diagnostics only).");

            var harmony = new Harmony(ModIdentity.Guid);
            harmony.PatchAll(typeof(Plugin).Assembly);
            var patched = harmony.GetPatchedMethods().Select(m => $"{m.DeclaringType?.Name}.{m.Name}").ToArray();
            Log.LogInfo($"{ModIdentity.Name} {ModBuildInfo.Version} loaded; patch applied: {string.Join(", ", patched)}");
        }
    }
}
