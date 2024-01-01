using BannerKings.Managers.Institutions.Religions.Faiths;
using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Localization;

namespace BannerKings.CulturesExpanded.Religions
{
    public class Ahhakism : PolytheisticFaith
    {
        public override Settlement FaithSeat => Settlement.All.First(x => x.StringId == "town_K6");
        public override Banner GetBanner() => new Banner("11.4.2.1528.1528.764.764.1.0.0.10058.22.3.483.483.764.764.0.0.0");

        public override TextObject GetBlessingAction() => new TextObject("{=!}I would like to pay tribute to the Yazatas.");

        public override TextObject GetBlessingActionName() => new TextObject("{=!}pay tribute to.");

        public override TextObject GetBlessingConfirmQuestion() => new TextObject("{=!}Confirm to me thy tribute to the Yazatas.");

        public override TextObject GetBlessingQuestion() => new TextObject("{=!}Thou wishest to pay tribute to Ahhak, Yatuanshah?");

        public override TextObject GetBlessingQuickInformation() => new TextObject("{=!}{HERO} has paid tributed to {DIVINITY}.");

        public override TextObject GetClergyForbiddenAnswer(int rank) => new TextObject("{=!}Take not heed of the fools of the Atashyasna. They will try to impose rules on thee. What is forbidden? Naught!");

        public override TextObject GetClergyForbiddenAnswerLast(int rank) => new TextObject("{=!}Ahhak, Yatuanshah taught us his wisdom: to take what is ours. He killed our enemies and fed to his snakes. Their wives and children, enslaved for his kingdom. We must not meet the enemy with mercy, for they will have none towards us.");

        public override TextObject GetClergyGreeting(int rank) => 
            new TextObject("{=!}Drod, stranger. I see thou art not one of our flock. Perhaps thou wishest to hear the wisdom of Ahhak, Yatuanshah?");

        public override TextObject GetClergyGreetingInducted(int rank) =>
            new TextObject("{=!}Drod abar to, follower of the Yatuanshah. I serve our Shah, Ahhak, as his Yatugar. Comest to me if thou needest the wisdom of the Yazatas and sorceries.");

        public override TextObject GetClergyInduction(int rank)
        {
            var induction = GetInductionAllowed(Hero.MainHero, rank);
            if (!induction.Item1)
            {
                return new TextObject("{=!}Thou art not one fit for the wisdom of the Yazatas, foreign blood.[rf:convo_bored]");
            }

            return new TextObject("{=!}Be welcome, {PLAYER.NAME}. Thou art wise to ignore the fools of the Atashyasna and take ear for the wisdom of Ahhak, King of Sorcery![if:convo_excited]");
        }

        public override TextObject GetClergyInductionLast(int rank)
        {
            var induction = GetInductionAllowed(Hero.MainHero, rank);
            if (!induction.Item1)
            {
                return new TextObject("{=!}Embrace our ancestors, the Darshi, or perhaps join the Devseg horselords in their pursuit. We have embraced the horselords of Odokh, for they have embraced our ways in return.[rf:convo_bored]");
            }

            return new TextObject("{=!}Whenever thou needest sorcery, come to me and I shall help thee. Many outside our flock will try to pursue and shame thee, but here thou art welcome, and through the wisdom of the Yazatas thou shalt prevail![if:convo_excited]");
        }

        public override TextObject GetClergyPreachingAnswer(int rank) => 
            new TextObject("{=!}The wisdom of Ahhak, Yatuanshah. Havest though heard of him? Perhaps thou havest heard lies from the Herbads and Mowbeds of the Atashyasna. They lie because of their ignorance, their fear of the truth - that their Flame does not burn as bright as they would like to believe!");

        public override TextObject GetClergyPreachingAnswerLast(int rank) =>
            new TextObject("{=!}Ahhak, our king, made streams spring from the Kohi Rohini. Erected the walls of Odokh. We own our livelihoods to him. For this we uphold his teachings - that of strength, and sorcery.");

        public override TextObject GetClergyProveFaith(int rank) =>
            new TextObject("{=!}Thou shalt be worthy of Ahhak when thou upholdest his teachings. Beest strong and show no quarter to thy enemies.");

        public override TextObject GetClergyProveFaithLast(int rank) =>
            new TextObject("{=!}Ahhak, our king, made streams spring from the Kohi Rohini. Erected the walls of Odokh. We own our livelihoods to him. For this we uphold his teachings - that of strength, and sorcery.");

        public override TextObject GetCultsDescription() => new TextObject("{=!}Yazatas");

        public override TextObject GetDescriptionHint() => new TextObject("{=!}Ahhakyasna is a cult developed in the Kohi Rohini region, when it was still ruled by the Darshi. Ahhak, King of Sorcery, is the core of the faith. Darshi of the Atashyasna claim he was a demon and tyrant, all but the opposite of good. Ahhakyasna, his followers, claim the Immortal Flame lies, and that Ahhak founded Odokh and its surroundings, bringing prosperity to his subjects.");

        public override TextObject GetFaithDescription() => new TextObject("{=!}Ahhakyasna is a cult developed in the Kohi Rohini region, when it was still ruled by the Darshi. Ahhak, King of Sorcery, is the core of the faith. Darshi of the Atashyasna claim he was a demon and tyrant, all but the opposite of good. Ahhakyasna, his followers, claim the Immortal Flame lies, and that Ahhak founded Odokh and its surroundings, bringing prosperity to his subjects. Faithful of the Ahhakyasna hold Ahhak to be one the Yazatas - holy beings within the Darshi theology. They recognize the Atash Amesha - the main Yazata of the Atashyasna - but claim the clergy of the Atashyasna lie, are ignorant and corrupt on the nature of their faith. Both faiths remain entirely hostile to each other.");

        public override TextObject GetFaithName() => new TextObject("{=!}Ahhakyasna");

        public override string GetId() => "ahhak";

        public override int GetIdealRank(Settlement settlement) => 1;

        public override (bool, TextObject) GetInductionAllowed(Hero hero, int rank)
        {
            if (IsCultureNaturalFaith(hero.Culture) || hero.Culture.StringId == "khuzait")
            {
                return new(true, new TextObject("{=GAuAoQDG}You will be converted"));
            }

            if (hero.MapFaction != null && hero.MapFaction.IsKingdomFaction && hero.MapFaction.Culture.StringId == BannerKingsConfig.KhuzaitCulture)
            {
                return new(true, new TextObject("{=GAuAoQDG}You will be converted"));
            }

            return new(false, GetInductionExplanationText());
        }

        public override TextObject GetInductionExplanationText() => new TextObject("{=!}Must be of Darshi or Devseg culture, or serve a Devseg realm");

        public override int GetMaxClergyRank() => 1;

        public override TextObject GetRankTitle(int rank) => new TextObject("{=!}Yatugar"); //sorcerer

        public override TextObject GetZealotsGroupName() => new TextObject("{=!}Ahhakan Hamrahan");

        public override bool IsCultureNaturalFaith(CultureObject culture) => false;

        public override bool IsHeroNaturalFaith(Hero hero)
        {
            if (hero.IsNotable) return hero.CurrentSettlement.StringId == "town_K6";
            else if (hero.Clan != null) return hero.Clan.StringId == "clan_khuzait_5";

            return false;
        }
    }
}
