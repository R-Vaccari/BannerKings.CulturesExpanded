using BannerKings.Behaviors.Invasions;
using System.Collections.Generic;
using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Localization;

namespace BannerKings.CulturesExpanded.Behaviors.Invasions
{
    public class BKCEInvasions : DefaultTypeInitializer<BKCEInvasions, Invasion>
    {
        public Invasion Darshi { get; } = new Invasion("Darshi");
        public override IEnumerable<Invasion> All
        {
            get
            {
                yield return Darshi;
            }
        }

        public override void Initialize()
        {
            //western empire banner 11.6.40.1836.1836.768.774.1.0.0.106.143.149.610.617.764.762.1.1.0.529.149.149.52.53.727.907.1.0.0.511.116.116.35.35.687.914.1.0.-91.511.116.116.35.35.687.900.1.1.90.527.116.116.50.50.778.906.1.1.0.527.116.116.50.50.774.906.1.0.0.510.116.116.32.28.797.919.1.0.90.527.116.116.50.50.834.908.1.0.0
            CultureObject darshi = Utils.Helpers.GetCulture("darshi");
            Clan darshiRuler = new Clan();
            darshiRuler.InitializeClan(new TextObject(),
                new TextObject(),
                darshi,
                new TaleWorlds.Core.Banner());
            darshiRuler.StringId = "bk_clan_darshi_1";

            Kingdom darshiKingdom = new Kingdom();
            darshiKingdom.InitializeKingdom(new TextObject(),
                new TextObject(),
                darshi,
                new TaleWorlds.Core.Banner(),
                0,
                0,
                Settlement.All.First(),
                new TextObject(),
                new TextObject(),
                new TextObject());

            /*Darshi.Initialize("bk_darshi_1_1",
                darshiRuler,
                Settlement.All.First(x => x.StringId == ""),
                ,
                new Dictionary<Clan, CharacterObject>()
                {

                });*/
        }
    }
}
