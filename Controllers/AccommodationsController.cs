using ASPNET_MVC_AirBnB.Models;
using ASPNET_MVC_AirBnB.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASPNET_MVC_AirBnB.Controllers
{
    public class AccommodationsController : Controller
    {

        private readonly NewAirBnBContext _context;

        public AccommodationsController(NewAirBnBContext context)
        {
            _context = context;
        }

        public IActionResult BnBs()
        {
            BnBViewModel viewModel = new BnBViewModel
            { Context = _context };
            viewModel.LoadList();
            return View(viewModel);
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
