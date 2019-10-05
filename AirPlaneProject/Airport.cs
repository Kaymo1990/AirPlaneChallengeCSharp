using System;
using System.Collections.Generic;
using System.Text;

namespace AirPlaneProject
{
    public class Airport
    {
        private readonly IList<Airplane> planeHanger = new List<Airplane>();

        public IEnumerable<Airplane> PlaneHanger
        {
            get
            {
                return this.planeHanger;
            }
        }

        public void AcceptPlane(Airplane airplane)
        {
            this.planeHanger.Add(airplane);
        }
    }
}
