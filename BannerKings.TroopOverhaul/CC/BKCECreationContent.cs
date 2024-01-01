using BannerKings.Managers.Skills;
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
            _startingPoints.Add("darshi", new Vec2(765.1729f, 150.5149f));
            _startingPoints.Add("geroia", new Vec2(478.6044f, 217.9456f));
            _startingPoints.Add("nord", new Vec2(170.9158f, 587.5662f));
            _startingPoints.Add("massa", new Vec2(191.1839f, 181.5139f));
            _startingPoints.Add("vakken", new Vec2(642.2234f, 624.5721f));
            _startingPoints.Add("kannic", new Vec2(262.9534f, 263.2021f));
            _startingPoints.Add("balion", new Vec2(61.83505f, 334.9693f));
            _startingPoints.Add("bragantia", new Vec2(61.83505f, 334.9693f));
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
                DefaultSkills.OneHanded
            };
            CharacterAttribute effectedAttribute = DefaultCharacterAttributes.Vigor;
            massaCategory.AddCategoryOption(new TextObject("{=!}Gahlaiba", null),
                effectedSkills, 
                effectedAttribute, 
                FocusToAdd, 
                SkillLevelToAdd, 
                AttributeLevelToAdd, 
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation, 
                1, 
                OccupationTypes.Retainer, 
                "", 
                "", 
                true,
                true), 
                (CharacterCreation characterCreation) => FinalizeParents(), 
                new TextObject("{=!}Your father served as a Gahlaiba to one of the Massa chiefs, teaching you the basics of fencing and riding.", null), 
                null, 
                0, 
                0, 
                0, 
                0, 
                0);

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.Polearm,
                DefaultSkills.Athletics
            };
            effectedAttribute = DefaultCharacterAttributes.Endurance;
            massaCategory.AddCategoryOption(new TextObject("{=!}Migration Herders", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                2,
                OccupationTypes.Farmer,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your parents migrated south to Niuja Landa in the Great Migration, when the Massa forged their own realm.", null),
                null,
                0,
                0,
                0,
                0,
                0);

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.Throwing,
                DefaultSkills.Scouting
            };
            effectedAttribute = DefaultCharacterAttributes.Control;
            massaCategory.AddCategoryOption(new TextObject("{=!}Woodland Foresters", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                3,
                OccupationTypes.Farmer,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your father works as a forester and explorer, going deep into the woods. At times with the Widugauja, the woodspeople, at times against them. The woods are thick and filled with both beasts and disease...", null),
                null,
                0,
                0,
                0,
                0,
                0);


            CharacterCreationCategory darshiCategory = menu
               .AddMenuCategory(new CharacterCreationOnCondition(DarshiCondition));

            effectedSkills = new MBList<SkillObject>
            {
                BKSkills.Instance.Scholarship,
                BKSkills.Instance.Theology
            };
            effectedAttribute = BKAttributes.Instance.Wisdom;
            darshiCategory.AddCategoryOption(new TextObject("{=!}Herbad", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                1,
                OccupationTypes.Healer,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your father served as a Herbad to the Atashyasna - the faith of the Darshi. He taught you writting and literature, specially by means of the holy poetry of the Atash.", null),
                null,
                0,
                0,
                0,
                0,
                0);

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.Bow,
                DefaultSkills.Polearm
            };
            effectedAttribute = DefaultCharacterAttributes.Vigor;
            darshiCategory.AddCategoryOption(new TextObject("{=!}Aswar", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                2,
                OccupationTypes.Retainer,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your father served as one of the Aswaran, teaching your in both the way of the lance and bow.", null),
                null,
                0,
                0,
                0,
                0,
                0);

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.Athletics,
                DefaultSkills.Polearm
            };
            effectedAttribute = DefaultCharacterAttributes.Endurance;
            darshiCategory.AddCategoryOption(new TextObject("{=!}Date Farmers", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                3,
                OccupationTypes.Farmer,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your parents farmed the Teyagh riverbanks, ripe for grains and dates.", null),
                null,
                0,
                0,
                0,
                0,
                0);

            CharacterCreationCategory siriCategory = menu
              .AddMenuCategory(new CharacterCreationOnCondition(SiriCondition));

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.Medicine,
                BKSkills.Instance.Theology
            };
            effectedAttribute = BKAttributes.Instance.Wisdom;
            siriCategory.AddCategoryOption(new TextObject("{=!}Tillik-Itt", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                1,
                OccupationTypes.Healer,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your mother served as a Tillik-Itt - a wisewoman, responsible for upholding the faith of the Siri. She taught you herb medicine and religious practices.", null),
                null,
                0,
                0,
                0,
                0,
                0);

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.Athletics,
                DefaultSkills.Bow
            };
            effectedAttribute = DefaultCharacterAttributes.Control;
            siriCategory.AddCategoryOption(new TextObject("{=!}Kandi", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                2,
                OccupationTypes.Retainer,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your mother served as a Kandi - one of the expert woman archers of the Siri. They are known for their trueshot and ability to pursue their prey unrelentlessly.", null),
                null,
                0,
                0,
                0,
                0,
                0);

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.Athletics,
                DefaultSkills.Polearm
            };
            effectedAttribute = DefaultCharacterAttributes.Endurance;
            siriCategory.AddCategoryOption(new TextObject("{=!}Date Farmers", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                3,
                OccupationTypes.Farmer,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your parents the Aman riverbanks, ripe for grains, dates and papyrus.", null),
                null,
                0,
                0,
                0,
                0,
                0);

            CharacterCreationCategory geroiaCategory = menu
              .AddMenuCategory(new CharacterCreationOnCondition(GeroiaCondition));

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.OneHanded,
                DefaultSkills.Throwing
            };
            effectedAttribute = DefaultCharacterAttributes.Vigor;
            geroiaCategory.AddCategoryOption(new TextObject("{=!}Privateer", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                1,
                OccupationTypes.Retainer,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your father served as one of the Geroian privateers, renowned for their fencing skills and their firebombs, both deadly in battles on ship decks.", null),
                null,
                0,
                0,
                0,
                0,
                0);

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.Trade,
                DefaultSkills.Steward
            };
            effectedAttribute = DefaultCharacterAttributes.Social;
            geroiaCategory.AddCategoryOption(new TextObject("{=!}Sea Merchants", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                2,
                OccupationTypes.Merchant,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your father travelled around the Perassic and Jade seas making a living out of the rich sea trade. Your mother stayed on land, managing their assets.", null),
                null,
                0,
                0,
                0,
                0,
                0);

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.Roguery,
                DefaultSkills.Trade
            };
            effectedAttribute = DefaultCharacterAttributes.Cunning;
            geroiaCategory.AddCategoryOption(new TextObject("{=!}Slavers", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                2,
                OccupationTypes.Mercenary,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your father traded slaves across the seas, both 'legally' and otherwise.", null),
                null,
                0,
                0,
                0,
                0,
                0);

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.Athletics,
                DefaultSkills.Throwing
            };
            effectedAttribute = DefaultCharacterAttributes.Endurance;
            geroiaCategory.AddCategoryOption(new TextObject("{=!}Sheep Herders", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                3,
                OccupationTypes.Farmer,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your parents raised sheep in the rocky slops of the Geroian islands. Since young, you pursed sheep and scared predators away.", null),
                null,
                0,
                0,
                0,
                0,
                0);

            CharacterCreationCategory nordCategory = menu
              .AddMenuCategory(new CharacterCreationOnCondition(NordCondition));

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.Athletics,
                DefaultSkills.Polearm
            };
            effectedAttribute = DefaultCharacterAttributes.Endurance;
            nordCategory.AddCategoryOption(new TextObject("{=!}Settlers", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                1,
                OccupationTypes.Farmer,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your parents came from Jumne to settle in Calradia. They have lived their lives as agricultural workers by one of the Jumne colonies such as Tihr and Rovalt.", null),
                null,
                0,
                0,
                0,
                0,
                0);

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.Crafting,
                DefaultSkills.OneHanded
            };
            effectedAttribute = DefaultCharacterAttributes.Endurance;
            nordCategory.AddCategoryOption(new TextObject("{=!}Shipbilders", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                2,
                OccupationTypes.Farmer,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your father built longships, very demanded by the Jumne expeditioners. He taught you crafting and woodworking since a young age.", null),
                null,
                0,
                0,
                0,
                0,
                0);

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.Throwing,
                DefaultSkills.Trade
            };
            effectedAttribute = DefaultCharacterAttributes.Control;
            nordCategory.AddCategoryOption(new TextObject("{=!}Whalers", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                3,
                OccupationTypes.Farmer,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your father sailed the deep sea for whaling. Since a young age, he taught you both how to hunt the beasts with true javelin strikes, and how to bargain it for maximum profit.", null),
                null,
                0,
                0,
                0,
                0,
                0);

            CharacterCreationCategory vakkenCategory = menu
              .AddMenuCategory(new CharacterCreationOnCondition(VakkenCondition));

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.Throwing,
                DefaultSkills.OneHanded
            };
            effectedAttribute = DefaultCharacterAttributes.Vigor;
            vakkenCategory.AddCategoryOption(new TextObject("{=!}Seuralainen", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                1,
                OccupationTypes.Retainer,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your father served as one of the Seuralainen: companions to a Vakken chief. He taught in the art of sword and javelin, but unlike most Vakken youngs, your targets were to be human foes rather than beasts....", null),
                null,
                0,
                0,
                0,
                0,
                0);

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.Bow,
                DefaultSkills.Scouting
            };
            effectedAttribute = DefaultCharacterAttributes.Endurance;
            vakkenCategory.AddCategoryOption(new TextObject("{=!}Foresters", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                2,
                OccupationTypes.Hunter,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your parents were typical Vakken foresters: they hunted and skinned game, a long tradition of the Vakken tribes.", null),
                null,
                0,
                0,
                0,
                0,
                0);

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.Trade,
                DefaultSkills.Scouting
            };
            effectedAttribute = DefaultCharacterAttributes.Social;
            vakkenCategory.AddCategoryOption(new TextObject("{=!}Merchants", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                3,
                OccupationTypes.Merchant,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your parents were itinerary merchants: they went town to town, haggling prices. Most of all they traded northern furs and timber.", null),
                null,
                0,
                0,
                0,
                0,
                0);

            CharacterCreationCategory balionCategory = menu
              .AddMenuCategory(new CharacterCreationOnCondition(BalionCondition));

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.Athletics,
                DefaultSkills.TwoHanded
            };
            effectedAttribute = DefaultCharacterAttributes.Vigor;
            balionCategory.AddCategoryOption(new TextObject("{=!}Huscarl", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                1,
                OccupationTypes.Retainer,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your father served as one of the Huscarls, the companions of Balion aristocrats. He taught you athleticism and the way of long ax.", null),
                null,
                0,
                0,
                0,
                0,
                0);

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.Athletics,
                DefaultSkills.Polearm
            };
            effectedAttribute = DefaultCharacterAttributes.Endurance;
            balionCategory.AddCategoryOption(new TextObject("{=!}Tenants", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                2,
                OccupationTypes.Farmer,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your parents were typical Balion tenant farms. On your youth, you tended to the farm and farm animals, scaring off predators with your father's spear.", null),
                null,
                0,
                0,
                0,
                0,
                0);

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.Trade,
                DefaultSkills.OneHanded
            };
            effectedAttribute = DefaultCharacterAttributes.Social;
            balionCategory.AddCategoryOption(new TextObject("{=!}Merchants", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                3,
                OccupationTypes.Merchant,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your parents were sea traders. Their trips often took them between Balion and Calradia, bringing wine, silks and olives to your homeland. Due to Jumne raiders spread out across the trade routes, your father taught you how to defend yourself.", null),
                null,
                0,
                0,
                0,
                0,
                0);

            CharacterCreationCategory bragantiaCategory = menu
             .AddMenuCategory(new CharacterCreationOnCondition(BiscaniaCondition));

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.OneHanded,
                DefaultSkills.Throwing
            };
            effectedAttribute = DefaultCharacterAttributes.Vigor;
            bragantiaCategory.AddCategoryOption(new TextObject("{=!}Mesnadeiro", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                1,
                OccupationTypes.Retainer,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your father served as one of the Mesnadeiros, companions to the isle lords. He taught you in the way of fighting, specially ship deck fighting.", null),
                null,
                0,
                0,
                0,
                0,
                0);

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.Athletics,
                DefaultSkills.Polearm
            };
            effectedAttribute = DefaultCharacterAttributes.Endurance;
            bragantiaCategory.AddCategoryOption(new TextObject("{=!}Cattle Raisers", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                2,
                OccupationTypes.Farmer,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your parents were typical cattle raises of the Biscanian islands. The lush grassy hills and mild weather have long sustained this tradition.", null),
                null,
                0,
                0,
                0,
                0,
                0);

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.Trade,
                DefaultSkills.Crafting
            };
            effectedAttribute = DefaultCharacterAttributes.Social;
            bragantiaCategory.AddCategoryOption(new TextObject("{=!}Merchants", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                3,
                OccupationTypes.Merchant,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your parents were sea traders and artisans. They traded often at the port city of Bragantja, where trade routes from all directions converge.", null),
                null,
                0,
                0,
                0,
                0,
                0);

            CharacterCreationCategory kannicCategory = menu
             .AddMenuCategory(new CharacterCreationOnCondition(KannicCondition));

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.OneHanded,
                DefaultSkills.Polearm
            };
            effectedAttribute = DefaultCharacterAttributes.Vigor;
            kannicCategory.AddCategoryOption(new TextObject("{=!}Citizen Militia", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                1,
                OccupationTypes.Retainer,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your father was part of the citizen class, a high class within Kannic society. He served with the citizen militia as a hoplite, and taught you the basics of Kannic warfare.", null),
                null,
                0,
                0,
                0,
                0,
                0);

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.Crafting,
                DefaultSkills.Steward
            };
            effectedAttribute = DefaultCharacterAttributes.Intelligence;
            kannicCategory.AddCategoryOption(new TextObject("{=!}Urban Artisans", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                2,
                OccupationTypes.Artisan,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your parents were part of the lively manufacting economy within Lys. They taught you craftsmanship and how to take care of your assets.", null),
                null,
                0,
                0,
                0,
                0,
                0);

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.Trade,
                DefaultSkills.Athletics
            };
            effectedAttribute = DefaultCharacterAttributes.Social;
            kannicCategory.AddCategoryOption(new TextObject("{=!}Merchants", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                3,
                OccupationTypes.Merchant,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your parents were itinerary traders, travelling much of Calradia in search of profit. You accompanied them and learned how to endure the trips and make the best profit.", null),
                null,
                0,
                0,
                0,
                0,
                0);
        }

        protected bool MassaCondition() => GetSelectedCulture().StringId == "massa";
        protected bool DarshiCondition() => GetSelectedCulture().StringId == "darshi";
        protected bool SiriCondition() => GetSelectedCulture().StringId == "siri";
        protected bool GeroiaCondition() => GetSelectedCulture().StringId == "geroia";
        protected bool NordCondition() => GetSelectedCulture().StringId == "nord";
        protected bool VakkenCondition() => GetSelectedCulture().StringId == "vakken";
        protected bool BiscaniaCondition() => GetSelectedCulture().StringId == "bragantia";
        protected bool BalionCondition() => GetSelectedCulture().StringId == "balion";
        protected bool KannicCondition() => GetSelectedCulture().StringId == "kannic";
    }
}
