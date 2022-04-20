using ASPNET_MVC_AirBnB.Models;
using ASPNET_MVC_AirBnB.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
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

            if (id == null)
            {
                return NotFound();   
            }

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



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PlaceReservation(int BnBId, [Bind("Id,TotalPrice,CheckIn,CheckOut")] Reservation reservation,  [Bind("Id,FirstName,LastName,Email,PhoneNumber")] Guest guest)
        {

            ReservationViewModel vm = new ReservationViewModel
            {
                Context = _context,
            };

            if (ModelState.IsValid)
            {
                reservation.BnB = _context.BnBs.First(c => c.Id == BnBId);
                reservation.Guest = guest;
                _context.Add(reservation);
                _context.SaveChanges();
                return RedirectToAction("Receipt", new {id = _context.Reservations.Max(r => r.Id)});
            }

            return View();
        }



        public IActionResult Receipt(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ReservationViewModel vm = new ReservationViewModel
            {
                Context = _context,
            };
            vm.LoadReceipt(id);
            if (vm.Reservation == null)
            {
                return NotFound();
            }

            return View(vm);
        }

       
    }
}
