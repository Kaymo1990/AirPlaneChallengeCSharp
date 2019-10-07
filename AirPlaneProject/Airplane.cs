using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirPlaneProject
{
    public class Airplane
    {
        public string CurrentAirport { get; set; } = "";
        public string PlaneStatus { get; set; } = "Flying";

        public string Land(Airport airport, Weather weather)
        {
            airport.AcceptPlane(this, weather);
            CurrentAirport = airport.airportLocation;
            PlaneStatus = "Landed";
            return "Landed";
        }

        public string TakeOff(Airport airport, Weather weather)
        {
            if (CurrentAirport != airport.airportLocation)
            {
                throw new Exception("Plane is not at this airport");
            }

            airport.EjectPlane(this, weather);
            CurrentAirport = "";
            PlaneStatus = "Flying";
            return $"Plane has taken off from {airport.airportLocation} airport";
            
        }
    }
}
