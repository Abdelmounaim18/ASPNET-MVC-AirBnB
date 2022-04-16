using Microsoft.AspNetCore.Mvc;

namespace ASPNET_MVC_AirBnB.Controllers
{
    public class AccommodationsController : Controller
    {
        public IActionResult Index()    
        {
            return View();
        }

        public IActionResult MoreInfo()
        {
            return View();
        }

        public IActionResult Lookup()
        {
            return View();
        }
    }
}
