using BannerKings.CulturesExpanded.Behaviors;
using BannerKings.CulturesExpanded.Cultures;
using BannerKings.CulturesExpanded.Goals;
using BannerKings.CulturesExpanded.Models;
using BannerKings.CulturesExpanded.Religions;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;

namespace BannerKings.CulturesExpanded
{
    public class Main : MBSubModuleBase
    {
        protected override void OnGameStart(Game game, IGameStarter gameStarter)
        {
            base.OnGameStart(game, gameStarter);
            if (gameStarter is not CampaignGameStarter campaignStarter)
            {
                return;
            }

            campaignStarter.AddBehavior(new CrownGuardBehavior());

            campaignStarter.AddModel(new BKCEInfluenceModel());
            campaignStarter.AddModel(new BKCELoyaltyModel());
            campaignStarter.AddModel(new BKCEProsperityModel());
            campaignStarter.AddModel(new BKCEVolunteerModel());

            BannerKingsConfig.Instance.AddInitializer(BKTORecruitSpawns.Instance);
            BannerKingsConfig.Instance.AddInitializer(BKTOPopulationNames.Instance);
            BannerKingsConfig.Instance.AddInitializer(BKTOTitleNames.Instance);
            BannerKingsConfig.Instance.AddInitializer(BKTOGoals.Instance);
            BannerKingsConfig.Instance.AddInitializer(BKCEDivinities.Instance);
            BannerKingsConfig.Instance.AddInitializer(BKCEFaithGroups.Instance);
            BannerKingsConfig.Instance.AddInitializer(BKCEDoctrines.Instance);
            BannerKingsConfig.Instance.AddInitializer(BKCEFaiths.Instance);
            BannerKingsConfig.Instance.AddInitializer(BKCEReligions.Instance);

            BannerKingsConfig.Instance.CultureModel = new BKCECultureModel();
            BannerKingsConfig.Instance.ReligionModel = new BKCEReligionModel();
        }
    }
}