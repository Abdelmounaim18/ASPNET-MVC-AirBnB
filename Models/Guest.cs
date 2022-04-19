using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace ASPNET_MVC_AirBnB.Models
{
    public class Guest
    {


        private int _id { get; set; }
        private string? _firstName { get; set; }
        private string? _lastName { get; set; }
        private string? _email { get; set; }
        private int _phoneNumber { get; set; }


        public int Id
        { get => _id; set { _id = value; } }

        [Display(Name = "Firstname")]
        [Required(ErrorMessage = "Please fill in your {0}")]
        public string? FirstName { get => _firstName; set { _firstName = value; } }

        [Display(Name = "Lastname")]
        [Required(ErrorMessage = "Please fill in your {0}")]
        public string? LastName { get => _lastName; set { _lastName = value; } }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please enter your {0}")]
        public string? Email
        { get => _email; set { _email = value; } }

        [Display(Name = "Phonenumber")]
        [Required(ErrorMessage = "Please enter your {0}")]
        public int PhoneNumber
        { get => _phoneNumber; set { _phoneNumber = value;  } }

    }
}
