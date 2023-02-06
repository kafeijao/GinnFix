using ABI_RC.Core.Player;
using HarmonyLib;
using MelonLoader;

namespace GinnFix;

public class GinnFix : MelonMod {

    [HarmonyPatch]
    private static class HarmonyPatches {

        [HarmonyPostfix]
        [HarmonyPatch(typeof(PlayerNameplate), nameof(PlayerNameplate.UpdateNamePlate))]
        private static void After_PlayerNameplate_UpdateNamePlate(PlayerNameplate __instance) {
            try {
                if (__instance.player.userName == "Ginn") {
                    __instance.usrNameText.text = "Gim";
                }
            }
            catch (Exception e) {
                MelonLogger.Error(e);
            }
        }
    }
}
