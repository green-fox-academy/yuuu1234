using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class PlanetService : IPlanetService
    {
        private readonly ApplicationContext applicationContext;

        public PlanetService(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }

        public void DecreasePopulation(long id)
        {
            var PlanetFromDB = applicationContext.planets.Find(id);
            PlanetFromDB.Population--;
            applicationContext.SaveChanges();
        }
       

        public void IncreasePopulation(long id)
        {
            var PlanetFromDB = applicationContext.planets.Find(id);
            PlanetFromDB.Population++;
            applicationContext.SaveChanges();
        }

        public List<Planet> TopPlanets()
        {
            var TopPlanets = applicationContext.planets
                .OrderByDescending(n => n.Population)
                .Take(3);
            return TopPlanets.ToList();
        }
    }
}
