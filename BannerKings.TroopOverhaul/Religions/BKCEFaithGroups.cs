using BannerKings.Managers.Institutions.Religions.Faiths;
using System.Collections.Generic;
using TaleWorlds.Localization;

namespace BannerKings.CulturesExpanded.Religions
{
    public class BKCEFaithGroups : DefaultTypeInitializer<BKCEFaithGroups, FaithGroup>
    {
        public FaithGroup AseraGroup { get; } = new FaithGroup("AseraGroup");
        public FaithGroup BattaniaGroup { get; } = new FaithGroup("BattaniaGroup");
        public FaithGroup ImperialGroup { get; } = new FaithGroup("ImperialGroup");
        public FaithGroup VlandiaGroup { get; } = new FaithGroup("VlandiaGroup");
        public FaithGroup SturgiaGroup { get; } = new FaithGroup("SturgiaGroup");
        public FaithGroup DevsegGroup { get; } = new FaithGroup("DevsegGroup");
        public FaithGroup DarshiGroup { get; } = new FaithGroup("DarshiGroup");

        public override IEnumerable<FaithGroup> All
        {
            get
            {
                yield return AseraGroup;
                yield return BattaniaGroup;
                yield return ImperialGroup;
                yield return VlandiaGroup;
                yield return SturgiaGroup;
                yield return DevsegGroup;
                yield return DarshiGroup;
            }
        }

        public override void Initialize()
        {
            DarshiGroup.Initialize(new TextObject("{=!}Darshi Faiths"),
                new TextObject("{=!}The Darshi faiths are a group of religions developed by the Darshi. It is mainly represented by the Atash Amesha, the faith of most Darshi and of the Darshianshahr, represented in their cities by the fire temples. However, a small, heretic cult was developed in Odokh, one that believes in sorcery rather than the Immortal Flame, and it has been adopted by its Khuzait overlords."));

            AseraGroup.Initialize(new TextObject("{=!}Nahasan Faiths"),
                new TextObject("{=!}The Nahasa and its tribes have historically bred a plethora of faiths. In Calradia, these are represented mainly by the Code of Asera, the faith and law of self-acclaimed Aserai confederate tribes. But there are also the Siri, with their Great Lion and animal gods, lie at the very core of the Nahasa, and have worshiped their gods long before the Nahawasi nomads gathered as the Aserai sultanate. Lastly, the Kannic faith, relinquished to the remainings of Kannic Politeia at Lys and secret groups of cultists along the Perassic sea, where the Kannic once ruled."));

            BattaniaGroup.Initialize(new TextObject("{=GbQpgQat}Derwyddon Faiths"),
                new TextObject("{=!}Long ago, when Calradoi attempted to communicate with local Battanians, one word appeared to them as distinctly important: 'Derwyddon'. In their ignorance, they assumed it to mean 'faith'. The word however was spoken by fur and cloak clad, elderly men: the druids, or in other words, Derwyddon. Though the ancient pre-Imperial faiths are often oral traditions and differ from tribe to tribe, important druids have come to agree on theological matters through the existence of the Battanian High-Kingdom, which stimulates this integration.{newline}{newline}Apart from the Battanians, this group is also represented by the Palaic, local kinsmen of the Battanians, and who share important beliefs in their faiths, such as the importance of lakes. However, scarcely exists anymore, after centuries of Imperial dominance."));

            ImperialGroup.Initialize(new TextObject("{=NWqkTdMt}Calradian Faiths"),
                new TextObject("{=!}The Imperial Calradoi faiths. Long ago, the Calradoi prayed only to godly, ethereal figures, who could not be engaged by men unless they chose to descend to our plane. Today these are known as the Erythryans. However, throughout the Imperial history, the concept of Divus and the deification of flesh and blood figures become more and more prevalent. Calradios is the epitome of such concept, but many since him have claimed to be his descendent, and thus descendents of the Gods themselves. Beloved emperors, empress and even military commanders, who held much sway over their legionaires, would foster such cults, if not simply allow them to thrive once they naturally developed. Such cults have grown apart, at times with different Senate factions favoring one over the other, and now through the separate Empire claimants, who favor cults that support their claim and worldview."));

            VlandiaGroup.Initialize(new TextObject("{=!}Wilunding Faiths"),
                new TextObject("{=!}The faiths brought through the seas by the Vlandic peoples. Though different among the original tribes that migrated to Calradia, the Wilunding tribes find theri faiths represented in Osfeyd. The Wilunding believe their gods are heroes, sometimes half-animal or fully animal as well, but still capable of the desires and begrudings of man."));

            SturgiaGroup.Initialize(new TextObject("{=!}Ircaran Faiths"),
                new TextObject("{=!}The faiths born within the Kachyar peninsula and Ircaran Wildlands. These are represented by the sister faiths of the Sturgians and Vakken."));

            DevsegGroup.Initialize(new TextObject("{=!}Devseg Faiths"),
                new TextObject("{=!}The group of faiths brought of the Devseg peoples. Most Devseg in Calradia are part of the Khuzait realm, and thus have come to the continent by hordes. However, Devseg tribes had already settled parts of eastern Calradia, such as the Iltanlar. These scarcce tribes however are overshadowed by their semi-nomadic horde cousins, who have certainly lifted the Devseg threat to the neighbouring cultures."));

            foreach (var item in All)
            {
                DefaultFaithGroups.Instance.AddObject(item);
            }
        }
    }
}
