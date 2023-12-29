using BannerKings.Managers.Institutions.Religions.Faiths;
using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Localization;

namespace BannerKings.CulturesExpanded.Religions
{
    public class ImmortalFlame : PolytheisticFaith
    {
        public override Settlement FaithSeat => Settlement.All.First(x => x.StringId == "town_Darshi_1");
        //34.212.149.1716.1948.768.746.0.0.0.10079.207.41.712.540.755.755.0.0.0
        public override Banner GetBanner() => new Banner("11.149.40.1836.1836.768.774.1.0.0.321.128.149.184.186.764.884.1.1.0.218.85.149.270.250.804.664.1.1.338.218.85.149.270.250.724.664.1.1.22.218.71.149.280.282.764.664.1.1.0");

        public override TextObject GetBlessingAction() => new TextObject("{=!}I would like to be blessed by the Yazatas.");

        public override TextObject GetBlessingActionName() => new TextObject("{=!}pay tribute to");

        public override TextObject GetBlessingConfirmQuestion() => new TextObject("{=!}Confirm to me thy tribute to the Yazatas.");

        public override TextObject GetBlessingQuestion() => new TextObject("{=!}Thou wishest to give kindling to the Atash Amesha?");

        public override TextObject GetBlessingQuickInformation() => new TextObject("{=!}{HERO} has paid tributed to {DIVINITY}.");

        public override TextObject GetClergyForbiddenAnswer(int rank) => new TextObject("{=!}To stray from the way of the Atash and the Darshianshahr. The tomes of the Atash teach us of good and evil. To be a follower of the Atash is to uphold good. For this reason, thou shalt not conspire with those of the Ahhakyasna. They pray to demons, and shall be purified by the Flame.");

        public override TextObject GetClergyForbiddenAnswerLast(int rank) => new TextObject("{=!}Above all, wield thy wisdom against thy vices. Uphold thy word, gather thy strength and protect thy kin. Beest kind and selfless to thy neighbour, and expect not rewards.");

        public override TextObject GetClergyGreeting(int rank) =>
            new TextObject("{=!}Drod, stranger. This is the place of the Atash Amesha. Perhaps though wishest to feel the warmth of the Flame?");

        public override TextObject GetClergyGreetingInducted(int rank) 
        {

            return new TextObject("{=!}Drod abar to, {?PLAYER.GENDER}kinswoman{?}kinsman{\\?}. I serve here as a {PREACHER} of our people, and keeper of the Atash. Comest to me if thou wishest to feel its tender warmth.")
                .SetTextVariable("PREACHER", GetRankTitle(rank));
        }
        

        public override TextObject GetClergyInduction(int rank)
        {
            var induction = GetInductionAllowed(Hero.MainHero, rank);
            if (!induction.Item1)
            {
                return new TextObject("{=!}Thou art not yet fit to be part of our Yasna. Uphold the ways of the Darshianshahr and cleanse thy sins. Until then, I would not grant you the warmth of the Flame.");
            }

            return new TextObject("{=!}I see thou upholdest the values of our wise ancestors. Beest welcome, {PLAYER.NAME}, to the warmth of our Yasna.");
        }

        public override TextObject GetClergyInductionLast(int rank)
        {
            var induction = GetInductionAllowed(Hero.MainHero, rank);
            if (!induction.Item1)
            {
                return new TextObject("{=!}Uphold the values of the Flame and of the Darshianshahr. Take thyself a good spouse of our ways to guide thee into our faith, become one of us, or serve the Shahanshah. Only then thou wouldst be fit for our Yasna.");
            }

            return new TextObject("{=!}Now, stray not thyself from the Atash. Wherever though goest, live by its tenets: wisdom, just and good judgement, benevolence and strength.");
        }

        public override TextObject GetClergyPreachingAnswer(int rank)
        {
            return new TextObject("{=!}The way of the Atash Amesha, known to foreigners as the Immortal Flame. The Atash we keep burning since countless generations of our ancestors. They have written down their wisdom for us, and we, learned keepers of the Flame, guard this treasure.");
        }

