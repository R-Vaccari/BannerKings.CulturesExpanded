using BannerKings.Managers.Institutions.Religions;
using System.Collections.Generic;
using TaleWorlds.CampaignSystem;

namespace BannerKings.CulturesExpanded.Religions
{
    public class BKCEReligions : DefaultTypeInitializer<BKCEReligions, Religion>
    {
        public Religion ImmortalFlame { get; } = new Religion("flame");
        public Religion Calradism { get; } = new Religion("calradian");
        public Religion Legionaries { get; } = new Religion("legionaries");
        public Religion AseraCode { get; } = new Religion("asera");
        public Religion Amra { get; } = new Religion("amra");
        public Religion Martyrdom { get; } = new Religion("darusosian");
        public Religion Canticles { get; } = new Religion("canticles");
        public Religion Treelore { get; } = new Religion("treelore");
        public Religion Osfeyd { get; } = new Religion("osfeyd");
        public Religion SixWinds { get; } = new Religion("sixWinds");
        public override IEnumerable<Religion> All
        {
            get
            {
                yield return Martyrdom;
                yield return Legionaries;
                yield return Calradism;
                yield return Osfeyd;
                yield return AseraCode;
                yield return Amra;           
                yield return Treelore;
                yield return SixWinds;
                yield return Canticles;
                //yield return ImmortalFlame;
            }
        }

        public override void Initialize()
        {
            var aserai = Utils.Helpers.GetCulture("aserai");
            var khuzait = Utils.Helpers.GetCulture("khuzait");
            var imperial = Utils.Helpers.GetCulture("empire");
            var battania = Utils.Helpers.GetCulture("battania");
            var vlandia = Utils.Helpers.GetCulture("vlandia");
            var sturgia = Utils.Helpers.GetCulture("sturgia");
            var vakken = Utils.Helpers.GetCulture("vakken");
            var swadia = Utils.Helpers.GetCulture("swadia");
            var rhodok = Utils.Helpers.GetCulture("rhodok");
            var osrickin = Utils.Helpers.GetCulture("osrickin");


            Legionaries.Initialize(BKCEFaiths.Instance.Legionaries,
               new List<CultureObject>()
               {
                    imperial
               });


            Calradism.Initialize(BKCEFaiths.Instance.Calradism,
                new List<CultureObject>()
                {
                    imperial
                });

            AseraCode.Initialize(BKCEFaiths.Instance.AseraCode,
                new List<CultureObject> { aserai, khuzait, imperial });

            Amra.Initialize(BKCEFaiths.Instance.AmraOllahm,
                new List<CultureObject> { battania });

            Treelore.Initialize(BKCEFaiths.Instance.Treelore,
                new List<CultureObject> { sturgia, vakken });

            Martyrdom.Initialize(BKCEFaiths.Instance.Darusosian,
                new List<CultureObject> { imperial });

            Canticles.Initialize(BKCEFaiths.Instance.Canticles,
                new List<CultureObject> { vlandia });

            Osfeyd.Initialize(BKCEFaiths.Instance.Osfeyd,
                new List<CultureObject> { vlandia });

            SixWinds.Initialize(BKCEFaiths.Instance.SixWinds,
                new List<CultureObject> { khuzait });

            foreach (var religion in All)
            {
                DefaultReligions.Instance.AddObject(religion);
            }
        }
    }
}
