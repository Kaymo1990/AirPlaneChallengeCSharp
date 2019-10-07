﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AirPlaneProject
{
    public class Airplane
    {
        public string CurrentAirport { get; set; } = "";
        public string PlaneStatus { get; set; } = "Flying";

        public string land(Airport airport)
        {
            PlaneStatus = "Landed";
            airport.AcceptPlane(this);
            return "Landed";
        }
    }
}
