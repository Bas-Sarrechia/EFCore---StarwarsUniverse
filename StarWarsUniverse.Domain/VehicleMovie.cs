using System;
using System.Collections.Generic;
using System.Text;
using StarWarsUniverse.domain;

namespace StarWarsUniverse.Domain
{
    public class VehicleMovie
    {
        public string MovieUri { get; set; }
        public Movie Movie { get; set; }
        public string VehicleUri { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
