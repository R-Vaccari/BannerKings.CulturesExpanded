using BannerKings.Behaviours;
using BannerKings.CulturesExpanded.Goals;
using System.Collections.Generic;
using TaleWorlds.CampaignSystem;

namespace BannerKings.CulturesExpanded.Behaviors
{
    public class CrownGuardBehavior : BannerKingsBehavior
    {
        private Dictionary<Kingdom, CampaignTime> kingdoms = new Dictionary<Kingdom, CampaignTime>(6);

        public bool IsTimeReady(Kingdom kingdom) => !kingdoms.ContainsKey(kingdom) || kingdoms[kingdom].ElapsedYearsUntilNow >= 5f;
        public void SetTime(Kingdom kingdom) => kingdoms[kingdom] = CampaignTime.Now;

        public CharacterObject GetKingdomTroop(Kingdom kingdom)
        {
            if (kingdom.StringId == "empire") return TaleWorlds.CampaignSystem.Campaign.Current.ObjectManager.GetObject<CharacterObject>("bk_laconian_guard");
            if (kingdom.Culture.StringId == "battania") return TaleWorlds.CampaignSystem.Campaign.Current.ObjectManager.GetObject<CharacterObject>("bk_battanian_teulu");
            if (kingdom.Culture.StringId == "khuzait") return TaleWorlds.CampaignSystem.Campaign.Current.ObjectManager.GetObject<CharacterObject>("bk_khuzait_glaiveman");
            return null;
        }

        public override void RegisterEvents()
        {
            CampaignEvents.WeeklyTickEvent.AddNonSerializedListener(this, OnWeeklyTick);
        }

        public override void SyncData(IDataStore dataStore)
        {
            dataStore.SyncData("bkto_crown_guard_timer", ref kingdoms);
            if (kingdoms == null) kingdoms = new Dictionary<Kingdom, CampaignTime>(6);
        }

        private void OnWeeklyTick()
        {
            foreach (var kingdom in Kingdom.All)
            {
                if (kingdom.IsEliminated) continue;

                Hero ruler = kingdom.RulingClan.Leader;
                if (ruler == Hero.MainHero) continue;

                CrownGuardGoal goal = new CrownGuardGoal(ruler);
                goal.DoAiDecision();
            }
        }
    }
}
