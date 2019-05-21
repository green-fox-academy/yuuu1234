using System;
using System.Collections.Generic;
using Frontend.Controllers;
using Frontend.Interfaces;
using Frontend.Models;
using NSubstitute;
using Xunit;

namespace Frontend.test
{
    public class HomeControllerTest
    {
        [Fact]
        public void DoublingTest()
        {
            //arrange
            var mockFrontendservice = SetUpFrontendServiceMock();
            var mocklogService = SetUpLogServiceMock();
            var controller = new HomeController(mockFrontendservice, mocklogService, null);
            //act
            var result = controller.Doubling(2);
            //assert
            Assert.Equal(4, result.Value.Result);
        }

        [Fact]
        public void GreetingTest()
        {

            //arrange
            var mockFrontendservice = SetUpFrontendServiceMock();
            var mocklogService = SetUpLogServiceMock();
            var controller = new HomeController(mockFrontendservice, mocklogService, null);
            //act
            var result = controller.Greeting("Jack", "student");
            //assert
            Assert.Equal(typeof(Greeting), result.Value.GetType());
        }

        [Fact]
        public void AppendaTest()
        {
            //arrange
            var mockFrontendservice = SetUpFrontendServiceMock();
            var mocklogService = SetUpLogServiceMock();
            var controller = new HomeController(mockFrontendservice, mocklogService, null);
            //act
            var result = controller.Appenda("kuty");
            //assert
            Assert.Equal("kuty", result.Value.Appenda);
        }

        [Fact]
        public void UntillTest()
        {
            //arrange
            var mockFrontendservice = SetUpFrontendServiceMock();
            var mocklogService = SetUpLogServiceMock();
            var controller = new HomeController(mockFrontendservice, mocklogService, null);
            var until=new Until(){Action = "sum",UntilNumber = 3};
            //act
            var result = controller.Untill(until);
            //assert
            Assert.Equal(0, result.Value.Result);
        }
        private static IFrontendService SetUpFrontendServiceMock()
        {
            var mockService = Substitute.For<IFrontendService>();
            mockService.UntilSum(3).ReturnsForAnyArgs(0);
            return mockService;
        }

        private static ILogService SetUpLogServiceMock()
        {
            var mockService = Substitute.For<ILogService>();
            //mockService.(null, null).ReturnsForAnyArgs(
            //    new List<Event>
            //    {
            //        new Event {EventId = 1},
            //        new Event {EventId = 2}
            //    });
            return mockService;
        }

    }

}
