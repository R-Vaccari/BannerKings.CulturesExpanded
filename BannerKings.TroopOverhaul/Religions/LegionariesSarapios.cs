using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Localization;

namespace BannerKings.Managers.Institutions.Religions.Faiths.Empire
{
    public class LegionariesSarapios : MonotheisticFaith
    {
        public override Settlement FaithSeat => Settlement.All.First(x => x.StringId == "town_EN1");
        public override Banner GetBanner() => new Banner("11.14.40.1836.1836.768.774.1.0.0.512.35.149.187.13.954.627.0.0.-90.510.96.149.381.68.954.804.1.1.-90.512.35.149.187.13.914.627.0.0.-90.510.96.149.381.68.914.804.1.1.-90.343.44.149.440.445.764.821.1.1.0.147.44.149.239.242.764.647.1.1.0.423.2.149.128.136.764.484.1.1.0.512.35.149.187.13.614.627.0.0.-90.510.96.149.381.68.614.804.1.1.-90.512.35.149.187.13.574.627.0.0.-90.510.96.149.381.68.574.804.1.1.-90");

        public override TextObject GetBlessingAction()
        {
            return new TextObject("{=!}I would like to pray to Sarapios Invictus.");
        }

        public override TextObject GetBlessingActionName()
        {
            return new TextObject("{=!}pray to");
        }

        public override TextObject GetBlessingConfirmQuestion()
        {
            return new TextObject("{=!}Confirm your devotion upon the name of Sarapios Invictus, our hallowed protector.");
        }

        public override TextObject GetBlessingQuestion()
        {
            return new TextObject("{=!}Do you seek the wisdom of Sarapios Invictus, or do you seek Ireos, the god of war himself?");
        }

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
            return new TextObject("{=!}");
        }

        public override TextObject GetClergyGreetingInducted(int rank)
        {
            return new TextObject("{=!}");
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
            return new TextObject("{=!}");
        }

        public override TextObject GetClergyPreachingAnswerLast(int rank)
        {
            return new TextObject("{=!}");
        }

        public override TextObject GetClergyProveFaith(int rank)
        {
            return new TextObject("{=!}");
        }

        public override TextObject GetClergyProveFaithLast(int rank)
        {
            return new TextObject("{=!}");
        }

        public override TextObject GetCultsDescription() => new TextObject("{=!}Cults");

        public override TextObject GetDescriptionHint() => new TextObject("{=!}Sarapios Divus was a commander of exceptional performance, to whom the founding of Epicrotea was honored. He was acclaimed Invictus in his lifetime - undefeated, a most honorable title - and Divus in his afterlife - a divinity. Though the rite becoming Divus is otherwise reserved to emperors and their families, the Senate had no choice but to concede to the demands of the deceased Sarapios' followers, thousands of legionaries and officers. So it is that rather than a state formality or political manoeuvre, his worship was a natural development, as the practice first began.");

        public override TextObject GetFaithDescription() => new TextObject("{=!}Sarapios Divus was a commander of exceptional performance, to whom the founding of Epicrotea was honored. He was acclaimed Invictus in his lifetime - undefeated, a most honorable title - and Divus in his afterlife - a divinity. Though the rite becoming Divus is otherwise reserved to emperors and their families, the Senate had no choice but to concede to the demands of the deceased Sarapios' followers, thousands of legionaries and officers. So it is that rather than a state formality or political manoeuvre, his worship was a natural development, as the practice first began. His cult is naturally aligned with the cult of Ireos, one of the Erithryans. Ireos is the spear-wielding god of war, and protector of the nation, an thus closely associated with bravery and military conquest. Sarapios' legionaries believed him to be blessed by the god, if not one of his descendants.");

        public override TextObject GetFaithName() => new TextObject("{=!}Legionaries of Sarapios Invictus");

        public override string GetId() => "legionaries";

        public override int GetIdealRank(Settlement settlement)
        {
            if (FaithSeat == settlement) return 2;
            return 1;
        }

        public override (bool, TextObject) GetInductionAllowed(Hero hero, int rank)
        {
            var text = new TextObject("{=aSkNfvzG}Induction is possible.");
            var kingdom = hero.Clan.Kingdom;
            if (!IsHeroNaturalFaith(hero) && (kingdom == null || kingdom.StringId != "empire_w"))
            {
                text = new TextObject("{=!}Not a member of the Western Empire.");
                return new(false, text);
            }

            return new(true, text);
        }

        public override TextObject GetInductionExplanationText() => new TextObject("{=!}Any Imperials may be inducted. Non-Imperials need to be part of the Western Empire.");

        public override int GetMaxClergyRank() => 2;

        public override TextObject GetRankTitle(int rank)
        {
            if (rank == 2) return new TextObject("{=!}Flamines Ireoilis");
            return new TextObject("{=!}Flamines");
        }

        public override bool IsCultureNaturalFaith(CultureObject culture) => culture.StringId == "empire";

        public override bool IsHeroNaturalFaith(Hero hero)
        {
            if (hero.Clan != null && hero.Clan.StringId == "legion_of_the_betrayed")
            {
                return true;
            }

            if (IsCultureNaturalFaith(hero.Culture) && hero.MapFaction != null && hero.MapFaction.IsKingdomFaction &&
                hero.MapFaction.StringId == "empire_w")
            {
                if (hero.IsLord) return true;
                else if (MBRandom.RandomFloat < 0.3f) return true;
            }

            return false;
        }
    }
}
