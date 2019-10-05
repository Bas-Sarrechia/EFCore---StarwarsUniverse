using System;
using System.Collections.Generic;
using System.Text;

namespace StarWarsUniverse.Domain
{
    public class PeopleVehicles
    {
        public string PersonUri { get; set; }
        public Person Person { get; set; }
        public string VehicleUri { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
