using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoxClubProject.Services.Fox;

namespace FoxClubProject.Repository
{
    public static class AllFoxes
    {
        public static List<FoxService> Foxlist=new List<FoxService>()
            {new FoxService{Name = "Mr.Green", Food = "salad",Drink = "water"}};
        public static DateTime StartTime= DateTime.Now;

        
       
    }
}
