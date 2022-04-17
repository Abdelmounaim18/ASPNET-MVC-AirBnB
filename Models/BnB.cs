using System.Collections.ObjectModel;

namespace ASPNET_MVC_AirBnB.Models
{
    public class BnB
    {
        //public ObservableCollection<Reservation>? Reservations { get; set; }


        private int _id { get; set; }
        private string? _name { get; set; }
        private double _price { get; set; }
        private int _numRooms { get; set; }
        private int _numBeds { get; set; }
        private int _numBathrooms { get; set; }
        private string? _smokingAllowed { get; set; }
        private string? _petsAllowed { get; set; }


        public int Id { get => _id; set { _id = value; } }
        public string? Name
        { get => _name; set { _name = value; } }

        public double Price
        { get => _price; set { _price = value; } }

        public int NumRooms
        { get => _numRooms; set { _numRooms = value;} }

        public int NumBeds
        { get => _numBeds; set { _numRooms = value; } }

        public int NumBathrooms
        { get => _numBathrooms; set { _numRooms = value;  } }

        public string? SmokingAllowed
        { get => _smokingAllowed; set { _smokingAllowed = value;  } }

        public string? PetsAllowed
        { get => _petsAllowed; set { _petsAllowed = value;  } }

        private Host? _host;
        public Host? Host
        { get => _host; set { _host = value;  } }

        private Location? _location;
        public Location? Location
        { get => _location; set { _location = value;  } }
    }
}
