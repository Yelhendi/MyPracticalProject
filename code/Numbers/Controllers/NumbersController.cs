using System;
using Microsoft.AspNetCore.Mvc;

namespace Numbers.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class NumbersController : ControllerBase
    {
    [HttpGet]
        

        public ActionResult<string> Get() 

        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            char[] SpecialCharacters = { '$', '&', '!', '£', '%', '?' };
            string password = string.Empty;
            Random random = new Random();
            int length = 6;

            for (int i = 0; i < length ; i++)
            {

                int a = random.Next(1, numbers.Length);
                int b = random.Next(1, SpecialCharacters.Length);

                //Don't Allow Repetation of Characters
                if (!password.Contains(numbers.GetValue(a).ToString()))
                    password += numbers.GetValue(a);

                else if (!password.Contains(SpecialCharacters.GetValue(b).ToString()))
                        password += SpecialCharacters.GetValue(b);

                  else
                    i--;
            }

            return password;
        }
        
    }
}
     