        public override TextObject GetClergyPreachingAnswerLast(int rank)
        {
            return new TextObject("{=!}We Darshi serve our Shahanshah, King of Kings, yet he himself serves the Atash. We preach not for others to follow our ways. When the Shahanshah conquers a king, he, in good wisdom, allows his new subjects to remain misaligned. But for those that wish to serve Truth, we are here to guide them.");
        }

        public override TextObject GetClergyProveFaith(int rank)
        {
            return new TextObject("{=!}Take thyself a good spouse of our ways to guide thee into our faith, {?PLAYER.GENDER}he{?}she{\\?} will be thy light out of the ignorant darkness.");
        }

        public override TextObject GetClergyProveFaithLast(int rank)
        {
            return new TextObject("{=!}Alternatively, become one of us. Assume the way of the Darshi. Or if though wishest, serve the Shahanshah as one of his vassals. If he judges you fit to serve the Darshianshahr, then thou wouldst be welcome in our Yasna.");
        }

        public override TextObject GetCultsDescription() => new TextObject("{=!}Yazatas");

        public override TextObject GetDescriptionHint() => 
            new TextObject("{=!}Atashyasna is the ancient belief system of the Darshi. They believe the Immortal Flame, Atash Amesha, is a force both of creation and desctruction - or in sum, purification. The Flame is the primary Yazata, or Divine Force, within their theology, and responsible for the creation of the world and mankind. Other Yazatas are also part of their faith, such as Aspas Suras, the Holy Waters, associated with bountiful prosperity.");

        public override TextObject GetFaithDescription() =>
            new TextObject("{=!}Atashyasna is the ancient belief system of the Darshi. They believe the Immortal Flame, Atash Amesha, is a force both of creation and desctruction - or in sum, purification. The Flame is the primary Yazata, or Divine Force, within their theology, and responsible for the creation of the world and mankind. Other Yazatas are also part of their faith, such as Aspas Suras, the Holy Waters, associated with bountiful prosperity. In sum, their belief is centered around divine forces that govern the cosmos, and these forces do not take human form. In the end of the world, the Darshi believe, all land will be inundated with molten, sacred metal, and only those already purified by the Flame will survive it, while the rest will burn away.");

        public override TextObject GetFaithName() => new TextObject("{=!}Atashyasna");

        public override string GetId() => "atash";

        public override int GetIdealRank(Settlement settlement)
        {
            if (settlement == FaithSeat) return 3;
            if (settlement.Town != null) return 2;
            return 1;
        }

        public override (bool, TextObject) GetInductionAllowed(Hero hero, int rank)
        {
            if (IsCultureNaturalFaith(hero.Culture))
            {
                return new(true, new TextObject("{=GAuAoQDG}You will be converted"));
            }

            if (hero.Spouse != null && IsCultureNaturalFaith(hero.Spouse.Culture) &&
                BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(hero.Spouse) == BKCEReligions.Instance.ImmortalFlame)
            {
                return new(true, new TextObject("{=GAuAoQDG}You will be converted"));
            }

            if (hero.MapFaction != null && hero.MapFaction.IsKingdomFaction && hero.MapFaction.Culture.StringId == "darshi")
            {
                return new(true, new TextObject("{=GAuAoQDG}You will be converted"));
            }

            return new(false, GetInductionExplanationText());
        }

        public override TextObject GetInductionExplanationText() => new TextObject("{=!}The faith only accepts those of Darshi culture, spouses of a Darshi faithful or that serve a Darshi realm");

        public override int GetMaxClergyRank() => 3;

        public override TextObject GetRankTitle(int rank)
        {
            if (rank == 3) return new TextObject("{=!}Dastur");
            if (rank == 2) return new TextObject("{=!}Mowbed");
            return new TextObject("{=!}Hirbad");
        }

        public override TextObject GetZealotsGroupName() => new TextObject("{=!}Anausaran");

        public override bool IsCultureNaturalFaith(CultureObject culture) => culture.StringId == "darshi";

        public override bool IsHeroNaturalFaith(Hero hero) => IsCultureNaturalFaith(hero.Culture);
    }
}
