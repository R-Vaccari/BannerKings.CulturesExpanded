using BannerKings.Managers.Institutions.Religions.Faiths;
using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Localization;

namespace BannerKings.CulturesExpanded.Religions
{
    public class Kannic : PolytheisticFaith
    {
        public override Settlement FaithSeat => Settlement.All.First(x => x.StringId == "town_Kanic_1");
        public override Banner GetBanner() => new Banner("11.162.166.1528.1528.764.764.1.0.0.10134.212.116.400.400.755.755.0.0.0");

        public override TextObject GetBlessingAction() => new TextObject("{=!}I would like to be blessed by the gods.");

        public override TextObject GetBlessingActionName() => new TextObject("{=!}be blessed by.");

        public override TextObject GetBlessingConfirmQuestion() =>
            new TextObject("{=!}Confirm to me thy pledge to me before I commune with the spirit realm.");

        public override TextObject GetBlessingQuestion() =>
            new TextObject("{=!}Dost thou seek the blessing of Vine Goddess, or perhaps the protection of the jinn?");

        public override TextObject GetBlessingQuickInformation() =>
            new TextObject("{=!}{HERO} is blessed by {DIVINITY}.");

        public override TextObject GetClergyForbiddenAnswer(int rank)
        {
            if (Hero.MainHero.Culture.StringId == "aserai")
            {
                return new TextObject("{=!}Thy teachings of Asera, of course! Your kind has corruped our Politeia, pillaging our colonies and teaching thy false prophecies.");
            }

            return new TextObject("{=!}");
        }

        public override TextObject GetClergyForbiddenAnswerLast(int rank)
        {
            if (Hero.MainHero.Culture.StringId == "aserai")
            {
                return new TextObject("{=!}Return to thy hut in the desert, your ancestral home. You, the Aserai, have too long sullied our once pristine cities.");
            }

            return new TextObject("{=!}");
        }

        public override TextObject GetClergyGreeting(int rank)
        {
            if (Hero.MainHero.Culture.StringId == "aserai")
            {
                ChangeRelationAction.ApplyPlayerRelation(Hero.OneToOneConversationHero, -5);
                return new TextObject("{=!}Thou art not welcome here, dog of Asera. Begone to the mud huts thy ancestors lived, before they lied and joined the Calradoi in taking our cities of marble. Go wander in the desert where you ought to be.");
            }

            return new TextObject("{=!}Hauo, stranger. I represent the Kannic in our community, and serve as their Kohen. Come to me if thou havest businness with us.");
        }

        public override TextObject GetClergyGreetingInducted(int rank) =>
            new TextObject("{=!}Hauo, {?PLAYER.GENDER}kinswoman{?}kinsman{\\?}. I serve here as the Koken for our folk. Come to me if thou wishest to hear the wisdom of the gods and our ancestors.");

        public override TextObject GetClergyInduction(int rank)
        {
            var induction = GetInductionAllowed(Hero.MainHero, rank);
            if (!induction.Item1)
            {
                return new TextObject("{=!}Thou art not ready to serve the goddess. Ailatyn, the goddess of vines, demands worthy servants.[if:convo_bored]");
            }

            return new TextObject("{=!}Thou art welcome, {?PLAYER.GENDER}kinswoman{?}kinsman{\\?}. Serve the goddess with resolve, and she will reward thee bountifully.");
        }

        public override TextObject GetClergyInductionLast(int rank)
        {
            var induction = GetInductionAllowed(Hero.MainHero, rank);
            if (!induction.Item1)
            {
                return new TextObject("{=!}If thou wishest to serve her, learnest our ways, the Kannic ways. Or be worthy of a true Kannic trader, for this is the art of the goddess.[if:convo_bored]");
            }

            return new TextObject("{=!}Take pride and pay respect to our ancestors. Seek thy place in the world, and win over thy foes, be it by gold or by steel.");
        }

        public override TextObject GetClergyPreachingAnswer(int rank) =>
            new TextObject("{=!}The teachings of Qudshn, the wisdom of the holy ones. Our ancient faith propelled us out of mediocrity and onto the seas, which we conquered. Ailatyn, our divine goddess, taught is that: to trade, to make love, and to wage war.");

        public override TextObject GetClergyPreachingAnswerLast(int rank) =>
            new TextObject("{=!}We follow the teachings of our goddess and of our ancestors such as the hallowed queen Eshora herself. Some of us also commune with the benign jinn, spirits with healing powers. That is what we Kohen, keepers of the holy wisdom, are bound to preserve through our rites.");

        public override TextObject GetClergyProveFaith(int rank) =>
            new TextObject("{=!}Prove thy faith? Take to a ship, and conquer! Conquer thy rivals in trade, conquer thy enemies in war. Seek thy own profit. The gods reward those with the resolve to claim what they do not have. Why wouldst thou not take more coins from thy rivals, given the chance? Make that chance.");

        public override TextObject GetClergyProveFaithLast(int rank) =>
            new TextObject("{=!}Thou couldst also make offerings to the gods. Bring wine - the finer it is, the better - for the goddess of vines, Ailatyn. Or bring a flock of rams, their blood shall feed the earth and please the gods. Such is the way our ancestors have lived and died. The way our goddess taught us.");

        public override TextObject GetCultsDescription() => new TextObject("{=!}Cults");

        public override TextObject GetDescriptionHint() => new TextObject("{=!}The core of the Kannic faith is the Vine Goddess: that which represents wealth, wine, love and war. Their faith once dominated the Perassic and Jade seas, and in every corner of these, one could find the Kannic ships, adorned with the vine leaves of their goddess.");

        public override TextObject GetFaithDescription() => new TextObject("{=!}The core of the Kannic faith is the Vine Goddess: that which represents wealth, wine, love and war. Their faith once dominated the Perassic and Jade seas, and in every corner of these, one could find the Kannic ships, adorned with the vine leaves of their goddess. Spirits, named jinn, are also part of Kannic tradition. Such spirits can be either benign or otherwise. The mighty queen Eshora, to whom the Eshorid claim lineage, is said to be have trapped such jinns with magic.");

        public override TextObject GetFaithName() => new TextObject("{=!}Qudshn"); // the holy ones

        public override string GetId() => "kannic";

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

            if (hero.GetSkillValue(DefaultSkills.Trade) >= 10)
            {
                return new(true, new TextObject("{=GAuAoQDG}You will be converted"));
            }

            if (hero.MapFaction != null && hero.MapFaction.IsKingdomFaction && hero.MapFaction.Culture.StringId == "kannic")
            {
                return new(true, new TextObject("{=GAuAoQDG}You will be converted"));
            }

            return new(false, GetInductionExplanationText());
        }

        public override TextObject GetInductionExplanationText() => new TextObject("{=!}The faith only accepts those of Kannic culture, or those who serve a Kannic realm, or those with at least 100 Trade skill. Must not be of Nahawasi culture.");

        public override int GetMaxClergyRank() => 2;

        public override TextObject GetRankTitle(int rank)
        {
            if (rank == 1) return new TextObject("{=!}Kohen");
            else return new TextObject("{=!}Rab Kohen");
        }

        public override TextObject GetZealotsGroupName() => new TextObject("{=!}Servants of Ailatyn");

        public override bool IsCultureNaturalFaith(CultureObject culture) => culture.StringId == "kannic";

        public override bool IsHeroNaturalFaith(Hero hero) => IsCultureNaturalFaith(hero.Culture);
    }
}
