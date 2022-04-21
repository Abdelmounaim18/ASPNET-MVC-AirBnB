using ASPNET_MVC_AirBnB.Models;
using ASPNET_MVC_AirBnB.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

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
            BnBViewModel bnbViewModel = new BnBViewModel
            { 
                Context = _context 
            };

            bnbViewModel.LoadAllBnBs();

            if (bnbViewModel.AllBnBs == null)
            {
                return NotFound();
            }

            return View(bnbViewModel);
        }


    }
}
