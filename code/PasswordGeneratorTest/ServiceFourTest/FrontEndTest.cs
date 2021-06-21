using FrontEnd.Controllers;
using FrontEnd;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Moq;
using Xunit;

namespace PasswordGeneratorTest
{
    public class FrontEndTest
    {
        private AppSettings appSettings = new AppSettings()
        {
            mergedServiceURL = "https://passwordgenerator-merge.azurewebsites.net"
        };

        [Fact]
        public async void GetFrontEndTest()
        {
            //Arrange
            var options = new Mock<IOptions<AppSettings>>();
            options.Setup(x => x.Value).Returns(appSettings);

            HomeController homeController = new HomeController(options.Object);
            var homeContollerResult = await homeController.Index();

            Assert.NotNull(homeContollerResult);
            //Assert.IsType <OkObjectResult>(homeContollerResult);
        }
    }
}
