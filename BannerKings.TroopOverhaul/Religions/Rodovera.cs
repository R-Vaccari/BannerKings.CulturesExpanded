using BannerKings.Managers.Institutions.Religions.Faiths;
using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Localization;

namespace BannerKings.CulturesExpanded.Religions
{
    public class Rodovera : PolytheisticFaith
    {
        public override Settlement FaithSeat => Settlement.All.First(x => x.StringId == "town_S3");
        public override TextObject GetZealotsGroupName()
        {
            return new TextObject("{=!}Scions of the Great Oak");
        }

        public override TextObject GetDescriptionHint()
        {
            return new TextObject("{=!}Rodovera is the ancient belief system of the Sturgians, natural to the Kachyar peninsula. is a native faith of the Calradian continent, stretching from the Kachyar peninsula to the Chertyg mountains. Thus, it is the natural faith of the Vakken and Sturgian peoples. According to the Sturgian volkhvs, future-seeing druids, the Great Oak is the source of life and root for the world of mankind. Besides the physical world, a dualistic view of Underworld and the Sacred Canopy separates what is good and bad, righteous and malicious, as well as flesh and spirit.");
        }
        public override Banner GetBanner() => new Banner("11.40.2.1528.1528.764.764.1.0.0.10071.148.3.483.483.764.764.0.0.0");

        public override bool IsCultureNaturalFaith(CultureObject culture) => culture.StringId == BannerKingsConfig.SturgiaCulture;

        public override bool IsHeroNaturalFaith(Hero hero)
        {
            if (hero.Clan != null)
            {
                string id = hero.Clan.StringId;
                return id == "clan_sturgia_9" || id == "clan_sturgia_8" || id == "clan_sturgia_7" || 
                    id == "clan_sturgia_5" || id == "clan_sturgia_2";
            }

            return IsCultureNaturalFaith(hero.Culture);
        }

        public override TextObject GetBlessingAction()
        {
            return new TextObject("{=qYmkFsWj}I would like to pledge myself to a cult.");
        }

        public override TextObject GetBlessingActionName()
        {
            return new TextObject("{=bd7HQSJH}pledge an oath to.");
        }

        public override TextObject GetBlessingConfirmQuestion()
        {
            return new TextObject("{=1wZntvX3}Confirm it, {?PLAYER.GENDER}sister{?}brother{\\?} of the forest, and it will be done.");
        }

        public override TextObject GetBlessingQuestion()
        {
            return new TextObject("{=u8UXkpef}To whom would you pledge? The Thunder-Wielder Pérkos, or the godess Méhns?");
        }

        public override TextObject GetBlessingQuickInformation()
        {
            return new TextObject("{=j1U1juRf}{HERO} has pledged an oath to {DIVINITY}.");
        }

        public override TextObject GetClergyForbiddenAnswer(int rank)
        {
            return new TextObject("{=AZf5AS94}What is forbidden? Not upholding family and tradition are crimes in the eyes of the gods. Likewise, betraying in act or word those you take as guests. But most of all, cravenness, of course. A craven is no child of forest, much like spoiled fruit is no nourishment. Fight with boldness or do not fight at all.");
        }

        public override TextObject GetClergyForbiddenAnswerLast(int rank)
        {
            return new TextObject("{=jcLBX8Db}The struggle between righteousness and darkness is the nature of the worlds. Our world, that of mankind, lies right in its midst. Uphold all that is godly, or rot in darkness.");
        }

        public override TextObject GetClergyGreeting(int rank) => new TextObject("{=zSR2NTfA}Hail to you, foreigner. Know that the spirits watch over all mankind, true believers or otherwise, and that no malice escapes their senses, and no misdeed goes unrecorded by the oak grain.");

        public override TextObject GetClergyGreetingInducted(int rank) => new TextObject("{=4FBPYfAH}Hail to you, brethren. How can I help you? Do you wish to hear the truth of the gods, or, perhaps, foretell the future?");

        public override TextObject GetClergyInduction(int rank)
        {
            var induction = GetInductionAllowed(Hero.MainHero, rank);
            if (!induction.Item1)
            {
                return new TextObject("{=e4mTQb3c}Alas, one born outside the embrace of the gods, can not choose to be embraced. Though one can be respected for their boldness, only a child of the forest can follow the path of the true gods - it is written in our ancestry. Such is the tale written in the oak grain.[if:convo_bored]");
            }

            return new TextObject("{=9ZxHecHk}I ask of you only this - why have you not come before? My brethren of the woods, you have come to your home. The way of Pérkos, Méhns and all the gods of the heavenly canopy, that is your true nature. Your blood and bone.");
        }

