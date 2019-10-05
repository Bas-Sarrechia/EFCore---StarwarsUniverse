using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using StarWarsUniverse.Data;
using StarWarsUniverse.Data.Repository.DB;
using StarWarsUniverse.domain;

namespace StarWarsUniverse
{
    class Program
    {
        public static void Main(string[] args)
        {

            var repo = new MovieDbRepository(new StarWarsContext());
            new StarWarsContext().Database.Migrate();

            Console.WriteLine("=== Star Wars Movies ===");
            foreach (Movie movie in repo.GetAllMovies())
            {
                Console.Write($"Episode {movie.EpisodeId} - {movie.Title}\n\tReleased: {movie.ReleaseDate:dd/MM/yyyy}\n\r\t[");
                foreach (var planet in movie.MoviePlanets.Select(moviePlanet=> moviePlanet.Planet).ToList())
                {
                    Console.Write($" ({planet.Name}) ");
                }
                Console.Write($"]\n\r");
            }
            Console.WriteLine("========================");
            Console.ReadKey();
            
        }
    }
}
