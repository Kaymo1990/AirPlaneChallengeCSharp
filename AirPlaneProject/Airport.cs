using System;
using System.Collections.Generic;
using System.Text;

namespace AirPlaneProject
{
    public class Airport
    {
        private string airport;
        public Airport(string airportName)
        {
            airport = airportName;
        }

        public string airportLocation
        {
            get { return airport; }
            private set { airport = value; }
        }
        public List<Airplane> planeHanger
        {
            get { return planeHanger; }
            private set { planeHanger = value; }
        }

        public void AcceptPlane(Airplane airplane)
        {
            planeHanger.Add(airplane);
        }
    }
}
