using SandBox;
using System;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.CharacterCreationContent;
using TaleWorlds.CampaignSystem.Encounters;
using TaleWorlds.CampaignSystem.GameState;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.ModuleManager;
using TaleWorlds.MountAndBlade;
using TaleWorlds.SaveSystem.Load;

namespace BannerKings.CulturesExpanded.CC
{
    internal class BKCEGameManager : SandBoxGameManager
    {
        private bool _loadingSavedGame;
        private LoadResult _loadedGameResult;

        public BKCEGameManager()
        {
            _loadingSavedGame = false;
        }

        public BKCEGameManager(LoadResult loadedGameResult)
        {
            _loadingSavedGame = true;
            _loadedGameResult = loadedGameResult;
        }

        public override void OnLoadFinished()
        {
            if (!this._loadingSavedGame)
            {
                if (!TaleWorlds.Core.Game.Current.IsDevelopmentMode)
                {
                    VideoPlaybackState videoPlaybackState = TaleWorlds.Core.Game.Current.GameStateManager.CreateState<VideoPlaybackState>();
                    string str = ModuleHelper.GetModuleFullPath("SandBox") + "Videos/CampaignIntro/";
                    string subtitleFileBasePath = str + "campaign_intro";
                    string videoPath = str + "campaign_intro.ivf";
                    string audioPath = str + "campaign_intro.ogg";
                    videoPlaybackState.SetStartingParameters(videoPath, audioPath, subtitleFileBasePath, 30f, true);
                    videoPlaybackState.SetOnVideoFinisedDelegate(new Action(this.LaunchSandboxCharacterCreation));
                    TaleWorlds.Core.Game.Current.GameStateManager.CleanAndPushState(videoPlaybackState, 0);
                }
                else
                {
                    this.LaunchSandboxCharacterCreation();
                }
            }
            else
            {
                TaleWorlds.Core.Game.Current.GameStateManager.OnSavedGameLoadFinished();
                TaleWorlds.Core.Game.Current.GameStateManager.CleanAndPushState(TaleWorlds.Core.Game.Current.GameStateManager.CreateState<MapState>(), 0);
                MapState mapState = TaleWorlds.Core.Game.Current.GameStateManager.ActiveState as MapState;
                string text = (mapState != null) ? mapState.GameMenuId : null;
                if (!string.IsNullOrEmpty(text))
                {
                    PlayerEncounter playerEncounter = PlayerEncounter.Current;
                    if (playerEncounter != null)
                    {
                        playerEncounter.OnLoad();
                    }
                    TaleWorlds.CampaignSystem.Campaign.Current.GameMenuManager.SetNextMenu(text);
                }
                PartyBase.MainParty.SetVisualAsDirty();
                TaleWorlds.CampaignSystem.Campaign.Current.CampaignInformationManager.OnGameLoaded();
                foreach (Settlement settlement in Settlement.All)
                {
                    settlement.Party.SetLevelMaskIsDirty();
                }
                CampaignEventDispatcher.Instance.OnGameLoadFinished();
                if (mapState != null)
                {
                    mapState.OnLoadingFinished();
                }
            }
            base.IsLoaded = true;
        }

        private void LaunchSandboxCharacterCreation()
        {
            CharacterCreationState gameState = TaleWorlds.Core.Game.Current.GameStateManager.CreateState<CharacterCreationState>(new object[]
            {
                new BKCECreationContent()
            });
            TaleWorlds.Core.Game.Current.GameStateManager.CleanAndPushState(gameState, 0);
        }
    }
}
