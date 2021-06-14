using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Numbers.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class NumbersController : ControllerBase
    {
            //private static readonly int[] Numbers = new[]
            //{
            //1,2,3,4,5,6,7,8,9,0

            //};

            [HttpGet]
        //code that works
        //public ActionResult<string> Get()
        //{
        //int[] numbers = new int[] { 1,2,3,4,5,6,7,8,9,0 };
        //char[] specialCharacters = new char[] {'$','&','!','£','%','?'};

        //Random rnd = new Random();
        //int nIndex = rnd.Next(numbers.Length);
        //int sIndex = rnd.Next(specialCharacters.Length);
        ////var mI = $"{malePetNames[mIndex]}";
        //var nI = $"{numbers[nIndex]}";
        //var sI = $"{specialCharacters[sIndex]}";
        //return nI.ToString() + sI.ToString();


        public ActionResult<string> Get() 

        {
            char[] chars = "$%#@!*?;:1234567890".ToCharArray();
            string password = string.Empty;
            Random random = new Random();
            int length = 5;

                for (int i = 0; i < length ; i++)
            {


                int x = random.Next(1, chars.Length);
                //Don't Allow Repetation of Characters
                if (!password.Contains(chars.GetValue(x).ToString()))
                    password += chars.GetValue(x);
                else
                    i--;
            }

            return password;
        }
        
    }



    // var rnd = new Random();
    // var returnIndex = rnd.Next(0, 9);
    // var numbers = Enumerable.Range('0', '9' - '0' + 1).Select(x => (char)x);
    // return Numbers[returnIndex].ToString();
    //return Numbers[numbers].ToString();
}
     