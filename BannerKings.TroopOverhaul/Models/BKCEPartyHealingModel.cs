using BannerKings.CulturesExpanded.Religions;
using BannerKings.Models.Vanilla;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Party;

namespace BannerKings.CulturesExpanded.Models
{
    public class BKCEPartyHealingModel : BKPartyHealingModel
    {
        public override ExplainedNumber GetDailyHealingForRegulars(MobileParty party, bool includeDescriptions = false)
        {
            ExplainedNumber result = base.GetDailyHealingForRegulars(party, includeDescriptions);

            Hero leader = party.LeaderHero;
            if (leader != null)
            {
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, BKCEDivinities.Instance.Jinn))
                {
                    result.Add(0.8f, BKCEDivinities.Instance.Jinn.Name);
                }
            }

            return result;
        }
    }
}
