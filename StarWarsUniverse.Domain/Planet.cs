using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using StarWarsUniverse.Domain;

namespace StarWarsUniverse.domain
{
    public class Planet : Resource
    {
        public string Name { get; set; }
        [JsonProperty("rotation_period")] public string RotationPeriod { get; set; }
        [JsonProperty("orbital_period")] public string OrbitalPeriod { get; set; }
        public string Diameter { get; set; }
        public string Climate { get; set; }
        public string Gravity { get; set; }
        public string Terrain { get; set; }
        [JsonProperty("surface_water")] public string SurfaceWater { get; set; }
        public string Population { get; set; }
        [JsonIgnore] public List<MoviePlanet> MoviePlanets { get; } = new List<MoviePlanet>();
        [JsonProperty(PropertyName = "films")] public List<string> MovieUris { get; set; }
        [JsonProperty(PropertyName = "residents")]
        public List<string> ResidentsUris { get; set; }
        [JsonIgnore] public List<Person> Residents { get; } = new List<Person>();
    }
}