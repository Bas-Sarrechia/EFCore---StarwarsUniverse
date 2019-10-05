using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using StarWarsUniverse.domain;
using StarWarsUniverse.Domain;

namespace StarWarsUniverse.Data
{
    public class StarWarsContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Planet> Planets { get; set; }
        public DbSet<Person> People { get; set; }

        public StarWarsContext()
        {
        }

        public StarWarsContext(DbContextOptions<StarWarsContext> options) : base(options)
        {
        }

        public StarWarsContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer(
                        "Server = (localdb)\\mssqllocaldb; Database = StarWarsDB; Trusted_Connection = True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasKey(m => m.Uri);
            modelBuilder.Entity<Planet>().HasKey(m => m.Uri);
            modelBuilder.Entity<Person>().HasKey(m => m.Uri);
            modelBuilder.Entity<Specie>().HasKey(m => m.Uri);
            modelBuilder.Entity<Vehicle>().HasKey(m => m.Uri);
            modelBuilder.Entity<StarShip>().HasKey(m => m.Uri);

            modelBuilder.Entity<Movie>()
                .Ignore(movie => movie.PlanetUris)
                .Ignore(m => m.CharacterUris)
                .Ignore(m => m.StarshipUris)
                .Ignore(m => m.VehicleUris)
                .Ignore(m => m.SpeciesUri);
            modelBuilder.Entity<Planet>()
                .Ignore(planet => planet.MovieUris)
                .Ignore(planet => planet.ResidentsUris);
            modelBuilder.Entity<Person>()
                .Ignore(person => person.MovieUris)
                .Ignore(person => person.VehiclesUris)
                .Ignore(person => person.StarshipUris)
                .Ignore(person => person.SpeciesUris);
            
            modelBuilder.Entity<Specie>()
                .Ignore(specie => specie.MovieUris)
                .Ignore(specie => specie.HomeworldUri)
                .Ignore(specie => specie.PeopleUris);
            modelBuilder.Entity<Vehicle>()
                .Ignore(vehicle => vehicle.MovieUris)
                .Ignore(vehicle => vehicle.PilotUris);
            modelBuilder.Entity<StarShip>()
                .Ignore(starShip => starShip.MovieUris)
                .Ignore(starShip => starShip.PilotUris);

            modelBuilder.Entity<MoviePlanet>().HasKey(moviePlanet => new {moviePlanet.MovieUri, moviePlanet.PlanetUri});
            modelBuilder.Entity<MovieCharacter>()
                .HasKey(movieCharacter => new {movieCharacter.MovieUri, movieCharacter.PersonUri});
            modelBuilder.Entity<StarshipMovie>()
                .HasKey(starshipMovie => new {starshipMovie.MovieUri, starshipMovie.StarshipUri});
            modelBuilder.Entity<SpecieMovie>()
                .HasKey(specieMovie => new {specieMovie.MovieUri, specieMovie.SpecieUri});
            modelBuilder.Entity<VehicleMovie>()
                .HasKey(vehicleMovie => new {vehicleMovie.MovieUri, vehicleMovie.VehicleUri});

            modelBuilder.Entity<PeopleSpecies>()
                .HasKey(peopleSpecies => new {peopleSpecies.PersonUri, peopleSpecies.SpecieUri});
            modelBuilder.Entity<PeopleStarships>()
                .HasKey(peopleSpecies => new {peopleSpecies.PersonUri, peopleSpecies.StarShipUri});
            modelBuilder.Entity<PeopleVehicles>()
                .HasKey(peopleSpecies => new {peopleSpecies.PersonUri, peopleSpecies.VehicleUri});


            var remoteRepository = new MovieApiRepository();

            IList<Movie> remoteMovies = remoteRepository.GetAllMovies();
            modelBuilder.Entity<Movie>().HasData(remoteMovies.ToArray());

            IList<Planet> remotePlanets = remoteRepository.GetAllPlanets();
            modelBuilder.Entity<Planet>().HasData(remotePlanets.ToArray());

            IList<Person> remotePeople = remoteRepository.GetAllPeople();
            modelBuilder.Entity<Person>().HasData(remotePeople.ToArray());

            IList<Specie> remoteSpecies = remoteRepository.GetAllSpecies();
            modelBuilder.Entity<Specie>().HasData(remoteSpecies.ToArray());

            IList<Vehicle> remoteVehicles = remoteRepository.GetAllVehicles();
            modelBuilder.Entity<Vehicle>().HasData(remoteVehicles.ToArray());

            IList<StarShip> remoteStarships = remoteRepository.GetAllStarships();
            modelBuilder.Entity<StarShip>().HasData(remoteStarships.ToArray());

            foreach (var movie in remoteMovies)
            {
                foreach (var planet in remotePlanets)
                {
                    if (movie.PlanetUris.Contains(planet.Uri))
                    {
                        modelBuilder.Entity<MoviePlanet>().HasData(new MoviePlanet()
                            {MovieUri = movie.Uri, PlanetUri = planet.Uri});
                    }
                }

                foreach (var person in remotePeople)
                {
                    if (movie.CharacterUris.Contains(person.Uri))
                    {
                        modelBuilder.Entity<MovieCharacter>().HasData(new MovieCharacter()
                            {MovieUri = movie.Uri, PersonUri = person.Uri});
                    }
                }

                foreach (var starShip in remoteStarships)
                {
                    if (movie.StarshipUris.Contains(starShip.Uri))
                    {
                        modelBuilder.Entity<StarshipMovie>().HasData(new StarshipMovie()
                            {MovieUri = movie.Uri, StarshipUri = starShip.Uri});
                    }
                }

                foreach (var vehicle in remoteVehicles)
                {
                    if (movie.VehicleUris.Contains(vehicle.Uri))
                    {
                        modelBuilder.Entity<VehicleMovie>().HasData(new VehicleMovie()
                            {MovieUri = movie.Uri, VehicleUri = vehicle.Uri});
                    }
                }

                foreach (var specie in remoteSpecies)
                {
                    if (movie.SpeciesUri.Contains(specie.Uri))
                    {
                        modelBuilder.Entity<SpecieMovie>().HasData(new SpecieMovie()
                            {MovieUri = movie.Uri, SpecieUri = specie.Uri});
                    }
                }
            }

            foreach (var person in remotePeople)
            {
                foreach (var specie in remoteSpecies)
                {
                    if (specie.PeopleUris.Contains(person.Uri))
                    {
                        modelBuilder.Entity<PeopleSpecies>().HasData(new PeopleSpecies()
                            { PersonUri = person.Uri, SpecieUri = specie.Uri });
                    }
                }

                foreach (var vehicle in remoteVehicles)
                {
                    if (vehicle.PilotUris.Contains(person.Uri))
                    {
                        modelBuilder.Entity<PeopleVehicles>().HasData(new PeopleVehicles()
                            { PersonUri = person.Uri, VehicleUri = vehicle.Uri });
                    }
                }

                foreach (var starShip in remoteStarships)
                {
                    if (starShip.PilotUris.Contains(person.Uri))
                    {
                        modelBuilder.Entity<PeopleStarships>().HasData(new PeopleStarships()
                            { PersonUri = person.Uri, StarShipUri = starShip.Uri });
                    }
                }
            }
        }
    }
}