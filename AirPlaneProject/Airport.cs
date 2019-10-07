using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AirPlaneProject
{
    public class Airport
    {
        private readonly IList<Airplane> planeHanger = new List<Airplane>();
        private string airport;
        public Airport(string airportName)
        {
            airport = airportName;
        }

        public IReadOnlyCollection<Airplane> PlaneHanger
        {
            get
            {
                return new ReadOnlyCollection<Airplane>(this.planeHanger);
            }
        }

        public string airportLocation
        {
            get { return airport; }
            private set { airport = value; }
        }
        

        public void AcceptPlane(Airplane airplane)
        {
            this.planeHanger.Add(airplane);
        }
    }
}
