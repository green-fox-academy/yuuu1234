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
    public class SpaceshipServiceTest
    {
        [Fact]
        public void ChangetheLocationServiceTest()
        {
            //arrange
            var context = SetUpApplicationContext();
            var service = new SpaceshipService(context);

            //act
            service.ChangeTheLocation((long) 1);
            //assert
            Assert.Equal("Moon", context.Spaceships.Find((long)1).Planet);

        }

        [Fact]
        public void DecreaseUtilizationServiceTest()
        {
            //arrange
            var context = SetUpApplicationContext();
            var service = new SpaceshipService(context);

            //act
            service.DecreaseUltilization();
            //assert
            Assert.Equal(19, context.Spaceships.Find((long)1).Utilization);

        }
        [Fact]
        public void IncreaseUtilizationServiceTest()
        {
            //arrange
            var context = SetUpApplicationContext();
            var service = new SpaceshipService(context);

            //act
            service.IncreaseUltilization();
            //assert
            Assert.Equal(21, context.Spaceships.Find((long)1).Utilization);

        }

        [Fact]
        public void GetUtilizationServiceTest()
        {
            //arrange
            var context = SetUpApplicationContext();
            var service = new SpaceshipService(context);

            //act
            var utilization=service.GetUltilization();
            //assert
            Assert.Equal(20, utilization);

        }

        private static ApplicationContext SetUpApplicationContext()
        {
            var random = new Random();
            var builder = new DbContextOptionsBuilder<ApplicationContext>();
            builder.UseInMemoryDatabase("EventListingDatabase" + random.Next());
            var context = new ApplicationContext(builder.Options);
            context.AddRange(
                new Spaceship { Max_capacity = 30, Planet = "mars", Utilization = 20 },
                new Planet {Name = "Moon"}
            );
            context.SaveChanges();
            return context;
        }
    }
}
