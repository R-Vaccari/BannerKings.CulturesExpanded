using BannerKings.Managers.Institutions.Religions.Faiths.Rites;
using System;
using System.Collections.Generic;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.Localization;
using TaleWorlds.ObjectSystem;

namespace BannerKings.CulturesExpanded.Religions.Rites
{
    internal class Lustratio : CompositeOffering
    {
        public Lustratio() : base(new Dictionary<ItemObject, int>()
        {
            { MBObjectManager.Instance.GetObject<ItemObject>("hog"), 1 },
            { MBObjectManager.Instance.GetObject<ItemObject>("sheep"), 1 },
            { MBObjectManager.Instance.GetObject<ItemObject>("cow"), 1 }
        })
        {
        }

        public override TextObject GetDescription() => new TextObject("{=!}An ancient Calradoi ritual to honor Ireos, the spear-wielder. The rite consists of sacrificing a sheep, a hog and a cow. It is considered a form of purification and begets the favor of the war god, granting various helpful blessings.");

        public override TextObject GetName() => new TextObject("{=!}Lustratio");

        public override float GetPietyReward()
        {
            throw new NotImplementedException();
        }

        public override TextObject GetRequirementsText(Hero hero)
        {
            throw new NotImplementedException();
        }

        public override void SetDialogue()
        {
            throw new NotImplementedException();
        }
    }
}
