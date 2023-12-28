using BannerKings.Behaviours.Diplomacy;
using BannerKings.CulturesExpanded.Religions;
using BannerKings.Models.BKModels;
using BannerKings.Utils.Models;
using TaleWorlds.CampaignSystem;

namespace BannerKings.CulturesExpanded.Models
{
    public class BKCELegitimacyModel : BKLegitimacyModel
    {
        public override BKExplainedNumber CalculateEffect(KingdomDiplomacy diplomacy, bool explanations = false)
        {
            BKExplainedNumber result = base.CalculateEffect(diplomacy, explanations);
            Hero leader = diplomacy.Kingdom.Leader;
            string cultureId = leader.Culture.StringId;
            var rel = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(leader);
            if (rel != null)
            {
                if (cultureId == "siri")
                {
                    if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, BKCEDivinities.Instance.GreatLion, rel))
                    {
                        result.Add(0.1f, BKCEDivinities.Instance.GreatLion.Name);
                    }
                }

                if (cultureId == "kannic")
                {
                    if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, BKCEDivinities.Instance.Eshora, rel))
                    {
                        result.Add(0.1f, BKCEDivinities.Instance.Eshora.Name);
                    }
                }

                if (cultureId == "darshi")
                {
                    if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, BKCEDivinities.Instance.ImmortalFlame, rel))
                    {
                        result.Add(0.1f, BKCEDivinities.Instance.ImmortalFlame.Name);
                    }
                }
            }

            return result;
        }
    }
}
