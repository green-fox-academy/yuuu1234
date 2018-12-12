using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Frontend.Models;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using Xunit;

namespace Frontend.test.IntegrationTest
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
        public async Task DoublingTest()
        {
            // Arrange
            var client = factory.CreateClient();

            // Act
            var responseMessage = await client.GetAsync("/doubling?input=2");
            var content = await responseMessage.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<Doubling>(content);

            // Assert
            Assert.Equal(4, result.Result);
        }

        [Fact]
        public async Task GreetingTest()
        {
            // Arrange
            var client = factory.CreateClient();

            // Act
            var responseMessage = await client.GetAsync("/greeter?name=Mia&&title=student");
            var content = await responseMessage.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<Greeting>(content);

            // Assert
            Assert.Equal("Oh, hi there Mia, my dear student!", result.Welcome_Message);
        }

        [Fact]
        public async Task AppendaTest()
        {
            // Arrange
            var client = factory.CreateClient();

            // Act
            var responseMessage = await client.GetAsync("/appenda/kuty");
            var content = await responseMessage.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<Appending>(content);

            // Assert
            Assert.Equal("kuty", result.Appenda);
        }

        [Fact]
        public async Task UntillTest()
        {
            // Arrange
            var client = factory.CreateClient();
            var stringContent = new StringContent("{\"until\": 15}", Encoding.UTF8);
            // Act
            var responseMessage = await client.PostAsync("/dountil/sum",stringContent);
            var content = await responseMessage.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<Until>(content);

            // Assert
            Assert.Equal(6, result.Result);
        }


    }
}
