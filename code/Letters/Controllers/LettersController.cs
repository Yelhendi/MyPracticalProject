using System;
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
        //private static readonly char[] Letters = new[]

       // {
        //'A','B, 'C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','X','Y','Z'
        //'a','b', 'c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','x','y','z',
        //'A', 'a', 'B', 'b','C','c','D','d','E','e','F','f','G','g','H','h','I','i','J','j','K','k','L','l','M','m','N','n','O','o','P','p','Q','q','R','r','S','s','T','t','U','u','V','v','W','w','X','x','Y','y','Z','z'

       // };
    


        [HttpGet]
        public ActionResult<string> Get()
        {
             char[] upperCaseLetters = new char[] { 'A','B','C','D','E','F','G','H','Y','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
             char[] lowerCaseLetters = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'x', 'y', 'z' };

            //string[] malePetNames = new string [] { "Rufus", "Bear", "Dakota", "Fido",
            //              "Vanya", "Samuel", "Koani", "Volodya",
            //              "Prince", "Yiska" };
            //string[] femalePetNames = new string [] { "Maggie", "Penny", "Saya", "Princess",
            //                "Abby", "Laila", "Sadie", "Olivia",
            //                "Starlight", "Talla" };

            Random rnd = new Random();

            int mIndex = rnd.Next(upperCaseLetters.Length );
            int fIndex = rnd.Next(lowerCaseLetters.Length);
            //var mI = $"{malePetNames[mIndex]}";
            var mI = $"{upperCaseLetters[mIndex]}";
            var fI = $"{lowerCaseLetters[fIndex]}";
            return mI.ToString() + fI.ToString();
            //var rnd = new Random();
            //var returnindex = rnd.Next(0, 50);
            //var returnlettersupper = Enumerable.Range('A', 'Z' - 'A' + 1).Select(x => (char)x);
            // var returnletterslower = Enumerable.Range('a', 'z' - 'a' + 1).Select(x => (char)x);


            //return Letters[returnindex].ToString();

            //return letters[returnlettersupper][returnletterslower].tostring();



            //}

        }
    }
}
