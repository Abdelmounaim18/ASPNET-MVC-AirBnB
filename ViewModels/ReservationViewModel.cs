using ASPNET_MVC_AirBnB.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ASPNET_MVC_AirBnB.ViewModels
{
    public class ReservationViewModel
    {
        public NewAirBnBContext Context { get; set; }
        public BnB BnB { get; set; }
        public Reservation Reservation { get; set; }
        public Guest Guest { get; set; }


        public void LoadBnBDetails(int? id = null)
        {
            if (id != null)
            {
                var GetBnB = Context.BnBs.Include(c => c.Location).Include(c => c.Host).FirstOrDefault(c => c.Id == id);
                if (GetBnB != null)
                {
                    BnB = GetBnB;
                }
            }
        }

        public void LoadReceipt(int? id = null)
        {
            if (id != null)
            {
                var GetReservation = Reservation = Context.Reservations.Include(c => c.BnB).Include(c => c.Guest).Where(c => c.Id == id).FirstOrDefault();
                if (GetReservation != null)
                {
                    Reservation = GetReservation;
                }
            }
        }


    }
}
