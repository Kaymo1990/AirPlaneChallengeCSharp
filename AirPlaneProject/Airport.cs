using System;
using System.Collections.Generic;
using System.Text;

namespace AirPlaneProject
{
    public class Airport
    {
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
