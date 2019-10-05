using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using StarWarsUniverse.domain;

namespace StarWarsUniverse.Domain
{
    public class StarShip :Resource
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        [JsonProperty("cost_in_credits")] public string CostInCredits { get; set; }
        public string Length { get; set; }
        [JsonProperty("max_atomosphering_speed")] public string MaxAtmospheringSpeed { get; set; }
        public string Crew { get; set; }
        public string Passengers { get; set; }
        [JsonProperty("cargo_capacity")] public string CargoCapacity { get; set; }
        public string Consumables { get; set; }
        [JsonProperty("hyperdrive_rating")] public string HyperdriveRating { get; set; }
        public string MGLT { get; set; }
        [JsonProperty("starship_class")] public string StarshipClass { get; set; }
        [JsonProperty("films")] public List<string> MovieUris { get; set; }
        [JsonIgnore] public List<Movie> Movies { get; } = new List<Movie>();
        [JsonProperty("pilots")] public List<string> PilotUris { get; set; }
        [JsonIgnore] public List<Person> Pilots { get; } = new List<Person>();
    }
}
