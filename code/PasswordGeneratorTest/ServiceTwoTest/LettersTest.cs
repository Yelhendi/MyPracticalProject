using Letters.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace PasswordGeneratorTest
{
    public class LettersTest
    {
        [Fact]

        public void GetLetter_Test()
        {
            //Arrange
            LettersController lettersController = new LettersController();
            //Act
            var lettersControllerResult = lettersController.Get();
            //Assert
            Assert.NotNull(lettersControllerResult);
            Assert.IsType<ActionResult<String>>(lettersControllerResult);
        }
    }
}
