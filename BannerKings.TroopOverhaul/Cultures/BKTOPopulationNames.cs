using BannerKings.Managers.Cultures;
using System;
using System.Collections.Generic;
using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Localization;

namespace BannerKings.CulturesExpanded.Cultures
{
    public class BKTOPopulationNames : DefaultTypeInitializer<BKTOPopulationNames, CulturalPopulationName>
    {
        #region Empire
        public CulturalPopulationName EmpireNobles { get; set; }
        public CulturalPopulationName EmpireCraftsmen { get; set; }
        public CulturalPopulationName EmpireTenants { get; set; }
        public CulturalPopulationName EmpireSerfs { get; set; }
        public CulturalPopulationName EmpireSlaves { get; set; }
        #endregion Empire

        #region Sturgia
        public CulturalPopulationName SturgiaNobles { get; set; }
        public CulturalPopulationName SturgiaCraftsmen { get; set; }
        public CulturalPopulationName SturgiaTenants { get; set; }
        public CulturalPopulationName SturgiaSerfs { get; set; }
        public CulturalPopulationName SturgiaSlaves { get; set; }
        #endregion Sturgia

        #region Vlandia
        public CulturalPopulationName VlandiaNobles { get; set; }
        public CulturalPopulationName VlandiaCraftsmen { get; set; }
        public CulturalPopulationName VlandiaTenants { get; set; }
        public CulturalPopulationName VlandiaSerfs { get; set; }
        public CulturalPopulationName VlandiaSlaves { get; set; }
        #endregion Vlandia

        #region Battania
        public CulturalPopulationName BattaniaNobles { get; set; }
        public CulturalPopulationName BattaniaCraftsmen { get; set; }
        public CulturalPopulationName BattaniaTenants { get; set; }
        public CulturalPopulationName BattaniaSerfs { get; set; }
        public CulturalPopulationName BattaniaSlaves { get; set; }
        #endregion Battania

        #region Aserai
        public CulturalPopulationName AseraiNobles { get; set; }
        public CulturalPopulationName AseraiCraftsmen { get; set; }
        public CulturalPopulationName AseraiTenants { get; set; }
        public CulturalPopulationName AseraiSerfs { get; set; }
        public CulturalPopulationName AseraiSlaves { get; set; }
        #endregion Aserai

        #region Khuzai
        public CulturalPopulationName KhuzaitNobles { get; set; }
        public CulturalPopulationName KhuzaitCraftsmen { get; set; }
        public CulturalPopulationName KhuzaitTenants { get; set; }
        public CulturalPopulationName KhuzaitSerfs { get; set; }
        public CulturalPopulationName KhuzaitSlaves { get; set; }
        #endregion Khuzai

        public override IEnumerable<CulturalPopulationName> All => throw new NotImplementedException();

