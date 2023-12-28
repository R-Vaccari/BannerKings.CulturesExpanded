using BannerKings.Managers.Institutions.Religions.Faiths;
using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Localization;

namespace BannerKings.CulturesExpanded.Religions
{
    public class Siri : PolytheisticFaith
    {
        public override Settlement FaithSeat => Settlement.All.First(x => x.StringId == "town_A10");
        public override Banner GetBanner() => new Banner("11.162.166.1528.1528.764.764.1.0.0.10134.212.116.400.400.755.755.0.0.0");

        public override TextObject GetBlessingAction() => new TextObject("{=!}I would like to be blessed by the gods.");

        public override TextObject GetBlessingActionName() => new TextObject("{=!}be blessed by.");

        public override TextObject GetBlessingConfirmQuestion() => 
            new TextObject("{=!}Confirm to me thy pledge to me before I commune with the godly realm.");

        public override TextObject GetBlessingQuestion() =>
            new TextObject("{=!}Dost thou seek the blessing of Laha Mouei, king of the Nahasa?");

        public override TextObject GetBlessingQuickInformation() =>
            new TextObject("{=!}{HERO} is blessed by {DIVINITY}.");

        public override TextObject GetClergyForbiddenAnswer(int rank) =>
            new TextObject("{=!}Above all, being prey to thy enemies. This any of the Siri knows. Does the lion flee from the sheep? To count among the pride of the gods is to follow their teachings.");

        public override TextObject GetClergyForbiddenAnswerLast(int rank) =>
            new TextObject("{=!}Be not afraid of thy enemies. Accept not disrepect. Twist not thy words: let them be direct and truthful. A lion does not bend his word. Pay tribute to the gods and teach thy children our ways.");

        public override TextObject GetClergyGreeting(int rank) =>
            new TextObject("{=!}Hail to thee, stranger. I see thou art not part of our pride. Here my Siri kinsfolk come to me, their Tillik-Itt. A woman of the gods, if you must. Thou art welcome to hear about the wisdom of our gods.");

        public override TextObject GetClergyGreetingInducted(int rank) =>
            new TextObject("{=!}Be welcome, {?PLAYER.GENDER}lioness{?}lion{\\?} brethen. I serve the gods here as their Tillik-Itt. Come to me if thou wishest to commune with them, or hear their wisdom.");

        public override TextObject GetClergyInduction(int rank)
        {
            var induction = GetInductionAllowed(Hero.MainHero, rank);
            if (!induction.Item1)
            {
                return new TextObject("{=!}Thou art not fit to be of our pride. If thou wishest to be with the gods, learnest our ways, the Siri ways.[if:convo_bored]");
            }

            return new TextObject("{=!}Be welcome to our pride, {PLAYER.NAME}. You shall now be known as a {?PLAYER.GENDER}lioness{?}lion{\\?} amongst our kinsfolk.");
        }

        public override TextObject GetClergyInductionLast(int rank)
        {
            var induction = GetInductionAllowed(Hero.MainHero, rank);
            if (!induction.Item1)
            {
                return new TextObject("{=!}{?PLAYER.GENDER}Or if thou wishest to prove thyself as a lioness, hunt as one. All Siri women learn the way of the hunt: to pursue and kill.{?}As a man, that is all thou canst do. Learn our ways, perhaps take thyself a good Siri wife - one that could provide strong cubs.{\\?}[if:convo_bored]");
            }

            return new TextObject("{=!}Comest to me whenever thou needest guidance or wisdom from the gods. Now go, and bolster the strength of our pride!");
        }

        public override TextObject GetClergyPreachingAnswer(int rank) =>
            new TextObject("{=!}We Tillik-Itt, the wisewomen of the Siri, teach our kinsfolk the wisdom of the gods. For the gods have many good things to teach us: strength, honor, pride.");

        public override TextObject GetClergyPreachingAnswerLast(int rank) =>
            new TextObject("{=!}Such is the way we Siri have lived by the Aman, the holy water, since a time woman and man were but children.");

        public override TextObject GetClergyProveFaith(int rank) =>
            new TextObject("{=!}If thou wishest to prove thy faith: the Great Lion takes kindly to offerings of food. Bring honey, the nectar of the gods, and they surely shall be pleased. Or if thou wishest, bring a bull to Laha Mouei. The lion must feed, and so a sacrifice must be made.");

        public override TextObject GetClergyProveFaithLast(int rank) =>
            new TextObject("{=!}And of course, live by the wisdom of the gods.");

        public override TextObject GetCultsDescription() => new TextObject("{=!}Gods");

        public override TextObject GetDescriptionHint() => new TextObject("{=!}The ancient beliefs of the Siri revolve around the river Aman, the holy water, and various animal or animalistic gods. Each of them a symbol to the Siri culture and faith. Highest among them all is the lion, represented by Laha Mouei, the Great Lion God. The Tillik-Itt, Siri wisewomen, tell such tales through glyphs and oral traditions, and claim the Siri are descendants of Laha Mouei.");

        public override TextObject GetFaithDescription() => new TextObject("{=!}The ancient beliefs of the Siri revolve around the river Aman, the holy water, and various animal or animalistic gods. Each of them a symbol to the Siri culture and faith. Highest among them all is the lion, represented by Laha Mouei, the Great Lion God. Among other animals, the cow is often associated with ferility and abundance, while the ram brings protection. The Tillik-Itt, Siri wisewomen, tell such tales through glyphs and oral traditions, and claim the Siri are descendants of Laha Mouei. In their matriarchal traditions, women of honour are expected to hunt and kill, not unlike lionesses.");

        public override TextObject GetFaithName() => new TextObject("{=!}Tillik-Deger");

        public override string GetId() => "siri";

        public override int GetIdealRank(Settlement settlement)
        {
            if (settlement == FaithSeat) return 2;
            return 1;
        }

        public override (bool, TextObject) GetInductionAllowed(Hero hero, int rank)
        {
            if (IsCultureNaturalFaith(hero.Culture))
            {
                return new(true, new TextObject("{=GAuAoQDG}You will be converted"));
            }

            if (hero.IsFemale && hero.GetSkillValue(DefaultSkills.Athletics) >= 50 && hero.GetSkillValue(DefaultSkills.Bow) >= 50)
            {
                return new(true, new TextObject("{=GAuAoQDG}You will be converted"));
            }

            return new(false, GetInductionExplanationText());
        }

        public override TextObject GetInductionExplanationText() => new TextObject("{=!}The faith only accepts those of Siri culture, or women with at least 50 Athletics and Bow skills");

        public override int GetMaxClergyRank() => 2;

        public override TextObject GetRankTitle(int rank)
        {
            if (rank == 2) new TextObject("{=!}Tillik-Unnol");
            return new TextObject("{=!}Tillik-Itt");
        }

        public override TextObject GetZealotsGroupName() => new TextObject("{=!}Amana Mooui"); //Aman's lions

        public override bool IsCultureNaturalFaith(CultureObject culture) => culture.StringId == "siri";

        public override bool IsHeroNaturalFaith(Hero hero) => IsCultureNaturalFaith(hero.Culture);
    }
}
