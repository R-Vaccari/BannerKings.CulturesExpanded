using BannerKings.Managers.Cultures;
using BannerKings.Settings;
using System.Collections.Generic;
using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Localization;

namespace BannerKings.CulturesExpanded.Cultures
{
    public class BKTOTitleNames : DefaultTypeInitializer<BKTOTitleNames, CulturalTitleName>
    {
        #region Empire
        public CulturalTitleName EmpireEmperor { get; private set; }
        public CulturalTitleName EmpireKing { get; private set; }
        public CulturalTitleName EmpireDuke { get; private set; }
        public CulturalTitleName EmpireCount { get; private set; }
        public CulturalTitleName EmpireBaron { get; private set; }
        public CulturalTitleName EmpireLord { get; private set; }
        public CulturalTitleName EmpirePrince { get; private set; }
        public CulturalTitleName EmpireKnight { get; private set; }
        #endregion Empire

        #region Aserai
        public CulturalTitleName AseraiEmperor { get; private set; }
        public CulturalTitleName AseraiKing { get; private set; }
        public CulturalTitleName AseraiDuke { get; private set; }
        public CulturalTitleName AseraiCount { get; private set; }
        public CulturalTitleName AseraiBaron { get; private set; }
        public CulturalTitleName AseraiLord { get; private set; }
        public CulturalTitleName AseraiPrince { get; private set; }
        public CulturalTitleName AseraiKnight { get; private set; }
        #endregion Aserai

        #region Battania
        public CulturalTitleName BattaniaEmperor { get; private set; }
        public CulturalTitleName BattaniaKing { get; private set; }
        public CulturalTitleName BattaniaDuke { get; private set; }
        public CulturalTitleName BattaniaCount { get; private set; }
        public CulturalTitleName BattaniaBaron { get; private set; }
        public CulturalTitleName BattaniaLord { get; private set; }
        public CulturalTitleName BattaniaPrince { get; private set; }
        public CulturalTitleName BattaniaKnight { get; private set; }
        #endregion Battania

        #region Vlandia
        public CulturalTitleName VlandiaEmperor { get; private set; }
        public CulturalTitleName VlandiaKing { get; private set; }
        public CulturalTitleName VlandiaDuke { get; private set; }
        public CulturalTitleName VlandiaCount { get; private set; }
        public CulturalTitleName VlandiaBaron { get; private set; }
        public CulturalTitleName VlandiaLord { get; private set; }
        public CulturalTitleName VlandiaPrince { get; private set; }
        public CulturalTitleName VlandiaKnight { get; private set; }
        #endregion Vlandia

        #region Sturgia
        public CulturalTitleName SturgiaEmperor { get; private set; }
        public CulturalTitleName SturgiaKing { get; private set; }
        public CulturalTitleName SturgiaDuke { get; private set; }
        public CulturalTitleName SturgiaCount { get; private set; }
        public CulturalTitleName SturgiaBaron { get; private set; }
        public CulturalTitleName SturgiaLord { get; private set; }
        public CulturalTitleName SturgiaPrince { get; private set; }
        public CulturalTitleName SturgiaKnight { get; private set; }
        #endregion Sturgia

        #region Khuzait
        public CulturalTitleName KhuzaitEmperor { get; private set; }
        public CulturalTitleName KhuzaitKing { get; private set; }
        public CulturalTitleName KhuzaitDuke { get; private set; }
        public CulturalTitleName KhuzaitCount { get; private set; }
        public CulturalTitleName KhuzaitBaron { get; private set; }
        public CulturalTitleName KhuzaitLord { get; private set; }
        public CulturalTitleName KhuzaitPrince { get; private set; }
        public CulturalTitleName KhuzaitKnight { get; private set; }
        #endregion Khuzait

