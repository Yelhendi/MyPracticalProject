using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using Microsoft.Extensions.Options;


namespace FrontEnd.Controllers
{

    public class HomeController : Controller
    {
        public AppSettings Configuration;
        public HomeController(IOptions<AppSettings> settings)
        {
            Configuration = settings.Value;
        }


        public async Task<IActionResult> Index()
        {
            //var mergedService = $"{Configuration["mergedServiceURL"]}/merge";
            var mergedService = $"{Configuration.mergedServiceURL}/merge";
            // var serviceThreeResponseCall = await new HttpClient().GetStringAsync(mergedService);
            var serviceThreeResponseCall = await new HttpClient().GetStringAsync(mergedService);
            ViewBag.responseCall = serviceThreeResponseCall;
            return View();

        }
    }
}
