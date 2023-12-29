using BannerKings.CulturesExpanded.Religions;
using BannerKings.Models.Vanilla;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.Core;

namespace BannerKings.CulturesExpanded.Models
{
    public class BKCEPriceModel : BKPriceFactorModel
    {
        public override float GetTradePenalty(ItemObject item, MobileParty clientParty, PartyBase merchant, bool isSelling, float inStore, float supply, float demand)
        {
            ExplainedNumber result = new ExplainedNumber(base.GetTradePenalty(item, clientParty, merchant, isSelling, inStore, supply, demand));
            if (clientParty != null)
            {
                Hero hero = clientParty.LeaderHero;
                if (hero != null)
                {
                    if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(hero, BKCEDivinities.Instance.VineGoddess))
                    {
                        result.AddFactor(-0.1f);
                    }
                }
            }

            return result.ResultNumber;
        }
    }
}
