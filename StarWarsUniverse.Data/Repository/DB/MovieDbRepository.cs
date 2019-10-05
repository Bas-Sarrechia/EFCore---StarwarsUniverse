using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using StarWarsUniverse.Data.Repository.StarWarsUniverse.Data.Repositories;
using StarWarsUniverse.domain;

namespace StarWarsUniverse.Data.Repository.DB
{
    public class MovieDbRepository : IMovieRepository
    {
        private StarWarsContext _context;

        public MovieDbRepository(StarWarsContext context)
        {
            this._context = context;
        }

        public IList<Movie> GetAllMovies()
        {
            return _context.Movies
                .Include(movie => movie.MoviePlanets)
                .ThenInclude(moviePlanet => moviePlanet.Planet)
                .OrderBy(movie => movie.EpisodeId)
                .ToList();
        }
    }
}