        public override IEnumerable<CulturalTitleName> All
        {
            get
            {
                yield return AseraiEmperor;
                yield return AseraiKing;
                yield return AseraiDuke;
                yield return AseraiCount;
                yield return AseraiBaron;
                yield return AseraiLord;
                yield return AseraiPrince;
                yield return AseraiKnight;

                yield return BattaniaEmperor;
                yield return BattaniaKing;
                yield return BattaniaDuke;
                yield return BattaniaCount;
                yield return BattaniaBaron;
                yield return BattaniaLord;
                yield return BattaniaPrince;
                yield return BattaniaKnight;

                yield return KhuzaitEmperor;
                yield return KhuzaitKing;
                yield return KhuzaitDuke;
                yield return KhuzaitCount;
                yield return KhuzaitBaron;
                yield return KhuzaitLord;
                yield return KhuzaitPrince;
                yield return KhuzaitKnight;

                yield return SturgiaEmperor;
                yield return SturgiaKing;
                yield return SturgiaDuke;
                yield return SturgiaCount;
                yield return SturgiaBaron;
                yield return SturgiaLord;
                yield return SturgiaPrince;
                yield return SturgiaKnight;

                yield return VlandiaEmperor;
                yield return VlandiaKing;
                yield return VlandiaDuke;
                yield return VlandiaCount;
                yield return VlandiaBaron;
                yield return VlandiaLord;
                yield return VlandiaPrince;
                yield return VlandiaKnight;

                yield return EmpireEmperor;
                yield return EmpireKing;
                yield return EmpireDuke;
                yield return EmpireCount;
                yield return EmpireBaron;
                yield return EmpireLord;
                yield return EmpirePrince;
                yield return EmpireKnight;
            }
        }

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
            if (BKTOSettings.Instance.LatinTitles)
            {
                EmpireEmperor = CulturalTitleName.CreateEmpire("EmpireEmperor",
                  empire,
                  new TextObject("{=uTLJjN8A}Imperator"),
                  new TextObject("{=b3dURwfW}Imperatrix"),
                  new TextObject("{=dSSX7xRm}Imperium"));

                EmpireKing = CulturalTitleName.CreateKingdom("EmpireKing",
                   empire,
                   new TextObject("{=V6HVF70v}Rex"),
                   new TextObject("{=BJvarzpV}Regina"),
                   new TextObject("{=7x3HJ29f}Kingdom"));

                EmpireDuke = CulturalTitleName.CreateDuchy("EmpireDuke",
                    empire,
                    new TextObject("{=8e3aXr1R}Dux"),
                    new TextObject("{=5aCrjmFi}Ducissa"),
                    new TextObject("{=HtWGKBDF}Dukedom"));

                EmpireCount = CulturalTitleName.CreateCounty("EmpireCount",
                    empire,
                    new TextObject("{=AW1t8MxQ}Conte"),
                    new TextObject("{=ex7NjOtr}Cometessa"),
                    new TextObject("{=c6ggHVzS}County"));

                EmpireBaron = CulturalTitleName.CreateBarony("EmpireBaron",
                    empire,
                    new TextObject("{=uzYP2iMU}Baro"),
                    new TextObject("{=dYq0qGzZ}Baronessa"),
                    new TextObject("{=qOLmvS0B}Barony"));

                EmpireLord = CulturalTitleName.CreateLordship("EmpireLord",
                    empire,
                    new TextObject("{=HGfR1YAx}Dominus"),
                    new TextObject("{=go9MmDKr}Domina"),
                    new TextObject("{=dwMA32rq}Lordship"));
            }
            else
            {
                EmpireEmperor = CulturalTitleName.CreateEmpire("EmpireEmperor",
                   empire,
                   new TextObject("{=!}Basileús"),
                   new TextObject("{=!}Basíleia"),
                   new TextObject("{=!}Basileía"));

                EmpireKing = CulturalTitleName.CreateKingdom("EmpireKing",
                   empire,
                   new TextObject("{=!}Exarkhos"),
                   new TextObject("{=!}Exarkhousa"),
                   new TextObject("{=!}Exarkhontate"));

                EmpireDuke = CulturalTitleName.CreateDuchy("EmpireDuke",
                    empire,
                    new TextObject("{=!}Doux"),
                    new TextObject("{=!}Doucissa"),
                    new TextObject("{=!}Théma"));

                EmpireCount = CulturalTitleName.CreateCounty("EmpireCount",
                    empire,
                    new TextObject("{=!}Árkhon"),
                    new TextObject("{=!}Árkhousa"),
                    new TextObject("{=!}Árkhontate"));

                EmpireBaron = CulturalTitleName.CreateBarony("EmpireBaron",
                    empire,
                    new TextObject("{=!}Kephalé"),
                    new TextObject("{=!}Kephalé"),
                    new TextObject("{=!}Katepaníkion"));

                EmpireLord = CulturalTitleName.CreateLordship("EmpireLord",
                    empire,
                    new TextObject("{=HGfR1YAx}Dominus"),
                    new TextObject("{=go9MmDKr}Domina"),
                    new TextObject("{=dwMA32rq}Lordship"));
            }

