using BannerKings.CulturesExpanded.Religions;
using BannerKings.Models.BKModels;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Settlements;

namespace BannerKings.CulturesExpanded.Models
{
    public class BKCEStabilityModel : BKStabilityModel
    {
        public override ExplainedNumber CalculateStabilityTarget(Settlement settlement, bool descriptions = false)
        {
            ExplainedNumber result = base.CalculateStabilityTarget(settlement, descriptions);

            if (settlement.OwnerClan != null)
            {
                Hero leader = settlement.OwnerClan.Leader;
                var rel = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(leader);
                if (rel != null)
                {
                    if (settlement.Culture.StringId == "darshi" &&
                        BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, BKCEDivinities.Instance.ImmortalFlame, rel))
                    {
                        result.Add(0.1f, BKCEDivinities.Instance.ImmortalFlame.Name);
                    }
                }
            }

            return result;
        }
    }
}
