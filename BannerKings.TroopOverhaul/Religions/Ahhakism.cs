using BannerKings.Managers.Institutions.Religions.Faiths;
using System;
using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Localization;

namespace BannerKings.CulturesExpanded.Religions
{
    public class Ahhakism : MonotheisticFaith
    {
        public override Settlement FaithSeat => Settlement.All.First(x => x.StringId == "");
        public override Banner GetBanner() => new Banner("11.4.2.1528.1528.764.764.1.0.0.10058.22.3.483.483.764.764.0.0.0");

        public override TextObject GetBlessingAction()
        {
            throw new NotImplementedException();
        }

        public override TextObject GetBlessingActionName()
        {
            throw new NotImplementedException();
        }

        public override TextObject GetBlessingConfirmQuestion()
        {
            throw new NotImplementedException();
        }

        public override TextObject GetBlessingQuestion()
        {
            throw new NotImplementedException();
        }

        public override TextObject GetBlessingQuickInformation()
        {
            throw new NotImplementedException();
        }

        public override TextObject GetClergyForbiddenAnswer(int rank)
        {
            throw new NotImplementedException();
        }

        public override TextObject GetClergyForbiddenAnswerLast(int rank)
        {
            throw new NotImplementedException();
        }

        public override TextObject GetClergyGreeting(int rank)
        {
            throw new NotImplementedException();
        }

        public override TextObject GetClergyGreetingInducted(int rank)
        {
            throw new NotImplementedException();
        }

        public override TextObject GetClergyInduction(int rank)
        {
            throw new NotImplementedException();
        }

        public override TextObject GetClergyInductionLast(int rank)
        {
            throw new NotImplementedException();
        }

        public override TextObject GetClergyPreachingAnswer(int rank)
        {
            throw new NotImplementedException();
        }

        public override TextObject GetClergyPreachingAnswerLast(int rank)
        {
            throw new NotImplementedException();
        }

        public override TextObject GetClergyProveFaith(int rank)
        {
            throw new NotImplementedException();
        }

        public override TextObject GetClergyProveFaithLast(int rank)
        {
            throw new NotImplementedException();
        }

        public override TextObject GetCultsDescription()
        {
            throw new NotImplementedException();
        }

        public override TextObject GetDescriptionHint()
        {
            throw new NotImplementedException();
        }

        public override TextObject GetFaithDescription()
        {
            throw new NotImplementedException();
        }

        public override TextObject GetFaithName()
        {
            throw new NotImplementedException();
        }

        public override string GetId()
        {
            throw new NotImplementedException();
        }

        public override int GetIdealRank(Settlement settlement)
        {
            throw new NotImplementedException();
        }

        public override (bool, TextObject) GetInductionAllowed(Hero hero, int rank)
        {
            throw new NotImplementedException();
        }

        public override TextObject GetInductionExplanationText()
        {
            throw new NotImplementedException();
        }

        public override int GetMaxClergyRank()
        {
            throw new NotImplementedException();
        }

        public override TextObject GetRankTitle(int rank)
        {
            throw new NotImplementedException();
        }

        public override TextObject GetZealotsGroupName()
        {
            throw new NotImplementedException();
        }

        public override bool IsCultureNaturalFaith(CultureObject culture)
        {
            throw new NotImplementedException();
        }

        public override bool IsHeroNaturalFaith(Hero hero)
        {
            throw new NotImplementedException();
        }
    }
}
