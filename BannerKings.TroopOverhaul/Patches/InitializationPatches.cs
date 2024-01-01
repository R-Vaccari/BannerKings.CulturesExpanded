using HarmonyLib;
using TaleWorlds.CampaignSystem.CharacterDevelopment;
using BannerKings.CulturesExpanded.Cultures;

namespace BannerKings.CulturesExpanded.Patches
{
    internal class InitializationPatches
    {
        [HarmonyPatch(typeof(DefaultCulturalFeats))]
        public class DefaultCulturalFeatsPatch
        {
            [HarmonyPostfix]
            [HarmonyPatch("InitializeAll")]
            static void Refresh(DefaultCulturalFeats __instance)
            {
                BKCEFeats.Instance.Initialize();
            }
        }
    }
}
