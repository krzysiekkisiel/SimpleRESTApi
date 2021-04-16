using System;
using Xunit;
using SimpleRESTApi.Controllers;
using Microsoft.Extensions.Logging;
using System.Collections;
using System.Collections.Generic;

namespace SimpleRESTApi.Test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController(new Logger<WeatherForecastController>(new LoggerFactory()));


        [Fact]
        public void Get_Returns_Data()
        {
            var retVal = controller.Get();

            Assert.NotNull(retVal);
            Assert.Equal(5, (retVal as WeatherForecast[]).Length);
        }
    }
}
