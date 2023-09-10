using BannerKings.Managers.Institutions.Religions.Doctrines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.Localization;

namespace BannerKings.CulturesExpanded.Religions
{
    public class BKCEDoctrines : DefaultTypeInitializer<BKCEDoctrines, Doctrine>
    {
        public Doctrine Astrology { get; private set; }
        public Doctrine Esotericism { get; private set; }
        public Doctrine RenovatioImperi { get; private set; }

        public override IEnumerable<Doctrine> All
        {
            get
            {
                yield return Astrology;
                yield return Esotericism;
                yield return RenovatioImperi;
            }
        }

        public override void Initialize()
        {
            RenovatioImperi = new Doctrine("RenovatioImperi",
               new TextObject("{=!}Renovatio Imperi"),
               new TextObject("{=!}Peace in Calradia can only exist with an united Empire. A kingdom under the teachings of Heaven. The faithful should cast aside their ambitions and work together for the benefit of the gods."),
               new TextObject("{=!}On showing mercy post siege, gain relations with all notables"),
               new List<Doctrine>()
               {
               },
               true);

            Esotericism = new Doctrine("Esotericism",
               new TextObject("{=!}Esotericism"),
               new TextObject("{=!}Knowledge and faith are less divided than most think. The cosmos is littered with mysteryes, and to seek their answers is to seek to reach the gods themselves."),
               new TextObject("{=!}Wisdom yields piety\nFinishing education projects yields piety"),
               new List<Doctrine>()
               {
               },
               true);

            Astrology = new Doctrine("Astrology",
               new TextObject("{=!}Astrology"),
               new TextObject("{=!}The study of the stars is the study of the divine itself. Much like the Sun blesses the land with fertility, the stars bless man with wisdom."),
               new TextObject("{=!}Cultural innovations develop faster (when Cultural Head)\n"),
               new List<Doctrine>()
               {
               },
               true);

            foreach (Doctrine item in All)
            {
                DefaultDoctrines.Instance.AddObject(item);
            }
        }
    }
}
