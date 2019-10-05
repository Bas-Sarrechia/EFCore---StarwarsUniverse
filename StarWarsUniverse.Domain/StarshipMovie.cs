using System;
using System.Collections.Generic;
using System.Text;
using StarWarsUniverse.domain;

namespace StarWarsUniverse.Domain
{
    public class StarshipMovie
    {
        public string MovieUri { get; set; }
        public Movie Movie { get; set; }
        public string StarshipUri { get; set; }
        public StarShip StarShip { get; set; }
    }
}
