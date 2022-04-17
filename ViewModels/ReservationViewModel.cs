﻿using ASPNET_MVC_AirBnB.Models;
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
        public List<Reservation> AllReservations { get; set; }
     
        
        public void LoadBnBDetails(int id)
        {
            BnB = Context.BnBs.Include(c => c.Location).Include(c => c.Host).First(c => c.Id == id);
        }

    }
}
