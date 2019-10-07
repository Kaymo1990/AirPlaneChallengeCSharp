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
        private int airportCapacity;
        public Airport(string airportName, int airportCap)
        {
            airport = airportName;
            airportCapacity = airportCap;
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

        public int airportMaxCapacity
        {
            get { return airportCapacity; }
            private set { airportCapacity = value; }
        }
        

        public void AcceptPlane(Airplane airplane)
        {
            if (Weather.IsStormy())
            {
                throw new Exception("It is too stormy to land");
            }

            if (planeHanger.Count == this.airportMaxCapacity)
            {
                throw new Exception("The airport is full");
            }
            this.planeHanger.Add(airplane);
        }

        public void EjectPlane(Airplane airplane)
        {
            if (Weather.IsStormy())
            {
                throw new Exception("It is too stormy to take off");
            }
            this.planeHanger.Remove(airplane);
        }
    }
}
