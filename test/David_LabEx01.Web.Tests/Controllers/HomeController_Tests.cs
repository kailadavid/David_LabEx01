using System.Threading.Tasks;
using David_LabEx01.Models.TokenAuth;
using David_LabEx01.Web.Controllers;
using Shouldly;
using Xunit;

namespace David_LabEx01.Web.Tests.Controllers
{
    public class HomeController_Tests: David_LabEx01WebTestBase
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