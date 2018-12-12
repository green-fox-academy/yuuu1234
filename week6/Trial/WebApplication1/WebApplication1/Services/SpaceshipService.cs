using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.InMemory.ValueGeneration.Internal;
using WebApplication1.Interfaces;

namespace WebApplication1.Services
{
    public class SpaceshipService : ISpaceshipService
    {
        private readonly ApplicationContext applicationContext;

        public SpaceshipService(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }

        public void ChangeTheLocation(long id)
        {
            var spaceshipFromDB = applicationContext.Spaceships.Find((long)1);
            string newPlanet = applicationContext.planets.Find(id).Name;
            spaceshipFromDB.Planet = newPlanet;
            applicationContext.SaveChanges();
        }

        public void DecreaseUltilization()
        {
            var spaceshipFromDB = applicationContext.Spaceships.Find((long)1);
            spaceshipFromDB.Utilization--;
            applicationContext.SaveChanges();
        }

        public void IncreaseUltilization()
        {
            var spaceshipFromDB = applicationContext.Spaceships.Find((long)1);
            spaceshipFromDB.Utilization++;
            applicationContext.SaveChanges();
        }

        public int GetUltilization()
        {
            var spaceshipFromDB = applicationContext.Spaceships.Find((long)1);
            return spaceshipFromDB.Utilization;
        }


    }
}
