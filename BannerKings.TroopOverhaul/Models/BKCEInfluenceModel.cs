using BannerKings.CulturesExpanded.Religions;
using BannerKings.Models.Vanilla;
using TaleWorlds.CampaignSystem;

namespace BannerKings.CulturesExpanded.Models
{
    public class BKCEInfluenceModel : BKInfluenceModel
    {
        public override ExplainedNumber CalculateInfluenceChange(Clan clan, bool includeDescriptions = false)
        {
            ExplainedNumber result = base.CalculateInfluenceChange(clan, includeDescriptions);
            Hero leader = clan.Leader;
            if (leader != null) 
            {
                var rel = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(leader);
                if (rel != null)
                {
                    if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(clan.Leader, BKCEDivinities.Instance.Calradios, rel))
                    {
                        result.AddFactor(result.BaseNumber > 0f ? 0.3f : -0.3f, BKCEDivinities.Instance.Calradios.Name);
                    }

                    if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(clan.Leader, BKCEDivinities.Instance.GreatLion, rel))
                    {
                        result.AddFactor(result.BaseNumber > 0f ? 0.25f : -0.25f, BKCEDivinities.Instance.Calradios.Name);
                    }
                }
            }

            return result;
        }
    }
}
