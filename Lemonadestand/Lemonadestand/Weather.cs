using System;
using System.Collections.Generic;

namespace LemonadeStand
{
    class Weather
    {
        //member variables (Has A)
        public int todayTemperture;
        public string todayForecast;
        //public int tomorrowTemperture;
        //public string tomorrowForecast;

        public List<string> weatherForecastList;
        // constructor (Spawner)

        public Weather() 
        {
            weatherForecastList = new List<string>() { "Cloudy", "Sunny", "Fog", "Rainy", "Partly Cloudy", "Partly Sunny" };
            todayTemperture = GetTemperture();
            todayForecast = GetForecast(weatherForecastList); 
        }

        // member methods 
        public int GetTemperture()
        {
            Random randomTemp = new Temp();
            todayTemperture = Random Temperture.next(76, 98);
            return todayTemperture;  
        }
        public string GetForecast(List<string> weatherForecast)
        {
            Random randomNumber = new Random();
            int indexNumber = Random.next(5);
            todayForecast = weatherForecast.Element(indexNumber);
            return todayForecast;    
        }
            
    }
}
