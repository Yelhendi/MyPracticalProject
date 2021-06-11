using System;
using System.Collections.Generic;
using System.Linq;
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
            public ActionResult<string> Get()
            {
            int[] numbers = new int[] { 1,2,3,4,5,6,7,8,9,0 };
            char[] specialCharacters = new char[] {'$','&','!','£','%','?'};
            
            Random rnd = new Random();
            int nIndex = rnd.Next(numbers.Length);
            int sIndex = rnd.Next(specialCharacters.Length);
            //var mI = $"{malePetNames[mIndex]}";
            var nI = $"{numbers[nIndex]}";
            var sI = $"{specialCharacters[sIndex]}";
            return nI.ToString() + sI.ToString();
            // var rnd = new Random();
            // var returnIndex = rnd.Next(0, 9);
            // var numbers = Enumerable.Range('0', '9' - '0' + 1).Select(x => (char)x);
            // return Numbers[returnIndex].ToString();
            //return Numbers[numbers].ToString();
        }
        }
}