        public override void Initialize()
        {
            var cultures = Campaign.Current.ObjectManager.GetObjectTypeList<CultureObject>();
            var empire = cultures.First(x => x.StringId == BannerKingsConfig.EmpireCulture);
            var vlandia = cultures.First(x => x.StringId == BannerKingsConfig.VlandiaCulture);
            var battania = cultures.First(x => x.StringId == BannerKingsConfig.BattaniaCulture);
            var khuzait = cultures.First(x => x.StringId == BannerKingsConfig.KhuzaitCulture);
            var aserai = cultures.First(x => x.StringId == BannerKingsConfig.AseraiCulture);
            var sturgia = cultures.First(x => x.StringId == BannerKingsConfig.SturgiaCulture);
            #region Empire
            EmpireNobles = CulturalPopulationName.CreateNobles("EmpireNobles",
                empire,
                new TextObject("{=Uv29oSQT}Nobiles"));

            EmpireCraftsmen = CulturalPopulationName.CreateCraftsmen("EmpireCraftsmen",
                empire,
               new TextObject("{=6hrBerHd}Cives"));

            EmpireTenants = CulturalPopulationName.CreateTenants("EmpireTenants",
                empire,
                new TextObject("{=GThkJp2s}Coloni"));

            EmpireSerfs = CulturalPopulationName.CreateSerfs("EmpireSerfs",
                empire,
                new TextObject("{=5Ym25L00}Servi"));

            EmpireSlaves = CulturalPopulationName.CreateSlaves("EmpireSlaves",
                empire,
                new TextObject("{=B9hAxxuo}Sclavi"));
            #endregion Empire

            #region Aserai
            AseraiNobles = CulturalPopulationName.CreateNobles("AseraiNobles",
                aserai,
                new TextObject("{=Uv29oSQT}Nobiles"));

            AseraiCraftsmen = CulturalPopulationName.CreateCraftsmen("AseraiCraftsmen",
                aserai,
               new TextObject("{=6hrBerHd}Cives"));

            AseraiTenants = CulturalPopulationName.CreateTenants("AseraiTenants",
                aserai,
                new TextObject("{=GThkJp2s}Coloni"));

            AseraiSerfs = CulturalPopulationName.CreateSerfs("AseraiSerfs",
                aserai,
                new TextObject("{=5Ym25L00}Servi"));

            AseraiSlaves = CulturalPopulationName.CreateSlaves("AseraiSlaves",
                aserai,
                new TextObject("{=TASERbwx}Mameluke"));
            #endregion Aserai

            #region Battania
            BattaniaNobles = CulturalPopulationName.CreateNobles("BattaniaNobles",
                battania,
                new TextObject("{=Uv29oSQT}Nobiles"));

            BattaniaCraftsmen = CulturalPopulationName.CreateCraftsmen("BattaniaCraftsmen",
                battania,
               new TextObject("{=6hrBerHd}Cives"));

            BattaniaTenants = CulturalPopulationName.CreateTenants("BattaniaTenants",
                battania,
                new TextObject("{=GThkJp2s}Coloni"));

            BattaniaSerfs = CulturalPopulationName.CreateSerfs("BattaniaSerfs",
                battania,
                new TextObject("{=5Ym25L00}Servi"));

            BattaniaSlaves = CulturalPopulationName.CreateSlaves("BattaniaSlaves",
                battania,
                new TextObject("{=B9hAxxuo}Sclavi"));
            #endregion Battania

            #region Vlandia
            VlandiaNobles = CulturalPopulationName.CreateNobles("VlandiaNobles",
                vlandia,
                new TextObject("{=!}Gesithas"));

            VlandiaCraftsmen = CulturalPopulationName.CreateCraftsmen("VlandiaCraftsmen",
                vlandia,
               new TextObject("{=!}Smithas"));

            VlandiaTenants = CulturalPopulationName.CreateTenants("VlandiaTenants",
                vlandia,
                new TextObject("{=!}Ceorlas"));

            VlandiaSerfs = CulturalPopulationName.CreateSerfs("VlandiaSerfs",
                vlandia,
                new TextObject("{=!}Cottas"));

            VlandiaSlaves = CulturalPopulationName.CreateSlaves("VlandiaSlaves",
                vlandia,
                new TextObject("{=!}Theowe"));
            #endregion Vlandia

            /*
             *   #region Osrickin https://www.anglo-norman.net/entry/artificer
            VlandiaNobles = CulturalPopulationName.CreateNobles("VlandiaNobles",
                vlandia,
                new TextObject("{=!}Gesithas"));

            VlandiaCraftsmen = CulturalPopulationName.CreateCraftsmen("VlandiaCraftsmen",
                vlandia,
               new TextObject("{=!}Artefeceres"));

            VlandiaTenants = CulturalPopulationName.CreateTenants("VlandiaTenants",
                vlandia,
                new TextObject("{=!}Ceorlas"));

            VlandiaSerfs = CulturalPopulationName.CreateSerfs("VlandiaSerfs",
                vlandia,
                new TextObject("{=!}Villeins"));

            VlandiaSlaves = CulturalPopulationName.CreateSlaves("VlandiaSlaves",
                vlandia,
                new TextObject("{=!}Theowe"));
            #endregion Osrickin
             */

            #region Khuzait
            KhuzaitNobles = CulturalPopulationName.CreateNobles("KhuzaitNobles",
                khuzait,
                new TextObject("{=Uv29oSQT}Nobiles"));

            KhuzaitCraftsmen = CulturalPopulationName.CreateCraftsmen("KhuzaitCraftsmen",
                khuzait,
               new TextObject("{=6hrBerHd}Cives"));

            KhuzaitTenants = CulturalPopulationName.CreateTenants("KhuzaitTenants",
                khuzait,
                new TextObject("{=GThkJp2s}Coloni"));

            KhuzaitSerfs = CulturalPopulationName.CreateSerfs("KhuzaitSerfs",
                khuzait,
                new TextObject("{=5Ym25L00}Servi"));

            KhuzaitSlaves = CulturalPopulationName.CreateSlaves("KhuzaitSlaves",
                khuzait,
                new TextObject("{=B9hAxxuo}Sclavi"));
            #endregion Khuzait

            #region Sturgia
            SturgiaNobles = CulturalPopulationName.CreateNobles("SturgiaNobles",
                sturgia,
                new TextObject("{=!}Nobles"));

            SturgiaCraftsmen = CulturalPopulationName.CreateCraftsmen("SturgiaCraftsmen",
                sturgia,
               new TextObject("{=6hrBerHd}Cives"));

            SturgiaTenants = CulturalPopulationName.CreateTenants("SturgiaTenants",
                sturgia,
                new TextObject("{=VviUbJTS}Smerdy"));

            SturgiaSerfs = CulturalPopulationName.CreateSerfs("SturgiaSerfs",
                sturgia,
                new TextObject("{=f9tsDXWf}Kholops"));

            SturgiaSlaves = CulturalPopulationName.CreateSlaves("SturgiaSlaves",
                sturgia,
                new TextObject("{=j6UDXO39}Thralls"));
            #endregion Sturgia

            foreach (CulturalPopulationName name in All)
            {
                DefaultPopulationNames.Instance.AddObject(name)
            };
        }
    }
}
