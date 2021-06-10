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
            private static readonly int[] Numbers = new[]
            {
            1,2,3,4,5,6,7,8,9,0
        };

            [HttpGet]
            public ActionResult<string> Get()
            {
                var rnd = new Random();
            //var returnIndex = rnd.Next(0, 9);
            var numbers = Enumerable.Range('0', '9' - '0' + 1).Select(x => (char)x);
            //return Numbers[returnIndex].ToString();
            return Numbers[numbers].ToString();
            }
        }
}

