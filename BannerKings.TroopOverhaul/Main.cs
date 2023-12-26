using BannerKings.CulturesExpanded.Behaviors;
using BannerKings.CulturesExpanded.Cultures;
using BannerKings.CulturesExpanded.Goals;
using BannerKings.CulturesExpanded.Models;
using BannerKings.CulturesExpanded.Religions;
using System;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.Localization;
using TaleWorlds.MountAndBlade;
using SandBox;
using TaleWorlds.SaveSystem.Load;
using System.Collections.Generic;
using System.Linq;
using BannerKings.CulturesExpanded.CC;
using HarmonyLib;

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
            BannerKingsConfig.Instance.AddInitializer(BKCEPopulationNames.Instance);
            BannerKingsConfig.Instance.AddInitializer(BKCETitleNames.Instance);
            BannerKingsConfig.Instance.AddInitializer(BKTOGoals.Instance);
            BannerKingsConfig.Instance.AddInitializer(BKCEDivinities.Instance);
            BannerKingsConfig.Instance.AddInitializer(BKCEFaithGroups.Instance);
            BannerKingsConfig.Instance.AddInitializer(BKCEFaiths.Instance);
            BannerKingsConfig.Instance.AddInitializer(BKCEReligions.Instance);
            BannerKingsConfig.Instance.AddInitializer(BKCELanguages.Instance);

            BannerKingsConfig.Instance.CultureModel = new BKCECultureModel();
            BannerKingsConfig.Instance.ReligionModel = new BKCEReligionModel();

            BannerKingsConfig.Instance.TitlesGeneratorPath = BasePath.Name + "Modules/BannerKings.CulturesExpanded/ModuleData/titles.xml";
        }

        protected override void OnSubModuleLoad()
        {
            new Harmony("BannerKings.CulturesExpanded").PatchAll();
            List<InitialStateOption> _initialStateOptions = (List<InitialStateOption>)Module.CurrentModule.GetType()
                .GetField("_initialStateOptions", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                .GetValue(Module.CurrentModule);

            InitialStateOption story = _initialStateOptions.First(x => x.Id == "StoryModeNewGame");
            InitialStateOption sb = _initialStateOptions.First(x => x.Id == "SandBoxNewGame");

            if (story != null) _initialStateOptions.Remove(story);
            if (sb != null) _initialStateOptions.Remove(sb);

            Module.CurrentModule.AddInitialStateOption(new InitialStateOption("BKCE", new TextObject("{=!}Banner Kings", null), 3, delegate ()
            {
                MBGameManager.StartNewGame(new BKCEGameManager());
            }, () => new ValueTuple<bool, TextObject>(Module.CurrentModule.IsOnlyCoreContentEnabled, new TextObject("{=V8BXjyYq}Disabled during installation."))));
        }

        private void StartGame(LoadResult loadResult)
        {
            MBGameManager.StartNewGame(new SandBoxGameManager(loadResult));
        }
    }
}