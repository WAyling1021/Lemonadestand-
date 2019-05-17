using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LemonadeStandTests
{
    [TestWeather()]
    public class LemonadeStandTest
    {
        [Test()]
        public void TestWeatherForecast()
        {
            // arrange
            weatherForecastList = new List<string>() { "Cloudy", "Sunny", "Fog", "Rainy", "Partly Cloudy", "Partly Sunny" };
            todayTemperture = GetTemperture();
            todayForecast = GetForecast(weatherForecastList);



            // act
            weather.GetRandomForecast(Forecast);
            actual = weather.Weatherforecast; 



            // assert 
            Assert.AreEqual(expected, actual);
        }
    }
}
