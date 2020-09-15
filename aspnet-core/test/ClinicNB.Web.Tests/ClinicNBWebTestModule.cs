using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ClinicNB.EntityFrameworkCore;
using ClinicNB.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace ClinicNB.Web.Tests
{
    [DependsOn(
        typeof(ClinicNBWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ClinicNBWebTestModule : AbpModule
    {
        public ClinicNBWebTestModule(ClinicNBEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ClinicNBWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ClinicNBWebMvcModule).Assembly);
        }
    }
}