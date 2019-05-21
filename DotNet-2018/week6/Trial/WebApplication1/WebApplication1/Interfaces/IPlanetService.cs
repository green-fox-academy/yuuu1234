using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Interfaces
{
   public interface IPlanetService
    {
        void IncreasePopulation(long id);
        void DecreasePopulation(long id);
        void ToPlanet(long planetId);
        List<Planet> TopPlanets();
        List<Planet> GetAllPlanets();
    }
}
