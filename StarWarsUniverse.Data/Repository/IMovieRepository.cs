using System;
using System.Collections.Generic;
using System.Text;
using StarWarsUniverse.domain;

namespace StarWarsUniverse.Data.Repository
{
    namespace StarWarsUniverse.Data.Repositories
    {
        public interface IMovieRepository
        {
            IList<Movie> GetAllMovies();
        }
    }
}