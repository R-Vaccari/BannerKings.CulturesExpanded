using BannerKings.Managers.Institutions.Religions.Faiths.Asera;
using BannerKings.Managers.Institutions.Religions.Faiths.Battania;
using BannerKings.Managers.Institutions.Religions.Faiths.Eastern;
using BannerKings.Managers.Institutions.Religions.Faiths.Empire;
using BannerKings.Managers.Institutions.Religions.Faiths.Northern;
using BannerKings.Managers.Institutions.Religions.Faiths.Vlandia;
using BannerKings.Managers.Institutions.Religions.Faiths;
using BannerKings.Managers.Institutions.Religions;
using System.Collections.Generic;
using BannerKings.Managers.Institutions.Religions.Faiths.Rites;
using BannerKings.Managers.Traits;
using TaleWorlds.CampaignSystem.CharacterDevelopment;
using BannerKings.Managers.Institutions.Religions.Faiths.Rites.Vlandia;
using BannerKings.Managers.Institutions.Religions.Faiths.Rites.Battania;
using BannerKings.Managers.Institutions.Religions.Faiths.Rites.Southern;
using BannerKings.Managers.Institutions.Religions.Doctrines;
using BannerKings.Managers.Institutions.Religions.Faiths.Rites.Empire;
using BannerKings.Managers.Institutions.Religions.Faiths.Rites.Northern;
using BannerKings.CulturesExpanded.Religions.Rites;

namespace BannerKings.CulturesExpanded.Religions
{
    public class BKCEFaiths : DefaultTypeInitializer<BKCEFaiths, Faith>
    {
        public MonotheisticFaith AseraCode { get; private set; } = new AseraFaith();
        public PolytheisticFaith AmraOllahm { get; private set; } = new AmraFaith();
        public MonotheisticFaith Darusosian { get; private set; } = new DarusosianFaith();
        public PolytheisticFaith Treelore { get; private set; } = new TreeloreFaith();
        public PolytheisticFaith Osfeyd { get; private set; } = new Osfeyd();
        public PolytheisticFaith SixWinds { get; } = new SixWinds();
        public PolytheisticFaith Rodovera { get; } = new Rodovera();
        public MonotheisticFaith Calradism { get; } = new Calradism();
        public MonotheisticFaith Legionaries { get; } = new LegionariesSarapios();
        public PolytheisticFaith Jumne { get; } = new Jumne();
        public PolytheisticFaith Siri { get; } = new Siri();
        public MonotheisticFaith ImmortalFlame { get; } = new ImmortalFlame();
        public PolytheisticFaith Kannic { get; } = new Kannic();

        public override IEnumerable<Faith> All
        {
            get
            {
                yield return Osfeyd;
                yield return AseraCode;
                yield return AmraOllahm;
                yield return Darusosian;
                yield return Treelore;
                yield return SixWinds;
                yield return Calradism;
                yield return Legionaries;
                yield return Jumne;
                yield return Rodovera;
                yield return ImmortalFlame;
                yield return Siri;
                yield return Kannic;
            }
        }

