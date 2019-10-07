using System;
using System.Collections.Generic;
using System.Text;

namespace AirPlaneProject
{
    public class Airplane
    {
        private string currentAirport = "";
        private string planeStatus = "Flying";

        public string CurrentAirport { get => currentAirport; set => currentAirport = value; }
        public string PlaneStatus { get => planeStatus; set => planeStatus = value; }

        public string land()
        {
            PlaneStatus = "Landed";
            return "Landed";
        }
    }
}
