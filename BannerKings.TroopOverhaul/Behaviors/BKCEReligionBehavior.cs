using BannerKings.Behaviours;
using BannerKings.CulturesExpanded.Religions;
using BannerKings.Managers.Institutions.Religions;
using System.Collections.Generic;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.Settlements;

namespace BannerKings.CulturesExpanded.Behaviors
{
    public class BKCEReligionBehavior : BannerKingsBehavior
    {
        public override void RegisterEvents()
        {
            CampaignEvents.OnSiegeAftermathAppliedEvent.AddNonSerializedListener(this, OnSiegeAftermath);
        }

        public override void SyncData(IDataStore dataStore)
        {
        }

        private void OnSiegeAftermath(MobileParty attackerParty, Settlement settlement, 
            SiegeAftermathAction.SiegeAftermath aftermathType, 
            Clan previousSettlementOwner, 
            Dictionary<MobileParty, float> partyContributions)
        {
            if (!attackerParty.IsLordParty || attackerParty.LeaderHero == null) return;

            Religion rel = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(attackerParty.LeaderHero);
            if (rel == null)
            {
                return;
            }

            if (aftermathType == SiegeAftermathAction.SiegeAftermath.ShowMercy && rel.HasDoctrine(BKCEDoctrines.Instance.RenovatioImperi))
            {

            }
        }
    }
}
