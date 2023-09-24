using BannerKings.Managers.Institutions.Religions.Faiths.Rites;
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
            return 100f;
        }

        public override TextObject GetRequirementsText(Hero hero)
        {
            return new TextObject("{=6Yj8erp7}May be performed every {YEARS} years\nRequires a cow, a hog and a sheep")
                .SetTextVariable("YEARS", GetTimeInterval(hero));
        }

        public override void SetDialogue()
        {
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM",
                new TextObject("{=!}Will you sacrifice a bull, a ram and a pig to Ireos, the god of war?"));
        }
    }
}
