using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using ClinicNB.Controllers;

namespace ClinicNB.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ClinicNBControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
