using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Frontend.Models;
using Frontend.Services;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace Frontend.test.UnitTest
{
    public class LogServiceTest
    {
        [Fact]
        public void AddTest()
        {
            //arrange
            var applicationContext = SetUpApplicationContext();
            var logService=new LogService(applicationContext);
            var log=new Log(){CreatedAt = DateTime.Now,Data = "test",Endpoint = "/"};
            //act
            logService.Add(log);
            //assert
            Assert.Equal(4,applicationContext.Logs.Count());


        }

        [Fact]
        public void LogEntriesCountTest()
        {
            //arrange
            var applicationContext = SetUpApplicationContext();
            var logService = new LogService(applicationContext);
            var log = new Log() { CreatedAt = DateTime.Now, Data = "test", Endpoint = "/" };
            //act
            var result=logService.logEntriesCount();
            //assert
            Assert.Equal(3, result);


        }
        private static ApplicationContext SetUpApplicationContext()
        {
            var random = new Random();
            var builder = new DbContextOptionsBuilder<ApplicationContext>();
            builder.UseInMemoryDatabase("EventListingDatabase" + random.Next());
            var context = new ApplicationContext(builder.Options);
            context.AddRange(
                new Log {CreatedAt = DateTime.Now, Data = "1", Endpoint = "/1" },
                new Log {CreatedAt = DateTime.Now, Data = "2", Endpoint = "/2" },
                new Log {CreatedAt = DateTime.Now, Data = "3", Endpoint = "/3" }
            );
            context.SaveChanges();
            return context;
        }

    }
}
