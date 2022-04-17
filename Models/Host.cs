using System.Collections.ObjectModel;

namespace ASPNET_MVC_AirBnB.Models
{
    public class Host
    {
        public ObservableCollection<BnB>? BnBs { get; set; }

        private int _id { get; set; }
        private string? _name { get; set; }
        private int _phoneNumber { get; set; }
        private string? _email { get; set; }


        public int Id
        { get => _id; set { _id = value; } }
        public string? Name
        { get => _name; set { _name = value; } }
        public int PhoneNumber
        { get => _phoneNumber; set { _phoneNumber = value;  } }
        public string? Email
        { get => _email; set { _email = value; } }
    }
}