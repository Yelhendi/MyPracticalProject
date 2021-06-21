using Merge;
using Merge.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Moq;
using Xunit;

namespace PasswordGeneratorTest
{
    public class MegeTest
    {
        private AppSettings appSettings = new AppSettings()
        {
            numbersServiceURL = "https://passwordgeneratoryasmin.azurewebsites.net",
            lettersServiceURL = "https://passwordgeneratoryasmin2.azurewebsites.net"
        };

        [Fact]
        public async void GetMergeTest()
        {
            var options = new Mock<IOptions<AppSettings>>();
            options.Setup(x => x.Value).Returns(appSettings);

            MergeController mergeController = new MergeController(options.Object);
            var mergeContollerResult = await mergeController.Get();

            Assert.NotNull(mergeContollerResult);
            Assert.IsType<OkObjectResult>(mergeContollerResult);
        }
    } 
}
