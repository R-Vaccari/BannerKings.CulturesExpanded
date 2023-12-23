using TaleWorlds.CampaignSystem.CharacterCreationContent;
using TaleWorlds.Library;

namespace BannerKings.CulturesExpanded.CharacterCreation
{
    internal class BKCECreationContent : SandboxCharacterCreationContent
    {
        protected override void OnInitialized(TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreation characterCreation)
        {
            base.OnInitialized(characterCreation);
            _startingPoints.Add("siri", new Vec2(385.5405f, 53.993f));
            _startingPoints.Add("darshi", new Vec2(764.147f, 147.43f));
            _startingPoints.Add("geroia", new Vec2(478.6044f, 217.9456f));
            _startingPoints.Add("nord", new Vec2(172.637f, 589.918f));
            _startingPoints.Add("massa", new Vec2(193.524f, 185.269f));
            _startingPoints.Add("vakken", new Vec2(640.26f, 625.285f));
        }
    }
}
