using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using StarWarsUniverse.domain;

namespace StarWarsUniverse.Domain
{
    public class Person : Resource
    {
        public string Name { get; set; }
        public string Height { get; set; }
        public string Mass { get; set; }
        [JsonProperty("hair_color")] public string HairColor { get; set; }
        [JsonProperty("skin_color")] public string SkinColor { get; set; }
        [JsonProperty("eye_color")] public string EyeColor { get; set; }
        [JsonProperty("birth_year")] public string BirthYear { get; set; }
        [JsonProperty("homeworld")] public string HomeWorldUri { get; set; }
        [JsonIgnore] public Planet HomeWorld { get; set; }
        [JsonProperty("films")] public List<string> MovieUris { get; set; }
        [JsonProperty("species")] public List<string> SpeciesUris { get; set; }
        [JsonProperty("vehicles")] public List<string> VehiclesUris { get; set; }
        [JsonProperty("starships")] public List<string> StarshipUris { get; set; }
        [JsonIgnore] public List<MovieCharacter> MovieCharacters { get; } = new List<MovieCharacter>();
    }
}