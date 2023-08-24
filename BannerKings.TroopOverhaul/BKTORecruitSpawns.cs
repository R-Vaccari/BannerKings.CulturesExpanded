using BannerKings.Managers.Innovations.Eras;
using BannerKings.Managers.Recruits;
using System.Collections.Generic;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;

namespace BannerKings.CulturesExpanded
{
    internal class BKTORecruitSpawns : DefaultTypeInitializer<BKTORecruitSpawns, RecruitSpawn>
    {
        #region strugia
        public RecruitSpawn SturgiaMeleeT1 { get; } = new RecruitSpawn();
        public RecruitSpawn SturgiaRangedT1 { get; } = new RecruitSpawn();
        public RecruitSpawn SturgiaMeleeT2 { get; } = new RecruitSpawn();
        public RecruitSpawn SturgiaRangedT2 { get; } = new RecruitSpawn();
        public RecruitSpawn SturgiaMeleeT3 { get; } = new RecruitSpawn();
        public RecruitSpawn SturgiaTyal { get; } = new RecruitSpawn();
        public RecruitSpawn SturgiaNoble { get; } = new RecruitSpawn();
        #endregion sturgia

        #region empire
        public RecruitSpawn EmpireMeleeT1 { get; } = new RecruitSpawn();
        public RecruitSpawn EmpireRangedT1 { get; } = new RecruitSpawn();
        public RecruitSpawn EmpireMeleeT2 { get; } = new RecruitSpawn();
        public RecruitSpawn EmpireRangedT2 { get; } = new RecruitSpawn();
        public RecruitSpawn EmpireMeleeT3 { get; } = new RecruitSpawn();
        public RecruitSpawn EmpireEques { get; } = new RecruitSpawn();
        public RecruitSpawn EmpireNoble { get; } = new RecruitSpawn();
        public RecruitSpawn EmpirePeltast { get; } = new RecruitSpawn();
        #endregion empire

        #region Vlandia
        public RecruitSpawn VlandiaMeleeT1 { get; } = new RecruitSpawn();
        public RecruitSpawn VlandiaRangedT1 { get; } = new RecruitSpawn();
        public RecruitSpawn VlandiaMeleeT2 { get; } = new RecruitSpawn();
        public RecruitSpawn VlandiaRangedT2 { get; } = new RecruitSpawn();
        public RecruitSpawn VlandiaMeleeT3 { get; } = new RecruitSpawn();
        public RecruitSpawn VlandiaJaculan { get; } = new RecruitSpawn();
        public RecruitSpawn VlandiaPravend { get; } = new RecruitSpawn();
        public RecruitSpawn VlandiaNoble { get; } = new RecruitSpawn();
        #endregion Vlandia

        #region Battania
        public RecruitSpawn BattaniaMeleeT1 { get; } = new RecruitSpawn();
        public RecruitSpawn BattaniaRangedT1 { get; } = new RecruitSpawn();
        public RecruitSpawn BattaniaMeleeT2 { get; } = new RecruitSpawn();
        public RecruitSpawn BattaniaRangedT2 { get; } = new RecruitSpawn();
        public RecruitSpawn BattaniaMeleeT3 { get; } = new RecruitSpawn();
        public RecruitSpawn BattaniaSpearSergeant { get; } = new RecruitSpawn();
        public RecruitSpawn BattaniaSkirmisher { get; } = new RecruitSpawn();
        public RecruitSpawn BattaniaNoble { get; } = new RecruitSpawn();
        #endregion Battania

        #region Aserai
        public RecruitSpawn AseraiMeleeT1 { get; } = new RecruitSpawn();
        public RecruitSpawn AseraiRangedT1 { get; } = new RecruitSpawn();
        public RecruitSpawn AseraiMeleeT2 { get; } = new RecruitSpawn();
        public RecruitSpawn AseraiRangedT2 { get; } = new RecruitSpawn();
        public RecruitSpawn AseraiMeleeT3 { get; } = new RecruitSpawn();
        public RecruitSpawn AseraiCamel { get; } = new RecruitSpawn();
        public RecruitSpawn AseraiCamelNoble { get; } = new RecruitSpawn();
        public RecruitSpawn AseraiNoble { get; } = new RecruitSpawn();
        public RecruitSpawn KanicRider { get; } = new RecruitSpawn();
        public RecruitSpawn KanicHorseman { get; } = new RecruitSpawn();
        #endregion Aserai

