using TaleWorlds.SaveSystem;
using BannerKings.CulturesExpanded.Religions;
using BannerKings.Managers.Institutions.Religions.Faiths.Empire;

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
            AddClassDefinition(typeof(LegionariesSarapios), 2);
            AddClassDefinition(typeof(Jumne), 3);
            AddClassDefinition(typeof(Rodovera), 4);
            AddClassDefinition(typeof(ImmortalFlame), 5);
            AddClassDefinition(typeof(Siri), 6);
            AddClassDefinition(typeof(Kannic), 7);
        }

        protected override void DefineContainerDefinitions()
        {
        }
    }
}