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

        [Required(ErrorMessage = "This field is required")]
        public string? FirstName { get => _firstName; set { _firstName = value; } }

        [Required(ErrorMessage = "This field is required")]
        public string? LastName { get => _lastName; set { _lastName = value; } }

        public string? Email
        { get => _email; set { _email = value; } }

        public int PhoneNumber
        { get => _phoneNumber; set { _phoneNumber = value;  } }

    }
}
