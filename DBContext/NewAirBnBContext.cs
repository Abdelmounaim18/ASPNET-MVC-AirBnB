using Microsoft.EntityFrameworkCore;

namespace ASPNET_MVC_AirBnB.Models
{
    public class NewAirBnBContext : DbContext
    {
        public NewAirBnBContext(DbContextOptions<NewAirBnBContext> options) : base(options)
        {

        }

        public DbSet<BnB> BnBs { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Host> Hosts { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Guest> Guests { get; set; }
    }
}
