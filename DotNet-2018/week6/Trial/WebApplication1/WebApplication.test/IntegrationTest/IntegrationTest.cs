using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication1;
using Xunit;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using WebApplication1.Models;


namespace WebApplication.test
{
    public class IntegrationTest : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> factory;

        public IntegrationTest(WebApplicationFactory<Startup> factory)
        {
            this.factory = factory;
        }
        [Fact]
        public async Task MainPageLoadsSuccessfully()
        {
            var responseMessage = await factory.CreateClient().GetAsync("/");

            responseMessage.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task TopPlanetsTest()
        {
            // Arrange
            var client = factory.CreateClient();

            // Act
            var responseMessage = await client.GetAsync("/top-planets");
            var content = await responseMessage.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<PlanetsList>(content);

            // Assert
            Assert.Equal(3, result.TopPlanet.Count);
        }
    }
}
