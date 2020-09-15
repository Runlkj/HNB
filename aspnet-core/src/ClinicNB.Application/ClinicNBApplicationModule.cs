using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ClinicNB.Authorization;

namespace ClinicNB
{
    [DependsOn(
        typeof(ClinicNBCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ClinicNBApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ClinicNBAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ClinicNBApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
