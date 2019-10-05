using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using StarWarsUniverse.Data.Repository.StarWarsUniverse.Data.Repositories;
using StarWarsUniverse.domain;
using StarWarsUniverse.Domain;

namespace StarWarsUniverse.Data
{
    public class MovieApiRepository : IMovieRepository
    {
        private readonly HttpClient _httpClient;

        public MovieApiRepository()
        {
            _httpClient = new HttpClient {BaseAddress = new Uri("https://swapi.co")};
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public IList<Movie> GetAllMovies()
        {
            var allMovies = new List<Movie>();
            RetrieveListFromApi("films", ref allMovies);
            return allMovies;
        }

        public IList<Planet> GetAllPlanets()
        {
            var allPlanets = new List<Planet>();
            RetrieveListFromApi("planets", ref allPlanets);
            return allPlanets;
        }

        public IList<Person> GetAllPeople()
        {
            var allPeople = new List<Person>();
            RetrieveListFromApi("people", ref allPeople);
            return allPeople;
        }

        public IList<StarShip> GetAllStarships()
        {
            var allStarships = new List<StarShip>();
            RetrieveListFromApi("starships", ref allStarships);
            return allStarships;
        }

        public IList<Vehicle> GetAllVehicles()
        {
            var allVehicles = new List<Vehicle>();
            RetrieveListFromApi("vehicles", ref allVehicles);
            return allVehicles;
        }

        public IList<Specie> GetAllSpecies()
        {
            var allSpecies = new List<Specie>();
            RetrieveListFromApi("species", ref allSpecies);
            return allSpecies;
        }


        private void RetrieveListFromApi<T>(string apiEndUrl, ref List<T> returnedList)
        {
            var url = "/api/" + apiEndUrl;

            HttpResponseMessage response = _httpClient.GetAsync(url).Result;
            string content = response.Content.ReadAsStringAsync().Result;
            var resultsPage = JsonConvert.DeserializeObject<ResultsPage<T>>(content);
            bool endOfFile = false;
            while (!endOfFile)
            {
                returnedList.AddRange(resultsPage.Results);
                response = _httpClient.GetAsync(resultsPage.Next).Result;
                content = response.Content.ReadAsStringAsync().Result;
                if (resultsPage.Next != null)
                {
                    resultsPage = JsonConvert.DeserializeObject<ResultsPage<T>>(content);
                }
                else
                {
                    endOfFile = true;
                }
            }
        }
    }
}