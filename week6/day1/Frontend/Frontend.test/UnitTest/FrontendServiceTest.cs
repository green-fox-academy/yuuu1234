using System;
using System.Collections.Generic;
using System.Text;
using Frontend.Services;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace Frontend.test.UnitTest
{
    public class FrontendServiceTest
    {
        private FrontendService frontendService = new FrontendService();
        [Fact]
        public void ArrayDoubleTest()
        {
            //arrange
            //act
            var result = frontendService.ArrayDouble(new long[] {1, 2, 3, 4});
            //assert
            Assert.Equal(4,result.Length);

        }


    }
}
