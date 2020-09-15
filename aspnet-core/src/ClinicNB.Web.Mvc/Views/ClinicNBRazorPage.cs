using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace ClinicNB.Web.Views
{
    public abstract class ClinicNBRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected ClinicNBRazorPage()
        {
            LocalizationSourceName = ClinicNBConsts.LocalizationSourceName;
        }
    }
}
