using BannerKings.CulturesExpanded.Behaviors;
using BannerKings.CulturesExpanded.Cultures;
using BannerKings.CulturesExpanded.Goals;
using BannerKings.CulturesExpanded.Models;
using BannerKings.CulturesExpanded.Religions;
using SandBox.View;
using System;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.Localization;
using TaleWorlds.MountAndBlade;
using TaleWorlds.ScreenSystem;
using SandBox;
using TaleWorlds.SaveSystem.Load;
using TaleWorlds.SaveSystem;
using TaleWorlds.MountAndBlade.View;
using BannerKings.CulturesExpanded.CharacterCreation;

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
            base.OnSubModuleLoad();
            Module.CurrentModule.ClearStateOptions();

            Module.CurrentModule.AddInitialStateOption(new InitialStateOption("CampaignResumeGame", new TextObject("{=6mN03uTP}Saved Games", null), 0, delegate ()
            {
                ScreenManager.PushScreen(SandBoxViewCreator.CreateSaveLoadScreen(false));
            }, () => new ValueTuple<bool, TextObject>(Module.CurrentModule.IsOnlyCoreContentEnabled, new TextObject("{=V8BXjyYq}Disabled during installation."))));

            Module.CurrentModule.AddInitialStateOption(new InitialStateOption("ContinueCampaign", new TextObject("{=0tJ1oarX}Continue Campaign", null), 1,
                new Action(this.ContinueCampaign), () => this.IsContinueCampaignDisabled()));

            Module.CurrentModule.AddInitialStateOption(new InitialStateOption("BKCE", new TextObject("{=!}Banner Kings: Cultures Expanded", null), 3, delegate ()
            {
                MBGameManager.StartNewGame(new BKCEGameManager());
            }, () => new ValueTuple<bool, TextObject>(Module.CurrentModule.IsOnlyCoreContentEnabled, new TextObject("{=V8BXjyYq}Disabled during installation."))));

            Module.CurrentModule.AddInitialStateOption(new InitialStateOption("Options", new TextObject("{=NqarFr4P}Options", null), 9998, delegate ()
            {
                ScreenManager.PushScreen(ViewCreator.CreateOptionsScreen(true));
            }, () => new ValueTuple<bool, TextObject>(false, TextObject.Empty)));
            Module.CurrentModule.AddInitialStateOption(new InitialStateOption("Credits", new TextObject("{=ODQmOrIw}Credits", null), 9999, delegate ()
            {
                ScreenManager.PushScreen(ViewCreator.CreateCreditsScreen());
            }, () => new ValueTuple<bool, TextObject>(false, TextObject.Empty)));
            Module.CurrentModule.AddInitialStateOption(new InitialStateOption("Exit", new TextObject("{=YbpzLHzk}Exit Game", null), 10000, delegate ()
            {
                MBInitialScreenBase.DoExitButtonAction();
            }, () => new ValueTuple<bool, TextObject>(Module.CurrentModule.IsOnlyCoreContentEnabled, new TextObject("{=V8BXjyYq}Disabled during installation."))));
        }

        private ValueTuple<bool, TextObject> IsContinueCampaignDisabled()
        {
            if (Module.CurrentModule.IsOnlyCoreContentEnabled)
            {
                return new ValueTuple<bool, TextObject>(true, new TextObject("{=V8BXjyYq}Disabled during installation.", null));
            }
            if (string.IsNullOrEmpty(BannerlordConfig.LatestSaveGameName))
            {
                return new ValueTuple<bool, TextObject>(true, new TextObject("{=aWMZQKXZ}Save the game at least once to continue", null));
            }
            SaveGameFileInfo saveFileWithName = MBSaveLoad.GetSaveFileWithName(BannerlordConfig.LatestSaveGameName);
            if (saveFileWithName == null)
            {
                return new ValueTuple<bool, TextObject>(true, new TextObject("{=60LTq0tQ}Can't find the save file for the latest save game.", null));
            }
            if (saveFileWithName.IsCorrupted)
            {
                return new ValueTuple<bool, TextObject>(true, new TextObject("{=t6W3UjG0}Save game file appear to be corrupted. Try starting a new campaign or load another one from Saved Games menu.", null));
            }
            return new ValueTuple<bool, TextObject>(false, TextObject.Empty);
        }

        private void ContinueCampaign()
        {
            SaveGameFileInfo saveFileWithName = MBSaveLoad.GetSaveFileWithName(BannerlordConfig.LatestSaveGameName);
            if (saveFileWithName != null && !saveFileWithName.IsCorrupted)
            {
                SandBoxSaveHelper.TryLoadSave(saveFileWithName, new Action<LoadResult>(this.StartGame), null);
                return;
            }
            InformationManager.ShowInquiry(new InquiryData(new TextObject("{=oZrVNUOk}Error", null).ToString(), new TextObject("{=t6W3UjG0}Save game file appear to be corrupted. Try starting a new campaign or load another one from Saved Games menu.", null).ToString(), true, false, new TextObject("{=yS7PvrTD}OK", null).ToString(), null, null, null, "", 0f, null, null, null), false, false);
        }

        private void StartGame(LoadResult loadResult)
        {
            MBGameManager.StartNewGame(new SandBoxGameManager(loadResult));
        }
    }
}