        public override TextObject GetClergyInductionLast(int rank)
        {
            var induction = GetInductionAllowed(Hero.MainHero, rank);
            if (!induction.Item1)
            {
                return new TextObject("{=x2BRcZSr}Go now, and return to those of your kind, wherever they might be. The children of the forest only accept those born in it.[rf:convo_bored]");
            }

            return new TextObject("{=3eB4RvfE}Be welcome as a child of the forest. Defend your brethren and your gods - fight our enemies fiercely, but also be kind to those that visit your hearth. Do not try and convince them of our ways - it is not their place. Yet it is ours to keep unharmed.[if:convo_excited]");
        }

        public override TextObject GetClergyPreachingAnswer(int rank) => new TextObject("{=cDgdXvLX}When it comes to the gods, there is nothing the words of man can say that the rustling of leaves or burbling of rivers does not tell better. The forest, offspring of the Great Oak, holds the chronicles of the past. Truth, you see, is embedded within all that which is godly, be it the river flow or the oak grain. I merely interpret it.");

        public override TextObject GetClergyPreachingAnswerLast(int rank) => new TextObject("{=Zz2xgYgb}But if you insist... We preach the way of the Thunder Wielder. Valor in defending your ancestry, honor in keeping your word, and generosity towards those you take into your hearth.");

        public override TextObject GetClergyProveFaith(int rank)
        {
            return new TextObject("{=7abfdtqE}Naturally, to follow the way of Pérkos is to be a true faithful. Uphold honor, honesty and righteousness. Defend your brethren with valor, as the gods that perch upon the Great Oak do over men. Those you take into your hearth as guests - treat them as your own blood, as much as good sense allows.");
        }

        public override TextObject GetClergyProveFaithLast(int rank)
        {
            return new TextObject("{=m5Zva8LP}Most importantly, uphold tradition and ancestry as a child of the forest, remain true to your family and multiply, lest the Great Oak is unrooted by darkness.");
        }

        public override TextObject GetFaithDescription() => new TextObject("{=!}Rodovera is the ancient belief system of the Sturgians, natural to the Kachyar peninsula. is a native faith of the Calradian continent, stretching from the Kachyar peninsula to the Chertyg mountains. Thus, it is the natural faith of the Vakken and Sturgian peoples. According to the Sturgian volkhvs, future-seeing druids, the Great Oak is the source of life and root for the world of mankind. Besides the physical world, a dualistic view of Underworld and the Sacred Canopy separates what is good and bad, righteous and malicious, as well as flesh and spirit. The Gods perch on the Sacred Canopy, atop the Great Oak, from where they defend and guide the children of the forest, that is, those that adhere to the faith. The children believe that spirits roam this world, and in the grains of oaks they chronicle all that which they witness. Moreover, believers argue that being a child of the forest is not a decision one takes, but is, instead, their ancestry. As such, a child of the forest must uphold the Gods, family and ancestry above all else.{newline}Among the gods stands out Pérkos, the Thunder-Wielder and All-Father of Rodovera. Vakken folks identify him as Pérkken, the Sky-Father of their own tradition. Of course, both cultures being distant kin and natural to the same regions, both are still bound by ancient beliefs that long precede their modern faithful.{newline}Though many of the Sturgian dynasties have forsaken their ancestry for the Junme faith and practices, Sturgian lower classes still adhere to the Rodovera tradition, who is protected within the royal court by the Kuloving dynasty.");

        public override TextObject GetFaithName() => new TextObject("{=!}Rodovera");
        public override string GetId() => "rodovera";

        public override int GetIdealRank(Settlement settlement)
        {
            if (settlement.IsVillage || settlement.IsTown)
            {
                return 1;
            }

            return 0;
        }

        public override (bool, TextObject) GetInductionAllowed(Hero hero, int rank)
        {
            if (IsCultureNaturalFaith(hero.Culture))
            {
                return new(true, new TextObject("{=GAuAoQDG}You will be converted"));
            }

            return new(false, new TextObject("{=!}The {FAITH} only accepts those of {STURGIA} culture or who serve in a realm of that culture.")
                .SetTextVariable("FAITH", GetFaithName())
                .SetTextVariable("STURGIA", Utils.Helpers.GetCulture("sturgia").Name)
                .SetTextVariable("VAKKEN", Utils.Helpers.GetCulture("vakken").Name));
        }

        public override int GetMaxClergyRank() => 1;

        public override TextObject GetRankTitle(int rank) => new TextObject("{=!}Volkhvs");

        public override TextObject GetCultsDescription() => new TextObject("{=J4D4X2XJ}Cults");

        public override TextObject GetInductionExplanationText() => new TextObject("{=8k60TAmt}The {FAITH} only accepts those of {STURGIA} and {VAKKEN} cultures")
                .SetTextVariable("FAITH", GetFaithName())
                .SetTextVariable("STURGIA", Utils.Helpers.GetCulture("sturgia").Name)
                .SetTextVariable("VAKKEN", Utils.Helpers.GetCulture("vakken").Name);
    }
}
