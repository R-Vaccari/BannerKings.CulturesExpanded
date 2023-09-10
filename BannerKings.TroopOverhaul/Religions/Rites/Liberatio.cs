using BannerKings.Managers.Institutions.Religions.Faiths.Rites;
using TaleWorlds.Core;
using TaleWorlds.Localization;
using TaleWorlds.ObjectSystem;

namespace BannerKings.CulturesExpanded.Religions.Rites
{
    public class Liberatio : Offering
    {
        public Liberatio() : base(MBObjectManager.Instance.GetObject<ItemObject>("wine"), 
            20)
        {
        }

        public override TextObject GetName() => new TextObject("{=!}Liberatio");
    }
}
