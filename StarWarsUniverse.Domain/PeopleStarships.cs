using System;
using System.Collections.Generic;
using System.Text;

namespace StarWarsUniverse.Domain
{
    public class PeopleStarships
    {
        public string PersonUri { get; set; }
        public Person Person { get; set; }
        public string StarShipUri { get; set; }
        public StarShip StarShip { get; set; }
    }
}
