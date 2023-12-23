using TaleWorlds.CampaignSystem.CharacterCreationContent;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.Localization;

namespace BannerKings.CulturesExpanded.CC
{
    internal class BKCECreationContent : SandboxCharacterCreationContent
    {
        protected override void OnInitialized(CharacterCreation characterCreation)
        {
            AddParentsMenu(characterCreation);
            AddChildhoodMenu(characterCreation);
            AddEducationMenu(characterCreation);
            AddYouthMenu(characterCreation);
            AddAdulthoodMenu(characterCreation);
            AddAgeSelectionMenu(characterCreation);

            _startingPoints.Add("siri", new Vec2(385.5405f, 53.993f));
            _startingPoints.Add("darshi", new Vec2(764.147f, 147.43f));
            _startingPoints.Add("geroia", new Vec2(478.6044f, 217.9456f));
            _startingPoints.Add("nord", new Vec2(172.637f, 589.918f));
            _startingPoints.Add("massa", new Vec2(193.524f, 185.269f));
            _startingPoints.Add("vakken", new Vec2(640.26f, 625.285f));
        }

        protected new void AddParentsMenu(CharacterCreation characterCreation) 
        {
            base.AddParentsMenu(characterCreation);
            CharacterCreationMenu menu = characterCreation.GetCurrentMenu(0);
            CharacterCreationCategory massaCategory = menu
                .AddMenuCategory(new CharacterCreationOnCondition(MassaCondition));

            MBList<SkillObject> effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.Riding,
                DefaultSkills.Polearm
            };
            CharacterAttribute effectedAttribute = DefaultCharacterAttributes.Vigor;
            massaCategory.AddCategoryOption(new TextObject("{=!}Migration Farmers", null),
                effectedSkills, 
                effectedAttribute, 
                FocusToAdd, 
                SkillLevelToAdd, 
                AttributeLevelToAdd, 
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation, 
                1, 
                SandboxCharacterCreationContent.OccupationTypes.Retainer, 
                "", 
                "", 
                true,
                true), 
                (CharacterCreation characterCreation) => FinalizeParents(), 
                new TextObject("{=ivKl4mV2}Your father was a trusted lieutenant of the local landowning aristocrat. He rode with the lord's cavalry, fighting as an armored lancer.", null), 
                null, 
                0, 
                0, 
                0, 
                0, 
                0);
            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.Trade,
                DefaultSkills.Charm
            };
        }

        protected bool MassaCondition() => GetSelectedCulture().StringId == "massa";

        protected new bool VlandianParentsOnCondition() => base.GetSelectedCulture().StringId == "vlandia" || base.GetSelectedCulture().StringId == "massa";
        protected new bool SturgianParentsOnCondition() => base.GetSelectedCulture().StringId == "nord" || base.GetSelectedCulture().StringId == "sturgia" || base.GetSelectedCulture().StringId == "vakken";
        protected new bool EmpireParentsOnCondition() => base.GetSelectedCulture().StringId == "empire" || base.GetSelectedCulture().StringId == "geroia";
        protected new bool AseraiParentsOnCondition() => base.GetSelectedCulture().StringId == "aserai" || base.GetSelectedCulture().StringId == "siri" ||  base.GetSelectedCulture().StringId == "darshi";
    }
}
