using Microsoft.AspNetCore.Mvc;

namespace ASPNET_MVC_AirBnB.Controllers
{
    public class ReservationsController : Controller
    {
        public IActionResult Checkout()
        {
            return View();
        }
        public IActionResult Receipt()
        {
            return View();
        }
    }
}