        #region Khuzait
        public RecruitSpawn KhuzaitRangedT1 { get; } = new RecruitSpawn();
        public RecruitSpawn KhuzaitMeleeT2 { get; } = new RecruitSpawn();
        public RecruitSpawn KhuzaitRangedT2 { get; } = new RecruitSpawn();
        public RecruitSpawn KhuzaitMeleeT3 { get; } = new RecruitSpawn();
        public RecruitSpawn KhuzaitInfantryT3 { get; } = new RecruitSpawn();
        public RecruitSpawn KhuzaitInfantryT2 { get; } = new RecruitSpawn();
        public RecruitSpawn KhuzaitNoble { get; } = new RecruitSpawn();
        #endregion Khuzait

        public override IEnumerable<RecruitSpawn> All
        {
            get
            {
                yield return SturgiaMeleeT1;
                yield return SturgiaRangedT1;
                yield return SturgiaMeleeT2;
                yield return SturgiaRangedT2;
                yield return SturgiaMeleeT3;
                yield return SturgiaTyal;
                yield return SturgiaNoble;
                yield return EmpireMeleeT1;
                yield return EmpireRangedT1;
                yield return EmpireMeleeT2;
                yield return EmpireRangedT2;
                yield return EmpirePeltast;
                yield return EmpireMeleeT3;
                yield return EmpireEques;
                yield return EmpireNoble;
                yield return VlandiaMeleeT1;
                yield return VlandiaRangedT1;
                yield return VlandiaMeleeT2;
                yield return VlandiaRangedT2;
                yield return VlandiaMeleeT3;
                yield return VlandiaPravend;
                yield return VlandiaJaculan;
                yield return VlandiaNoble;
                yield return BattaniaMeleeT1;
                yield return BattaniaMeleeT2;
                yield return BattaniaMeleeT3;
                yield return BattaniaSpearSergeant;
                yield return BattaniaRangedT1;     
                yield return BattaniaRangedT2;
                yield return BattaniaSkirmisher;
                yield return BattaniaNoble;             
                yield return AseraiMeleeT1;
                yield return AseraiRangedT1;
                yield return AseraiMeleeT2;
                yield return AseraiRangedT2;
                yield return AseraiMeleeT3;
                yield return KanicRider;
                yield return KanicHorseman;
                yield return AseraiCamel;
                yield return AseraiCamelNoble;
                yield return AseraiNoble;
                yield return KhuzaitRangedT1;
                yield return KhuzaitMeleeT2;
                yield return KhuzaitRangedT2;
                yield return KhuzaitMeleeT3;
                yield return KhuzaitInfantryT2;
                yield return KhuzaitNoble;
                yield return KhuzaitInfantryT3;
            }
        }

