using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using StarWarsUniverse.domain;
using StarWarsUniverse.Domain;

namespace StarWarsUniverse.domain
{
    public class Movie : Resource
    {
        public string Title { get; set; }

        [JsonProperty(PropertyName = "episode_id")]
        public int EpisodeId { get; set; }

        [JsonProperty(PropertyName = "opening_crawl")]
        public string OpeningCrawl { get; set; }

        public string Director { get; set; }
        public string Producer { get; set; }

        [JsonProperty(PropertyName = "release_date")]
        public DateTime ReleaseDate { get; set; }

        [JsonIgnore] public List<MoviePlanet> MoviePlanets { get; } = new List<MoviePlanet>();

        [JsonProperty(PropertyName = "planets")]
        public List<string> PlanetUris { get; set; }

        [JsonIgnore] public List<MovieCharacter> MovieCharacters { get; } = new List<MovieCharacter>();

        [JsonProperty(PropertyName = "characters")]
        public List<string> CharacterUris { get; set; }

        [JsonIgnore] public List<StarshipMovie> StarshipMovie { get; } = new List<StarshipMovie>();

        [JsonProperty(PropertyName = "starships")]
        public List<string> StarshipUris { get; set; }
        [JsonIgnore] public List<VehicleMovie> VehicleMovie { get; } = new List<VehicleMovie>();

        [JsonProperty(PropertyName = "vehicles")]
        public List<string> VehicleUris { get; set; }
        [JsonIgnore] public List<SpecieMovie> SpecieMovie { get; } = new List<SpecieMovie>();

        [JsonProperty(PropertyName = "species")]
        public List<string> SpeciesUri { get; set; }

    }
}