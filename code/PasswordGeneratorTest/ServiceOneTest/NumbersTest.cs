using Microsoft.AspNetCore.Mvc;
using Numbers.Controllers;
using System;
using Xunit;

namespace PasswordGeneratorTest
{
    public class NumbersTest
    {
        
    [Fact]
        public void GetNumber_Test()
        {
            //Arrange
            NumbersController numbersController = new NumbersController();
            //Act
            var NumbersControllerResult = numbersController.Get();
            //Assert
            Assert.NotNull(NumbersControllerResult);
            Assert.IsType<ActionResult<String>>(NumbersControllerResult);

        }
    }
}
