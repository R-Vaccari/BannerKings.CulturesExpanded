using BannerKings.Managers.Institutions.Religions.Faiths;
using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Localization;

namespace BannerKings.CulturesExpanded.Religions
{
    public class Calradism : MonotheisticFaith
    {
        public override Settlement FaithSeat => Settlement.All.First(x => x.StringId == "town_ES4");
        public override Banner GetBanner() => new Banner("11.8.40.1836.1836.768.774.1.0.0.512.35.149.328.24.983.592.0.0.45.510.92.149.668.120.764.812.1.1.45.512.35.149.328.24.545.593.0.0.-45.510.92.149.668.120.764.812.1.1.-45.344.40.149.320.324.764.810.1.1.0.423.2.149.489.494.764.812.1.1.0.108.121.149.225.228.764.552.1.1.0");

        public override TextObject GetBlessingAction() => new TextObject("{=!}I would like to pray to Augoustos Calradios.");

        public override TextObject GetBlessingActionName() => new TextObject("{=!}pray to");

        public override TextObject GetBlessingConfirmQuestion() => new TextObject("{=!}Confirm your devotion upon the name of Calradios and the good Gods of Heaven.");

        public override TextObject GetBlessingQuestion() => new TextObject("{=!}Would you pray to Calradios, Augoustos Divi Filius, or our sacred gods of Heaven?");

        public override TextObject GetBlessingQuickInformation()
        {
            return new TextObject("{=!}{HERO} is medidating upon {DIVINITY}.");
        }

        public override TextObject GetClergyForbiddenAnswer(int rank)
        {
            return new TextObject("{=!}");
        }

        public override TextObject GetClergyForbiddenAnswerLast(int rank)
        {
            return new TextObject("{=!}");
        }

        public override TextObject GetClergyGreeting(int rank)
        {
            return new TextObject("{=!}Ave, newcomer. I represent here the good citizens of the empire, those pious to Heaven. I see you do not share that with us, regardless, you shall be welcome. As their Flamines, the citizens allow me to speak for them in most matters, trusting the good judgement of the gods.");
        }

        public override TextObject GetClergyGreetingInducted(int rank)
        {
            return new TextObject("{=!}Salve, citizen! As you may see, I represent our peers here at {SETTLEMENT}. We here respect the way of Heaven as you yourself do. As their flamines, I speak for them in most matters.")
                .SetTextVariable("SETTLEMENT", Settlement.CurrentSettlement.Name);
        }

        public override TextObject GetClergyInduction(int rank)
        {
            return new TextObject("{=!}");
        }

        public override TextObject GetClergyInductionLast(int rank)
        {
            return new TextObject("{=!}");
        }

        public override TextObject GetClergyPreachingAnswer(int rank)
        {
            return new TextObject("{=!}We uphold the values of the gods in Heaven. Calradios was their messenger, and he instructed us to build the world. That is what we preach. To expand, cultivate, assimilate, rule. For centuries we have done so. At times, erronously, such as these times of the Internecine. But Heaven is just and corrects our path.");
        }

        public override TextObject GetClergyPreachingAnswerLast(int rank)
        {
            return new TextObject("{=!}But to answer your question: we preach the dominion of Heaven, the Empire, the Senate and the Calradoi. We do not wish for the demise of others, but instead that they join us in this holy mission. A single flag where all the peaples converge, under the council of Heaven, to unite Calradia.");
        }

        public override TextObject GetClergyProveFaith(int rank)
        {
            return new TextObject("{=!}Many are the virtues of Heaven we ought to practice. Such ways they have passed onto us through the hallowed Calradios and his descendants, and through our rites. To sacrifice a bull or a ram to them, that a man pious to Heaven should do. Or instead, offer the gods wine through Lustratio, for even the gods need amusement.");
        }

        public override TextObject GetClergyProveFaithLast(int rank)
        {
            return new TextObject("{=!}Above all, uphold their values. Veritas, be true to your word, which will not escape the ears of the Sky-Father. Industria, work as hard as you can, as did our ancestors, as did Augoustos Calradios, so that we and our descendants may live in glory. Finally, Justitia, to give good judgement and fair punishment, for above all, the gods are just.");
        }

        public override TextObject GetCultsDescription() => new TextObject("{=!}Cults");

        public override TextObject GetDescriptionHint() => new TextObject("{=!}Calradiolismus for a long time was the main religious cult throughout the empire. The faith revolves around the concept of Divus, or, in other words, divinities materialized in great men. Calradios, of course, is the greatest Divus known to history, descendant of Ireos, son of Iovis, the Sky-Father. Iovis and his cohort of gods are believed to take residence upon mount Erithrys - the Erithryans. Collectively, these gods are refered to by folks as 'Heaven', for their home reaches the sky.");

        public override TextObject GetFaithDescription() => new TextObject("{=!}Calradiolismus for a long time was the main religious cult throughout the empire. The faith revolves around the concept of Divus, or, in other words, divinities materialized in great men. Many a time great emperors or generals have either cults created around them, or incited such cults themselves. Eventually, the concept was formalized through the Divus annointment. Naturally, however, the Senate is highly resistant to granting such status to living people, in fear of granting them too much popular influence. None but the most heterodox could, however, deny Calradios' status as Divus and Founder of the empire. In addition to Calradios, the cult of the Erithryans is widespread, and forms the basis of Calradian theology. Erithryans are the traditional pantheon of Gods for the Calradoi, believed to have made residence on mount Erithrys and thus bless and watch over the Calradoi. Collectively, these gods are refered to by folks as 'Heaven', for their home reaches the sky.");

        public override TextObject GetFaithName() => new TextObject("{=!}Calradiolismus");

        public override string GetId() => "calradian";

        public override int GetIdealRank(Settlement settlement)
        {
            if (FaithSeat == settlement) return 2;
            return 1;
        }

        public override (bool, TextObject) GetInductionAllowed(Hero hero, int rank) => 
            new(true, new TextObject("{=GAuAoQDG}You will be converted"));

        public override TextObject GetInductionExplanationText() => new TextObject("{=!}Anyone may be inducted.");

        public override int GetMaxClergyRank() => 2;

        public override TextObject GetRankTitle(int rank)
        {
            if (rank == 2) return new TextObject("{=!}Flamines Iovilis");
            return new TextObject("{=!}Flamines");
        }

        public override bool IsCultureNaturalFaith(CultureObject culture) => culture.StringId == "empire";
        

        public override bool IsHeroNaturalFaith(Hero hero) => IsCultureNaturalFaith(hero.Culture);
    }
}
