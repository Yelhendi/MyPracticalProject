using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Merge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        //Need to be able to call application
        //numbersurl: https://localhost:44345/
        //LetterUrl: https://localhost:44364/
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //Call numbers service 
            var numbersService = "https://localhost:44345/numbers ";
            var numbersResponseCall = await new HttpClient().GetStringAsync(numbersService);
            var lettersService = "https://localhost:44364/letters ";
            var lettersResponseCall = await new HttpClient().GetStringAsync(lettersService);

            //Ready to merge stuff using string interpolatrion
            var mergedResponse = $"{numbersResponseCall}{lettersResponseCall}";
            return Ok(mergedResponse);
        }
    }
}
