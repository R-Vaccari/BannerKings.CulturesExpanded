using System.Collections.Generic;
using TaleWorlds.CampaignSystem.CharacterDevelopment;
using TaleWorlds.Core;

namespace BannerKings.CulturesExpanded.Cultures
{
    public class BKCEFeats : DefaultTypeInitializer<BKCEFeats, FeatObject>
    {
        public FeatObject SailingSpeed { get; set; }
        public FeatObject SailingBattle { get; set; }
        public FeatObject Unscholarly { get; set; }
        public FeatObject VillageMilitia { get; set; }
        public FeatObject Vakken1 { get; set; }
        public FeatObject SouthernAgriculture { get; set; }
        public FeatObject Siri1 { get; set; }

        public override IEnumerable<FeatObject> All => throw new System.NotImplementedException();

        public override void Initialize()
        {
            SailingSpeed = Game.Current.ObjectManager.RegisterPresumedObject(new FeatObject("BKCE_sailing_speed"));
            SailingSpeed.Initialize("BKCE_sailing_speed",
                "{=!}Naval Tradition: parties are 15% faster while sailing.",
                0.15f,
                true,
            FeatObject.AdditionType.Add);

            SailingBattle = Game.Current.ObjectManager.RegisterPresumedObject(new FeatObject("BKCE_sailing_battle"));
            SailingBattle.Initialize("BKCE_sailing_battle",
                "{=!}Naval Tradition: parties are 10% more effective in autoresolve battles while sailing.",
                0.1f,
                true,
                FeatObject.AdditionType.Add);

            Unscholarly = Game.Current.ObjectManager.RegisterPresumedObject(new FeatObject("BKCE_unscholarly"));
            Unscholarly.Initialize("BKCE_unscholarly",
                "{=!}Unscholarly Tradition:.",
                0.2f,
                true,
                FeatObject.AdditionType.Add);

            VillageMilitia = Game.Current.ObjectManager.RegisterPresumedObject(new FeatObject("BKCE_village_militia"));
            VillageMilitia.Initialize("BKCE_village_militia",
                "{=!}Village Militia Tradition:.",
                0.2f,
                true,
                FeatObject.AdditionType.Add);

            Vakken1 = Game.Current.ObjectManager.RegisterPresumedObject(new FeatObject("BKCE_vakken_production"));
            Vakken1.Initialize("BKCE_vakken_production",
                "{=!}Hunter Tradition: forester and trapper villages are 20% more productive.",
                0.2f,
                true,
                FeatObject.AdditionType.Add);

            SouthernAgriculture = Game.Current.ObjectManager.RegisterPresumedObject(new FeatObject("BKCE_south_production"));
            SouthernAgriculture.Initialize("BKCE_south_production",
                "{=!}Agriculture Tradition: 25% production bonus to grains, papyrus and dates.",
                0.2f,
                true,
                FeatObject.AdditionType.Add);

            Siri1 = Game.Current.ObjectManager.RegisterPresumedObject(new FeatObject("BKCE_siri_archers"));
            Siri1.Initialize("BKCE_siri_archers",
                "{=!}Bow Tradition: ranged units are 40% cheaper to recruit.",
                -0.4f,
                true,
                FeatObject.AdditionType.AddFactor);

            /*
            DefaultCulturalFeats.BattanianForestSpeedFeat.Initialize("{=!}battanian_forest_speed", 
                "{=!}Woodland Tradition: 50% less speed penalty and 15% sight range bonus in forests.", 
                0.5f, 
                true, 
                FeatObject.AdditionType.AddFactor);

            DefaultCulturalFeats.BattanianMilitiaFeat.Initialize("{=!}battanian_militia_production", 
                "{=!}Citizen Militia Tradition: towns have +1 militia production.", 
                1f, 
                true, 
                FeatObject.AdditionType.Add);

            DefaultCulturalFeats.VlandianCastleVillageProductionFeat.Initialize("{=!}vlandian_villages_production_bonus", 
                "{=!}Buhr Tradition: villages bound to castles (burhs) are 10% more productive.", 
                0.1f, 
                true, 
                FeatObject.AdditionType.AddFactor);

            DefaultCulturalFeats.VlandianRenownMercenaryFeat.Initialize("{=!}vlandian_renown_mercenary_income", 
                "{=!}Mercenary Tradition: 5% more renown from the battles, 15% more income while serving as a mercenary.", 
                0.05f, 
                true, 
                FeatObject.AdditionType.AddFactor);

            DefaultCulturalFeats.VlandianArmyInfluenceFeat.Initialize("{=!}vlandian_increased_army_influence_cost", 
                "{=!}Autonomous Lords: recruiting lords to armies costs 20% more influence.", 
                0.2f, 
                false, 
                FeatObject.AdditionType.AddFactor);

            DefaultCulturalFeats.SturgianArmyCohesionFeat.Initialize("{=!}sturgian_decreased_cohesion_rate", 
                "{=!}Cohesive Leadership: armies lose 20% less daily cohesion.", 
                -0.2f,
                true, 
                FeatObject.AdditionType.AddFactor);*/
        }
    }
}
