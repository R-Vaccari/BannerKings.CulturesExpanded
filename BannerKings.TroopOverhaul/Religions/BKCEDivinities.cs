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
        public Divinity Perkos { get; } = new Divinity("Perkos");
        public Divinity GreatLion { get; } = new Divinity("GreatLion");
        public Divinity VineGoddess { get; } = new Divinity("VineGoddess");
        public Divinity Jinn { get; } = new Divinity("Jinn");
        public Divinity Eshora { get; } = new Divinity("Eshora");

        public override IEnumerable<Divinity> All
        {
            get
            {
                yield return Calradios;
                yield return Erithrians;
                yield return Sarapios;
                yield return Ireos;
                yield return Perkos;
                yield return ImmortalFlame;
                yield return GreatLion;
                yield return Eshora;
                yield return VineGoddess;
                yield return Jinn;
            }
        }

        public override void Initialize()
        {
            VineGoddess.Initialize(new TextObject("{=!}Ailatyn"),
               new TextObject("{=!}The Kannic goddess of war, wine, trade and love. Her cult goes back as far as the first Kannic colony by the Jade sea, and is the core of Kannic beliefs and practices. The goddess represents what others might call a hedonistic imperative, for all the pleasures man can have are assocaited with them: that of food, drink, love and killing. This imperative is interpreted by the Kannic as a legitimization of their ambition."),
               new TextObject("{=!}Improved trade penalties\nIncreased party morale"),
               new TextObject("{=!}Vine Goddess"),
               200,
               new TextObject(),
               new TextObject());

            Eshora.Initialize(new TextObject("{=!}Eshora"),
               new TextObject("{=!}A legendary queen of the Kannic. Eshora is said to have cast magic on malign jinns, using them to irrigate Qasira and its surroundings. Her tale is strong within Kannic culture and belief, and being assocaited with her is a symbol of legitimacy and true right of rule."),
               new TextObject("{=!}Legitimacy for Kannic rulers\nIncreased Kannic fiefs prosperity"),
               new TextObject("{=!}Legendary Queen"),
               300,
               new TextObject(),
               new TextObject());

            Jinn.Initialize(new TextObject("{=!}Jinn"),
               new TextObject("{=!}Spirits of elusive nature, the jinn are part of the Kannic belief. They are said to hide away from humans, for the most part. Often, they take the shape of an animal, such as a cobra. Jinns can be both malign or benign. The Kannic seek the wisdom of benign jinns, and ward away the malign with magic. Benign jinns are said to be wise is the ways of medicine and healing."),
               new TextObject("{=!}Improved party health recovery\nIncreased Kannic village hearth growth"),
               new TextObject("{=!}Spirits"),
               300,
               new TextObject(),
               new TextObject());

            GreatLion.Initialize(new TextObject("{=!}Laha Mouei"),
               new TextObject("{=!}The Great Lion god of the Siri people. Among many things, Laha Mouei symbolizes the epitome of power in the very core of the Nahasa, as well as symbols for fertility and regality, portrayed by his unmatched lion mane. As conqueror, the Siri pray for his blessing when declaring a war, which the Siri seldom provoke, but would not relent to take arms to defend themselves. As patriarch, the fertility of land is also associated with his seed, and the holy water of the Aman (known to the Nahawasi as Darmar) which provides bountiful harvest. Lastly, as a regal symbol, to be associated with Laha Mouei is a symbol of divine investiture, and thus the queens of the Siri traditionally pay him a ceremony on their ascension."),
               new TextObject("{=!}Legitimacy for Siri rulers\nIncreased military influence rewards"),
               new TextObject("{=!}Lion-God"),
               200,
               new TextObject(),
               new TextObject(),
               Settlement.All.First(x => x.StringId == "town_A9"));

            ImmortalFlame.Initialize(new TextObject("{=!}Atash Amesha"),
               new TextObject("{=!}The divine force of creation, the Immortal Flame is the fire of creation of the world. Like the flames of a forge, the world was forged by this force, according to the Darshi. A long Darshi literary tradition of poets and treatises describe many allegories around the Flame, the world and t he founding of the Darshianshahr. These texts are the basis of the Darshi theology, which revolves around the Atash. According to them, not unlike how the world was created, one day the Flame will cleanse the world, and a flood of molten metal will cleanse the earth."),
               new TextObject("{=!}Increased stability for Darshi fiefs{newline}Increased legitimacy for Darshi rulers"),
               new TextObject("{=!}Divine Force"),
               200,
               new TextObject(),
               new TextObject(),
               Settlement.All.First(x => x.StringId == "town_Darshi_1"));

            Perkos.Initialize(new TextObject("{=qBT3wpBX}Pérkos, Thunder Wielder"),
               new TextObject("{=!}Once, there was naught between the Underworld, nested deep in the roots of the Great Oak, and the heavenly canopy of the gods. Pérkos struck the Great Tree's bark, and from it's sap, mankind blossomed. Such is the tale told by the Volkhvs of the Rodovera. The children of the forest, however, have a different tale. Nevertheless, both the Sturgian and Vakken faiths share the belief on the Thunder-Wielder, for long ago both tribes were closer kin than they are today."),
               new TextObject("{=CfqOi9gq}Stability for all settlements of acceptable cultures\nRenown gain for every successful raid on foreign villages"),
               new TextObject("{=z0VYqrO5}Supreme God"));

            Calradios.Initialize(new TextObject("{=!}Augoustos Calradios"),
                new TextObject("{=!}A millenia ago, it is said, Calradios arrived on this land. He and his exiles sailed north, from another continent, until they arrived on the vicinities of Charas, where the first colony was stablished, Charasea. Over the following centuries, the Calradoi expanded over the continent, subjugating the native peoples, mainly Palaic and Battanian tribes. Imperial dynasties and claimants have ever since claimed descendancy to Calradios - descendant of Ireos, son of Sky-Father Iovis -, and thus, to the Gods themselves. True or not, Calradios has long since been annointed by the people as their founder, and by the state as Divus and Augoustos, meaning 'the Great one'."),
                new TextObject("{=!}Greatly increased influence gain and Legitimacy (rulers)"),
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
