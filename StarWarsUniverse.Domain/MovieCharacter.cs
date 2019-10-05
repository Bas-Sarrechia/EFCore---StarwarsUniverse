using System;
using System.Collections.Generic;
using System.Text;
using StarWarsUniverse.domain;

namespace StarWarsUniverse.Domain
{
    public class MovieCharacter
    {
        public string MovieUri { get; set; }
        public Movie Movie { get; set; }
        public string PersonUri { get; set; }
        public Person Character { get; set; }
    }
}
