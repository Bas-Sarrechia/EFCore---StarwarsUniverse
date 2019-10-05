using System;
using System.Collections.Generic;
using System.Text;

namespace StarWarsUniverse.Domain
{
    public class PeopleSpecies
    {
        public string PersonUri { get; set; }
        public Person Person { get; set; }
        public string SpecieUri { get; set; }
        public Specie Specie { get; set; }
    }
}
