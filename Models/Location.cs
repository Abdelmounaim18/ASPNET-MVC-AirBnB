using System.Collections.ObjectModel;

namespace ASPNET_MVC_AirBnB.Models
{
    public class Location
    {
        public ObservableCollection<BnB>? BnBs { get; set; }

        private int _id { get; set; }
        private string? _street { get; set; }
        private string? _zipCode { get; set; }
        private string? _city { get; set; }
        private string? _country { get; set; }


        public int Id
        { get => _id; set { _id = value; } }
        public string? Street
        { get => _street; set { _street = value;  } }
        public string? ZipCode
        { get => _zipCode; set { _zipCode = value;  } }
        public string? City
        { get => _city; set { _city = value;  } }
        public string? Country
        { get => _country; set { _country = value;  } }
    }
}