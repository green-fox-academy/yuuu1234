using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory.ValueGeneration.Internal;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class SpaceshipService : ISpaceshipService
    {
        private readonly ApplicationContext applicationContext;

        public SpaceshipService(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }

        public Spaceship GetSpaceship()
        {
            
            return applicationContext.Spaceships.Find((long) 1);
        }

        public void ChangeTheLocation(long id)
        {
            var spaceshipFromDB = applicationContext.Spaceships.Find((long)1);
            spaceshipFromDB.PlanetId = id;
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

        public bool AbleToMoveOrAcceptPeople()
        {
            var ultilization = applicationContext.Spaceships.Find((long)1).Utilization;
            return ultilization > 0 && ultilization < applicationContext.Spaceships.Find((long)1).Max_capacity;
        }

        public void ToSpaceship()
        {
            var avaliableCapacity = applicationContext.Spaceships.Find((long)1).Max_capacity -
                                    applicationContext.Spaceships.Find((long)1).Utilization;
            var currentPlanet = applicationContext.Spaceships.Find((long)1).PlanetId;
            var planetPopulation = applicationContext.planets.Find(currentPlanet).Population;
            if (avaliableCapacity >= planetPopulation)
            {
                applicationContext.Spaceships.Find((long)1).Utilization += (int)planetPopulation;
                applicationContext.planets.Find(currentPlanet).Population = 0;
            }
            else
            {
                applicationContext.Spaceships.Find((long)1).Utilization = applicationContext.Spaceships.Find((long)1).Max_capacity;
                applicationContext.planets.Find(currentPlanet).Population -= avaliableCapacity;
            }

            applicationContext.SaveChanges();


        }

        public bool AbleToMoveToPlanet()
        {
            return applicationContext.Spaceships.Find((long) 1).Utilization > 0;
        }

        public bool AbleToMoveToShip()
        {
            return applicationContext.Spaceships.Find((long)1).Utilization <
                   applicationContext.Spaceships.Find((long)1).Max_capacity;
        }
    }
}
