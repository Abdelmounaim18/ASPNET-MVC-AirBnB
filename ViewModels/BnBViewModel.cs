using ASPNET_MVC_AirBnB.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ASPNET_MVC_AirBnB.ViewModels
{
    public class BnBViewModel
    {
        public NewAirBnBContext Context { get; set; }
        public BnB BnB { get; set; }

        public List<BnB> AllBnBs { get; set; }

        public string SearchTerm { get; set; }


        public void Load(int? id = null)
        {
            if (id != null)
            {
                BnB = Context.BnBs.Include(c => c.Location).First(c => c.Id == id);
            }
        }

        public void LoadList()
        {
            if (SearchTerm != null)
            {
                AllBnBs = Context.BnBs.Include(c => c.Location).ToList();
            }
            else
            {
                AllBnBs = Context.BnBs.Include(c => c.Location).ToList();
            }

        }
    }


}
