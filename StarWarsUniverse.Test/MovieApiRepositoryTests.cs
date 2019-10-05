using NUnit.Framework;
using StarWarsUniverse.Data;

namespace StarWarsUniverse.Test
{
    [TestFixture]
    public class MovieApiRepositoryTests
    {
        private MovieApiRepository _repo;

        [SetUp]
        public void SetUp()
        {
            _repo = new MovieApiRepository();
        }

        [Test]
        public void GetAllMovies()
        {
            Assert.That(_repo.GetAllMovies().Count, Is.GreaterThanOrEqualTo(7));
        }
    }
}