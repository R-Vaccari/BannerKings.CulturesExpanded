using BannerKings.CulturesExpanded.Religions;
using BannerKings.Models.Vanilla;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Settlements;

namespace BannerKings.CulturesExpanded.Models
{
    public class BKCEProsperityModel : BKProsperityModel
    {
        public override ExplainedNumber CalculateProsperityChange(Town fortification, bool includeDescriptions = false)
        {
            ExplainedNumber result = base.CalculateProsperityChange(fortification, includeDescriptions);
            if (fortification.OwnerClan != null)
            {
                Hero leader = fortification.OwnerClan.Leader;
                if (fortification.Culture.StringId == BannerKingsConfig.EmpireCulture && 
                    BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, BKCEDivinities.Instance.Erithrians))
                {
                    result.Add(0.5f, BKCEDivinities.Instance.Erithrians.Name);
                }
            }

            return result;
        }
    }
}
