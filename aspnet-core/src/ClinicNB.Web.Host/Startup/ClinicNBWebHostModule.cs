using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ClinicNB.Configuration;

namespace ClinicNB.Web.Host.Startup
{
    [DependsOn(
       typeof(ClinicNBWebCoreModule))]
    public class ClinicNBWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ClinicNBWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ClinicNBWebHostModule).GetAssembly());
        }
    }
}