            EmpirePrince = CulturalTitleName.CreatePrince("EmpirePrince",
                    empire,
                    new TextObject("{=ouHkQtyZ}Princeps"),
                    new TextObject("{=gNVEqLz4}Principissa"),
                    new TextObject("{=!}Princes"));

            EmpireKnight = CulturalTitleName.CreateKnight("EmpireKnight",
                empire,
                new TextObject("{=oapL1nXd}Pronoiarius"),
                new TextObject("{=oapL1nXd}Pronoiarius"),
                new TextObject("{=VLB8LyH0}Pronoiarii"));

            #endregion Empire

            #region Battania
            BattaniaEmperor = CulturalTitleName.CreateEmpire("BattaniaEmperor",
                battania,
                new TextObject("{=!}Pendreic"),
                new TextObject("{=!}Pendreic"),
                new TextObject("{=!}Pendragonate"));

            BattaniaKing = CulturalTitleName.CreateKingdom("BattaniaKing",
                battania,
                new TextObject("{=Mn61rKcx}Ard-Righ"),
                new TextObject("{=25sz3WPn}Ard-Banrigh"),
                new TextObject("{=!}Ard-Rioghachd"));

            BattaniaDuke = CulturalTitleName.CreateDuchy("BattaniaDuke",
                battania,
                new TextObject("{=VU1Lsphi}Righ"),
                new TextObject("{=XLAgsQ0J}Banrigh"),
                new TextObject("{=!}Rioghachd"));

            BattaniaCount = CulturalTitleName.CreateCounty("BattaniaCount",
                battania,
                new TextObject("{=yUowh1Mz}Mormaer"),
                new TextObject("{=FMWNKESs}Bantiarna"),
                new TextObject("{=!}Mormaerdom"));

            BattaniaBaron = CulturalTitleName.CreateBarony("BattaniaBaron",
                battania,
                new TextObject("{=hpbLyVY2}Toisiche"),
                new TextObject("{=811sxLhn}Thaoiseach"),
                new TextObject("{=!}Toiseachadh"));

            BattaniaLord = CulturalTitleName.CreateLordship("BattaniaLord",
                battania,
                new TextObject("{=0ymhCPeh}Tighearna"),
                new TextObject("{=tD38koMS}Baintighearna"),
                new TextObject("{=!}Túath"));

            BattaniaPrince = CulturalTitleName.CreatePrince("BattaniaPrince",
                battania,
                new TextObject("{=7z7iEwxU}Prionnsa"),
                new TextObject("{=RYoxePAG}Bana-Phrionnsa"),
                new TextObject("{=!}Prionnsachan"));

            BattaniaKnight = CulturalTitleName.CreateKnight("BattaniaKnight",
                battania,
                new TextObject("{=V7fYyS93}Fiann"),
                new TextObject("{=V7fYyS93}Fiann"),
                new TextObject("{=4b5WsUZ7}Fianna"));

            #endregion Battania

            #region Sturgia
            SturgiaEmperor = CulturalTitleName.CreateEmpire("SturgiaEmperor",
                sturgia,
                new TextObject("{=!}"),
                new TextObject("{=!}"),
                new TextObject("{=!}"));

            SturgiaKing = CulturalTitleName.CreateKingdom("SturgiaKing",
                sturgia,
                new TextObject("{=sFnMQqdQ}Velikiy Knyaz"),
                new TextObject("{=LmHWN0vt}Velikaya Knyaginya"),
                new TextObject("{=jz2SCLZS}Grand-Principality"));

            SturgiaDuke = CulturalTitleName.CreateDuchy("SturgiaDuke",
                sturgia,
                new TextObject("{=1XDPfDim}Knyaz"),
                new TextObject("{=S3kc2bhW}Knyaginya"),
                new TextObject("{=5rmKW4c9}Principality"));

