using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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

        public List<Planet> GetAllPlanets()
        {
            return applicationContext.planets.ToList();
        }

        public void DecreasePopulation(long id)
        {
            var planetFromDB = applicationContext.planets.Find(id);
            planetFromDB.Population--;
            applicationContext.SaveChanges();
        }


        public void IncreasePopulation(long id)
        {
            var planetFromDB = applicationContext.planets.Find(id);
            planetFromDB.Population++;
            applicationContext.SaveChanges();
        }

        public void ToPlanet(long planetId)
        {
            var ultilization = applicationContext.Spaceships.Find((long) 1).Utilization;
            var planetFromDB = applicationContext.planets.Find(planetId);
            planetFromDB.Population += ultilization;
            applicationContext.Spaceships.Find((long) 1).Utilization = 0;
            applicationContext.SaveChanges();
        }

        public List<Planet> TopPlanets()
        {
            var topPlanets = applicationContext.planets
                .OrderByDescending(n => n.Population)
                .Take(3);
            return topPlanets.ToList();
        }
    }
}
