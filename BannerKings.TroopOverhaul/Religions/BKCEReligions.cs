using BannerKings.Managers.Institutions.Religions;
using System.Collections.Generic;
using TaleWorlds.CampaignSystem;

namespace BannerKings.CulturesExpanded.Religions
{
    public class BKCEReligions : DefaultTypeInitializer<BKCEReligions, Religion>
    {
        public Religion ImmortalFlame { get; } = new Religion("atash");
        public Religion Calradism { get; } = new Religion("calradian");
        public Religion Legionaries { get; } = new Religion("legionaries");
        public Religion AseraCode { get; } = new Religion("asera");
        public Religion Amra { get; } = new Religion("amra");
        public Religion Martyrdom { get; } = new Religion("darusosian");
        public Religion Canticles { get; } = new Religion("canticles");
        public Religion Treelore { get; } = new Religion("treelore");
        public Religion Osfeyd { get; } = new Religion("osfeyd");
        public Religion SixWinds { get; } = new Religion("sixWinds");
        public Religion Jumne { get; } = new Religion("junme");
        public Religion Rodovera { get; } = new Religion("rodovera");
        public Religion Siri { get; } = new Religion("siri");
        public Religion Kannic { get; } = new Religion("kannic");
        public Religion Ahhak { get; } = new Religion("ahhak");
        public override IEnumerable<Religion> All
        {
            get
            {
                yield return Martyrdom;
                yield return Legionaries;
                yield return Calradism;
                yield return Osfeyd;
                yield return Amra;
                yield return AseraCode;
                yield return Ahhak;
                yield return ImmortalFlame;
                yield return SixWinds;     
                yield return Siri;
                yield return Kannic;
                yield return Jumne;
                yield return Rodovera;
                yield return Treelore;
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
            var nord = Utils.Helpers.GetCulture("nord");
            var darshi = Utils.Helpers.GetCulture("darshi");
            var siri = Utils.Helpers.GetCulture("siri");
            var swadia = Utils.Helpers.GetCulture("swadia");
            var rhodok = Utils.Helpers.GetCulture("rhodok");
            var osrickin = Utils.Helpers.GetCulture("osrickin");
            var massa = Utils.Helpers.GetCulture("massa");
            var kannic = Utils.Helpers.GetCulture("kannic");

            Ahhak.Initialize(BKCEFaiths.Instance.Ahhak,
               new List<CultureObject>()
               {
                    darshi, khuzait
               });

            Kannic.Initialize(BKCEFaiths.Instance.Kannic,
               new List<CultureObject>()
               {
                    kannic
               });

            ImmortalFlame.Initialize(BKCEFaiths.Instance.ImmortalFlame,
               new List<CultureObject>()
               {
                    darshi
               });

            Siri.Initialize(BKCEFaiths.Instance.Siri,
               new List<CultureObject>()
               {
                    siri
               });

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
                new List<CultureObject> { vakken, sturgia });

            Rodovera.Initialize(BKCEFaiths.Instance.Rodovera,
                new List<CultureObject> { sturgia });

            Martyrdom.Initialize(BKCEFaiths.Instance.Darusosian,
                new List<CultureObject> { imperial });

            Osfeyd.Initialize(BKCEFaiths.Instance.Osfeyd,
                new List<CultureObject> { vlandia, massa });

            SixWinds.Initialize(BKCEFaiths.Instance.SixWinds,
                new List<CultureObject> { khuzait });

            Jumne.Initialize(BKCEFaiths.Instance.Jumne,
               new List<CultureObject> { nord });

            foreach (var religion in All)
            {
                DefaultReligions.Instance.AddObject(religion);
            }
        }
    }
}
