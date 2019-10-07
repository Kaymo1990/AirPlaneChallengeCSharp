using System;
using System.Collections.Generic;
using System.Text;

namespace AirPlaneProject
{
    public class Weather
    {
        private double stormyChance;

        public Weather(double _stormyChance)
            {
            stormyChance = _stormyChance;
            }
        public bool IsStormy()
            { 
            var randomWeatherChance = new Random();
            if (randomWeatherChance.NextDouble() >= stormyChance)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
