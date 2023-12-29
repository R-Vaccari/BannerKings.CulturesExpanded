using BannerKings.Managers.Institutions.Religions.Faiths;
using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Localization;

namespace BannerKings.CulturesExpanded.Religions
{
    public class Jumne : PolytheisticFaith
    {
        public override Settlement FaithSeat => Settlement.All.First(x => x.StringId == "town_S2");
        public override TextObject GetZealotsGroupName() => new TextObject("{=!}Truvarlithum");
        
        public override TextObject GetDescriptionHint()
        {
            return new TextObject("{=!}Jumnartruva, the faith of Jumne, is the religion of those most Calradians call 'nords'. The Great Oak they say, much like some native Calradian beliefs, is where all life blossoms. Their many gods are said to write fate itself, Urthr, and they reward the virtuous with bountiful fate. Their faith has spread to the Sturgian realm through ascending dynasties of Jumne descent, such as the Gundavoring, who are now grand princes of Sturgia. However, common folk often in Sturgia still adhere to their ancestral faith, while Jumnartruva finds itself among the rulers and Jumne immigrants.");
        }

        public override Banner GetBanner() => new Banner("11.127.2.1528.1528.764.764.1.0.0.437.227.3.483.483.764.764.0.0.0");

        public override bool IsCultureNaturalFaith(CultureObject culture) => culture.StringId == "nord";

        public override bool IsHeroNaturalFaith(Hero hero)
        {
            if (hero.Clan != null)
            {
                string id = hero.Clan.StringId;
                return id == "clan_sturgia_1" || id == "clan_sturgia_3" || id == "clan_sturgia_4" ||
                    id == "clan_sturgia_6" || id == "skolderbrotva";
            }
            else if (hero.IsNotable && hero.Culture.StringId == BannerKingsConfig.SturgiaCulture)
            {
                return MBRandom.RandomFloat < 0.1f;
            }

            return IsCultureNaturalFaith(hero.Culture);
        }

        public override TextObject GetBlessingAction() => new TextObject("{=!}I would like to pray to the gods and our ancestors.");

        public override TextObject GetBlessingActionName() => new TextObject("{=!}pray to.");
        

        public override TextObject GetBlessingConfirmQuestion() =>
            new TextObject("{=!}Confirm thy pledge to me and I shall ask the spirits to influence thy Urthr.");
        
        public override TextObject GetBlessingQuestion()
        {
            return new TextObject("{=!}To whom would you pledge yourself? The Gods of Fate themselves?");
        }

        public override TextObject GetBlessingQuickInformation()
        {
            return new TextObject("{=j1U1juRf}{HERO} has pledged an oath to {DIVINITY}.");
        }

        public override TextObject GetClergyForbiddenAnswer(int rank) => new TextObject("{=!}It is not my position to tell thee what thou shalt or not do - thy Urthr is for the gods. Take heed, however, of the deeds of our ancestors.");

        public override TextObject GetClergyForbiddenAnswerLast(int rank) => new TextObject("{=!}To flee a battle is the worst shame thou canst have. Our Urthr is written by the gods. If they fated thee to die, thou shalt die. Thy craveness will only have thee die in shame, and cursed out of the gods' hall. Face death with courage: if thou art fated to die, thou shalt meet the gods in their hall, if not, thou shallst take victory.");     

        public override TextObject GetClergyGreeting(int rank) => new TextObject("{=!}Heill, erlendr. I serve here as the Gothi. Do not take me for a Volkvhs, those are the Sturgian fools who worship the moon. I bring to this place the ways of Jumne.");

        public override TextObject GetClergyGreetingInducted(int rank) => new TextObject("{=!}Heill! I see thou art of us - one of Jumne. Beest welcome, and come to me when thou needest guidance from the gods, or our ancestors.");

        public override TextObject GetClergyInduction(int rank)
        {
            var induction = GetInductionAllowed(Hero.MainHero, rank);
            if (!induction.Item1)
            {
                return new TextObject("{=!}If thou wishest to join our Truva, then first adopt our ways, the ways of Jumne. Or, if thou wishest, serve the Sturgians, whose princes have embraced our ways and are blood of our blood, and so the gods have embraced them back.[if:convo_bored]");
            }

            return new TextObject("{=!}The gods smile on thy fate, friend. Be welcome in our community. Come to me, your Gothi, when thou needest to commune with the spirits.");
        }

        public override TextObject GetClergyInductionLast(int rank)
        {
            var induction = GetInductionAllowed(Hero.MainHero, rank);
            if (!induction.Item1)
            {
                return new TextObject("{=!}Until then, thou art not amongst those the gods weave favored fates for.[rf:convo_bored]");
            }

            return new TextObject("{=!}Set sail and take up on the sword. Conquer thy fate as the gods instruct us.[if:convo_excited]");
        }

        public override TextObject GetClergyPreachingAnswer(int rank) 
            => new TextObject("{=!}Folks come to me to hear of our Truva, passed on to us by our ancestors. We uphold their way, and that of the gods. What way, you may ask? Simple: havest thou heard the saga of Gundar?");

        public override TextObject GetClergyPreachingAnswerLast(int rank) 
            => new TextObject("{=!}Gundar came to this continent and conquered his part of the world. That is our way. To take what is ours. We do it, because the gods allow it. And the gods allow it to those with the resolve to do so. Our venture is holy, and our success proves it.");

        public override TextObject GetClergyProveFaith(int rank) => 
            new TextObject("{=!}If thou wishest to prove thyself, do as our ancestors did. Set sail to lands far, found a dynasty, and most of all, achieve conquest over thy enemies. To fight is to prove thy faith - that is the only way thou wilt know what fate the gods have weaved for thee.");

        public override TextObject GetClergyProveFaithLast(int rank) => 
            new TextObject("{=!}Thy actions shall be how the gods judge thee.");
        
        public override TextObject GetFaithDescription() => new TextObject("{=!}Far north, where the land is frozen water, lies the realm of the giants. The gods once fought them, slaying their master and creating the land for man. The Great Oak they say, much like some native Calradian beliefs, is where all life blossoms. From dark corners and depths, evil forces continuously try to unroot the Oak. Among these stands out Ásbani, the God-Devouring Serpent.{newline}The Jumne believe the gods reward the virtuous with bountiful fate. That is how they justify invading and conquering foreign lands - if they won, it is because the gods wished so, and so their exploits were justified. As such, great heroes and conquerors are, within Jumne tradition, annointed as quasi-divine figures. Their beliefs have flourished within the Sturgian realm, whose nobility has been gradually being replaced or assimilated by Jumne descendants. Among them stands out the ruling dynasty itself, Gundavoring, the descendants of the Jumne hero Gundar.");

        public override TextObject GetFaithName() => new TextObject("{=!}Jumnartruva");
        public override string GetId() => "junme";

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

            if (hero.MapFaction != null && hero.MapFaction.IsKingdomFaction &&  hero.MapFaction.Culture.StringId == BannerKingsConfig.SturgiaCulture)
            {
                return new(true, new TextObject("{=GAuAoQDG}You will be converted"));
            }

            return new(false, GetInductionExplanationText());
        }

        public override int GetMaxClergyRank() => 1;

        public override TextObject GetRankTitle(int rank) => new TextObject("{=!}Gothi");

        public override TextObject GetCultsDescription() => new TextObject("{=J4D4X2XJ}Cults");

        public override TextObject GetInductionExplanationText() => new TextObject("{=!}The faith only accepts those of Jumne culture or that serve a Sturgian realm");
    }
}
