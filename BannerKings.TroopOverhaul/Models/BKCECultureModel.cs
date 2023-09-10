using BannerKings.Managers.Populations;
using BannerKings.Models.BKModels;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.CampaignSystem;
using BannerKings.CulturesExpanded.Religions;

namespace BannerKings.CulturesExpanded.Models
{
    public class BKCECultureModel : BKCultureModel
    {
        public new ExplainedNumber CalculateCultureWeight(Settlement settlement, CultureDataClass data, float baseWeight = 0f)
        {
            ExplainedNumber result = base.CalculateCultureWeight(settlement, data, baseWeight);
            if (settlement.OwnerClan != null)
            {
                Hero leader = settlement.OwnerClan.Leader;
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, BKCEDivinities.Instance.Erithrians))
                {
                    result.Add(5f, BKCEDivinities.Instance.Erithrians.Name);
                }

                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, BKCEDivinities.Instance.Sarapios))
                {
                    result.Add(8f, BKCEDivinities.Instance.Sarapios.Name);
                }
            }

            return result;
        }

        public new ExplainedNumber CalculateAcceptanceGain(CultureDataClass data)
        {
            ExplainedNumber result = base.CalculateAcceptanceGain(data);
            Settlement settlement = data.Settlement;
            if (settlement.OwnerClan != null)
            {
                Hero leader = settlement.OwnerClan.Leader;
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, BKCEDivinities.Instance.Sarapios))
                {
                    result.Add(0.05f, BKCEDivinities.Instance.Sarapios.Name);
                }
            }

            return result;
        }
    }
}
