using System;
using System.Collections.Generic;
using System.Text;

namespace AirPlaneProject
{
    public class Weather
    {
        public static bool IsStormy(int stormyChance)
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
