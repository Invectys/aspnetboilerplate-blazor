using System.Threading.Tasks;
using Main.Models.TokenAuth;
using Main.Web.Controllers;
using Shouldly;
using Xunit;

namespace Main.Web.Tests.Controllers
{
    public class HomeController_Tests: MainWebTestBase
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