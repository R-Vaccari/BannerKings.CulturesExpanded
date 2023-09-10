using BannerKings.Managers.Institutions.Religions;
using BannerKings.Models.BKModels;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.CampaignSystem;
using BannerKings.CulturesExpanded.Religions;

namespace BannerKings.CulturesExpanded.Models
{
    public class BKCEReligionModel : BKReligionModel
    {
        public new ExplainedNumber CalculateReligionWeight(Religion religion, Settlement settlement)
        {
            ExplainedNumber result = base.CalculateReligionWeight(religion, settlement);
            if (settlement.OwnerClan != null)
            {
                Hero leader = settlement.OwnerClan.Leader;
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, BKCEDivinities.Instance.Erithrians))
                {
                    result.Add(5f, BKCEDivinities.Instance.Erithrians.Name);
                }
            }

            return result;
        }
    }
}