        public override void Initialize()
        {
            #region sturgia
            var sturgia = GetCulture("sturgia");
            SturgiaMeleeT1.Initialize(GetTroop("bk_sturgian_levy"),
                sturgia,
                0.7f,
                Managers.PopulationManager.PopType.Serfs
                );

            SturgiaRangedT1.Initialize(GetTroop("bk_sturgian_levy_archer"),
                sturgia,
                0.3f,
                Managers.PopulationManager.PopType.Serfs
                );

            SturgiaMeleeT2.Initialize(GetTroop("bk_sturgian_militiaman"),
                sturgia,
                0.7f,
                Managers.PopulationManager.PopType.Tenants
                );

            SturgiaRangedT2.Initialize(GetTroop("bk_sturgian_militiaman_archer"),
                sturgia,
                0.3f,
                Managers.PopulationManager.PopType.Tenants
                );

            SturgiaMeleeT3.Initialize(GetTroop("bk_sturgia_sergeant"),
                sturgia,
                1f,
                Managers.PopulationManager.PopType.Craftsmen
                );

            SturgiaMeleeT3.Initialize(GetTroop("bk_sturgia_squire"),
                sturgia,
                1f,
                Managers.PopulationManager.PopType.Nobles
                );

            SturgiaTyal.Initialize(GetTroop("bk_sturgian_tyalese_archer"),
                sturgia,
                1f,
                Managers.PopulationManager.PopType.Craftsmen
                );
            SturgiaTyal.AddFiefString("town_S5");

            #endregion sturgia

            #region empire
            var empire = GetCulture("empire");
            EmpireMeleeT1.Initialize(GetTroop("bk_imperial_levy"),
                empire,
                0.7f,
                Managers.PopulationManager.PopType.Serfs
                );

            EmpireRangedT1.Initialize(GetTroop("bk_imperial_levy_archer"),
                empire,
                0.3f,
                Managers.PopulationManager.PopType.Serfs
                );

            EmpireMeleeT2.Initialize(GetTroop("bk_imperial_militiaman"),
                empire,
                0.5f,
                Managers.PopulationManager.PopType.Tenants
                );

            EmpirePeltast.Initialize(GetTroop("bk_imperial_peltast"),
                empire,
                0.2f,
                Managers.PopulationManager.PopType.Tenants
                );

            EmpireRangedT2.Initialize(GetTroop("bk_imperial_militiaman_archer"),
                empire,
                0.3f,
                Managers.PopulationManager.PopType.Tenants
                );

            EmpireMeleeT3.Initialize(GetTroop("bk_imperial_sergeant"),
                empire,
                1f,
                Managers.PopulationManager.PopType.Craftsmen
                );
            EmpireMeleeT3.SetTroopAdvancement(DefaultEras.Instance.SecondEra, "bk_skoutatos_e2");
            EmpireMeleeT3.SetTroopAdvancement(DefaultEras.Instance.ThirdEra, "bk_skoutatos_e3");

            EmpireNoble.Initialize(GetTroop("bk_imperial_squire"),
               empire,
               1f,
               Managers.PopulationManager.PopType.Nobles
               );
            EmpireNoble.SetTroopAdvancement(DefaultEras.Instance.SecondEra, "bk_imperial_squire_e2");
            EmpireNoble.SetTroopAdvancement(DefaultEras.Instance.ThirdEra, "bk_imperial_squire_e3");

            var cataphract = GetTroop("bk_imperial_cataphract");
            DefaultEras.Instance.SecondEra.AddTroopAdvancement(new BKTroopAdvancement(cataphract, 
                "bk_cataphract_e2"));
            DefaultEras.Instance.ThirdEra.AddTroopAdvancement(new BKTroopAdvancement(cataphract,
                "bk_cataphract_e3"));

            EmpireEques.Initialize(GetTroop("bk_imperial_eques"),
                empire,
                1f,
                Managers.PopulationManager.PopType.Craftsmen
                );
            EmpireEques.SetTroopAdvancement(DefaultEras.Instance.SecondEra, "bk_imperial_eques_e2");
            EmpireEques.SetTroopAdvancement(DefaultEras.Instance.ThirdEra, "bk_imperial_eques_e3");
            #endregion empire

            #region Vlandia
            var Vlandia = GetCulture("vlandia");
            VlandiaMeleeT1.Initialize(GetTroop("bk_vlandia_levy"),
                Vlandia,
                0.7f,
                Managers.PopulationManager.PopType.Serfs
                );

            VlandiaRangedT1.Initialize(GetTroop("bk_vlandia_levy_crossbow"),
                Vlandia,
                0.3f,
                Managers.PopulationManager.PopType.Serfs
                );

            VlandiaMeleeT2.Initialize(GetTroop("bk_vlandia_militiaman"),
                Vlandia,
                0.7f,
                Managers.PopulationManager.PopType.Tenants
                );

            VlandiaRangedT2.Initialize(GetTroop("bk_vlandia_militiaman_crossbow"),
                Vlandia,
                0.3f,
                Managers.PopulationManager.PopType.Tenants
                );

            VlandiaMeleeT3.Initialize(GetTroop("bk_vlandia_sergeant"),
                Vlandia,
                1f,
                Managers.PopulationManager.PopType.Craftsmen
                );

            VlandiaNoble.Initialize(GetTroop("bk_vlandia_squire"),
               Vlandia,
               1f,
               Managers.PopulationManager.PopType.Nobles
               );
            VlandiaNoble.SetTroopAdvancement(DefaultEras.Instance.SecondEra, "bk_vlandia_knight_e2");

            VlandiaPravend.Initialize(GetTroop("bk_vlandia_longbowman"),
                Vlandia,
                1f,
                Managers.PopulationManager.PopType.Craftsmen
                );
            VlandiaPravend.AddFiefString("town_V3");

            VlandiaJaculan.Initialize(GetTroop("bk_vlandia_jaculan_xbow"),
                Vlandia,
                1f,
                Managers.PopulationManager.PopType.Craftsmen
                );
            VlandiaJaculan.AddFiefString("town_V6");
            #endregion Vlandia

            #region Battania
            var Battania = GetCulture("battania");
            BattaniaMeleeT1.Initialize(GetTroop("bk_battanian_levy"),
                Battania,
                0.7f,
                Managers.PopulationManager.PopType.Serfs
                );

            BattaniaRangedT1.Initialize(GetTroop("bk_battanian_levy_archer"),
                Battania,
                0.3f,
                Managers.PopulationManager.PopType.Serfs
                );

            BattaniaMeleeT2.Initialize(GetTroop("bk_battanian_militiaman"),
                Battania,
                0.7f,
                Managers.PopulationManager.PopType.Tenants
                );

            BattaniaRangedT2.Initialize(GetTroop("bk_battanian_militiaman_archer"),
                Battania,
                0.3f,
                Managers.PopulationManager.PopType.Tenants
                );

            BattaniaSkirmisher.Initialize(GetTroop("bk_battanian_skirmisher"),
                Battania,
                0.3f,
                Managers.PopulationManager.PopType.Tenants
                );

            BattaniaMeleeT3.Initialize(GetTroop("bk_battanian_sergeant"),
                Battania,
                0.5f,
                Managers.PopulationManager.PopType.Craftsmen
                );

            BattaniaSpearSergeant.Initialize(GetTroop("bk_battanian_sergeant_spear"),
                Battania,
                0.5f,
                Managers.PopulationManager.PopType.Craftsmen
                );

            BattaniaNoble.Initialize(GetTroop("bk_battanian_squire"),
               Battania,
               1f,
               Managers.PopulationManager.PopType.Nobles
               );
            #endregion Battania

            #region Aserai
            var Aserai = GetCulture("aserai");
            AseraiMeleeT1.Initialize(GetTroop("bk_aserai_levy"),
                Aserai,
                0.7f,
                Managers.PopulationManager.PopType.Serfs
                );

            AseraiRangedT1.Initialize(GetTroop("bk_aserai_levy_archer"),
                Aserai,
                0.3f,
                Managers.PopulationManager.PopType.Serfs
                );

            AseraiMeleeT2.Initialize(GetTroop("bk_aserai_militiaman"),
                Aserai,
                0.7f,
                Managers.PopulationManager.PopType.Tenants
                );

            AseraiRangedT2.Initialize(GetTroop("bk_aserai_militiaman_archer"),
                Aserai,
                0.3f,
                Managers.PopulationManager.PopType.Tenants
                );

            AseraiCamel.Initialize(GetTroop("bk_aserai_tuareg"),
               Aserai,
               0.3f,
               Managers.PopulationManager.PopType.Tenants
               );
            AseraiCamel.AddFiefString("town_A7");
            AseraiCamel.AddFiefString("castle_A3");
            AseraiCamel.AddFiefString("castle_A9");
            AseraiCamel.AddFiefString("castle_A4");
            AseraiCamel.AddFiefString("town_A3");
            AseraiCamel.AddFiefString("castle_A5"); 
            AseraiCamel.AddFiefString("town_A5");
            AseraiCamel.AddFiefString("castle_A2");
            AseraiCamel.AddFiefString("castle_A7");
            AseraiCamel.AddFiefString("town_A6"); 
            AseraiCamel.AddFiefString("town_A8");
            AseraiCamel.AddFiefString("castle_A1");

            AseraiCamelNoble.Initialize(GetTroop("bk_aserai_tuareg_noble"),
               Aserai,
               0.7f,
               Managers.PopulationManager.PopType.Nobles
               );
            AseraiCamelNoble.AddFiefString("town_A7");
            AseraiCamelNoble.AddFiefString("castle_A3");
            AseraiCamelNoble.AddFiefString("castle_A9");
            AseraiCamelNoble.AddFiefString("castle_A4");
            AseraiCamelNoble.AddFiefString("town_A3");
            AseraiCamelNoble.AddFiefString("castle_A5");
            AseraiCamelNoble.AddFiefString("town_A5");
            AseraiCamelNoble.AddFiefString("castle_A2");
            AseraiCamelNoble.AddFiefString("castle_A7");
            AseraiCamelNoble.AddFiefString("town_A6");
            AseraiCamelNoble.AddFiefString("town_A8");
            AseraiCamelNoble.AddFiefString("castle_A1");
            
            AseraiMeleeT3.Initialize(GetTroop("bk_aserai_sergeant"),
                Aserai,
                1f,
                Managers.PopulationManager.PopType.Craftsmen
                );

            KanicRider.Initialize(GetTroop("bk_kanic_rider"),
                Aserai,
                0.15f,
                Managers.PopulationManager.PopType.Tenants
                );
            KanicRider.AddFiefString("town_A1");
            KanicRider.AddFiefString("castle_A1");
            KanicRider.AddFiefString("castle_A7");
            KanicRider.AddFiefString("town_A6");
            KanicRider.AddFiefString("town_A8");
            KanicRider.AddFiefString("town_A4");

            KanicHorseman.Initialize(GetTroop("bk_kanic_horseman"),
                Aserai,
                0.15f,
                Managers.PopulationManager.PopType.Craftsmen
                );
            KanicHorseman.AddFiefString("town_A1");
            KanicHorseman.AddFiefString("castle_A1");
            KanicHorseman.AddFiefString("castle_A7");
            KanicHorseman.AddFiefString("town_A6");
            KanicHorseman.AddFiefString("town_A8");
            KanicHorseman.AddFiefString("town_A4");

            AseraiNoble.Initialize(GetTroop("bk_aserai_squire"),
               Aserai,
               1f,
               Managers.PopulationManager.PopType.Nobles
               );
            #endregion Aserai

            #region Khuzait
            var Khuzait = GetCulture("khuzait");
            KhuzaitRangedT1.Initialize(GetTroop("bk_khuzait_levy"),
                Khuzait,
                1f,
                Managers.PopulationManager.PopType.Serfs
                );

            KhuzaitMeleeT2.Initialize(GetTroop("bk_khuzait_militiaman_lancer"),
                Khuzait,
                0.5f,
                Managers.PopulationManager.PopType.Tenants
                );

            KhuzaitRangedT2.Initialize(GetTroop("bk_khuzait_militiaman"),
                Khuzait,
                0.6f,
                Managers.PopulationManager.PopType.Tenants
                );

            KhuzaitInfantryT2.Initialize(GetTroop("bk_khuzait_militiaman_infantry"),
                Khuzait,
                0.2f,
                Managers.PopulationManager.PopType.Tenants
                );

            KhuzaitInfantryT3.Initialize(GetTroop("bk_khuzait_sergeant_infantry"),
                Khuzait,
                0.2f,
                Managers.PopulationManager.PopType.Craftsmen
                );

            KhuzaitMeleeT3.Initialize(GetTroop("bk_khuzait_sergeant_lancer"),
                Khuzait,
                1f,
                Managers.PopulationManager.PopType.Craftsmen
                );

            KhuzaitNoble.Initialize(GetTroop("bk_khuzait_squire"),
               Khuzait,
               1f,
               Managers.PopulationManager.PopType.Nobles
               );      
            #endregion Khuzait

            foreach (var spawn in All)
            {
                DefaultRecruitSpawns.Instance.AddObject(spawn);
            }
        }

        private CultureObject GetCulture(string id) => Campaign.Current.ObjectManager.GetObject<CultureObject>(x => x.StringId == id);
        private CharacterObject GetTroop(string id) => Campaign.Current.ObjectManager.GetObject<CharacterObject>(x => x.StringId == id);
    }
}
