using BannerKings.CulturesExpanded.Religions;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.GameComponents;

namespace BannerKings.CulturesExpanded.Models
{
    public class BKCEDeathModel : DefaultHeroDeathProbabilityCalculationModel
    {
        public override float CalculateHeroDeathProbability(Hero hero)
        {
            float chance = base.CalculateHeroDeathProbability(hero);
            if (!CampaignOptions.IsLifeDeathCycleDisabled)
            {
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(hero, BKCEDivinities.Instance.Ahhak))
                {
                    chance *= 0.1f;
                }
            }

            return chance;
        }
    }
}
