using System;
using System.Collections.Generic;
using System.Text;
using StarWarsUniverse.domain;

namespace StarWarsUniverse.Domain
{
    public class SpecieMovie
    {
        public string MovieUri { get; set; }
        public Movie Movie { get; set; }
        public string SpecieUri { get; set; }
        public Specie Specie { get; set; }
    }
}