            SturgiaCount = CulturalTitleName.CreateCounty("SturgiaCount",
                sturgia,
                new TextObject("{=ShdRMhVL}Boyar"),
                new TextObject("{=KTxFYNyo}Boyarina"), 
                new TextObject("{=GHeUbN6f}Boyardom"));

            SturgiaBaron = CulturalTitleName.CreateBarony("SturgiaBaron",
                sturgia,
                new TextObject("{=DanL6SW3}Voivode"),
                new TextObject("{=bYQLoRUt}Voivodina"),
                new TextObject("{=eUi8JOkv}Voivodeship"));

            SturgiaLord = CulturalTitleName.CreateLordship("SturgiaLord",
                sturgia,
                new TextObject("{=wc51byvw}Gospodin"),
                new TextObject("{=Ec79HNiF}Gospoda"),
                new TextObject("{=wc51byvw}Gospodin"));

            SturgiaPrince = CulturalTitleName.CreatePrince("SturgiaPrince",
                sturgia,
                new TextObject("{=1XDPfDim}Knyaz"),
                new TextObject("{=S3kc2bhW}Knyaginya"),
                new TextObject("{=!}Princes"));

            SturgiaKnight = CulturalTitleName.CreateKnight("SturgiaKnight",
                sturgia,
                new TextObject("{=Qucsad67}Druzhinnik"),
                new TextObject("{=HEAw5x03}Druzhinnica"),
                new TextObject("{=TOWzCa0Y}Druzhina"));

            #endregion Sturgia

            #region Vlandia
            VlandiaEmperor = CulturalTitleName.CreateEmpire("VlandiaEmperor",
                vlandia,
                new TextObject("{=!}Bretwalda"),
                new TextObject("{=!}Bretwalda"),
                new TextObject("{=!}Empire"));

            VlandiaKing = CulturalTitleName.CreateKingdom("VlandiaKing",
                vlandia,
                new TextObject("{=!}Kyning"),
                new TextObject("{=!}Kyninge"),
                new TextObject("{=!}Kyningdóm"));

            VlandiaDuke = CulturalTitleName.CreateDuchy("VlandiaDuke",
                vlandia,
                new TextObject("{=!}Ealdorman"),
                new TextObject("{=!}Hlaefdige"),
                new TextObject("{=!}Earldóm"));

            VlandiaCount = CulturalTitleName.CreateCounty("VlandiaCount",
                vlandia,
                new TextObject("{=!}Horgrefe"),
                new TextObject("{=!}Hlaefdige"),
                new TextObject("{=!}Hold"));

            VlandiaBaron = CulturalTitleName.CreateBarony("VlandiaBaron",
                vlandia,
                new TextObject("{=!}Thegn"),
                new TextObject("{=!}Hlaefdige"),
                new TextObject("{=!}Thanate"));

            VlandiaLord = CulturalTitleName.CreateLordship("VlandiaLord",
                vlandia,
                new TextObject("{=!}Hlaford"),
                new TextObject("{=!}Hlaefdige"),
                new TextObject("{=!}Hlafordship"));

            VlandiaPrince = CulturalTitleName.CreatePrince("VlandiaPrince",
                vlandia,
                new TextObject("{=!}Aetheling"),
                new TextObject("{=!}Aethelinge"),
                new TextObject("{=!}Aethelingas"));

            VlandiaKnight = CulturalTitleName.CreateKnight("VlandiaKnight",
                vlandia,
                new TextObject("{=!}Cniht"),
                new TextObject("{=!}Cniht"),
                new TextObject("{=!}Cneohtas"));

            #endregion Vlandia

            #region Khuzait
            KhuzaitEmperor = CulturalTitleName.CreateEmpire("KhuzaitEmperor",
                khuzait,
                new TextObject("{=2MOuvAj0}Khagan"),
                new TextObject("{=SdJk1Vpf}Khatun"),
                new TextObject("{=!}Khaganate"));

            KhuzaitKing = CulturalTitleName.CreateKingdom("KhuzaitKing",
                khuzait,
                new TextObject("{=ciWnpkW0}Khan"),
                new TextObject("{=cepkCz19}Khanum"),
                new TextObject("{=!}Khanate"));

