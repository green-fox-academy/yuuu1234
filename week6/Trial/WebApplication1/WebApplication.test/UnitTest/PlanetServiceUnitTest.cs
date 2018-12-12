using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using WebApplication1;
using WebApplication1.Models;
using WebApplication1.Services;
using Xunit;

namespace WebApplication.test.UnitTest
{
    public class PlanetServiceUnitTest
    {
        [Fact]
        public void DecreasePopulationTest()
        {
            //arrange
            var context = SetUpApplicationContext();
            var planetService = new PlanetService(context);
            long id = 1;
            //act

            planetService.DecreasePopulation(id);
            //assert
            Assert.Equal(14, context.planets.Find(id).Population);

        }
        [Fact]
        public void IncreasePopulationTest()
        {
            //arrange
            var context = SetUpApplicationContext();
            var planetService = new PlanetService(context);
            long id = 1;
            //act

            planetService.IncreasePopulation(id);
            //assert
            Assert.Equal(16, context.planets.Find(id).Population);

        }

        [Fact]
        public void TopPlanetTest()
        {
            //arrange
            var context = SetUpApplicationContext();
            var planetService = new PlanetService(context);
            //act

            var result=planetService.TopPlanets();
            //assert
            Assert.Equal(1, result.Count);

        }

        private static ApplicationContext SetUpApplicationContext()
        {
            var random = new Random();
            var builder = new DbContextOptionsBuilder<ApplicationContext>();
            builder.UseInMemoryDatabase("EventListingDatabase" + random.Next());
            var context = new ApplicationContext(builder.Options);
            context.AddRange(
                new Planet { Name = "mars", Population = 15 }

            );
            context.SaveChanges();
            return context;
        }
    }
}
