using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;

namespace BannerKings.CulturesExpanded
{
    public class Main : MBSubModuleBase
    {
        protected override void OnGameStart(Game game, IGameStarter gameStarter)
        {
            base.OnGameStart(game, gameStarter);
            BannerKingsConfig.Instance.AddInitializer(new BKTORecruitSpawns());
        }
    }
}