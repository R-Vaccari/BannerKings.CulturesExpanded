using HarmonyLib;
using System.Collections.Generic;
using TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using System.Linq;
using TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator;

namespace BannerKings.CulturesExpanded.Patches
{
    internal class CharacterCreationPatches
    {
        [HarmonyPatch(typeof(FaceGenVM))]
        public class BKCEDressedPatch
        {
            [HarmonyPrefix]
            [HarmonyPatch("RefreshValues")]
            static void Refresh(FaceGenVM __instance)
            {
                __instance.IsDressed = false;
                __instance.ExecuteChangeClothing();
            }
        }

        [HarmonyPatch(typeof(CharacterCreationCultureStageVM), "InitializePlayersFaceKeyAccordingToCultureSelection")]
        public class BKCECultureFaceKeyPatch
        {
            static void Postfix(CharacterCreationCultureVM selectedCulture)
            {
                Dictionary<CultureObject, string> dic = new Dictionary<CultureObject, string>(15);
                var cultures = TaleWorlds.CampaignSystem.Campaign.Current.ObjectManager.GetObjectTypeList<CultureObject>();
                dic.Add(cultures.First(x => x.StringId == BannerKingsConfig.EmpireCulture),
                    "<BodyProperties version='4' age='25.84' weight='0.5000' build='0.5000'  key='001CB80CC000300D7C7664876753888A7577866254C69643C4B647398C95A0370077760307A7497300000000000000000000000000000000000000003AF47002'/>");
                dic.Add(cultures.First(x => x.StringId == BannerKingsConfig.VlandiaCulture),
                    "<BodyProperties version='4' age='25.84' weight='0.5000' build='0.5000'  key='000BAC088000100DB976648E6774B835537D86629511323BDCB177278A84F667017776140748B49500000000000000000000000000000000000000003EFC5002'/>");
                dic.Add(cultures.First(x => x.StringId == BannerKingsConfig.SturgiaCulture),
                    "<BodyProperties version='4' age='25.84' weight='0.5000' build='0.5000'  key='000500000000000D797664884754DCBAA35E866295A0967774414A498C8336860F7776F20BA7B7A500000000000000000000000000000000000000003CFC2002'/>");
                dic.Add(cultures.First(x => x.StringId == BannerKingsConfig.AseraiCulture),
                    "<BodyProperties version='4' age='25.84' weight='0.5000' build='0.5000'  key='0028C80FC000100DBA756445533377873CD1833B3101B44A21C3C5347CA32C260F7776F20BBC35E8000000000000000000000000000000000000000042F41002'/>");
                dic.Add(cultures.First(x => x.StringId == BannerKingsConfig.KhuzaitCulture),
                    "<BodyProperties version='4' age='25.84' weight='0.5000' build='0.5000'   key='0016F80E4000200EB8708BD6CDC85229D3698B3ABDFE344CD22D3DD5388988680F7776F20B96723B00000000000000000000000000000000000000003EF41002'/>");
                dic.Add(cultures.First(x => x.StringId == BannerKingsConfig.BattaniaCulture),
                    "<BodyProperties version='4' age='25.84' weight='0.5000' build='0.5000'  key='000000058000200D79766434475CDCBAC34E866255A096777441DA49838BF6A50F7776F20BA7B7A500000000000000000000000000000000000000003CFC0002'/>");

                dic.Add(cultures.First(x => x.StringId == "balion"),
                    "<BodyProperties version='4' age='22.12' weight='0.5' build='0.5'  key='000A600800003004BA478A1C6585B8B57AAB788C8578874555B29832874A693C00777603072DA68200000000000000000000000000000000000000003EFC1042'  />");
                dic.Add(cultures.First(x => x.StringId == "bragantia"),
                    "<BodyProperties version='4' age='22.12' weight='0.5' build='0.5'  key='000A600800003004BA478A1C6585B8B57AAB788C8578874555B29832874A693C00777603072DA68200000000000000000000000000000000000000003EFC1042'  />");
                dic.Add(cultures.First(x => x.StringId == "kannic"),
                    "<BodyProperties version='4' age='22.12' weight='0.5' build='0.5'  key='001EA80D8000100EA856B79A98C4983BA5638966589AAD689A67426959A88A170077760307776A67000000000000000000000000000000000000000042F41042'  />");
                dic.Add(cultures.First(x => x.StringId == "darshi"),
                    "<BodyProperties version='4' age='22.12' weight='0.5' build='0.5'  key='001EA80D8000100EA856B79A98C4983BA5638966589AAD689A67426959A88A170077760307776A67000000000000000000000000000000000000000042F41042'  />");
                dic.Add(cultures.First(x => x.StringId == "siri"),
                    "<BodyProperties version='4' age='22.12' weight='0.5687' build='0.5002'  key='003FAC0D89442015595A8C617878A755AB95AAD646B873687867A37A89678EB700A896030A6B99750000000000000000000000000000000000000000435C6042'  />");
                dic.Add(cultures.First(x => x.StringId == "nord"),
                    "<BodyProperties version='4' age='22.12' weight='0.5' build='0.5'  key='00021000000026095398A8A97A178A69A35E87D7D2BB5C978589597B8C83368600A776030A57791A00000000000000000000000000000000000000003D5C5042'  />");
                dic.Add(cultures.First(x => x.StringId == "geroia"),
                    "<BodyProperties version='4' age='22.12' weight='0.5' build='0.5'  key='001B880A4000310D37A64683926771397AA826B85238B8A5C9B65A415AA5694300777603073D56A800000000000000000000000000000000000000003AF410C2'  />");
                dic.Add(cultures.First(x => x.StringId == "massa"),
                    "<BodyProperties version='4' age='22.12' weight='0.5' build='0.5'  key='000A600800003004BA478A1C6585B8B57AAB788C8578874555B29832874A693C00777603072DA68200000000000000000000000000000000000000003EFC1042'  />");
                dic.Add(cultures.First(x => x.StringId == "vakken"),
                    "<BodyProperties version='4' age='22.12' weight='0.5321' build='0.4756'  key='00009C02804426085F77E82344D468A6899589ED89C739E1C856A67498454872009786030965D3770000000000000000000000000000000000000000473C90C2'  />");


                BodyProperties properties;
                if (BodyProperties.FromString(dic[selectedCulture.Culture], out properties))
                {
                    CharacterObject.PlayerCharacter.UpdatePlayerCharacterBodyProperties(properties, CharacterObject.PlayerCharacter.Race,
                        CharacterObject.PlayerCharacter.IsFemale);
                }
            }
        }
    }
}
