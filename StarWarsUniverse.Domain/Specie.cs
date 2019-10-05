using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using StarWarsUniverse.domain;

namespace StarWarsUniverse.Domain
{
    public class Specie : Resource
    {
        public string Name { get; set; }
        public string Designation { get; set; }
        [JsonProperty("average_height")] public string AverageHeight { get; set; }
        [JsonProperty("skin_colors")] public string SkinColors { get; set; }
        [JsonProperty("hair_colors")] public string HairColors { get; set; }
        [JsonProperty("eye_colors")] public string EyeColors { get; set; }
        [JsonProperty("average_lifespan")] public string AverageLifespan { get; set; }
        [JsonProperty("homeworld")] public string HomeworldUri { get; set; }
        [JsonIgnore] public Planet Homeworld { get; set; }
        public string Language { get; set; }
        [JsonProperty("people")] public List<string> PeopleUris { get; set; }
        [JsonIgnore] public List<Person> People { get; } = new List<Person>();
        [JsonProperty("films")] public List<string> MovieUris { get; set; }
        [JsonIgnore] public List<Movie> Movies { get; } = new List<Movie>();
    }
}