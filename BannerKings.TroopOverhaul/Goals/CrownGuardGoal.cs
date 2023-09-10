using BannerKings.CulturesExpanded.Behaviors;
using BannerKings.Managers.Goals;
using BannerKings.Managers.Populations;
using System.Collections.Generic;
using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.Localization;

namespace BannerKings.CulturesExpanded.Goals
{
    public class CrownGuardGoal : Goal
    {
        private int guardsAmount = -1;

        public CrownGuardGoal(Hero fulfiller = null) : base("goal_royal_guard_decision", GoalCategory.Kingdom, GoalUpdateType.Manual, fulfiller)
        {
            var name = new TextObject("{=!}Summon Crown Guards");
            var description = new TextObject("{=!}\n");

            Initialize(name, description);
        }

        public override bool IsAvailable() => Clan.PlayerClan.Kingdom != null && Clan.PlayerClan.Kingdom.RulingClan == Clan.PlayerClan;

        public override bool IsFulfilled(out List<TextObject> failedReasons)
        {
            failedReasons = new List<TextObject>();

            var behavior = Campaign.Current.GetCampaignBehavior<CrownGuardBehavior>();
            Kingdom kingdom = GetFulfiller().Clan.Kingdom;

            if (!behavior.IsTimeReady(kingdom))
            {
                failedReasons.Add(new TextObject("{=!}It has been less than 5 years since guards were drawn"));
            }

            if (behavior.GetKingdomTroop(kingdom) == null)
            {
                failedReasons.Add(new TextObject("{=!}No guard template available for your kingdom"));
            }

            if (GetAvailableManpower(kingdom) < 20)
            {
                failedReasons.Add(new TextObject("{=!}Insufficient noble manpower in the realm"));
            }

            return failedReasons.IsEmpty();
        }

        private int GetAvailableManpower(Kingdom kingdom)
        {
            int result = 0;
            foreach (var fief in kingdom.Fiefs)
            {
                PopulationData data = BannerKingsConfig.Instance.PopulationManager.GetPopData(fief.Settlement);
                result += (int)(data.MilitaryData.NobleManpower * 0.5f);
            }

            return result;
        }

        public override void ShowInquiry()
        {
            var options = new List<InquiryElement>();
            Kingdom kingdom = Clan.PlayerClan.Kingdom;
            int manpower = GetAvailableManpower(kingdom);
            int div = MathF.Floor(manpower / 10f);

            var behavior = Campaign.Current.GetCampaignBehavior<CrownGuardBehavior>();
            CharacterObject troop = behavior.GetKingdomTroop(kingdom);
            int cost = (int)(Campaign.Current.Models.PartyWageModel.GetTroopRecruitmentCost(troop, Hero.MainHero) * 3f);

            for (int i = 1; i <= div; i++)
            {
                int count = (int)(10f * i);
                int totalCost = (int)(cost * count);
                bool enabled = true;
                TextObject hint = TextObject.Empty;

                if (count > MobileParty.MainParty.LimitedPartySize - MobileParty.MainParty.MemberRoster.TotalManCount)
                {
                    enabled = false;
                    hint = new TextObject("{=!}Not enough party space.");
                }

                if (totalCost > Hero.MainHero.Gold)
                {
                    enabled = false;
                    hint = new TextObject("{=!}Not enough money.");
                }

                options.Add(new InquiryElement(count,
                    new TextObject("{=!}{COUNT} {TROOP} - {GOLD}{GOLD_ICON}")
                    .SetTextVariable("GOLD", totalCost)
                    .SetTextVariable("TROOP", troop.Name)
                    .SetTextVariable("COUNT", count)
                    .ToString(),
                    new ImageIdentifier(CharacterCode.CreateFrom(troop)),
                    enabled,
                    hint.ToString()
                    ));
            }

            int space = MathF.Max(MobileParty.MainParty.LimitedPartySize - MobileParty.MainParty.MemberRoster.TotalManCount, 0);
            MBInformationManager.ShowMultiSelectionInquiry(new MultiSelectionInquiryData(
                new TextObject("{=!}Summon Crown Guards").ToString(),
                new TextObject("{=!}Summon volunteers to serve as guards for the crown. Such volunteers are drawn from the nobility and are excellent combatants in their fighting tradition, as well as exceptionally equipped. There are {CANDIDATES} available candidates while your retinue can accomodate {TROOPS} more troops.")
                .SetTextVariable("CANDIDATES", manpower)
                .SetTextVariable("TROOPS", space)
                .ToString(),
                options,
                true,
                1,
                GameTexts.FindText("str_done").ToString(),
                GameTexts.FindText("str_cancel").ToString(),
                delegate (List<InquiryElement> selectedOptions)
                {
                    guardsAmount = (int)selectedOptions.First().Identifier;
                    ApplyGoal();
                },
                null,
                string.Empty));
        }

        public override void ApplyGoal()
        {
            var party = GetFulfiller().PartyBelongedTo;
            if (guardsAmount < 0)
            {
                int space = MathF.Max(party.LimitedPartySize - party.MemberRoster.TotalManCount, 0);
                if (space >= 20) guardsAmount = space;
                else return;
            }

            var kingdom = GetFulfiller().Clan.Kingdom;
            var behavior = Campaign.Current.GetCampaignBehavior<CrownGuardBehavior>();
            CharacterObject troop = behavior.GetKingdomTroop(kingdom);
            int cost = (int)(Campaign.Current.Models.PartyWageModel.GetTroopRecruitmentCost(troop, GetFulfiller()) * 3f);

            if (GetFulfiller().Gold < cost)
            {
                return;
            }

            behavior.SetTime(kingdom);
            for (int i = 0; i < guardsAmount; i++)
            {
                var fief = kingdom.Fiefs.GetRandomElement();
                var data = BannerKingsConfig.Instance.PopulationManager.GetPopData(fief.Settlement);
                int max = MathF.Min(1, (int)data.MilitaryData.NobleManpower);
                if (max > 0)
                {
                    data.MilitaryData.DeduceManpower(data, max, Managers.PopulationManager.PopType.Nobles);
                }

                party.MemberRoster.AddToCounts(troop, 1);
            }

            GetFulfiller().ChangeHeroGold(-cost);
        }

        public override void DoAiDecision()
        {
            Hero hero = GetFulfiller();
            Kingdom kingdom = hero.Clan.Kingdom;
            MobileParty party = hero.PartyBelongedTo;
            if (hero.Clan.Leader != hero || hero.IsPrisoner || party == null || party.LeaderHero != hero || 
                kingdom == null || hero.Clan != kingdom.RulingClan)
            {
                return;
            }

            var list = new List<TextObject>();
            if (!IsFulfilled(out list))
            {
                return;
            }

            var behavior = Campaign.Current.GetCampaignBehavior<CrownGuardBehavior>();
            CharacterObject troop = behavior.GetKingdomTroop(kingdom);
            int manpower = GetAvailableManpower(kingdom);
            int cost = (int)(Campaign.Current.Models.PartyWageModel.GetTroopRecruitmentCost(troop, GetFulfiller()) * 3f);
            int take = MathF.Min(manpower, party.LimitedPartySize - party.MemberRoster.TotalManCount);
            int totalCost = (int)(cost * take);
            if (hero.Gold >= totalCost * 2f)
            {
                ApplyGoal();
            }
        }
    }
}
