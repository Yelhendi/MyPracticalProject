using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

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
            //var result = "this password is strong enough";
            var returnValue = ValidatePassword(mergedResponse);
            return Ok(returnValue);

        }
        string ValidatePassword(string password)
        {
            var input = password;
            var Message = string.Empty;

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[$&!£%?@]");

            if (!hasLowerChar.IsMatch(input))
            {
               Message = "Password needs at least one lower case letter to make it even stronger!!";
               return $"{password} :  {Message}";
            }
            else if (!hasUpperChar.IsMatch(input))
            {
                Message = "Password needs at least one upper case letter to make it even stronger!!";
                return $"{password} :  {Message}";
            }
           
            else if (!hasNumber.IsMatch(input))
            {
                Message = "Password need at least one numeric value to make it even better!!";
                return $"{password} :  {Message}";
            }

            else if (!hasSymbols.IsMatch(input))
            {
                Message = "Password needs at least one special case character to make it super strong!";
                return $"{password} :  {Message}";
            }
            else
            {
                Message = "Your Password is perfect. Good luck cracking this!!!";
                return $"{password} :  {Message}";
            }

        }
    }
}
