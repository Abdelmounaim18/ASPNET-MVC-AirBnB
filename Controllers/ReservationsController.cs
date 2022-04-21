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

        public IActionResult Checkout(int? id)
        {


            ReservationViewModel reservationViewModel = new ReservationViewModel
            { 
                Context = _context 
            };

            if (id == null)
            {
                return NotFound();
            }

            reservationViewModel.LoadBnBDetails(id);

            if (reservationViewModel.BnB == null)
            {
                return NotFound();
            }

            return View(reservationViewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PlaceReservation(int BnBId, [Bind("Id,TotalPrice,CheckIn,CheckOut")] Reservation reservation, [Bind("Id,FirstName,LastName,Email,PhoneNumber")] Guest guest)
        {

            ReservationViewModel reservationViewModel = new ReservationViewModel
            {
                Context = _context,
            };

            if (ModelState.IsValid)
            {
                reservation.BnB = _context.BnBs.First(c => c.Id == BnBId);
                reservation.Guest = guest;
                _context.Add(reservation);
                await _context.SaveChangesAsync();
                return RedirectToAction("Receipt", new
                {
                    id = _context.Reservations.Max(r => r.Id)
                });
            }

            return View();
        }



        public IActionResult Receipt(int? id)
        {
            ReservationViewModel reservationViewModel = new ReservationViewModel
            {
                Context = _context,
            };

            if (id == null)
            {
                return NotFound();
            }

            reservationViewModel.LoadReceipt(id);

            if (reservationViewModel.Reservation == null)
            {
                return NotFound();
            }

            return View(reservationViewModel);
        }


    }
}
