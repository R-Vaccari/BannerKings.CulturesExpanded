using BannerKings.CulturesExpanded.Religions;
using BannerKings.Extensions;
using BannerKings.Managers.Institutions.Religions;
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

                if (fortification.Culture.StringId == "kannic" &&
                    BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, BKCEDivinities.Instance.Eshora))
                {
                    result.Add(0.5f, BKCEDivinities.Instance.Eshora.Name);
                }
            }

            return result;
        }

        public override ExplainedNumber CalculateHearthChange(Village village, bool includeDescriptions = false)
        {
            ExplainedNumber baseResult = base.CalculateHearthChange(village, includeDescriptions);

            var owner = village.GetActualOwner();
            var rel = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(owner);

            if (rel != null)
            {
                if ((village.VillageType == DefaultVillageTypes.DateFarm || village.VillageType == DefaultVillageTypes.DesertHorseRanch)
                                && BannerKingsConfig.Instance.ReligionsManager.HasBlessing(owner, DefaultDivinities.Instance.AseraSecondary3, rel))
                {
                    baseResult.Add(0.1f, DefaultDivinities.Instance.AseraSecondary3.Name);
                }

                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(owner, DefaultDivinities.Instance.AmraMain, rel)
                    && (village.VillageType == DefaultVillageTypes.HogFarm || village.VillageType == DefaultVillageTypes.CattleRange ||
                    village.VillageType == DefaultVillageTypes.Lumberjack))
                {
                    baseResult.Add(0.2f, DefaultDivinities.Instance.AmraMain.Name);
                }

                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(owner, DefaultDivinities.Instance.Mehns, rel))
                {
                    if (rel.FavoredCultures.Contains(village.Settlement.Culture))
                    {
                        baseResult.Add(0.08f, DefaultDivinities.Instance.Mehns.Name);
                    }
                }

                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(owner, DefaultDivinities.Instance.Horsa, rel))
                {
                    baseResult.Add(0.05f, DefaultDivinities.Instance.Horsa.Name);
                }

                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(owner, DefaultDivinities.Instance.WindEast, rel))
                {
                    baseResult.Add(0.05f, DefaultDivinities.Instance.WindEast.Name);
                }

                if (village.Settlement.Culture.StringId == "kannic" &&
                    BannerKingsConfig.Instance.ReligionsManager.HasBlessing(owner, BKCEDivinities.Instance.Jinn, rel))
                {
                    baseResult.Add(0.06f, BKCEDivinities.Instance.Jinn.Name);
                }
            }

            return baseResult;
        }
    }
}
