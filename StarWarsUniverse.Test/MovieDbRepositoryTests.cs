using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using StarWarsUniverse.Data;
using StarWarsUniverse.Data.Repository.DB;
using StarWarsUniverse.domain;

namespace StarWarsUniverse.Test
{
    [TestFixture]
    public class MovieDbRepositoryTests
    {
        [OneTimeSetUp]
        public void SetUp()
        {
            using (var context = CreateContext())
            {
                context.Database.EnsureCreated();
            }
        }

        [Test]
        public void GetAllMoviesShouldReturnEveryMovie()
        {
            using (var context = CreateContext())
            {
                //Arrange
                var repo = new MovieDbRepository(context);
                //Write your unit test here

                var movies = repo.GetAllMovies();

                Assert.That(movies, Is.TypeOf<List<Movie>>());
                Assert.That(movies.Count, Is.GreaterThanOrEqualTo(7));
            }
        }

        private StarWarsContext CreateContext()
        {
            var options = new DbContextOptionsBuilder<StarWarsContext>()
                .UseInMemoryDatabase(databaseName: "starwars_in_memory_db").Options;

            var context = new StarWarsContext(options);
            return context;
        }
    }
}