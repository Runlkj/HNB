using System.Threading.Tasks;
using ClinicNB.Models.TokenAuth;
using ClinicNB.Web.Controllers;
using Shouldly;
using Xunit;

namespace ClinicNB.Web.Tests.Controllers
{
    public class HomeController_Tests: ClinicNBWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}