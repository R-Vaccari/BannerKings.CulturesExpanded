using TaleWorlds.SaveSystem;
using BannerKings.CulturesExpanded.Religions;

namespace BannerKings
{
    internal class SaveDefiner : SaveableTypeDefiner
    {
        public SaveDefiner() : base(83828290)
        {
        }

        protected override void DefineClassTypes()
        {
            AddClassDefinition(typeof(Calradism), 1);
        }

        protected override void DefineContainerDefinitions()
        {
        }
    }
}