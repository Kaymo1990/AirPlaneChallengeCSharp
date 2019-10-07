using System;
using System.Collections.Generic;
using System.Text;

namespace AirPlaneProject
{
    class Weather
    {
        public static bool IsStormy()
        {
            bool isStormy = Random.value
                > 0.5f;
        }
    }
}
