using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace David_LabEx01.Localization
{
    public static class David_LabEx01LocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(David_LabEx01Consts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(David_LabEx01LocalizationConfigurer).GetAssembly(),
                        "David_LabEx01.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
