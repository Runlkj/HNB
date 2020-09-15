using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace ClinicNB.Localization
{
    public static class ClinicNBLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(ClinicNBConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ClinicNBLocalizationConfigurer).GetAssembly(),
                        "ClinicNB.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