        public override void Initialize()
        {
            Kannic.Initialize(BKCEDivinities.Instance.VineGoddess,
                new List<Divinity>
                {
                    BKCEDivinities.Instance.Eshora,
                    BKCEDivinities.Instance.Jinn
                },
                new Dictionary<TraitObject, bool>
                {
                    {DefaultTraits.Generosity, false},
                    {DefaultTraits.Valor, true},
                    {BKTraits.Instance.Ambitious, true}
                },
                BKCEFaithGroups.Instance.AseraGroup,
                new List<Doctrine>
                {
                    DefaultDoctrines.Instance.AncestorWorship,
                    DefaultDoctrines.Instance.Astrology,
                    DefaultDoctrines.Instance.Animism
                },
                new List<Rite>
                {
                });

            Siri.Initialize(BKCEDivinities.Instance.GreatLion,
                new List<Divinity>
                {
                },
                new Dictionary<TraitObject, bool>
                {
                    {DefaultTraits.Honor, true},
                    {DefaultTraits.Valor, true},
                    {DefaultTraits.Mercy, true}
                },
                BKCEFaithGroups.Instance.AseraGroup,
                new List<Doctrine>
                {
                    DefaultDoctrines.Instance.AncestorWorship,
                    DefaultDoctrines.Instance.Shamanism,
                    DefaultDoctrines.Instance.Animism
                },
                new List<Rite>
                {
                });

            ImmortalFlame.Initialize(BKCEDivinities.Instance.ImmortalFlame,
                new List<Divinity>
                {
                },
                new Dictionary<TraitObject, bool>
                {
                    {DefaultTraits.Honor, true},
                    {DefaultTraits.Generosity, true},
                    {BKTraits.Instance.Just, true}
                },
                new List<Doctrine>
                {
                    DefaultDoctrines.Instance.AncestorWorship,
                    DefaultDoctrines.Instance.Esotericism,
                    DefaultDoctrines.Instance.Literalism
                },
                BKCEFaithGroups.Instance.DarshiGroup,         
                new List<Rite>
                {
                });

            Jumne.Initialize(DefaultDivinities.Instance.GodsFate,
                new List<Divinity>
                {
                },
                new Dictionary<TraitObject, bool>
                {
                    {DefaultTraits.Mercy, false},
                    {DefaultTraits.Valor, true},
                    {BKTraits.Instance.Just, true}
                },
                BKCEFaithGroups.Instance.VlandiaGroup,
                new List<Doctrine>
                {
                    DefaultDoctrines.Instance.AncestorWorship,
                    DefaultDoctrines.Instance.Warlike,
                    DefaultDoctrines.Instance.Animism
                },
                new List<Rite>
                {
                });

            Rodovera.Initialize(BKCEDivinities.Instance.Perkos,
                new List<Divinity>
                {
                    DefaultDivinities.Instance.Mehns
                },
                new Dictionary<TraitObject, bool>
                {
                    {DefaultTraits.Generosity, true},
                    {DefaultTraits.Valor, true}
                },
                BKCEFaithGroups.Instance.SturgiaGroup,
                new List<Doctrine>
                {
                    DefaultDoctrines.Instance.Druidism,
                    DefaultDoctrines.Instance.Animism,
                    DefaultDoctrines.Instance.AncestorWorship
                },
                new List<Rite>()
                {
                    new AxeOffering()
                });

            Treelore.Initialize(DefaultDivinities.Instance.TreeloreMain,
                new List<Divinity>
                {
                    DefaultDivinities.Instance.Hirvi
                },
                new Dictionary<TraitObject, bool>
                {
                    {DefaultTraits.Mercy, false},
                    {DefaultTraits.Valor, true}
                },
                BKCEFaithGroups.Instance.SturgiaGroup,
                new List<Doctrine>
                {
                    DefaultDoctrines.Instance.Shamanism,
                    DefaultDoctrines.Instance.AncestorWorship,
                    DefaultDoctrines.Instance.Animism,
                    DefaultDoctrines.Instance.Esotericism
                },
                new List<Rite>()
                {
                    new TreeloreFestival(),
                    new AxeOffering()
                },
                Behaviours.Feasts.Feast.FeastType.Treelore);

            AseraCode.Initialize(DefaultDivinities.Instance.AseraMain,
                new List<Divinity>
                {
                    DefaultDivinities.Instance.AseraSecondary1, DefaultDivinities.Instance.AseraSecondary2,
                    DefaultDivinities.Instance.AseraSecondary3
                },
                new Dictionary<TraitObject, bool>
                {
                    {DefaultTraits.Honor, true},
                    {DefaultTraits.Valor, true}
                },
                 new List<Doctrine>
                {
                    DefaultDoctrines.Instance.Literalism,
                    DefaultDoctrines.Instance.Legalism,
                    DefaultDoctrines.Instance.HeathenTax,
                    DefaultDoctrines.Instance.Esotericism
                },
                BKCEFaithGroups.Instance.AseraGroup,
                new List<Rite>
                {
                    new Zabiha()
                });

            AmraOllahm.Initialize(DefaultDivinities.Instance.AmraMain,
                new List<Divinity> { DefaultDivinities.Instance.AmraSecondary1, DefaultDivinities.Instance.AmraSecondary2 },
                new Dictionary<TraitObject, bool>
                {
                    {DefaultTraits.Honor, false},
                    {DefaultTraits.Valor, true}
                },
                BKCEFaithGroups.Instance.BattaniaGroup,
                 new List<Doctrine>
                {
                    DefaultDoctrines.Instance.Druidism,
                    DefaultDoctrines.Instance.Animism
                },
                new List<Rite>
                {
                    new IronOffering(),
                    new GreatSwordOffering()
                });

            Calradism.Initialize(BKCEDivinities.Instance.Calradios,
                new List<Divinity>   
                {
                    BKCEDivinities.Instance.Erithrians
                },
                new Dictionary<TraitObject, bool>
                {
                    {DefaultTraits.Honor, true},
                    {BKTraits.Instance.Just, true},
                    {BKTraits.Instance.Diligent, true}
                },
                new List<Doctrine>
                {
                    DefaultDoctrines.Instance.RenovatioImperi,
                    DefaultDoctrines.Instance.Esotericism,
                    DefaultDoctrines.Instance.Astrology
                },
                BKCEFaithGroups.Instance.ImperialGroup,
                new List<Rite>()
                {
                    new Liberatio()
                });

            Legionaries.Initialize(BKCEDivinities.Instance.Sarapios,
               new List<Divinity>
               {
                    BKCEDivinities.Instance.Ireos
               },
               new Dictionary<TraitObject, bool>
               {
                    {DefaultTraits.Honor, true},
                    {DefaultTraits.Generosity, false},
                    {DefaultTraits.Valor, true}
               },
               new List<Doctrine>
               {
                    DefaultDoctrines.Instance.RenovatioImperi,
                    DefaultDoctrines.Instance.Astrology,
                    DefaultDoctrines.Instance.Esotericism
               },
               BKCEFaithGroups.Instance.ImperialGroup,
               new List<Rite>()
               {
                    new Lustratio(),
                    new Liberatio()
               });

            Darusosian.Initialize(DefaultDivinities.Instance.DarusosianMain,
                new List<Divinity>
                    {DefaultDivinities.Instance.DarusosianSecondary1, DefaultDivinities.Instance.DarusosianSecondary2},
                new Dictionary<TraitObject, bool>
                {
                    {DefaultTraits.Honor, true},
                    {DefaultTraits.Mercy, true}
                },
                new List<Doctrine>
                {
                    DefaultDoctrines.Instance.Legalism,
                    DefaultDoctrines.Instance.Astrology,
                    DefaultDoctrines.Instance.Childbirth
                },
                BKCEFaithGroups.Instance.ImperialGroup, 
                new List<Rite>() 
                { 
                    new DarusosianExecution(),
                    new AstaroniaFestival(),
                    new Lustratio()
                },
                Behaviours.Feasts.Feast.FeastType.Astaronia);

            Osfeyd.Initialize(DefaultDivinities.Instance.Wilund,
                new List<Divinity>
                {
                   DefaultDivinities.Instance.Osric,
                   DefaultDivinities.Instance.Horsa,
                   DefaultDivinities.Instance.Oca
                },
                new Dictionary<TraitObject, bool>
                {
                    { DefaultTraits.Mercy, false},
                    { DefaultTraits.Valor, true },
                    { BKTraits.Instance.Ambitious, true}
                },
                BKCEFaithGroups.Instance.VlandiaGroup,
                new List<Doctrine>
                {
                    DefaultDoctrines.Instance.OsricsVengeance,
                    DefaultDoctrines.Instance.Animism
                },
                new List<Rite>()
                {
                    new VlandiaHorse(),
                    new LanceOffering()
                });

            SixWinds.Initialize(DefaultDivinities.Instance.WindHeaven,
                new List<Divinity>
                {
                    DefaultDivinities.Instance.WindHell,
                    DefaultDivinities.Instance.WindEast,
                    DefaultDivinities.Instance.WindWest,
                    DefaultDivinities.Instance.WindNorth,
                    DefaultDivinities.Instance.WindSouth,
                    DefaultDivinities.Instance.SheWolf,
                    DefaultDivinities.Instance.Iltanlar,
                },
                new Dictionary<TraitObject, bool>
                {
                    {DefaultTraits.Honor, true},
                    {BKTraits.Instance.Just, true}
                },
                BKCEFaithGroups.Instance.DevsegGroup,
                new List<Doctrine>
                {
                    DefaultDoctrines.Instance.Animism,
                    DefaultDoctrines.Instance.Shamanism,
                    DefaultDoctrines.Instance.Tolerant,
                    DefaultDoctrines.Instance.Reavers
                },
                new List<Rite>()
                {
                });

            foreach (var faith in All)
            {
                DefaultFaiths.Instance.AddObject(faith);
            }
        }
    }
}
