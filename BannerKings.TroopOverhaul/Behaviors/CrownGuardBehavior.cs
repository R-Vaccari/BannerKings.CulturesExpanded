﻿using BannerKings.Behaviours;
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
            if (kingdom.StringId == "empire") return Campaign.Current.ObjectManager.GetObject<CharacterObject>("bk_laconian_guard");
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
                Hero ruler = kingdom.RulingClan.Leader;
                if (ruler == Hero.MainHero) continue;

                CrownGuardGoal goal = new CrownGuardGoal(ruler);
                goal.DoAiDecision();
            }
        }
    }
}