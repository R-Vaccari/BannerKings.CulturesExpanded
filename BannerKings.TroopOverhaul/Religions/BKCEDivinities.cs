using BannerKings.Managers.Institutions.Religions;
using System.Collections.Generic;
using System.Linq;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Localization;

namespace BannerKings.CulturesExpanded.Religions
{
    public class BKCEDivinities : DefaultTypeInitializer<BKCEDivinities, Divinity>
    {
        public Divinity ImmortalFlame { get; } = new Divinity("ImmortalFlame");
        public Divinity Ahhak { get; } = new Divinity("Ahhak");
        public Divinity Calradios { get; } = new Divinity("Claradios");
        public Divinity Ireos { get; } = new Divinity("Ireos");
        public Divinity Sarapios { get; } = new Divinity("Sarapios");
        public Divinity Carsos { get; } = new Divinity("Carsos");
        public Divinity Erithrians { get; } = new Divinity("Erithrians");

        public override IEnumerable<Divinity> All
        {
            get
            {
                yield return Calradios;
            }
        }

        public override void Initialize()
        {
            //ImmortalFlame.
            Calradios.Initialize(new TextObject("{=!}Augoustos Calradios"),
                new TextObject("{=!}A millenia ago, it is said, Calradios arrived on this land. He and his exiles sailed north, from another continent, until they arrived on the vicinities of Charas, where the first colony was stablished, Charasea. Over the following centuries, the Calradoi expanded over the continent, subjugating the native peoples, mainly Palaic and Battanian tribes. Imperial dynasties and claimants have ever since claimed descendancy to Calradios - descendant of Ireos, son of Sky-Father Iovis -, and thus, to the Gods themselves. True or not, Calradios has long since been annointed by the people as their founder, and by the state as Divus and Augoustos, meaning 'the Great one'."),
                new TextObject("{=!}Greatly increased influence gain and Legitimacy"),
                new TextObject("{=!}Augoustos Divi Filius"),
                200,
                new TextObject(),
                new TextObject(),
                Settlement.All.First(x => x.StringId == "town_V7"));

            Erithrians.Initialize(new TextObject("{=!}Erithryans"),
                new TextObject("{=!}The Erithryans, called so as they reside on mount Erithrys, are the founding gods of the Calradoi theology. They are a pantheon of man-like, yet immortal gods, who represent many aspects of man: Iovis, the Sky-Father with his immense wisdom and judgement, Astaronia, the mother of mothers, Ireos, the protector of the nation, among other gods and godesses. They have long ago moved to Calradia, to watch over their nation, choosing mount Erithys for its central position, blessing the surroinding vales and forests with plentiful harvest and ripe game. Some, such as Augoustos Calradios, are said to be descendants of the gods themselves."),
                new TextObject("{=!}Increased cultural and religious presence in settlements\nIncreased Empire settlement loyalty and prosperity"),
                new TextObject("{=!}Gods"),
                300,
                new TextObject(),
                new TextObject(),
                Settlement.All.First(x => x.StringId == "town_EW6"));

            Sarapios.Initialize(new TextObject("{=!}Sarapios Invictus"),
               new TextObject("{=!}Annointed Divus through the influence of his legionaires, Sarapios was an exceptional imperial commander. He is attributed the conquest of Rhotae and partially the conquest of Lageta. The city of Epicrotea was built on his honor. Being undefeated throughout his campaign, he was granted the title Invictus - undefeated -, one of the highest honors generals may achieve. Already during his lifetime, a cult around him was formed, proclaiming him a descendant of Ireos, the god of war, much like Calradios. Though Calradios is still granted much honor in this cult, Sarapios is seen as a modern Calradios, a new messenger for the gods, a message written in conquest and assimilation."),
               new TextObject("{=!}Signicantly increased cultural presence and acceptance gain"),
               new TextObject("{=!}Divus"),
               200,
               new TextObject("{=!}"),
               new TextObject("{=!}"));

            Ireos.Initialize(new TextObject("{=!}Ireos"),
                new TextObject("{=!}The spear-wielding son of Iovis, the Sky-Father. Ireos is worshipped as the protector of the Calradoi, the herald of war. Tradition says the earth trembles, ever so slightly, and the trees seem to vibrate around mount Erithrys, the seat of the Gods, once war is come. That is the time Ireos bashes his spear against his shields, as is the traditions of the legions of old, with each bash echoing in the very earth."),
                new TextObject("{=!}Greatly improved party morale from Empire troops\nIncreased Empire fiefs militarism"),
                new TextObject("{=!}God of War"),
                300,
                new TextObject(),
                new TextObject());

            foreach (var divinity in All)
            {
                DefaultDivinities.Instance.AddObject(divinity);
            }
        }
    }
}
