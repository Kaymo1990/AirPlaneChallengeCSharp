using System;
using System.Collections.Generic;
using System.Text;

namespace AirPlaneProject
{
    public class Airplane
    {
        private string currentAirport;
        private string planeStatus;
        public Airplane(string _currentAirport = "", string _planeStatus = "Flying")
        {
            currentAirport = _currentAirport;
            planeStatus = _planeStatus;
        }
        


        public string CurrentAirport
        {
            get { return currentAirport; }
            set { currentAirport = value; }
        }
        public string PlaneStatus
        {
            get { return planeStatus; }
            set { planeStatus = value; }
        }

        public string land()
        {
            PlaneStatus = "Landed";
            return "Landed";
        }
    }
}
