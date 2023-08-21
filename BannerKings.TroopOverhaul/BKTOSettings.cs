using TaleWorlds.Localization;
using MCM.Abstractions.Attributes.v1;
using MCM.Abstractions.Base.Global;

namespace BannerKings.Settings
{
    public class BKTOSettings : AttributeGlobalSettings<BKTOSettings>
    {
        private int volunteersLimit = 10;
        public override string Id => "BannerKings.CulturesExpanded";
        public override string DisplayName => new TextObject("{=!}Banner Kings: Cultures Expanded").ToString();
        public override string FolderName => "BannerKings.CulturesExpanded"; 
        public override string FormatType => "json2";

        [SettingProperty("{=!}Latin Titles", RequireRestart = true, HintText = "{=!}Switch hellenized Empire titles for Latin language titles. Default: False.")]
        public bool LatinTitles { get; set; } = false;
    }
}