            KhuzaitDuke = CulturalTitleName.CreateDuchy("KhuzaitDuke",
                khuzait,
                new TextObject("{=!}Beyzade"),
                new TextObject("{=!}Begumzade"),
                new TextObject("{=!}Beyzadelik"));

            KhuzaitCount = CulturalTitleName.CreateCounty("KhuzaitCount",
                khuzait,
                new TextObject("{=!}Atabey"),
                new TextObject("{=!}Atabegum"),
                new TextObject("{=!}Atabeylik"));

            KhuzaitBaron = CulturalTitleName.CreateBarony("KhuzaitBaron",
                khuzait,
                new TextObject("{=uwuM708D}Bey"),
                new TextObject("{=Ajj9ptAU}Begum"),
                new TextObject("{=!}Beylik"));

            KhuzaitLord = CulturalTitleName.CreateLordship("KhuzaitLord",
                khuzait,
                new TextObject("{=YMr5KkWu}Erxem"),
                new TextObject("{=dB9Rfp6W}Khatagtai"),
                new TextObject("{=!}Erxemlik"));

            KhuzaitPrince = CulturalTitleName.CreatePrince("KhuzaitPrince",
                khuzait,
                new TextObject("{=!}Khan Khuu"),
                new TextObject("{=!}Gonji"),
                new TextObject("{=!}Princes"));

            KhuzaitKnight = CulturalTitleName.CreateKnight("KhuzaitKnight",
                khuzait,
                new TextObject("{=!}Kheshig"),
                new TextObject("{=!}Kheshig"),
                new TextObject("{=RYd2Z1OU}Kheshignud"));

            #endregion Khuzait

            #region Aserai
            AseraiEmperor = CulturalTitleName.CreateEmpire("AseraiEmperor",
                aserai,
                new TextObject("{=!}Khalifa"),
                new TextObject("{=!}Khalifa"),
                new TextObject("{=!}Khilaafat"));

            AseraiKing = CulturalTitleName.CreateKingdom("AseraiKing",
                aserai,
                new TextObject("{=U0MEYHty}Sultan"),
                new TextObject("{=DQXH6NeY}Sultana"),
                new TextObject("{=DQXH6NeY}Sultanate"));

            AseraiDuke = CulturalTitleName.CreateDuchy("AseraiDuke",
                aserai,
                new TextObject("{=9dUqWF9A}Emir"),
                new TextObject("{=MVjsWtcZ}Emira"),
                new TextObject("{=MVjsWtcZ}Emirate"));

            AseraiCount = CulturalTitleName.CreateCounty("AseraiCount",
                aserai,
                new TextObject("{=b2fGz9XO}Sheikh"),
                new TextObject("{=AUoParHT}Shaykah"),
                new TextObject("{=V4ra7Por}Sheikhdom"));

            AseraiBaron = CulturalTitleName.CreateBarony("AseraiBaron",
                aserai,
                new TextObject("{=shJ1hjYg}Wali"),
                new TextObject("{=LYY1ZegU}Walia"),
                new TextObject("{=qOLmvS0B}Barony"));

            AseraiLord = CulturalTitleName.CreateLordship("AseraiLord",
                aserai,
                new TextObject("{=YNNXm6GE}Mawlaa"),
                new TextObject("{=VGXsX6Ue}Beghum"),
                new TextObject("{=dwMA32rq}Lordship"));

            AseraiPrince = CulturalTitleName.CreatePrince("AseraiPrince",
                aserai,
                new TextObject("{=!}Shahzade"),
                new TextObject("{=!}Shahzade"),
                new TextObject("{=!}Shahzade"));

            AseraiKnight = CulturalTitleName.CreateKnight("AseraiKnight",
                aserai,
                new TextObject("{=GmHEzRcz}Faaris"),
                new TextObject("{=GmHEzRcz}Faaris"),
                new TextObject("{=kgPoTnBi}Fursaan"));

            #endregion Aserai

            foreach (CulturalTitleName name in All)
            {
                DefaultTitleNames.Instance.AddObject(name);
            }

            /*
             * LaconiaDuke = Polemarchos
             */
        }
    }
}
