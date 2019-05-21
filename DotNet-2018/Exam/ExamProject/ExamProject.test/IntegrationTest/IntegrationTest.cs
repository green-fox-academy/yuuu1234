using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using Xunit;

namespace ExamProject.test.IntegrationTest
{
    public class IntegrationTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> factory;

        public IntegrationTests(WebApplicationFactory<Startup> factory)
        {
            this.factory = factory;
        }

        [Fact]
        public async Task MainPageLoadsSuccessfully()
        {
            var responseMessage = await factory.CreateClient().GetAsync("/");

            responseMessage.EnsureSuccessStatusCode();
        }

        //[Fact]
        //public async Task DoublingTest()
        //{
        //    // Arrange
        //    var client = factory.CreateClient();

        //    // Act
        //    var responseMessage = await client.GetAsync("/doubling?input=2");
        //    var content = await responseMessage.Content.ReadAsStringAsync();

        //    var result = JsonConvert.DeserializeObject<Doubling>(content);

        //   // Assert
        //    Assert.Equal(4, result.Result);
        //}
    }
}
