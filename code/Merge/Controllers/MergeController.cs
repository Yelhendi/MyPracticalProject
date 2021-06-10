using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Merge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MergeController : ControllerBase
    {
        //NumbersURL: https://localhost:44365/
        //LetterURL:https://localhost:44397/
        private IConfiguration Configuration;
        public MergeController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //Call numbers service 
            // var numbersService = " https://localhost:44365/numbers ";
            var numbersService = $"{Configuration["numbersServiceURL"]}/numbers";
            var numbersResponseCall = await new HttpClient().GetStringAsync(numbersService);

            //var lettersService = "https://localhost:44397/letters ";
            var lettersService = $"{Configuration["lettersServiceURL"]}/letters";
            var lettersResponseCall = await new HttpClient().GetStringAsync(lettersService);

            //Ready to merge stuff using string interpolatrion
            var mergedResponse = $"{numbersResponseCall}{lettersResponseCall}";
            return Ok(mergedResponse);

            Random random = new Random();
            var password = string.Empty;
            for (int i = 0; i < 15; i++)
            {
                var idx = random.Next(mergedResponse.Count());
                password += mergedResponse[idx];
            }
            Console.WriteLine(password);
        }
    }
}
