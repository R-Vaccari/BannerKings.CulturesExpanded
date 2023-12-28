using BannerKings.Models.Vanilla;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.Localization;
using BannerKings.Settings;

namespace BannerKings.CulturesExpanded.Models
{
    public class BKCEPartySpeedModel : BKPartySpeedModel
    {
        public override ExplainedNumber CalculateFinalSpeed(MobileParty mobileParty, ExplainedNumber finalSpeed)
        {
            if (TaleWorlds.CampaignSystem.Campaign.Current.MapSceneWrapper.GetFaceTerrainType(mobileParty.CurrentNavigationFace) == TerrainType.Swamp)
            {
                bool description = mobileParty.ActualClan == Clan.PlayerClan;
                ExplainedNumber speed = new ExplainedNumber(2f, description);

                if (mobileParty.Army != null) speed.AddFactor(-0.2f, new TextObject("{=!}Sailing army"));
                else if (mobileParty.IsCaravan) speed.AddFactor(0.12f, new TextObject("{=!}Sailing caravan"));

                string culture = mobileParty.ActualClan != null ? mobileParty.ActualClan.Culture.StringId :
                    mobileParty.Owner.Culture.StringId;
                if (culture == "nord" || culture == "kannic" || culture == "geroia") speed.Add(0.15f, GameTexts.FindText("str_culture"));

                if (BannerKingsSettings.Instance.SlowerParties > 0f)
                {
                    speed.AddFactor(-BannerKingsSettings.Instance.SlowerParties, new TextObject("{=OohdenyR}Slower Parties setting"));
                }

                return speed;
            }

            ExplainedNumber newFinalSpeed = base.CalculateFinalSpeed(mobileParty, finalSpeed);
            return newFinalSpeed;
        }
    }
}
