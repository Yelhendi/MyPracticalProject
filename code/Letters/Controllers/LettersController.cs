using System;
using Microsoft.AspNetCore.Mvc;

namespace Letters.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LettersController : ControllerBase
    {
       
        [HttpGet]
        public ActionResult<string> Get()
        {
            //loop
            char[] UpperCase = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'Y', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] LowerCase = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'x', 'y', 'z' };
            string password = string.Empty;
            Random random = new Random();
            int length = 5;

            for (int i = 0; i < length; i++)
            {

                int x = random.Next(1, UpperCase.Length);
                int y = random.Next(1, LowerCase.Length);
                //Don't Allow Repetation of Characters
                if (!password.Contains(UpperCase.GetValue(x).ToString()))
                    password += UpperCase.GetValue(x);
                else if (!password.Contains(LowerCase.GetValue(y).ToString()))
                    password += LowerCase.GetValue(y);
                else
                    i--;
            }

            return password;

        }
    }
}
