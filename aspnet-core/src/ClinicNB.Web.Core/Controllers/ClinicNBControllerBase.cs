using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ClinicNB.Controllers
{
    public abstract class ClinicNBControllerBase: AbpController
    {
        protected ClinicNBControllerBase()
        {
            LocalizationSourceName = ClinicNBConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
