using System;
using System.ComponentModel.DataAnnotations;

namespace ASPNET_MVC_AirBnB.Models
{
    public class Reservation
    {

        private int _id { get; set; }
        private double _totalprice { get; set; }
        private DateTime _checkIn { get; set; }
        private DateTime _checkOut { get; set; }


        public int Id
        { get => _id; set { _id = value; } }

        [Required(ErrorMessage = "Please choose a different Check-out date")]
        public double TotalPrice
        { get => _totalprice; set { _totalprice = value; } }

        [Display(Name = "Check-in")]
        [Required(ErrorMessage = "Please enter your {0} date")]
        public DateTime CheckIn
        { get => _checkIn; set { _checkIn = value; } }

        [Display(Name = "Check-out")]
        [Required(ErrorMessage = "Please enter your {0} date")]
        public DateTime CheckOut
        { get => _checkOut; set { _checkOut = value; } } 

        private BnB? _bnb;
        public BnB? BnB
        { get => _bnb; set { _bnb = value; } }


        private Guest? _guest;
        public Guest? Guest
        { get => _guest; set { _guest = value; } }





    }
}