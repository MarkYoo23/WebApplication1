using Microsoft.Extensions.Logging;
using Moq;
using System;
using WebApplication1.Controllers;
using Xunit;

namespace ApiTests
{
    public class UnitTest1
    {

        private readonly WeatherForecastController _weatherForecastController;

        public UnitTest1()
        {
            Mock<ILogger<WeatherForecastController>> logger = new Mock<ILogger<WeatherForecastController>>();
            _weatherForecastController = new WeatherForecastController(logger.Object);
        }

        [Fact]
        public void Test1()
        {
            var weatherForecasts = _weatherForecastController.Get();
            Assert.NotEmpty(weatherForecasts);
        }

        [Fact]
        public void Test2()
        {
            var weatherForecasts = _weatherForecastController.Get();
            Assert.NotNull(weatherForecasts);
        }
    }
}
