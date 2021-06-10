﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Letters.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LettersController : ControllerBase
    {
         private static readonly char[] Letters = new[]
        {
         'A','B', 'C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','X','Y','Z'
            
        };
       

        [HttpGet]
        public ActionResult<string> Get()
        {
        
            var rnd = new Random();
            //var returnIndex = rnd.Next(0, 25);
            var returnlettersUpper = Enumerable.Range('A', 'Z' - 'A' + 1).Select(x => (char)x);
            var returnlettersLower = Enumerable.Range('a', 'z' - 'a' + 1).Select(x => (char)x);


            //return Letters[returnIndex].ToString();
            return Letters[returnlettersUpper][returnlettersLower].ToString();


        }

    }
}
