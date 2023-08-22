using BannerKings.CulturesExpanded.Behaviors;
using BannerKings.CulturesExpanded.Cultures;
using BannerKings.CulturesExpanded.Goals;
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

            BannerKingsConfig.Instance.AddInitializer(new BKTORecruitSpawns());
            BannerKingsConfig.Instance.AddInitializer(new BKTOPopulationNames());
            BannerKingsConfig.Instance.AddInitializer(new BKTOTitleNames());
            BannerKingsConfig.Instance.AddInitializer(new BKTOGoals());
        }
    }
}