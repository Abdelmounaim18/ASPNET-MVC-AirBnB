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
    }
}
