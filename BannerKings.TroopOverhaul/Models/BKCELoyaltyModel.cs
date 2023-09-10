using BannerKings.CulturesExpanded.Religions;
using BannerKings.Models.Vanilla;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Settlements;

namespace BannerKings.CulturesExpanded.Models
{
    public class BKCELoyaltyModel : BKLoyaltyModel
    {
        public override ExplainedNumber CalculateLoyaltyChange(Town town, bool includeDescriptions = false)
        {
            ExplainedNumber result = base.CalculateLoyaltyChange(town, includeDescriptions);
            if (town.OwnerClan != null)
            {
                Hero leader = town.OwnerClan.Leader;
                if (town.Culture.StringId == BannerKingsConfig.EmpireCulture &&
                    BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, BKCEDivinities.Instance.Erithrians))
                {
                    result.Add(0.5f, BKCEDivinities.Instance.Erithrians.Name);
                }
            }

            return result;
        }
    }
}
