using Abp.AspNetCore.Mvc.ViewComponents;

namespace ClinicNB.Web.Views
{
    public abstract class ClinicNBViewComponent : AbpViewComponent
    {
        protected ClinicNBViewComponent()
        {
            LocalizationSourceName = ClinicNBConsts.LocalizationSourceName;
        }
    }
}
