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

        public string Land(Airport airport)
        {
            airport.AcceptPlane(this);
            CurrentAirport = airport.airportLocation;
            PlaneStatus = "Landed";
            return "Landed";
        }

        public string TakeOff(Airport airport)
        {
            if (CurrentAirport != airport.airportLocation)
            {
                throw new Exception("Plane is not at this airport");
            }

            airport.EjectPlane(this);
            CurrentAirport = "";
            PlaneStatus = "Flying";
            return $"Plane has taken off from {airport.airportLocation} airport";
            
        }
    }
}
