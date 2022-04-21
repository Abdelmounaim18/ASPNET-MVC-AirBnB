using ASPNET_MVC_AirBnB.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

using System.Threading.Tasks;
using System.Linq;

namespace ASPNET_MVC_AirBnB.ViewModels
{
    public class BnBViewModel
    {
        public NewAirBnBContext Context { get; set; }
        public BnB BnB { get; set; }
        public Guest Guest { get; set; }
        public List<BnB> AllBnBs { get; set; }

        public void LoadAllBnBs()
        {
            var GetAllBnBs = Context.BnBs.Include(c => c.Location).Include(c => c.Host).ToList();
            if (GetAllBnBs != null)
            {
                AllBnBs = GetAllBnBs;
            }
        }
    }


}
