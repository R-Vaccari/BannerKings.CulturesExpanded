using BannerKings.CulturesExpanded.Religions;
using BannerKings.Managers.Education.Languages;
using BannerKings.Managers.Recruits;
using System;
using System.Collections.Generic;
using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.Localization;

namespace BannerKings.CulturesExpanded.Cultures
{
    public class BKCELanguages : DefaultTypeInitializer<BKCELanguages, Language>
    {
        public Language Darshi { get; } = new Language("language_darshi");
        public Language Jumne { get; } = new Language("language_nord");
        public Language Kannic { get; } = new Language("language_kannic");
        public Language Geroia { get; } = new Language("language_geroian");
        public Language Bragantian { get; } = new Language("language_bragantian");
        public Language Massa { get; } = new Language("language_massa");
        public Language Siri { get; } = new Language("language_siri");

        public override IEnumerable<Language> All { 
            get 
            {
                yield return Darshi;
                yield return Jumne;
                yield return Kannic;
                yield return Geroia;
                yield return Siri;
                yield return Massa;
                yield return Bragantian;
            }
        }

        public override void Initialize()
        {
            var cultures = Game.Current.ObjectManager.GetObjectTypeList<CultureObject>();

            DefaultLanguages.Instance.Vlandic.Initialize(new TextObject("{=!}Wilunding"),
                new TextObject("{=!}The common language spoken in the Wilunding realm, an amalgamation of various dialects. The Wilunding tribes originally hail from Balion, a realm in another continent, where they speak still much similar to their Calradian distant kin."),
                new List<CultureObject>(1)
                {
                    cultures.First(x => x.StringId == "vlandia"),
                    cultures.First(x => x.StringId == "balion")
                },
                new Dictionary<Language, float> 
                { 
                    { DefaultLanguages.Instance.Calradian, 0.15f },
                    { Jumne, 0.4f },
                    { Massa, 0.7f }
                });

            Bragantian.Initialize(new TextObject("{=!}Biscanjan"),
               new TextObject("{=!}Spoken in the Biscan Isles, Biscanjan is the amalgamation of the existing Calradoi dialect, itslef already diverging from the main imperial language, with the Massa settlers of the isles."),
               new List<CultureObject>(1)
               {
                    cultures.First(x => x.StringId == "bragantia")
               },
               new Dictionary<Language, float>()
               {
                   {  Massa, 0.2f },
                   {  DefaultLanguages.Instance.Calradian, 0.4f }
               });

            Massa.Initialize(new TextObject("{=!}Massa"),
               new TextObject("{=!}Spoken by the Massa tribe, their language is much similar to Vlandic. Most of their vocabulary still revolves around agricultural and warfare themes, lacking in deep philosophical concepts."),
               new List<CultureObject>(1)
               {
                    cultures.First(x => x.StringId == "massa")
               },
               new Dictionary<Language, float>()
               {
                   {  Jumne, 0.2f },
                   {  DefaultLanguages.Instance.Vlandic, 0.7f }
               });

            Siri.Initialize(new TextObject("{=!}Siri"),
               new TextObject("{=!}The ancient language of the Siri people."),
               new List<CultureObject>(1)
               {
                    cultures.First(x => x.StringId == "siri")
               },
               new Dictionary<Language, float>());

            Darshi.Initialize(new TextObject("{=IHhWB1aa}Darshi"),
               new TextObject("{=!}A very ancient language, with echoes from a civilized past before the existance of the Calradoi. The Darshi language is natural to the southeast of Calradia, and previously the east, before the Khuzaits conquered their kingdom, mostly composed of cities founded by the Darshi. The language is elaborate, poetic and for the ears of a foreigner, complex. Yet, it has nevertheless gained space in the courts of the Aserai, who have long took aspects of Darshi culture to their own uses."),
               new List<CultureObject>(1)
               {
                    cultures.First(x => x.StringId == "darshi")
               },
               new Dictionary<Language, float>());

            Jumne.Initialize(new TextObject("{=!}Jumne"),
               new TextObject("{=!}Spoken by the northern sailors, raiders and traders alike, Jumne is also the namesake of their distant land. The language of Jumne is foreign to all of those in Calradia, except to the Wilunding. Both share still echoes of a distant kinship."),
               new List<CultureObject>(1)
               {
                    cultures.First(x => x.StringId == "nord")
               },
               new Dictionary<Language, float>()
               {
                   { DefaultLanguages.Instance.Vlandic, 0.4f },
                   { Massa, 0.2f }
               });

            Kannic.Initialize(new TextObject("{=!}Kannic"),
               new TextObject("{=!}Although now mostly faded away, the Kannic language remains strong in the remaining Kannic strongholds. The language is notoriously curt, favoring small words and little vowels. Nevertheless, it shares vocabulary with the Nahawasi language, and serves the Kannic well on their maritime trades."),
               new List<CultureObject>(1)
               {
                    cultures.First(x => x.StringId == "kannic")
               },
               new Dictionary<Language, float>()
               {
                   { DefaultLanguages.Instance.Aseran, 0.15f }
               });

            Geroia.Initialize(new TextObject("{=!}Geroiako"),
               new TextObject("{=!}Originally a variation of the Calradian language, Geroiako has become its own language over the centuries. Isolated from the mainland, the islanders have developed linguistical shifts that make mutual understanding difficult with their distant Calradian kin. The Geroians however, take pride in their language and culture, which they spread through their slave-oared ships."),
               new List<CultureObject>(1)
               {
                    cultures.First(x => x.StringId == "geroia")
               },
               new Dictionary<Language, float>()
               {
                   { DefaultLanguages.Instance.Calradian, 0.3f }
               });

            foreach (var language in All)
            {
                DefaultLanguages.Instance.AddObject(language);
            }
        }
    }
}
