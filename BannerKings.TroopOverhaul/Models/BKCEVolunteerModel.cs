using BannerKings.Models.Vanilla;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.CampaignSystem;
using BannerKings.CulturesExpanded.Religions;

namespace BannerKings.CulturesExpanded.Models
{
    public class BKCEVolunteerModel : BKVolunteerModel
    {
        public new ExplainedNumber GetMilitarism(Settlement settlement)
        {
            ExplainedNumber result = base.GetMilitarism(settlement);
            if (settlement.Culture.StringId == BannerKingsConfig.EmpireCulture && settlement.OwnerClan != null)
            {
                Hero leader = settlement.OwnerClan.Leader;
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, BKCEDivinities.Instance.Ireos))
                {
                    result.Add(0.04f, BKCEDivinities.Instance.Ireos.Name);
                }
            }

            return result;
        }
    }
}
