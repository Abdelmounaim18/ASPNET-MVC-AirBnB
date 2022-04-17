using ASPNET_MVC_AirBnB.Models;
using ASPNET_MVC_AirBnB.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ASPNET_MVC_AirBnB.Controllers
{
    public class ReservationsController : Controller
    {
        private readonly NewAirBnBContext _context;

        public ReservationsController(NewAirBnBContext context)
        {
            _context = context;
        }

        public IActionResult Checkout(int id)
        {

            ReservationViewModel vm = new ReservationViewModel
            { Context = _context };
            vm.LoadBnBDetails(id);
            return View(vm);
        }

        //public async Task<IActionResult> Checkout(int? id)
        //{


        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var SelectedBnB = await _context.BnBs.Include(c => c.Location).Include(c => c.Host).FirstOrDefaultAsync(m => m.Id == id);

        //    if (SelectedBnB == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(SelectedBnB);
        //}


        
        public IActionResult Receipt()
        {
            return View();
        }
    }
}
