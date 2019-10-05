using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarWarsUniverse.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Planets",
                columns: table => new
                {
                    Uri = table.Column<string>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    Edited = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    RotationPeriod = table.Column<string>(nullable: true),
                    OrbitalPeriod = table.Column<string>(nullable: true),
                    Diameter = table.Column<string>(nullable: true),
                    Climate = table.Column<string>(nullable: true),
                    Gravity = table.Column<string>(nullable: true),
                    Terrain = table.Column<string>(nullable: true),
                    SurfaceWater = table.Column<string>(nullable: true),
                    Population = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planets", x => x.Uri);
                });

            migrationBuilder.CreateTable(
                name: "StarShip",
                columns: table => new
                {
                    Uri = table.Column<string>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    Edited = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    CostInCredits = table.Column<string>(nullable: true),
                    Length = table.Column<string>(nullable: true),
                    MaxAtmospheringSpeed = table.Column<string>(nullable: true),
                    Crew = table.Column<string>(nullable: true),
                    Passengers = table.Column<string>(nullable: true),
                    CargoCapacity = table.Column<string>(nullable: true),
                    Consumables = table.Column<string>(nullable: true),
                    HyperdriveRating = table.Column<string>(nullable: true),
                    MGLT = table.Column<string>(nullable: true),
                    StarshipClass = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StarShip", x => x.Uri);
                });

            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    Uri = table.Column<string>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    Edited = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    CostInCredits = table.Column<string>(nullable: true),
                    Length = table.Column<string>(nullable: true),
                    MaxAtmospheringSpeed = table.Column<string>(nullable: true),
                    Crew = table.Column<string>(nullable: true),
                    Passengers = table.Column<string>(nullable: true),
                    CargoCapacity = table.Column<string>(nullable: true),
                    VehicleClass = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.Uri);
                });

            migrationBuilder.CreateTable(
                name: "Specie",
                columns: table => new
                {
                    Uri = table.Column<string>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    Edited = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Designation = table.Column<string>(nullable: true),
                    AverageHeight = table.Column<string>(nullable: true),
                    SkinColors = table.Column<string>(nullable: true),
                    HairColors = table.Column<string>(nullable: true),
                    EyeColors = table.Column<string>(nullable: true),
                    AverageLifespan = table.Column<string>(nullable: true),
                    HomeworldUri1 = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specie", x => x.Uri);
                    table.ForeignKey(
                        name: "FK_Specie_Planets_HomeworldUri1",
                        column: x => x.HomeworldUri1,
                        principalTable: "Planets",
                        principalColumn: "Uri",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Uri = table.Column<string>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    Edited = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    EpisodeId = table.Column<int>(nullable: false),
                    OpeningCrawl = table.Column<string>(nullable: true),
                    Director = table.Column<string>(nullable: true),
                    Producer = table.Column<string>(nullable: true),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    SpecieUri = table.Column<string>(nullable: true),
                    StarShipUri = table.Column<string>(nullable: true),
                    VehicleUri = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Uri);
                    table.ForeignKey(
                        name: "FK_Movies_Specie_SpecieUri",
                        column: x => x.SpecieUri,
                        principalTable: "Specie",
                        principalColumn: "Uri",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Movies_StarShip_StarShipUri",
                        column: x => x.StarShipUri,
                        principalTable: "StarShip",
                        principalColumn: "Uri",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Movies_Vehicle_VehicleUri",
                        column: x => x.VehicleUri,
                        principalTable: "Vehicle",
                        principalColumn: "Uri",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Uri = table.Column<string>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    Edited = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Height = table.Column<string>(nullable: true),
                    Mass = table.Column<string>(nullable: true),
                    HairColor = table.Column<string>(nullable: true),
                    SkinColor = table.Column<string>(nullable: true),
                    EyeColor = table.Column<string>(nullable: true),
                    BirthYear = table.Column<string>(nullable: true),
                    HomeWorldUri = table.Column<string>(nullable: true),
                    SpecieUri = table.Column<string>(nullable: true),
                    StarShipUri = table.Column<string>(nullable: true),
                    VehicleUri = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Uri);
                    table.ForeignKey(
                        name: "FK_People_Planets_HomeWorldUri",
                        column: x => x.HomeWorldUri,
                        principalTable: "Planets",
                        principalColumn: "Uri",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_People_Specie_SpecieUri",
                        column: x => x.SpecieUri,
                        principalTable: "Specie",
                        principalColumn: "Uri",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_People_StarShip_StarShipUri",
                        column: x => x.StarShipUri,
                        principalTable: "StarShip",
                        principalColumn: "Uri",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_People_Vehicle_VehicleUri",
                        column: x => x.VehicleUri,
                        principalTable: "Vehicle",
                        principalColumn: "Uri",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MoviePlanet",
                columns: table => new
                {
                    MovieUri = table.Column<string>(nullable: false),
                    PlanetUri = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoviePlanet", x => new { x.MovieUri, x.PlanetUri });
                    table.ForeignKey(
                        name: "FK_MoviePlanet_Movies_MovieUri",
                        column: x => x.MovieUri,
                        principalTable: "Movies",
                        principalColumn: "Uri",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MoviePlanet_Planets_PlanetUri",
                        column: x => x.PlanetUri,
                        principalTable: "Planets",
                        principalColumn: "Uri",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpecieMovie",
                columns: table => new
                {
                    MovieUri = table.Column<string>(nullable: false),
                    SpecieUri = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecieMovie", x => new { x.MovieUri, x.SpecieUri });
                    table.ForeignKey(
                        name: "FK_SpecieMovie_Movies_MovieUri",
                        column: x => x.MovieUri,
                        principalTable: "Movies",
                        principalColumn: "Uri",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpecieMovie_Specie_SpecieUri",
                        column: x => x.SpecieUri,
                        principalTable: "Specie",
                        principalColumn: "Uri",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StarshipMovie",
                columns: table => new
                {
                    MovieUri = table.Column<string>(nullable: false),
                    StarshipUri = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StarshipMovie", x => new { x.MovieUri, x.StarshipUri });
                    table.ForeignKey(
                        name: "FK_StarshipMovie_Movies_MovieUri",
                        column: x => x.MovieUri,
                        principalTable: "Movies",
                        principalColumn: "Uri",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StarshipMovie_StarShip_StarshipUri",
                        column: x => x.StarshipUri,
                        principalTable: "StarShip",
                        principalColumn: "Uri",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VehicleMovie",
                columns: table => new
                {
                    MovieUri = table.Column<string>(nullable: false),
                    VehicleUri = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleMovie", x => new { x.MovieUri, x.VehicleUri });
                    table.ForeignKey(
                        name: "FK_VehicleMovie_Movies_MovieUri",
                        column: x => x.MovieUri,
                        principalTable: "Movies",
                        principalColumn: "Uri",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VehicleMovie_Vehicle_VehicleUri",
                        column: x => x.VehicleUri,
                        principalTable: "Vehicle",
                        principalColumn: "Uri",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieCharacter",
                columns: table => new
                {
                    MovieUri = table.Column<string>(nullable: false),
                    PersonUri = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieCharacter", x => new { x.MovieUri, x.PersonUri });
                    table.ForeignKey(
                        name: "FK_MovieCharacter_Movies_MovieUri",
                        column: x => x.MovieUri,
                        principalTable: "Movies",
                        principalColumn: "Uri",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieCharacter_People_PersonUri",
                        column: x => x.PersonUri,
                        principalTable: "People",
                        principalColumn: "Uri",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PeopleSpecies",
                columns: table => new
                {
                    PersonUri = table.Column<string>(nullable: false),
                    SpecieUri = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeopleSpecies", x => new { x.PersonUri, x.SpecieUri });
                    table.ForeignKey(
                        name: "FK_PeopleSpecies_People_PersonUri",
                        column: x => x.PersonUri,
                        principalTable: "People",
                        principalColumn: "Uri",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PeopleSpecies_Specie_SpecieUri",
                        column: x => x.SpecieUri,
                        principalTable: "Specie",
                        principalColumn: "Uri",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PeopleStarships",
                columns: table => new
                {
                    PersonUri = table.Column<string>(nullable: false),
                    StarShipUri = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeopleStarships", x => new { x.PersonUri, x.StarShipUri });
                    table.ForeignKey(
                        name: "FK_PeopleStarships_People_PersonUri",
                        column: x => x.PersonUri,
                        principalTable: "People",
                        principalColumn: "Uri",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PeopleStarships_StarShip_StarShipUri",
                        column: x => x.StarShipUri,
                        principalTable: "StarShip",
                        principalColumn: "Uri",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PeopleVehicles",
                columns: table => new
                {
                    PersonUri = table.Column<string>(nullable: false),
                    VehicleUri = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeopleVehicles", x => new { x.PersonUri, x.VehicleUri });
                    table.ForeignKey(
                        name: "FK_PeopleVehicles_People_PersonUri",
                        column: x => x.PersonUri,
                        principalTable: "People",
                        principalColumn: "Uri",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PeopleVehicles_Vehicle_VehicleUri",
                        column: x => x.VehicleUri,
                        principalTable: "Vehicle",
                        principalColumn: "Uri",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Uri", "Created", "Director", "Edited", "EpisodeId", "OpeningCrawl", "Producer", "ReleaseDate", "SpecieUri", "StarShipUri", "Title", "VehicleUri" },
                values: new object[,]
                {
                    { "https://swapi.co/api/films/1/", new DateTime(2014, 12, 10, 14, 23, 31, 880, DateTimeKind.Utc), "George Lucas", new DateTime(2015, 4, 11, 9, 46, 52, 774, DateTimeKind.Utc).AddTicks(8970), 4, @"It is a period of civil war.
                Rebel spaceships, striking
                from a hidden base, have won
                their first victory against
                the evil Galactic Empire.

                During the battle, Rebel
                spies managed to steal secret
                plans to the Empire's
                ultimate weapon, the DEATH
                STAR, an armored space
                station with enough power
                to destroy an entire planet.

                Pursued by the Empire's
                sinister agents, Princess
                Leia races home aboard her
                starship, custodian of the
                stolen plans that can save her
                people and restore
                freedom to the galaxy....", "Gary Kurtz, Rick McCallum", new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "A New Hope", null },
                    { "https://swapi.co/api/films/5/", new DateTime(2014, 12, 20, 10, 57, 57, 886, DateTimeKind.Utc), "George Lucas", new DateTime(2015, 4, 11, 9, 45, 1, 623, DateTimeKind.Utc).AddTicks(9820), 2, @"There is unrest in the Galactic
                Senate. Several thousand solar
                systems have declared their
                intentions to leave the Republic.

                This separatist movement,
                under the leadership of the
                mysterious Count Dooku, has
                made it difficult for the limited
                number of Jedi Knights to maintain 
                peace and order in the galaxy.

                Senator Amidala, the former
                Queen of Naboo, is returning
                to the Galactic Senate to vote
                on the critical issue of creating
                an ARMY OF THE REPUBLIC
                to assist the overwhelmed
                Jedi....", "Rick McCallum", new DateTime(2002, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Attack of the Clones", null },
                    { "https://swapi.co/api/films/4/", new DateTime(2014, 12, 19, 16, 52, 55, 740, DateTimeKind.Utc), "George Lucas", new DateTime(2015, 4, 11, 9, 45, 18, 689, DateTimeKind.Utc).AddTicks(3010), 1, @"Turmoil has engulfed the
                Galactic Republic. The taxation
                of trade routes to outlying star
                systems is in dispute.

                Hoping to resolve the matter
                with a blockade of deadly
                battleships, the greedy Trade
                Federation has stopped all
                shipping to the small planet
                of Naboo.

                While the Congress of the
                Republic endlessly debates
                this alarming chain of events,
                the Supreme Chancellor has
                secretly dispatched two Jedi
                Knights, the guardians of
                peace and justice in the
                galaxy, to settle the conflict....", "Rick McCallum", new DateTime(1999, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "The Phantom Menace", null },
                    { "https://swapi.co/api/films/6/", new DateTime(2014, 12, 20, 18, 49, 38, 403, DateTimeKind.Utc), "George Lucas", new DateTime(2015, 4, 11, 9, 45, 44, 862, DateTimeKind.Utc).AddTicks(1220), 3, @"War! The Republic is crumbling
                under attacks by the ruthless
                Sith Lord, Count Dooku.
                There are heroes on both sides.
                Evil is everywhere.

                In a stunning move, the
                fiendish droid leader, General
                Grievous, has swept into the
                Republic capital and kidnapped
                Chancellor Palpatine, leader of
                the Galactic Senate.

                As the Separatist Droid Army
                attempts to flee the besieged
                capital with their valuable
                hostage, two Jedi Knights lead a
                desperate mission to rescue the
                captive Chancellor....", "Rick McCallum", new DateTime(2005, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Revenge of the Sith", null },
                    { "https://swapi.co/api/films/3/", new DateTime(2014, 12, 18, 10, 39, 33, 255, DateTimeKind.Utc), "Richard Marquand", new DateTime(2015, 4, 11, 9, 46, 5, 220, DateTimeKind.Utc).AddTicks(3650), 6, @"Luke Skywalker has returned to
                his home planet of Tatooine in
                an attempt to rescue his
                friend Han Solo from the
                clutches of the vile gangster
                Jabba the Hutt.

                Little does Luke know that the
                GALACTIC EMPIRE has secretly
                begun construction on a new
                armored space station even
                more powerful than the first
                dreaded Death Star.

                When completed, this ultimate
                weapon will spell certain doom
                for the small band of rebels
                struggling to restore freedom
                to the galaxy...", "Howard G. Kazanjian, George Lucas, Rick McCallum", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Return of the Jedi", null },
                    { "https://swapi.co/api/films/2/", new DateTime(2014, 12, 12, 11, 26, 24, 656, DateTimeKind.Utc), "Irvin Kershner", new DateTime(2017, 4, 19, 10, 57, 29, 544, DateTimeKind.Utc).AddTicks(2560), 5, @"It is a dark time for the
                Rebellion. Although the Death
                Star has been destroyed,
                Imperial troops have driven the
                Rebel forces from their hidden
                base and pursued them across
                the galaxy.

                Evading the dreaded Imperial
                Starfleet, a group of freedom
                fighters led by Luke Skywalker
                has established a new secret
                base on the remote ice world
                of Hoth.

                The evil lord Darth Vader,
                obsessed with finding young
                Skywalker, has dispatched
                thousands of remote probes into
                the far reaches of space....", "Gary Kurtz, Rick McCallum", new DateTime(1980, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "The Empire Strikes Back", null },
                    { "https://swapi.co/api/films/7/", new DateTime(2015, 4, 17, 6, 51, 30, 504, DateTimeKind.Utc).AddTicks(7800), "J. J. Abrams", new DateTime(2015, 12, 17, 14, 31, 47, 617, DateTimeKind.Utc).AddTicks(7680), 7, @"Luke Skywalker has vanished.
                In his absence, the sinister
                FIRST ORDER has risen from
                the ashes of the Empire
                and will not rest until
                Skywalker, the last Jedi,
                has been destroyed.
                 
                With the support of the
                REPUBLIC, General Leia Organa
                leads a brave RESISTANCE.
                She is desperate to find her
                brother Luke and gain his
                help in restoring peace and
                justice to the galaxy.
                 
                Leia has sent her most daring
                pilot on a secret mission
                to Jakku, where an old ally
                has discovered a clue to
                Luke's whereabouts....", "Kathleen Kennedy, J. J. Abrams, Bryan Burk", new DateTime(2015, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "The Force Awakens", null }
                });

            migrationBuilder.InsertData(
                table: "Planets",
                columns: new[] { "Uri", "Climate", "Created", "Diameter", "Edited", "Gravity", "Name", "OrbitalPeriod", "Population", "RotationPeriod", "SurfaceWater", "Terrain" },
                values: new object[,]
                {
                    { "https://swapi.co/api/planets/17/", "hot, humid", new DateTime(2014, 12, 10, 13, 44, 50, 397, DateTimeKind.Utc), "9100", new DateTime(2014, 12, 20, 20, 58, 18, 447, DateTimeKind.Utc), "0.75 standard", "Felucia", "231", "8500000", "34", "unknown", "fungus forests" },
                    { "https://swapi.co/api/planets/18/", "temperate, moist", new DateTime(2014, 12, 10, 13, 46, 28, 704, DateTimeKind.Utc), "0", new DateTime(2014, 12, 20, 20, 58, 18, 449, DateTimeKind.Utc), "1 standard", "Cato Neimoidia", "278", "10000000", "25", "unknown", "mountains, fields, forests, rock arches" },
                    { "https://swapi.co/api/planets/19/", "hot", new DateTime(2014, 12, 10, 13, 47, 46, 874, DateTimeKind.Utc), "14920", new DateTime(2014, 12, 20, 20, 58, 18, 450, DateTimeKind.Utc), "unknown", "Saleucami", "392", "1400000000", "26", "unknown", "caves, desert, mountains, volcanoes" },
                    { "https://swapi.co/api/planets/20/", "temperate", new DateTime(2014, 12, 10, 16, 16, 26, 566, DateTimeKind.Utc), "0", new DateTime(2014, 12, 20, 20, 58, 18, 452, DateTimeKind.Utc), "1 standard", "Stewjon", "unknown", "unknown", "unknown", "unknown", "grass" },
                    { "https://swapi.co/api/planets/21/", "polluted", new DateTime(2014, 12, 10, 16, 26, 54, 384, DateTimeKind.Utc), "13490", new DateTime(2014, 12, 20, 20, 58, 18, 454, DateTimeKind.Utc), "1 standard", "Eriadu", "360", "22000000000", "24", "unknown", "cityscape" },
                    { "https://swapi.co/api/planets/24/", "temperate", new DateTime(2014, 12, 10, 17, 11, 29, 452, DateTimeKind.Utc), "12150", new DateTime(2014, 12, 20, 20, 58, 18, 460, DateTimeKind.Utc), "1 standard", "Nal Hutta", "413", "7000000000", "87", "unknown", "urban, oceans, swamps, bogs" },
                    { "https://swapi.co/api/planets/23/", "hot", new DateTime(2014, 12, 10, 17, 3, 28, 110, DateTimeKind.Utc), "7549", new DateTime(2014, 12, 20, 20, 58, 18, 458, DateTimeKind.Utc), "1 standard", "Rodia", "305", "1300000000", "29", "60", "jungles, oceans, urban, swamps" },
                    { "https://swapi.co/api/planets/16/", "frigid", new DateTime(2014, 12, 10, 13, 43, 39, 139, DateTimeKind.Utc), "10088", new DateTime(2014, 12, 20, 20, 58, 18, 446, DateTimeKind.Utc), "1 standard", "Mygeeto", "167", "19000000", "12", "unknown", "glaciers, mountains, ice canyons" },
                    { "https://swapi.co/api/planets/25/", "temperate", new DateTime(2014, 12, 10, 17, 23, 29, 896, DateTimeKind.Utc), "9830", new DateTime(2014, 12, 20, 20, 58, 18, 461, DateTimeKind.Utc), "1 standard", "Dantooine", "378", "1000", "25", "unknown", "oceans, savannas, mountains, grasslands" },
                    { "https://swapi.co/api/planets/26/", "temperate", new DateTime(2014, 12, 12, 11, 16, 55, 78, DateTimeKind.Utc), "6400", new DateTime(2014, 12, 20, 20, 58, 18, 463, DateTimeKind.Utc), "unknown", "Bestine IV", "680", "62000000", "26", "98", "rocky islands, oceans" },
                    { "https://swapi.co/api/planets/22/", "temperate", new DateTime(2014, 12, 10, 16, 49, 12, 453, DateTimeKind.Utc), "11000", new DateTime(2014, 12, 20, 20, 58, 18, 456, DateTimeKind.Utc), "1 standard", "Corellia", "329", "3000000000", "25", "70", "plains, urban, hills, forests" },
                    { "https://swapi.co/api/planets/15/", "artificial temperate ", new DateTime(2014, 12, 10, 13, 33, 46, 405, DateTimeKind.Utc), "0", new DateTime(2014, 12, 20, 20, 58, 18, 444, DateTimeKind.Utc), "0.56 standard", "Polis Massa", "590", "1000000", "24", "0", "airless asteroid" },
                    { "https://swapi.co/api/planets/11/", "temperate, arid", new DateTime(2014, 12, 10, 12, 47, 22, 350, DateTimeKind.Utc), "11370", new DateTime(2014, 12, 20, 20, 58, 18, 437, DateTimeKind.Utc), "0.9 standard", "Geonosis", "256", "100000000000", "30", "5", "rock, desert, mountain, barren" },
                    { "https://swapi.co/api/planets/13/", "hot", new DateTime(2014, 12, 10, 12, 50, 16, 526, DateTimeKind.Utc), "4200", new DateTime(2014, 12, 20, 20, 58, 18, 440, DateTimeKind.Utc), "1 standard", "Mustafar", "412", "20000", "36", "0", "volcanoes, lava rivers, mountains, caves" },
                    { "https://swapi.co/api/planets/12/", "temperate, arid, windy", new DateTime(2014, 12, 10, 12, 49, 1, 491, DateTimeKind.Utc), "12900", new DateTime(2014, 12, 20, 20, 58, 18, 439, DateTimeKind.Utc), "1 standard", "Utapau", "351", "95000000", "27", "0.9", "scrublands, savanna, canyons, sinkholes" },
                    { "https://swapi.co/api/planets/27/", "temperate", new DateTime(2014, 12, 15, 12, 23, 41, 661, DateTimeKind.Utc), "14050", new DateTime(2014, 12, 20, 20, 58, 18, 464, DateTimeKind.Utc), "1 standard", "Ord Mantell", "334", "4000000000", "26", "10", "plains, seas, mesas" },
                    { "https://swapi.co/api/planets/10/", "temperate", new DateTime(2014, 12, 10, 12, 45, 6, 577, DateTimeKind.Utc), "19720", new DateTime(2014, 12, 20, 20, 58, 18, 434, DateTimeKind.Utc), "1 standard", "Kamino", "463", "1000000000", "27", "100", "ocean" },
                    { "https://swapi.co/api/planets/9/", "temperate", new DateTime(2014, 12, 10, 11, 54, 13, 921, DateTimeKind.Utc), "12240", new DateTime(2014, 12, 20, 20, 58, 18, 432, DateTimeKind.Utc), "1 standard", "Coruscant", "368", "1000000000000", "24", "unknown", "cityscape, mountains" },
                    { "https://swapi.co/api/planets/8/", "temperate", new DateTime(2014, 12, 10, 11, 52, 31, 66, DateTimeKind.Utc), "12120", new DateTime(2014, 12, 20, 20, 58, 18, 430, DateTimeKind.Utc), "1 standard", "Naboo", "312", "4500000000", "26", "12", "grassy hills, swamps, forests, mountains" },
                    { "https://swapi.co/api/planets/7/", "temperate", new DateTime(2014, 12, 10, 11, 50, 29, 349, DateTimeKind.Utc), "4900", new DateTime(2014, 12, 20, 20, 58, 18, 429, DateTimeKind.Utc), "0.85 standard", "Endor", "402", "30000000", "18", "8", "forests, mountains, lakes" },
                    { "https://swapi.co/api/planets/6/", "temperate", new DateTime(2014, 12, 10, 11, 43, 55, 240, DateTimeKind.Utc), "118000", new DateTime(2014, 12, 20, 20, 58, 18, 427, DateTimeKind.Utc), "1.5 (surface), 1 standard (Cloud City)", "Bespin", "5110", "6000000", "12", "0", "gas giant" },
                    { "https://swapi.co/api/planets/5/", "murky", new DateTime(2014, 12, 10, 11, 42, 22, 590, DateTimeKind.Utc), "8900", new DateTime(2014, 12, 20, 20, 58, 18, 425, DateTimeKind.Utc), "N/A", "Dagobah", "341", "unknown", "23", "8", "swamp, jungles" },
                    { "https://swapi.co/api/planets/4/", "frozen", new DateTime(2014, 12, 10, 11, 39, 13, 934, DateTimeKind.Utc), "7200", new DateTime(2014, 12, 20, 20, 58, 18, 423, DateTimeKind.Utc), "1.1 standard", "Hoth", "549", "unknown", "23", "100", "tundra, ice caves, mountain ranges" },
                    { "https://swapi.co/api/planets/3/", "temperate, tropical", new DateTime(2014, 12, 10, 11, 37, 19, 144, DateTimeKind.Utc), "10200", new DateTime(2014, 12, 20, 20, 58, 18, 421, DateTimeKind.Utc), "1 standard", "Yavin IV", "4818", "1000", "24", "8", "jungle, rainforests" },
                    { "https://swapi.co/api/planets/2/", "temperate", new DateTime(2014, 12, 10, 11, 35, 48, 479, DateTimeKind.Utc), "12500", new DateTime(2014, 12, 20, 20, 58, 18, 420, DateTimeKind.Utc), "1 standard", "Alderaan", "364", "2000000000", "24", "40", "grasslands, mountains" },
                    { "https://swapi.co/api/planets/14/", "tropical", new DateTime(2014, 12, 10, 13, 32, 0, 124, DateTimeKind.Utc), "12765", new DateTime(2014, 12, 20, 20, 58, 18, 442, DateTimeKind.Utc), "1 standard", "Kashyyyk", "381", "45000000", "26", "60", "jungle, forests, lakes, rivers" },
                    { "https://swapi.co/api/planets/61/", "unknown", new DateTime(2015, 4, 17, 6, 55, 57, 556, DateTimeKind.Utc).AddTicks(4950), "unknown", new DateTime(2015, 4, 17, 6, 55, 57, 556, DateTimeKind.Utc).AddTicks(5510), "unknown", "Jakku", "unknown", "unknown", "unknown", "unknown", "deserts" },
                    { "https://swapi.co/api/planets/28/", "unknown", new DateTime(2014, 12, 15, 12, 25, 59, 569, DateTimeKind.Utc), "0", new DateTime(2014, 12, 20, 20, 58, 18, 466, DateTimeKind.Utc), "unknown", "unknown", "0", "unknown", "0", "unknown", "unknown" },
                    { "https://swapi.co/api/planets/30/", "arid", new DateTime(2014, 12, 15, 12, 56, 31, 121, DateTimeKind.Utc), "0", new DateTime(2014, 12, 20, 20, 58, 18, 469, DateTimeKind.Utc), "1 standard", "Socorro", "326", "300000000", "20", "unknown", "deserts, mountains" },
                    { "https://swapi.co/api/planets/60/", "unknown", new DateTime(2014, 12, 20, 20, 18, 36, 256, DateTimeKind.Utc), "unknown", new DateTime(2014, 12, 20, 20, 58, 18, 525, DateTimeKind.Utc), "unknown", "Umbara", "unknown", "unknown", "unknown", "unknown", "unknown" },
                    { "https://swapi.co/api/planets/59/", "arid, temperate, tropical", new DateTime(2014, 12, 20, 19, 43, 51, 278, DateTimeKind.Utc), "13850", new DateTime(2014, 12, 20, 20, 58, 18, 523, DateTimeKind.Utc), "1", "Kalee", "378", "4000000000", "23", "unknown", "rainforests, cliffs, canyons, seas" },
                    { "https://swapi.co/api/planets/58/", "temperate", new DateTime(2014, 12, 20, 18, 43, 14, 49, DateTimeKind.Utc), "unknown", new DateTime(2014, 12, 20, 20, 58, 18, 521, DateTimeKind.Utc), "1", "Shili", "unknown", "unknown", "unknown", "unknown", "cities, savannahs, seas, plains" },
                    { "https://swapi.co/api/planets/57/", "temperate", new DateTime(2014, 12, 20, 17, 57, 47, 420, DateTimeKind.Utc), "13800", new DateTime(2014, 12, 20, 20, 58, 18, 519, DateTimeKind.Utc), "1", "Muunilinst", "412", "5000000000", "28", "25", "plains, forests, hills, mountains" },
                    { "https://swapi.co/api/planets/56/", "temperate", new DateTime(2014, 12, 20, 17, 50, 47, 864, DateTimeKind.Utc), "unknown", new DateTime(2014, 12, 20, 20, 58, 18, 517, DateTimeKind.Utc), "1", "Skako", "384", "500000000000", "27", "unknown", "urban, vines" },
                    { "https://swapi.co/api/planets/55/", "frigid", new DateTime(2014, 12, 20, 17, 27, 41, 286, DateTimeKind.Utc), "unknown", new DateTime(2014, 12, 20, 20, 58, 18, 516, DateTimeKind.Utc), "unknown", "Ojom", "unknown", "500000000", "unknown", "100", "oceans, glaciers" },
                    { "https://swapi.co/api/planets/54/", "unknown", new DateTime(2014, 12, 20, 16, 56, 37, 250, DateTimeKind.Utc), "unknown", new DateTime(2014, 12, 20, 20, 58, 18, 514, DateTimeKind.Utc), "unknown", "Zolan", "unknown", "unknown", "unknown", "unknown", "unknown" },
                    { "https://swapi.co/api/planets/53/", "unknown", new DateTime(2014, 12, 20, 16, 54, 39, 909, DateTimeKind.Utc), "unknown", new DateTime(2014, 12, 20, 20, 58, 18, 512, DateTimeKind.Utc), "unknown", "Concord Dawn", "unknown", "unknown", "unknown", "unknown", "jungles, forests, deserts" },
                    { "https://swapi.co/api/planets/52/", "unknown", new DateTime(2014, 12, 20, 16, 52, 13, 357, DateTimeKind.Utc), "unknown", new DateTime(2014, 12, 20, 20, 58, 18, 510, DateTimeKind.Utc), "unknown", "Serenno", "unknown", "unknown", "unknown", "unknown", "rainforests, rivers, mountains" },
                    { "https://swapi.co/api/planets/51/", "unknown", new DateTime(2014, 12, 20, 16, 44, 46, 318, DateTimeKind.Utc), "unknown", new DateTime(2014, 12, 20, 20, 58, 18, 508, DateTimeKind.Utc), "unknown", "Mirial", "unknown", "unknown", "unknown", "unknown", "deserts" },
                    { "https://swapi.co/api/planets/50/", "temperate", new DateTime(2014, 12, 20, 10, 52, 51, 524, DateTimeKind.Utc), "unknown", new DateTime(2014, 12, 20, 20, 58, 18, 506, DateTimeKind.Utc), "1", "Champala", "318", "3500000000", "27", "unknown", "oceans, rainforests, plateaus" },
                    { "https://swapi.co/api/planets/49/", "temperate", new DateTime(2014, 12, 20, 10, 48, 36, 141, DateTimeKind.Utc), "13400", new DateTime(2014, 12, 20, 20, 58, 18, 504, DateTimeKind.Utc), "1", "Dorin", "409", "unknown", "22", "unknown", "unknown" },
                    { "https://swapi.co/api/planets/48/", "unknown", new DateTime(2014, 12, 20, 10, 34, 8, 249, DateTimeKind.Utc), "unknown", new DateTime(2014, 12, 20, 20, 58, 18, 502, DateTimeKind.Utc), "unknown", "Quermia", "unknown", "unknown", "unknown", "unknown", "unknown" },
                    { "https://swapi.co/api/planets/47/", "arid, rocky, windy", new DateTime(2014, 12, 20, 10, 31, 32, 413, DateTimeKind.Utc), "unknown", new DateTime(2014, 12, 20, 20, 58, 18, 500, DateTimeKind.Utc), "1", "Iktotch", "481", "unknown", "22", "unknown", "rocky" },
                    { "https://swapi.co/api/planets/29/", "arid", new DateTime(2014, 12, 15, 12, 53, 47, 695, DateTimeKind.Utc), "0", new DateTime(2014, 12, 20, 20, 58, 18, 468, DateTimeKind.Utc), "0.62 standard", "Trandosha", "371", "42000000", "25", "unknown", "mountains, seas, grasslands, deserts" },
                    { "https://swapi.co/api/planets/46/", "unknown", new DateTime(2014, 12, 20, 10, 28, 31, 117, DateTimeKind.Utc), "unknown", new DateTime(2014, 12, 20, 20, 58, 18, 498, DateTimeKind.Utc), "unknown", "Tholoth", "unknown", "unknown", "unknown", "unknown", "unknown" },
                    { "https://swapi.co/api/planets/44/", "tropical, temperate", new DateTime(2014, 12, 20, 10, 18, 26, 110, DateTimeKind.Utc), "15600", new DateTime(2014, 12, 20, 20, 58, 18, 495, DateTimeKind.Utc), "1", "Glee Anselm", "206", "500000000", "33", "80", "lakes, islands, swamps, seas" },
                    { "https://swapi.co/api/planets/43/", "temperate", new DateTime(2014, 12, 20, 10, 14, 48, 178, DateTimeKind.Utc), "unknown", new DateTime(2014, 12, 20, 20, 58, 18, 493, DateTimeKind.Utc), "1", "Cerea", "386", "450000000", "27", "20", "verdant" },
                    { "https://swapi.co/api/planets/42/", "temperate", new DateTime(2014, 12, 20, 10, 12, 28, 980, DateTimeKind.Utc), "10120", new DateTime(2014, 12, 20, 20, 58, 18, 491, DateTimeKind.Utc), "0.98", "Haruun Kal", "383", "705300", "25", "unknown", "toxic cloudsea, plateaus, volcanoes" },
                    { "https://swapi.co/api/planets/41/", "unknown", new DateTime(2014, 12, 20, 10, 7, 29, 578, DateTimeKind.Utc), "12190", new DateTime(2014, 12, 20, 20, 58, 18, 489, DateTimeKind.Utc), "unknown", "Tund", "1770", "0", "48", "unknown", "barren, ash" },
                    { "https://swapi.co/api/planets/40/", "unknown", new DateTime(2014, 12, 20, 10, 1, 37, 395, DateTimeKind.Utc), "unknown", new DateTime(2014, 12, 20, 20, 58, 18, 487, DateTimeKind.Utc), "unknown", "Troiken", "unknown", "unknown", "unknown", "unknown", "desert, tundra, rainforests, mountains" },
                    { "https://swapi.co/api/planets/39/", "temperate, artic", new DateTime(2014, 12, 20, 9, 56, 58, 874, DateTimeKind.Utc), "14900", new DateTime(2014, 12, 20, 20, 58, 18, 485, DateTimeKind.Utc), "1", "Vulpter", "391", "421000000", "22", "unknown", "urban, barren" },
                    { "https://swapi.co/api/planets/38/", "unknown", new DateTime(2014, 12, 20, 9, 52, 23, 452, DateTimeKind.Utc), "unknown", new DateTime(2014, 12, 20, 20, 58, 18, 483, DateTimeKind.Utc), "unknown", "Aleen Minor", "unknown", "unknown", "unknown", "unknown", "unknown" },
                    { "https://swapi.co/api/planets/37/", "temperate, arid, subartic", new DateTime(2014, 12, 20, 9, 46, 25, 740, DateTimeKind.Utc), "10600", new DateTime(2014, 12, 20, 20, 58, 18, 481, DateTimeKind.Utc), "1", "Ryloth", "305", "1500000000", "30", "5", "mountains, valleys, deserts, tundra" },
                    { "https://swapi.co/api/planets/36/", "temperate", new DateTime(2014, 12, 19, 18, 0, 40, 142, DateTimeKind.Utc), "10480", new DateTime(2014, 12, 20, 20, 58, 18, 480, DateTimeKind.Utc), "0.9", "Dathomir", "491", "5200", "24", "unknown", "forests, deserts, savannas" },
                    { "https://swapi.co/api/planets/35/", "arid, temperate, tropical", new DateTime(2014, 12, 19, 17, 52, 13, 106, DateTimeKind.Utc), "18880", new DateTime(2014, 12, 20, 20, 58, 18, 478, DateTimeKind.Utc), "1.56", "Malastare", "201", "2000000000", "26", "unknown", "swamps, deserts, jungles, mountains" },
                    { "https://swapi.co/api/planets/34/", "temperate", new DateTime(2014, 12, 19, 17, 47, 54, 403, DateTimeKind.Utc), "7900", new DateTime(2014, 12, 20, 20, 58, 18, 476, DateTimeKind.Utc), "1", "Toydaria", "184", "11000000", "21", "unknown", "swamps, lakes" },
                    { "https://swapi.co/api/planets/33/", "superheated", new DateTime(2014, 12, 18, 11, 25, 40, 243, DateTimeKind.Utc), "12780", new DateTime(2014, 12, 20, 20, 58, 18, 474, DateTimeKind.Utc), "1", "Sullust", "263", "18500000000", "20", "5", "mountains, volcanoes, rocky deserts" },
                    { "https://swapi.co/api/planets/32/", "temperate", new DateTime(2014, 12, 18, 11, 11, 51, 872, DateTimeKind.Utc), "13500", new DateTime(2014, 12, 20, 20, 58, 18, 472, DateTimeKind.Utc), "1", "Chandrila", "368", "1200000000", "20", "40", "plains, forests" },
                    { "https://swapi.co/api/planets/31/", "temperate", new DateTime(2014, 12, 18, 11, 7, 1, 792, DateTimeKind.Utc), "11030", new DateTime(2014, 12, 20, 20, 58, 18, 471, DateTimeKind.Utc), "1", "Mon Cala", "398", "27000000000", "21", "100", "oceans, reefs, islands" },
                    { "https://swapi.co/api/planets/45/", "unknown", new DateTime(2014, 12, 20, 10, 26, 5, 788, DateTimeKind.Utc), "unknown", new DateTime(2014, 12, 20, 20, 58, 18, 497, DateTimeKind.Utc), "unknown", "Iridonia", "413", "unknown", "29", "unknown", "rocky canyons, acid pools" },
                    { "https://swapi.co/api/planets/1/", "arid", new DateTime(2014, 12, 9, 13, 50, 49, 641, DateTimeKind.Utc), "10465", new DateTime(2014, 12, 21, 20, 48, 4, 175, DateTimeKind.Utc).AddTicks(7780), "1 standard", "Tatooine", "304", "200000", "23", "1", "desert" }
                });

            migrationBuilder.InsertData(
                table: "Specie",
                columns: new[] { "Uri", "AverageHeight", "AverageLifespan", "Created", "Designation", "Edited", "EyeColors", "HairColors", "HomeworldUri1", "Language", "Name", "SkinColors" },
                values: new object[,]
                {
                    { "https://swapi.co/api/species/5/", "300", "1000", new DateTime(2014, 12, 10, 17, 12, 50, 410, DateTimeKind.Utc), "sentient", new DateTime(2014, 12, 20, 21, 36, 42, 146, DateTimeKind.Utc), "yellow, red", "n/a", null, "Huttese", "Hutt", "green, brown, tan" },
                    { "https://swapi.co/api/species/32/", "220", "80", new DateTime(2014, 12, 20, 17, 31, 24, 838, DateTimeKind.Utc), "sentient", new DateTime(2014, 12, 20, 21, 36, 42, 202, DateTimeKind.Utc), "black", "none", null, "Kaminoan", "Kaminoan", "grey, blue" },
                    { "https://swapi.co/api/species/25/", "240", "86", new DateTime(2014, 12, 20, 10, 34, 50, 827, DateTimeKind.Utc), "sentient", new DateTime(2014, 12, 20, 21, 36, 42, 189, DateTimeKind.Utc), "yellow", "none", null, "Quermian", "Quermian", "white" },
                    { "https://swapi.co/api/species/27/", "190", "unknown", new DateTime(2014, 12, 20, 10, 53, 28, 795, DateTimeKind.Utc), "sentient", new DateTime(2014, 12, 20, 21, 36, 42, 193, DateTimeKind.Utc), "blue", "none", null, "Chagria", "Chagrian", "blue" },
                    { "https://swapi.co/api/species/28/", "178", "unknown", new DateTime(2014, 12, 20, 16, 40, 45, 618, DateTimeKind.Utc), "sentient", new DateTime(2014, 12, 20, 21, 36, 42, 195, DateTimeKind.Utc), "green, hazel", "none", null, "Geonosian", "Geonosian", "green, brown" },
                    { "https://swapi.co/api/species/29/", "180", "unknown", new DateTime(2014, 12, 20, 16, 46, 48, 290, DateTimeKind.Utc), "sentient", new DateTime(2014, 12, 20, 21, 36, 42, 197, DateTimeKind.Utc), "blue, green, red, yellow, brown, orange", "black, brown", null, "Mirialan", "Mirialan", "yellow, green" },
                    { "https://swapi.co/api/species/30/", "180", "70", new DateTime(2014, 12, 20, 16, 57, 46, 171, DateTimeKind.Utc), "sentient", new DateTime(2014, 12, 20, 21, 36, 42, 199, DateTimeKind.Utc), "yellow", "none", null, "Clawdite", "Clawdite", "green, yellow" },
                    { "https://swapi.co/api/species/31/", "178", "75", new DateTime(2014, 12, 20, 17, 28, 28, 821, DateTimeKind.Utc), "sentient", new DateTime(2014, 12, 20, 21, 36, 42, 200, DateTimeKind.Utc), "yellow", "none", null, "besalisk", "Besalisk", "brown" },
                    { "https://swapi.co/api/species/33/", "unknown", "unknown", new DateTime(2014, 12, 20, 17, 53, 54, 515, DateTimeKind.Utc), "sentient", new DateTime(2014, 12, 20, 21, 36, 42, 204, DateTimeKind.Utc), "unknown", "none", null, "Skakoan", "Skakoan", "grey, green" },
                    { "https://swapi.co/api/species/34/", "190", "100", new DateTime(2014, 12, 20, 17, 58, 19, 88, DateTimeKind.Utc), "sentient", new DateTime(2014, 12, 20, 21, 36, 42, 207, DateTimeKind.Utc), "black", "none", null, "Muun", "Muun", "grey, white" },
                    { "https://swapi.co/api/species/35/", "180", "94", new DateTime(2014, 12, 20, 18, 44, 3, 246, DateTimeKind.Utc), "sentient", new DateTime(2014, 12, 20, 21, 36, 42, 209, DateTimeKind.Utc), "red, orange, yellow, green, blue, black", "none", null, "Togruti", "Togruta", "red, white, orange, yellow, green, blue" },
                    { "https://swapi.co/api/species/36/", "170", "80", new DateTime(2014, 12, 20, 19, 45, 42, 537, DateTimeKind.Utc), "sentient", new DateTime(2014, 12, 20, 21, 36, 42, 210, DateTimeKind.Utc), "yellow", "none", null, "Kaleesh", "Kaleesh", "brown, orange, tan" },
                    { "https://swapi.co/api/species/37/", "190", "700", new DateTime(2014, 12, 20, 20, 35, 6, 777, DateTimeKind.Utc), "sentient", new DateTime(2014, 12, 20, 21, 36, 42, 212, DateTimeKind.Utc), "black", "none", null, "Utapese", "Pau'an", "grey" },
                    { "https://swapi.co/api/species/3/", "210", "400", new DateTime(2014, 12, 10, 16, 44, 31, 486, DateTimeKind.Utc), "sentient", new DateTime(2015, 1, 30, 21, 23, 3, 74, DateTimeKind.Utc).AddTicks(5980), "blue, green, yellow, brown, golden, red", "black, brown", null, "Shyriiwook", "Wookiee", "gray" },
                    { "https://swapi.co/api/species/2/", "n/a", "indefinite", new DateTime(2014, 12, 10, 15, 16, 16, 259, DateTimeKind.Utc), "sentient", new DateTime(2015, 4, 17, 6, 59, 43, 869, DateTimeKind.Utc).AddTicks(5280), "n/a", "n/a", null, "n/a", "Droid", "n/a" },
                    { "https://swapi.co/api/species/1/", "180", "120", new DateTime(2014, 12, 10, 13, 52, 11, 567, DateTimeKind.Utc), "sentient", new DateTime(2015, 4, 17, 6, 59, 55, 850, DateTimeKind.Utc).AddTicks(6710), "brown, blue, green, hazel, grey, amber", "blonde, brown, black, red", null, "Galactic Basic", "Human", "caucasian, black, asian, hispanic" },
                    { "https://swapi.co/api/species/4/", "170", "unknown", new DateTime(2014, 12, 10, 17, 5, 26, 471, DateTimeKind.Utc), "reptilian", new DateTime(2016, 7, 19, 13, 27, 3, 156, DateTimeKind.Utc).AddTicks(4980), "black", "n/a", null, "Galactic Basic", "Rodian", "green, blue" },
                    { "https://swapi.co/api/species/24/", "180", "unknown", new DateTime(2014, 12, 20, 10, 32, 13, 46, DateTimeKind.Utc), "sentient", new DateTime(2014, 12, 20, 21, 36, 42, 188, DateTimeKind.Utc), "orange", "none", null, "Iktotchese", "Iktotchi", "pink" },
                    { "https://swapi.co/api/species/23/", "unknown", "unknown", new DateTime(2014, 12, 20, 10, 29, 13, 798, DateTimeKind.Utc), "sentient", new DateTime(2014, 12, 20, 21, 36, 42, 186, DateTimeKind.Utc), "blue, indigo", "unknown", null, "unknown", "Tholothian", "dark" },
                    { "https://swapi.co/api/species/26/", "180", "70", new DateTime(2014, 12, 20, 10, 49, 21, 692, DateTimeKind.Utc), "sentient", new DateTime(2014, 12, 20, 21, 36, 42, 191, DateTimeKind.Utc), "black, silver", "none", null, "Kel Dor", "Kel Dor", "peach, orange, red" },
                    { "https://swapi.co/api/species/21/", "180", "70", new DateTime(2014, 12, 20, 10, 18, 58, 610, DateTimeKind.Utc), "sentient", new DateTime(2014, 12, 20, 21, 36, 42, 181, DateTimeKind.Utc), "black", "none", null, "Nautila", "Nautolan", "green, blue, brown, red" },
                    { "https://swapi.co/api/species/6/", "66", "900", new DateTime(2014, 12, 15, 12, 27, 22, 877, DateTimeKind.Utc), "sentient", new DateTime(2014, 12, 20, 21, 36, 42, 148, DateTimeKind.Utc), "brown, green, yellow", "brown, white", null, "Galactic basic", "Yoda's species", "green, yellow" },
                    { "https://swapi.co/api/species/7/", "200", "unknown", new DateTime(2014, 12, 15, 13, 7, 47, 704, DateTimeKind.Utc), "sentient", new DateTime(2014, 12, 20, 21, 36, 42, 151, DateTimeKind.Utc), "yellow, orange", "none", null, "Dosh", "Trandoshan", "brown, green" },
                    { "https://swapi.co/api/species/8/", "160", "unknown", new DateTime(2014, 12, 18, 11, 9, 52, 263, DateTimeKind.Utc), "sentient", new DateTime(2014, 12, 20, 21, 36, 42, 153, DateTimeKind.Utc), "yellow", "none", null, "Mon Calamarian", "Mon Calamari", "red, blue, brown, magenta" },
                    { "https://swapi.co/api/species/9/", "100", "unknown", new DateTime(2014, 12, 18, 11, 22, 0, 285, DateTimeKind.Utc), "sentient", new DateTime(2014, 12, 20, 21, 36, 42, 155, DateTimeKind.Utc), "orange, brown", "white, brown, black", null, "Ewokese", "Ewok", "brown" },
                    { "https://swapi.co/api/species/10/", "180", "unknown", new DateTime(2014, 12, 18, 11, 26, 20, 103, DateTimeKind.Utc), "sentient", new DateTime(2014, 12, 20, 21, 36, 42, 157, DateTimeKind.Utc), "black", "none", null, "Sullutese", "Sullustan", "pale" },
                    { "https://swapi.co/api/species/22/", "180", "unknown", new DateTime(2014, 12, 20, 10, 26, 59, 894, DateTimeKind.Utc), "sentient", new DateTime(2014, 12, 20, 21, 36, 42, 183, DateTimeKind.Utc), "brown, orange", "black", null, "Zabraki", "Zabrak", "pale, brown, red, orange, yellow" },
                    { "https://swapi.co/api/species/12/", "190", "unknown", new DateTime(2014, 12, 19, 17, 30, 37, 341, DateTimeKind.Utc), "sentient", new DateTime(2014, 12, 20, 21, 36, 42, 163, DateTimeKind.Utc), "orange", "none", null, "Gungan basic", "Gungan", "brown, green" },
                    { "https://swapi.co/api/species/13/", "120", "91", new DateTime(2014, 12, 19, 17, 48, 56, 893, DateTimeKind.Utc), "sentient", new DateTime(2014, 12, 20, 21, 36, 42, 165, DateTimeKind.Utc), "yellow", "none", null, "Toydarian", "Toydarian", "blue, green, grey" },
                    { "https://swapi.co/api/species/11/", "180", "unknown", new DateTime(2014, 12, 19, 17, 7, 31, 319, DateTimeKind.Utc), "sentient", new DateTime(2014, 12, 20, 21, 36, 42, 160, DateTimeKind.Utc), "red, pink", "none", null, "Neimoidia", "Neimodian", "grey, green" },
                    { "https://swapi.co/api/species/15/", "200", "unknown", new DateTime(2014, 12, 20, 9, 48, 2, 406, DateTimeKind.Utc), "sentient", new DateTime(2014, 12, 20, 21, 36, 42, 169, DateTimeKind.Utc), "blue, brown, orange, pink", "none", null, "Twi'leki", "Twi'lek", "orange, yellow, blue, green, pink, purple, tan" },
                    { "https://swapi.co/api/species/16/", "80", "79", new DateTime(2014, 12, 20, 9, 53, 16, 481, DateTimeKind.Utc), "sentient", new DateTime(2014, 12, 20, 21, 36, 42, 171, DateTimeKind.Utc), "unknown", "none", null, "Aleena", "Aleena", "blue, gray" },
                    { "https://swapi.co/api/species/17/", "100", "unknown", new DateTime(2014, 12, 20, 9, 57, 33, 128, DateTimeKind.Utc), "sentient", new DateTime(2014, 12, 20, 21, 36, 42, 173, DateTimeKind.Utc), "yellow", "none", null, "vulpterish", "Vulptereen", "grey" },
                    { "https://swapi.co/api/species/18/", "125", "unknown", new DateTime(2014, 12, 20, 10, 2, 13, 915, DateTimeKind.Utc), "sentient", new DateTime(2014, 12, 20, 21, 36, 42, 175, DateTimeKind.Utc), "black", "none", null, "Xextese", "Xexto", "grey, yellow, purple" },
                    { "https://swapi.co/api/species/19/", "200", "unknown", new DateTime(2014, 12, 20, 10, 8, 36, 795, DateTimeKind.Utc), "sentient", new DateTime(2014, 12, 20, 21, 36, 42, 177, DateTimeKind.Utc), "orange", "none", null, "Tundan", "Toong", "grey, green, yellow" },
                    { "https://swapi.co/api/species/20/", "200", "unknown", new DateTime(2014, 12, 20, 10, 15, 33, 765, DateTimeKind.Utc), "sentient", new DateTime(2014, 12, 20, 21, 36, 42, 179, DateTimeKind.Utc), "hazel", "red, blond, black, white", null, "Cerean", "Cerean", "pale pink" },
                    { "https://swapi.co/api/species/14/", "100", "unknown", new DateTime(2014, 12, 19, 17, 53, 11, 214, DateTimeKind.Utc), "sentient", new DateTime(2014, 12, 20, 21, 36, 42, 167, DateTimeKind.Utc), "yellow, blue", "none", null, "Dugese", "Dug", "brown, purple, grey, red" }
                });

            migrationBuilder.InsertData(
                table: "StarShip",
                columns: new[] { "Uri", "CargoCapacity", "Consumables", "CostInCredits", "Created", "Crew", "Edited", "HyperdriveRating", "Length", "MGLT", "Manufacturer", "MaxAtmospheringSpeed", "Model", "Name", "Passengers", "StarshipClass" },
                values: new object[,]
                {
                    { "https://swapi.co/api/starships/40/", "unknown", "unknown", "unknown", new DateTime(2014, 12, 19, 17, 45, 3, 506, DateTimeKind.Utc), "8", new DateTime(2014, 12, 22, 17, 35, 45, 91, DateTimeKind.Utc).AddTicks(9250), "1.8", "76", "unknown", "Theed Palace Space Vessel Engineering Corps, Nubia Star Drives", null, "J-type 327 Nubian royal starship", "Naboo Royal Starship", "unknown", "yacht" },
                    { "https://swapi.co/api/starships/23/", "6000000", "2 years", "8500000", new DateTime(2014, 12, 15, 13, 6, 30, 813, DateTimeKind.Utc), "854", new DateTime(2014, 12, 22, 17, 35, 44, 848, DateTimeKind.Utc).AddTicks(3290), "2.0", "300", "40", "Kuat Drive Yards", null, "EF76 Nebulon-B escort frigate", "EF76 Nebulon-B escort frigate", "75", "Escort ship" },
                    { "https://swapi.co/api/starships/39/", "65", "7 days", "200000", new DateTime(2014, 12, 19, 17, 39, 17, 582, DateTimeKind.Utc), "1", new DateTime(2014, 12, 22, 17, 35, 45, 79, DateTimeKind.Utc).AddTicks(4520), "1.0", "11", "unknown", "Theed Palace Space Vessel Engineering Corps", null, "N-1 starfighter", "Naboo fighter", "0", "Starfighter" },
                    { "https://swapi.co/api/starships/31/", "unknown", "unknown", "unknown", new DateTime(2014, 12, 19, 17, 1, 31, 488, DateTimeKind.Utc), "9", new DateTime(2014, 12, 22, 17, 35, 45, 27, DateTimeKind.Utc).AddTicks(3080), "2.0", "115", "unknown", "Corellian Engineering Corporation", null, "Consular-class cruiser", "Republic Cruiser", "16", "Space cruiser" },
                    { "https://swapi.co/api/starships/29/", "45", "1 week", "220000", new DateTime(2014, 12, 18, 11, 18, 4, 763, DateTimeKind.Utc), "1", new DateTime(2014, 12, 22, 17, 35, 45, 11, DateTimeKind.Utc).AddTicks(1930), "2.0", "16.9", "91", "Slayn & Korpil", null, "A/SF-01 B-wing starfighter", "B-wing", "0", "Assault Starfighter" },
                    { "https://swapi.co/api/starships/28/", "40", "1 week", "175000", new DateTime(2014, 12, 18, 11, 16, 34, 542, DateTimeKind.Utc), "1", new DateTime(2014, 12, 22, 17, 35, 44, 978, DateTimeKind.Utc).AddTicks(7540), "1.0", "9.6", "120", "Alliance Underground Engineering, Incom Corporation", null, "RZ-1 A-wing Interceptor", "A-wing", "0", "Starfighter" },
                    { "https://swapi.co/api/starships/27/", "unknown", "2 years", "104000000", new DateTime(2014, 12, 18, 10, 54, 57, 804, DateTimeKind.Utc), "5400", new DateTime(2014, 12, 22, 17, 35, 44, 957, DateTimeKind.Utc).AddTicks(8520), "1.0", "1200", "60", "Mon Calamari shipyards", null, "MC80 Liberty type Star Cruiser", "Calamari Cruiser", "1200", "Star Cruiser" },
                    { "https://swapi.co/api/starships/22/", "80000", "2 months", "240000", new DateTime(2014, 12, 15, 13, 4, 47, 235, DateTimeKind.Utc), "6", new DateTime(2014, 12, 22, 17, 35, 44, 795, DateTimeKind.Utc).AddTicks(4050), "1.0", "20", "50", "Sienar Fleet Systems", null, "Lambda-class T-4a shuttle", "Imperial shuttle", "20", "Armed government transport" },
                    { "https://swapi.co/api/starships/66/", "110", "5 days", "155000", new DateTime(2014, 12, 20, 20, 3, 48, 603, DateTimeKind.Utc), "3", new DateTime(2014, 12, 22, 17, 35, 45, 287, DateTimeKind.Utc).AddTicks(2140), "1.0", "14.5", "100", "Incom Corporation, Subpro Corporation", null, "Aggressive Reconnaissance-170 starfighte", "arc-170", "0", "starfighter" },
                    { "https://swapi.co/api/starships/13/", "150", "5 days", "unknown", new DateTime(2014, 12, 12, 11, 21, 32, 991, DateTimeKind.Utc), "1", new DateTime(2014, 12, 22, 17, 35, 44, 549, DateTimeKind.Utc).AddTicks(470), "1.0", "9.2", "105", "Sienar Fleet Systems", null, "Twin Ion Engine Advanced x1", "TIE Advanced x1", "0", "Starfighter" },
                    { "https://swapi.co/api/starships/12/", "110", "1 week", "149999", new DateTime(2014, 12, 12, 11, 19, 5, 340, DateTimeKind.Utc), "1", new DateTime(2014, 12, 22, 17, 35, 44, 491, DateTimeKind.Utc).AddTicks(2330), "1.0", "12.5", "100", "Incom Corporation", null, "T-65 X-wing", "X-wing", "0", "Starfighter" },
                    { "https://swapi.co/api/starships/11/", "110", "1 week", "134999", new DateTime(2014, 12, 12, 11, 0, 39, 817, DateTimeKind.Utc), "2", new DateTime(2014, 12, 22, 17, 35, 44, 479, DateTimeKind.Utc).AddTicks(7060), "1.0", "14", "80", "Koensayr Manufacturing", null, "BTL Y-wing", "Y-wing", "0", "assault starfighter" },
                    { "https://swapi.co/api/starships/10/", "100000", "2 months", "100000", new DateTime(2014, 12, 10, 16, 59, 45, 94, DateTimeKind.Utc), "4", new DateTime(2014, 12, 22, 17, 35, 44, 464, DateTimeKind.Utc).AddTicks(1560), "0.5", "34.37", "75", "Corellian Engineering Corporation", null, "YT-1300 light freighter", "Millennium Falcon", "6", "Light freighter" },
                    { "https://swapi.co/api/starships/9/", "1000000000000", "3 years", "1000000000000", new DateTime(2014, 12, 10, 16, 36, 50, 509, DateTimeKind.Utc), "342953", new DateTime(2014, 12, 22, 17, 35, 44, 452, DateTimeKind.Utc).AddTicks(5890), "4.0", "120000", "10", "Imperial Department of Military Research, Sienar Fleet Systems", null, "DS-1 Orbital Battle Station", "Death Star", "843342", "Deep Space Mobile Battlestation" },
                    { "https://swapi.co/api/starships/5/", "180000", "1 month", "240000", new DateTime(2014, 12, 10, 15, 48, 0, 586, DateTimeKind.Utc), "5", new DateTime(2014, 12, 22, 17, 35, 44, 431, DateTimeKind.Utc).AddTicks(4070), "1.0", "38", "70", "Sienar Fleet Systems, Cyngus Spaceworks", null, "Sentinel-class landing craft", "Sentinel-class landing craft", "75", "landing craft" },
                    { "https://swapi.co/api/starships/15/", "250000000", "6 years", "1143350000", new DateTime(2014, 12, 15, 12, 31, 42, 547, DateTimeKind.Utc), "279144", new DateTime(2017, 4, 19, 10, 56, 6, 685, DateTimeKind.Utc).AddTicks(5920), "2.0", "19000", "40", "Kuat Drive Yards, Fondor Shipyards", null, "Executor-class star dreadnought", "Executor", "38000", "Star dreadnought" },
                    { "https://swapi.co/api/starships/41/", "2500000", "30 days", "55000000", new DateTime(2014, 12, 20, 9, 39, 56, 116, DateTimeKind.Utc), "1", new DateTime(2014, 12, 22, 17, 35, 45, 105, DateTimeKind.Utc).AddTicks(5220), "1.5", "26.5", "unknown", "Republic Sienar Systems", null, "Star Courier", "Scimitar", "6", "Space Transport" },
                    { "https://swapi.co/api/starships/21/", "70000", "1 month", "unknown", new DateTime(2014, 12, 15, 13, 0, 56, 332, DateTimeKind.Utc), "1", new DateTime(2014, 12, 22, 17, 35, 44, 716, DateTimeKind.Utc).AddTicks(2730), "3.0", "21.5", "70", "Kuat Systems Engineering", null, "Firespray-31-class patrol and attack", "Slave 1", "6", "Patrol craft" },
                    { "https://swapi.co/api/starships/43/", "unknown", "1 year", "2000000", new DateTime(2014, 12, 20, 11, 5, 51, 237, DateTimeKind.Utc), "5", new DateTime(2014, 12, 22, 17, 35, 45, 124, DateTimeKind.Utc).AddTicks(3860), "0.7", "39", "unknown", "Theed Palace Space Vessel Engineering Corps, Nubia Star Drives", null, "J-type diplomatic barge", "J-type diplomatic barge", "10", "Diplomatic barge" },
                    { "https://swapi.co/api/starships/47/", "unknown", "unknown", "unknown", new DateTime(2014, 12, 20, 17, 24, 23, 509, DateTimeKind.Utc), "unknown", new DateTime(2014, 12, 22, 17, 35, 45, 135, DateTimeKind.Utc).AddTicks(9870), "unknown", "390", "unknown", "Botajef Shipyards", null, "Botajef AA-9 Freighter-Liner", "AA-9 Coruscant freighter", "30000", "freighter" },
                    { "https://swapi.co/api/starships/48/", "60", "7 days", "180000", new DateTime(2014, 12, 20, 17, 35, 23, 906, DateTimeKind.Utc), "1", new DateTime(2014, 12, 22, 17, 35, 45, 147, DateTimeKind.Utc).AddTicks(7460), "1.0", "8", "unknown", "Kuat Systems Engineering", null, "Delta-7 Aethersprite-class interceptor", "Jedi starfighter", "0", "Starfighter" },
                    { "https://swapi.co/api/starships/65/", "60", "2 days", "320000", new DateTime(2014, 12, 20, 19, 56, 57, 468, DateTimeKind.Utc), "1", new DateTime(2014, 12, 22, 17, 35, 45, 272, DateTimeKind.Utc).AddTicks(3490), "1.0", "5.47", "unknown", "Kuat Systems Engineering", null, "Eta-2 Actis-class light interceptor", "Jedi Interceptor", "0", "starfighter" },
                    { "https://swapi.co/api/starships/68/", "40000000", "2 years", "57000000", new DateTime(2014, 12, 20, 20, 7, 11, 538, DateTimeKind.Utc), "200", new DateTime(2017, 4, 19, 10, 53, 32, 700, DateTimeKind.Utc).AddTicks(2830), "1.0", "825", "unknown", "Hoersch-Kessel Drive, Inc, Gwori Revolutionary Industries", null, "Munificent-class star frigate", "Banking clan frigate", "unknown", "cruiser" },
                    { "https://swapi.co/api/starships/2/", "3000000", "1 year", "3500000", new DateTime(2014, 12, 10, 14, 20, 33, 369, DateTimeKind.Utc), "165", new DateTime(2014, 12, 22, 17, 35, 45, 408, DateTimeKind.Utc).AddTicks(3680), "2.0", "150", "60", "Corellian Engineering Corporation", null, "CR90 corvette", "CR90 corvette", "600", "corvette" },
                    { "https://swapi.co/api/starships/75/", "60", "15 hours", "102500", new DateTime(2014, 12, 20, 20, 43, 4, 349, DateTimeKind.Utc), "1", new DateTime(2014, 12, 22, 17, 35, 45, 396, DateTimeKind.Utc).AddTicks(7110), "1.0", "7.9", "unknown", "Kuat Systems Engineering", null, "Alpha-3 Nimbus-class V-wing starfighter", "V-wing", "0", "starfighter" },
                    { "https://swapi.co/api/starships/74/", "140", "7 days", "168000", new DateTime(2014, 12, 20, 20, 38, 5, 31, DateTimeKind.Utc), "1", new DateTime(2014, 12, 22, 17, 35, 45, 381, DateTimeKind.Utc).AddTicks(9000), "6", "6.71", "unknown", "Feethan Ottraw Scalable Assemblies", null, "Belbullab-22 starfighter", "Belbullab-22 starfighter", "0", "starfighter" },
                    { "https://swapi.co/api/starships/63/", "20000000", "2 years", "59000000", new DateTime(2014, 12, 20, 19, 52, 56, 232, DateTimeKind.Utc), "7400", new DateTime(2014, 12, 22, 17, 35, 45, 224, DateTimeKind.Utc).AddTicks(5400), "1.0", "1137", "unknown", "Kuat Drive Yards, Allanteen Six shipyards", null, "Senator-class Star Destroyer", "Republic attack cruiser", "2000", "star destroyer" },
                    { "https://swapi.co/api/starships/58/", "240", "7 days", "35700", new DateTime(2014, 12, 20, 18, 37, 56, 969, DateTimeKind.Utc), "3", new DateTime(2014, 12, 22, 17, 35, 45, 183, DateTimeKind.Utc).AddTicks(750), "1.5", "15.2", "unknown", "Huppla Pasa Tisc Shipwrights Collective", null, "Punworcca 116-class interstellar sloop", "Solar Sailer", "11", "yacht" },
                    { "https://swapi.co/api/starships/64/", "unknown", "unknown", "unknown", new DateTime(2014, 12, 20, 19, 55, 15, 396, DateTimeKind.Utc), "3", new DateTime(2014, 12, 22, 17, 35, 45, 258, DateTimeKind.Utc).AddTicks(8590), "0.5", "29.2", "unknown", "Theed Palace Space Vessel Engineering Corps/Nubia Star Drives, Incorporated", null, "J-type star skiff", "Naboo star skiff", "3", "yacht" },
                    { "https://swapi.co/api/starships/32/", "4000000000", "500 days", "unknown", new DateTime(2014, 12, 19, 17, 4, 6, 323, DateTimeKind.Utc), "175", new DateTime(2014, 12, 22, 17, 35, 45, 42, DateTimeKind.Utc).AddTicks(9000), "2.0", "3170", "unknown", "Hoersch-Kessel Drive, Inc.", null, "Lucrehulk-class Droid Control Ship", "Droid control ship", "139000", "Droid control ship" },
                    { "https://swapi.co/api/starships/17/", "19000000", "6 months", "unknown", new DateTime(2014, 12, 15, 12, 34, 52, 264, DateTimeKind.Utc), "6", new DateTime(2014, 12, 22, 17, 35, 44, 680, DateTimeKind.Utc).AddTicks(8380), "4.0", "90", "20", "Gallofree Yards, Inc.", null, "GR-75 medium transport", "Rebel transport", "90", "Medium transport" },
                    { "https://swapi.co/api/starships/77/", "unknown", "unknown", "unknown", new DateTime(2015, 4, 17, 6, 58, 50, 614, DateTimeKind.Utc).AddTicks(4750), "1", new DateTime(2015, 4, 17, 6, 58, 50, 614, DateTimeKind.Utc).AddTicks(5280), "unknown", "unknown", "unknown", "Incom", null, "T-70 X-wing fighter", "T-70 X-wing fighter", "unknown", "fighter" },
                    { "https://swapi.co/api/starships/61/", "50000", "56 days", "1000000", new DateTime(2014, 12, 20, 19, 48, 40, 409, DateTimeKind.Utc), "5", new DateTime(2014, 12, 22, 17, 35, 45, 208, DateTimeKind.Utc).AddTicks(5840), "1.0", "18.5", "unknown", "Cygnus Spaceworks", null, "Theta-class T-2c shuttle", "Theta-class T-2c shuttle", "16", "transport" },
                    { "https://swapi.co/api/starships/59/", "50000000", "4 years", "125000000", new DateTime(2014, 12, 20, 19, 40, 21, 902, DateTimeKind.Utc), "600", new DateTime(2014, 12, 22, 17, 35, 45, 195, DateTimeKind.Utc).AddTicks(1650), "1.5", "1088", "unknown", "Rendili StarDrive, Free Dac Volunteers Engineering corps.", null, "Providence-class carrier/destroyer", "Trade Federation cruiser", "48247", "capital ship" },
                    { "https://swapi.co/api/starships/3/", "36000000", "2 years", "150000000", new DateTime(2014, 12, 10, 15, 8, 19, 848, DateTimeKind.Utc), "47060", new DateTime(2014, 12, 22, 17, 35, 44, 410, DateTimeKind.Utc).AddTicks(9410), "2.0", "1,600", "60", "Kuat Drive Yards", null, "Imperial I-class Star Destroyer", "Star Destroyer", "0", "Star Destroyer" },
                    { "https://swapi.co/api/starships/49/", "unknown", "unknown", "unknown", new DateTime(2014, 12, 20, 17, 46, 46, 847, DateTimeKind.Utc), "4", new DateTime(2014, 12, 22, 17, 35, 45, 158, DateTimeKind.Utc).AddTicks(9690), "0.9", "47.9", "unknown", "Theed Palace Space Vessel Engineering Corps", null, "H-type Nubian yacht", "H-type Nubian yacht", "unknown", "yacht" },
                    { "https://swapi.co/api/starships/52/", "11250000", "2 years", "unknown", new DateTime(2014, 12, 20, 18, 8, 42, 926, DateTimeKind.Utc), "700", new DateTime(2014, 12, 22, 17, 35, 45, 171, DateTimeKind.Utc).AddTicks(6530), "0.6", "752", "unknown", "Rothana Heavy Engineering", null, "Acclamator I-class assault ship", "Republic Assault ship", "16000", "assault ship" }
                });

            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "Uri", "CargoCapacity", "CostInCredits", "Created", "Crew", "Edited", "Length", "Manufacturer", "MaxAtmospheringSpeed", "Model", "Name", "Passengers", "VehicleClass" },
                values: new object[,]
                {
                    { "https://swapi.co/api/vehicles/34/", "12000", "138000", new DateTime(2014, 12, 19, 17, 12, 4, 400, DateTimeKind.Utc), "4", new DateTime(2014, 12, 22, 18, 21, 15, 975, DateTimeKind.Utc).AddTicks(1710), "31", "Baktoid Armor Workshop", null, "Multi-Troop Transport", "Multi-Troop Transport", "112", "repulsorcraft" },
                    { "https://swapi.co/api/vehicles/33/", "0", "unknown", new DateTime(2014, 12, 19, 17, 9, 53, 584, DateTimeKind.Utc), "0", new DateTime(2014, 12, 22, 18, 21, 15, 953, DateTimeKind.Utc).AddTicks(8700), "3.5", "Haor Chall Engineering, Baktoid Armor Workshop", null, "Vulture-class droid starfighter", "Vulture Droid", "0", "starfighter" },
                    { "https://swapi.co/api/vehicles/30/", "4", "8000", new DateTime(2014, 12, 18, 11, 20, 4, 625, DateTimeKind.Utc), "1", new DateTime(2014, 12, 22, 18, 21, 15, 920, DateTimeKind.Utc).AddTicks(5370), "3", "Aratech Repulsor Company", null, "74-Z speeder bike", "Imperial Speeder Bike", "1", "speeder" },
                    { "https://swapi.co/api/vehicles/26/", "75", "unknown", new DateTime(2014, 12, 18, 10, 50, 28, 225, DateTimeKind.Utc), "1", new DateTime(2014, 12, 22, 18, 21, 15, 882, DateTimeKind.Utc).AddTicks(3880), "9.6", "Sienar Fleet Systems", null, "Twin Ion Engine Interceptor", "TIE/IN interceptor", "0", "starfighter" },
                    { "https://swapi.co/api/vehicles/25/", "135000", "8000", new DateTime(2014, 12, 18, 10, 48, 3, 208, DateTimeKind.Utc), "5", new DateTime(2014, 12, 22, 18, 21, 15, 845, DateTimeKind.Utc).AddTicks(9880), "9.5", "Ubrikkian Industries", null, "Bantha-II", "Bantha-II cargo skiff", "16", "repulsorcraft cargo skiff" },
                    { "https://swapi.co/api/vehicles/24/", "2000000", "285000", new DateTime(2014, 12, 18, 10, 44, 14, 217, DateTimeKind.Utc), "26", new DateTime(2014, 12, 22, 18, 21, 15, 807, DateTimeKind.Utc).AddTicks(9060), "30", "Ubrikkian Industries Custom Vehicle Division", null, "Modified Luxury Sail Barge", "Sail barge", "500", "sail barge" },
                    { "https://swapi.co/api/vehicles/16/", "none", "unknown", new DateTime(2014, 12, 15, 12, 33, 15, 838, DateTimeKind.Utc), "1", new DateTime(2014, 12, 22, 18, 21, 15, 667, DateTimeKind.Utc).AddTicks(7300), "7.8", "Sienar Fleet Systems", null, "TIE/sa bomber", "TIE bomber", "0", "space/planetary bomber" },
                    { "https://swapi.co/api/vehicles/19/", "200", "unknown", new DateTime(2014, 12, 15, 12, 46, 42, 384, DateTimeKind.Utc), "2", new DateTime(2014, 12, 22, 18, 21, 15, 761, DateTimeKind.Utc).AddTicks(5840), "2", "Kuat Drive Yards, Imperial Department of Military Research", null, "All Terrain Scout Transport", "AT-ST", "0", "walker" },
                    { "https://swapi.co/api/vehicles/18/", "1000", "unknown", new DateTime(2014, 12, 15, 12, 38, 25, 937, DateTimeKind.Utc), "5", new DateTime(2014, 12, 22, 18, 21, 15, 714, DateTimeKind.Utc).AddTicks(6730), "20", "Kuat Drive Yards, Imperial Department of Military Research", null, "All Terrain Armored Transport", "AT-AT", "40", "assault walker" },
                    { "https://swapi.co/api/vehicles/14/", "10", "unknown", new DateTime(2014, 12, 15, 12, 22, 12, 0, DateTimeKind.Utc), "2", new DateTime(2014, 12, 22, 18, 21, 15, 623, DateTimeKind.Utc).AddTicks(330), "4.5", "Incom corporation", null, "t-47 airspeeder", "Snowspeeder", "0", "airspeeder" },
                    { "https://swapi.co/api/vehicles/8/", "65", "unknown", new DateTime(2014, 12, 10, 16, 33, 52, 860, DateTimeKind.Utc), "1", new DateTime(2014, 12, 22, 18, 21, 15, 606, DateTimeKind.Utc).AddTicks(1490), "6.4", "Sienar Fleet Systems", null, "Twin Ion Engine/Ln Starfighter", "TIE/LN starfighter", "0", "starfighter" },
                    { "https://swapi.co/api/vehicles/7/", "5", "10550", new DateTime(2014, 12, 10, 16, 13, 52, 586, DateTimeKind.Utc), "1", new DateTime(2014, 12, 22, 18, 21, 15, 583, DateTimeKind.Utc).AddTicks(7000), "3.4", "SoroSuub Corporation", null, "X-34 landspeeder", "X-34 landspeeder", "1", "repulsorcraft" },
                    { "https://swapi.co/api/vehicles/35/", "unknown", "unknown", new DateTime(2014, 12, 19, 17, 13, 29, 799, DateTimeKind.Utc), "4", new DateTime(2014, 12, 22, 18, 21, 15, 984, DateTimeKind.Utc).AddTicks(8170), "9.75", "Baktoid Armor Workshop", null, "Armoured Assault Tank", "Armored Assault Tank", "6", "repulsorcraft" },
                    { "https://swapi.co/api/vehicles/4/", "50000", "150000", new DateTime(2014, 12, 10, 15, 36, 25, 724, DateTimeKind.Utc), "46", new DateTime(2014, 12, 22, 18, 21, 15, 523, DateTimeKind.Utc).AddTicks(5870), "36.8", "Corellia Mining Corporation", null, "Digger Crawler", "Sand Crawler", "30", "wheeled" },
                    { "https://swapi.co/api/vehicles/20/", "10", "75000", new DateTime(2014, 12, 15, 12, 58, 50, 530, DateTimeKind.Utc), "2", new DateTime(2014, 12, 22, 18, 21, 15, 783, DateTimeKind.Utc).AddTicks(2320), "7", "Bespin Motors", null, "Storm IV Twin-Pod", "Storm IV Twin-Pod cloud car", "0", "repulsorcraft" },
                    { "https://swapi.co/api/vehicles/6/", "50", "14500", new DateTime(2014, 12, 10, 16, 1, 52, 434, DateTimeKind.Utc), "1", new DateTime(2014, 12, 22, 18, 21, 15, 552, DateTimeKind.Utc).AddTicks(6140), "10.4", "Incom Corporation", null, "T-16 skyhopper", "T-16 skyhopper", "1", "repulsorcraft" },
                    { "https://swapi.co/api/vehicles/46/", "unknown", "unknown", new DateTime(2014, 12, 20, 17, 19, 19, 991, DateTimeKind.Utc), "1", new DateTime(2014, 12, 22, 18, 21, 16, 150, DateTimeKind.Utc).AddTicks(1940), "6.23", "Narglatch AirTech prefabricated kit", null, "XJ-6 airspeeder", "XJ-6 airspeeder", "1", "airspeeder" },
                    { "https://swapi.co/api/vehicles/38/", "1600", "unknown", new DateTime(2014, 12, 19, 17, 37, 37, 924, DateTimeKind.Utc), "1", new DateTime(2014, 12, 22, 18, 21, 16, 72, DateTimeKind.Utc).AddTicks(830), "15", "Otoh Gunga Bongameken Cooperative", null, "Tribubble bongo", "Tribubble bongo", "2", "submarine" }
                });

            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "Uri", "CargoCapacity", "CostInCredits", "Created", "Crew", "Edited", "Length", "Manufacturer", "MaxAtmospheringSpeed", "Model", "Name", "Passengers", "VehicleClass" },
                values: new object[,]
                {
                    { "https://swapi.co/api/vehicles/57/", "unknown", "unknown", new DateTime(2014, 12, 20, 18, 34, 12, 541, DateTimeKind.Utc), "1", new DateTime(2014, 12, 22, 18, 21, 16, 390, DateTimeKind.Utc).AddTicks(9800), "9.8", "Huppla Pasa Tisc Shipwrights Collective", null, "Nantex-class territorial defense", "Geonosian starfighter", "0", "starfighter" },
                    { "https://swapi.co/api/vehicles/56/", "1000", "unknown", new DateTime(2014, 12, 20, 18, 25, 44, 912, DateTimeKind.Utc), "2", new DateTime(2014, 12, 22, 18, 21, 16, 366, DateTimeKind.Utc).AddTicks(1340), "20", "Haor Chall Engineering", null, "Sheathipede-class transport shuttle", "Neimoidian shuttle", "6", "transport" },
                    { "https://swapi.co/api/vehicles/55/", "unknown", "8000", new DateTime(2014, 12, 20, 18, 15, 20, 312, DateTimeKind.Utc), "1", new DateTime(2014, 12, 22, 18, 21, 16, 335, DateTimeKind.Utc).AddTicks(50), "2", "Huppla Pasa Tisc Shipwrights Collective", null, "Flitknot speeder", "Flitknot speeder", "0", "speeder" },
                    { "https://swapi.co/api/vehicles/54/", "500", "unknown", new DateTime(2014, 12, 20, 18, 12, 32, 315, DateTimeKind.Utc), "25", new DateTime(2014, 12, 22, 18, 21, 16, 311, DateTimeKind.Utc).AddTicks(7610), "140", "Rothana Heavy Engineering", null, "Self-Propelled Heavy Artillery", "SPHA", "30", "walker" },
                    { "https://swapi.co/api/vehicles/53/", "10000", "unknown", new DateTime(2014, 12, 20, 18, 10, 7, 560, DateTimeKind.Utc), "6", new DateTime(2014, 12, 22, 18, 21, 16, 293, DateTimeKind.Utc).AddTicks(7710), "13.2", "Rothana Heavy Engineering, Kuat Drive Yards", null, "All Terrain Tactical Enforcer", "AT-TE", "36", "walker" },
                    { "https://swapi.co/api/vehicles/76/", "20", "40000", new DateTime(2014, 12, 20, 20, 47, 49, 189, DateTimeKind.Utc), "1", new DateTime(2014, 12, 22, 18, 21, 16, 672, DateTimeKind.Utc).AddTicks(8210), "3.2", "Kuat Drive Yards", null, "All Terrain Recon Transport", "AT-RT", "0", "walker" },
                    { "https://swapi.co/api/vehicles/73/", "0", "60000", new DateTime(2014, 12, 20, 20, 32, 5, 687, DateTimeKind.Utc), "0", new DateTime(2014, 12, 22, 18, 21, 16, 643, DateTimeKind.Utc).AddTicks(3290), "12.3", "Baktoid Fleet Ordnance, Haor Chall Engineering", null, "HMP droid gunship", "Droid gunship", "0", "airspeeder" },
                    { "https://swapi.co/api/vehicles/72/", "none", "49000", new DateTime(2014, 12, 20, 20, 26, 55, 522, DateTimeKind.Utc), "0", new DateTime(2014, 12, 22, 18, 21, 16, 612, DateTimeKind.Utc).AddTicks(9020), "10.96", "Techno Union", null, "NR-N99 Persuader-class droid enforcer", "Corporate Alliance tank droid", "4", "droid tank" },
                    { "https://swapi.co/api/vehicles/71/", "30000", "350000", new DateTime(2014, 12, 20, 20, 24, 45, 587, DateTimeKind.Utc), "20", new DateTime(2014, 12, 22, 18, 21, 16, 571, DateTimeKind.Utc).AddTicks(790), "49.4", "Kuat Drive Yards", null, "HAVw A6 Juggernaut", "Clone turbo tank", "300", "wheeled walker" },
                    { "https://swapi.co/api/vehicles/70/", "20", "14750", new DateTime(2014, 12, 20, 20, 21, 55, 648, DateTimeKind.Utc), "2", new DateTime(2014, 12, 22, 18, 21, 16, 547, DateTimeKind.Utc).AddTicks(7080), "7", "Appazanna Engineering Works", null, "Raddaugh Gnasp fluttercraft", "Raddaugh Gnasp fluttercraft", "0", "air speeder" },
                    { "https://swapi.co/api/vehicles/69/", "50", "12125", new DateTime(2014, 12, 20, 20, 20, 53, 931, DateTimeKind.Utc), "2", new DateTime(2014, 12, 22, 18, 21, 16, 517, DateTimeKind.Utc).AddTicks(490), "15.1", "Appazanna Engineering Works", null, "Oevvaor jet catamaran", "Oevvaor jet catamaran", "2", "airspeeder" },
                    { "https://swapi.co/api/vehicles/67/", "0", "20000", new DateTime(2014, 12, 20, 20, 5, 19, 992, DateTimeKind.Utc), "1", new DateTime(2014, 12, 22, 18, 21, 16, 478, DateTimeKind.Utc).AddTicks(9010), "5.4", "Colla Designs, Phlac-Arphocc Automata Industries", null, "tri-fighter", "Droid tri-fighter", "0", "droid starfighter" },
                    { "https://swapi.co/api/vehicles/62/", "unknown", "unknown", new DateTime(2014, 12, 20, 19, 50, 58, 559, DateTimeKind.Utc), "2", new DateTime(2014, 12, 22, 18, 21, 16, 450, DateTimeKind.Utc).AddTicks(6550), "unknown", "unknown", null, "Fire suppression speeder", "Emergency Firespeeder", "unknown", "fire suppression ship" },
                    { "https://swapi.co/api/vehicles/60/", "10", "15000", new DateTime(2014, 12, 20, 19, 43, 54, 870, DateTimeKind.Utc), "1", new DateTime(2014, 12, 22, 18, 21, 16, 422, DateTimeKind.Utc).AddTicks(6620), "3.5", "Z-Gomot Ternbuell Guppat Corporation", null, "Tsmeu-6 personal wheel bike", "Tsmeu-6 personal wheel bike", "1", "wheeled walker" },
                    { "https://swapi.co/api/vehicles/51/", "40000", "unknown", new DateTime(2014, 12, 20, 18, 2, 46, 802, DateTimeKind.Utc), "1", new DateTime(2014, 12, 22, 18, 21, 16, 229, DateTimeKind.Utc).AddTicks(7330), "28.82", "Rothana Heavy Engineering", null, "Low Altitude Assault Transport/carrier", "LAAT/c", "0", "gunship" },
                    { "https://swapi.co/api/vehicles/50/", "170", "unknown", new DateTime(2014, 12, 20, 18, 1, 21, 14, DateTimeKind.Utc), "6", new DateTime(2014, 12, 22, 18, 21, 16, 181, DateTimeKind.Utc).AddTicks(3630), "17.4", "Rothana Heavy Engineering", null, "Low Altitude Assault Transport/infrantry", "LAAT/i", "30", "gunship" },
                    { "https://swapi.co/api/vehicles/45/", "80", "unknown", new DateTime(2014, 12, 20, 17, 17, 33, 526, DateTimeKind.Utc), "1", new DateTime(2014, 12, 22, 18, 21, 16, 140, DateTimeKind.Utc).AddTicks(180), "6.6", "Desler Gizh Outworld Mobility Corporation", null, "Koro-2 Exodrive airspeeder", "Koro-2 Exodrive airspeeder", "1", "airspeeder" },
                    { "https://swapi.co/api/vehicles/44/", "200", "5750", new DateTime(2014, 12, 20, 16, 24, 16, 26, DateTimeKind.Utc), "1", new DateTime(2014, 12, 22, 18, 21, 16, 117, DateTimeKind.Utc).AddTicks(6520), "3.68", "Mobquet Swoops and Speeders", null, "Zephyr-G swoop bike", "Zephyr-G swoop bike", "1", "repulsorcraft" },
                    { "https://swapi.co/api/vehicles/42/", "2", "4000", new DateTime(2014, 12, 20, 10, 9, 56, 95, DateTimeKind.Utc), "1", new DateTime(2014, 12, 22, 18, 21, 16, 95, DateTimeKind.Utc).AddTicks(410), "1.5", "Razalon", null, "FC-20 speeder bike", "Sith speeder", "0", "speeder" },
                    { "https://swapi.co/api/vehicles/37/", "1800000", "200000", new DateTime(2014, 12, 19, 17, 20, 36, 373, DateTimeKind.Utc), "140", new DateTime(2014, 12, 22, 18, 21, 16, 33, DateTimeKind.Utc).AddTicks(7380), "210", "Haor Chall Engineering", null, "C-9979 landing craft", "C-9979 landing craft", "284", "landing craft" },
                    { "https://swapi.co/api/vehicles/36/", "none", "2500", new DateTime(2014, 12, 19, 17, 15, 9, 511, DateTimeKind.Utc), "1", new DateTime(2014, 12, 22, 18, 21, 16, 8, DateTimeKind.Utc).AddTicks(5940), "2", "Baktoid Armor Workshop", null, "Single Trooper Aerial Platform", "Single Trooper Aerial Platform", "0", "repulsorcraft" }
                });

            migrationBuilder.InsertData(
                table: "MoviePlanet",
                columns: new[] { "MovieUri", "PlanetUri" },
                values: new object[,]
                {
                    { "https://swapi.co/api/films/7/", "https://swapi.co/api/planets/61/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/planets/17/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/planets/16/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/planets/15/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/planets/14/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/planets/13/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/planets/12/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/planets/11/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/planets/10/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/planets/9/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/planets/9/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/planets/9/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/planets/9/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/planets/18/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/planets/8/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/planets/8/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/planets/8/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/planets/7/" },
                    { "https://swapi.co/api/films/2/", "https://swapi.co/api/planets/6/" },
                    { "https://swapi.co/api/films/2/", "https://swapi.co/api/planets/5/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/planets/5/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/planets/5/" },
                    { "https://swapi.co/api/films/2/", "https://swapi.co/api/planets/4/" },
                    { "https://swapi.co/api/films/1/", "https://swapi.co/api/planets/3/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/planets/2/" },
                    { "https://swapi.co/api/films/1/", "https://swapi.co/api/planets/2/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/planets/1/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/planets/8/" },
                    { "https://swapi.co/api/films/2/", "https://swapi.co/api/planets/27/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/planets/19/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/planets/1/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/planets/1/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/planets/1/" },
                    { "https://swapi.co/api/films/1/", "https://swapi.co/api/planets/1/" }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Uri", "BirthYear", "Created", "Edited", "EyeColor", "HairColor", "Height", "HomeWorldUri", "Mass", "Name", "SkinColor", "SpecieUri", "StarShipUri", "VehicleUri" },
                values: new object[,]
                {
                    { "https://swapi.co/api/people/54/", "unknown", new DateTime(2014, 12, 20, 10, 26, 47, 902, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 427, DateTimeKind.Utc), "brown", "black", "171", "https://swapi.co/api/planets/45/", "unknown", "Eeth Koth", "brown", null, null, null },
                    { "https://swapi.co/api/people/6/", "52BBY", new DateTime(2014, 12, 10, 15, 52, 14, 24, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 317, DateTimeKind.Utc), "blue", "brown, grey", "178", "https://swapi.co/api/planets/1/", "120", "Owen Lars", "light", null, null, null },
                    { "https://swapi.co/api/people/4/", "41.9BBY", new DateTime(2014, 12, 10, 15, 18, 20, 704, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 313, DateTimeKind.Utc), "yellow", "none", "202", "https://swapi.co/api/planets/1/", "136", "Darth Vader", "white", null, null, null },
                    { "https://swapi.co/api/people/2/", "112BBY", new DateTime(2014, 12, 10, 15, 10, 51, 357, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 309, DateTimeKind.Utc), "yellow", "n/a", "167", "https://swapi.co/api/planets/1/", "75", "C-3PO", "gold", null, null, null },
                    { "https://swapi.co/api/people/1/", "19BBY", new DateTime(2014, 12, 9, 13, 50, 51, 644, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 56, 891, DateTimeKind.Utc), "blue", "blond", "172", "https://swapi.co/api/planets/1/", "77", "Luke Skywalker", "fair", null, null, null },
                    { "https://swapi.co/api/people/34/", "91BBY", new DateTime(2014, 12, 19, 17, 21, 45, 915, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 379, DateTimeKind.Utc), "blue", "blond", "170", "https://swapi.co/api/planets/9/", "unknown", "Finis Valorum", "fair", null, null, null },
                    { "https://swapi.co/api/people/55/", "unknown", new DateTime(2014, 12, 20, 10, 29, 11, 661, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 432, DateTimeKind.Utc), "blue", "none", "184", "https://swapi.co/api/planets/9/", "50", "Adi Gallia", "dark", null, null, null },
                    { "https://swapi.co/api/people/74/", "unknown", new DateTime(2014, 12, 20, 17, 32, 51, 996, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 476, DateTimeKind.Utc), "blue", "white", "167", "https://swapi.co/api/planets/9/", "unknown", "Jocasta Nu", "fair", null, null, null },
                    { "https://swapi.co/api/people/82/", "unknown", new DateTime(2014, 12, 20, 20, 18, 37, 619, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 496, DateTimeKind.Utc), "white", "none", "178", "https://swapi.co/api/planets/60/", "48", "Sly Moore", "pale", null, null, null },
                    { "https://swapi.co/api/people/77/", "unknown", new DateTime(2014, 12, 20, 17, 58, 17, 49, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 484, DateTimeKind.Utc), "gold", "none", "191", "https://swapi.co/api/planets/57/", "unknown", "San Hill", "grey", null, null, null },
                    { "https://swapi.co/api/people/78/", "unknown", new DateTime(2014, 12, 20, 18, 44, 1, 103, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 486, DateTimeKind.Utc), "black", "none", "178", "https://swapi.co/api/planets/58/", "57", "Shaak Ti", "red, blue, white", null, null, null },
                    { "https://swapi.co/api/people/35/", "46BBY", new DateTime(2014, 12, 19, 17, 28, 26, 926, DateTimeKind.Utc), new DateTime(2016, 4, 20, 17, 6, 31, 502, DateTimeKind.Utc).AddTicks(5550), "brown", "brown", "165", "https://swapi.co/api/planets/8/", "45", "Padmé Amidala", "light", null, null, null },
                    { "https://swapi.co/api/people/22/", "31.5BBY", new DateTime(2014, 12, 15, 12, 49, 32, 457, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 349, DateTimeKind.Utc), "brown", "black", "183", "https://swapi.co/api/planets/10/", "78.2", "Boba Fett", "fair", null, null, null },
                    { "https://swapi.co/api/people/72/", "unknown", new DateTime(2014, 12, 20, 17, 30, 50, 416, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 473, DateTimeKind.Utc), "black", "none", "229", "https://swapi.co/api/planets/10/", "88", "Lama Su", "grey", null, null, null },
                    { "https://swapi.co/api/people/56/", "unknown", new DateTime(2014, 12, 20, 10, 32, 11, 669, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 434, DateTimeKind.Utc), "orange", "none", "188", "https://swapi.co/api/planets/47/", "unknown", "Saesee Tiin", "pale", null, null, null },
                    { "https://swapi.co/api/people/76/", "unknown", new DateTime(2014, 12, 20, 17, 53, 52, 607, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 481, DateTimeKind.Utc), "unknown", "none", "193", "https://swapi.co/api/planets/56/", "48", "Wat Tambor", "green, grey", null, null, null },
                    { "https://swapi.co/api/people/63/", "unknown", new DateTime(2014, 12, 20, 16, 40, 43, 977, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 453, DateTimeKind.Utc), "yellow", "none", "183", "https://swapi.co/api/planets/11/", "80", "Poggle the Lesser", "green", null, null, null },
                    { "https://swapi.co/api/people/71/", "unknown", new DateTime(2014, 12, 20, 17, 28, 27, 248, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 470, DateTimeKind.Utc), "yellow", "none", "198", "https://swapi.co/api/planets/55/", "102", "Dexter Jettster", "brown", null, null, null },
                    { "https://swapi.co/api/people/79/", "unknown", new DateTime(2014, 12, 20, 19, 43, 53, 348, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 488, DateTimeKind.Utc), "green, yellow", "none", "216", "https://swapi.co/api/planets/59/", "159", "Grievous", "brown, white", null, null, null },
                    { "https://swapi.co/api/people/66/", "unknown", new DateTime(2014, 12, 20, 16, 49, 14, 640, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 460, DateTimeKind.Utc), "brown", "brown", "165", "https://swapi.co/api/planets/8/", "unknown", "Dormé", "light", null, null, null },
                    { "https://swapi.co/api/people/42/", "62BBY", new DateTime(2014, 12, 19, 17, 55, 43, 348, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 399, DateTimeKind.Utc), "brown", "black", "183", "https://swapi.co/api/planets/8/", "unknown", "Quarsh Panaka", "dark", null, null, null },
                    { "https://swapi.co/api/people/60/", "unknown", new DateTime(2014, 12, 20, 11, 10, 10, 381, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 445, DateTimeKind.Utc), "brown", "black", "185", "https://swapi.co/api/planets/8/", "85", "Gregar Typho", "dark", null, null, null },
                    { "https://swapi.co/api/people/5/", "19BBY", new DateTime(2014, 12, 10, 15, 20, 9, 791, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 315, DateTimeKind.Utc), "brown", "brown", "150", "https://swapi.co/api/planets/2/", "49", "Leia Organa", "light", null, null, null },
                    { "https://swapi.co/api/people/68/", "67BBY", new DateTime(2014, 12, 20, 16, 53, 8, 575, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 463, DateTimeKind.Utc), "brown", "black", "191", "https://swapi.co/api/planets/2/", "unknown", "Bail Prestor Organa", "tan", null, null, null },
                    { "https://swapi.co/api/people/81/", "unknown", new DateTime(2014, 12, 20, 19, 49, 35, 583, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 493, DateTimeKind.Utc), "brown", "brown", "188", "https://swapi.co/api/planets/2/", "79", "Raymus Antilles", "light", null, null, null },
                    { "https://swapi.co/api/people/62/", "82BBY", new DateTime(2014, 12, 20, 15, 59, 3, 958, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 451, DateTimeKind.Utc), "blue", "brown", "183", "https://swapi.co/api/planets/1/", "unknown", "Cliegg Lars", "fair", null, null, null },
                    { "https://swapi.co/api/people/43/", "72BBY", new DateTime(2014, 12, 19, 17, 57, 41, 191, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 401, DateTimeKind.Utc), "brown", "black", "163", "https://swapi.co/api/planets/1/", "unknown", "Shmi Skywalker", "fair", null, null, null },
                    { "https://swapi.co/api/people/11/", "41.9BBY", new DateTime(2014, 12, 10, 16, 20, 44, 310, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 327, DateTimeKind.Utc), "blue", "blond", "188", "https://swapi.co/api/planets/1/", "84", "Anakin Skywalker", "fair", null, null, null },
                    { "https://swapi.co/api/people/9/", "24BBY", new DateTime(2014, 12, 10, 15, 59, 50, 509, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 323, DateTimeKind.Utc), "brown", "black", "183", "https://swapi.co/api/planets/1/", "84", "Biggs Darklighter", "light", null, null, null },
                    { "https://swapi.co/api/people/26/", "37BBY", new DateTime(2014, 12, 15, 13, 1, 57, 178, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 359, DateTimeKind.Utc), "blue", "none", "175", "https://swapi.co/api/planets/6/", "79", "Lobot", "light", null, null, null },
                    { "https://swapi.co/api/people/61/", "unknown", new DateTime(2014, 12, 20, 11, 11, 39, 630, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 449, DateTimeKind.Utc), "brown", "brown", "157", "https://swapi.co/api/planets/8/", "unknown", "Cordé", "light", null, null, null },
                    { "https://swapi.co/api/people/8/", "unknown", new DateTime(2014, 12, 10, 15, 57, 50, 959, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 321, DateTimeKind.Utc), "red", "n/a", "97", "https://swapi.co/api/planets/1/", "32", "R5-D4", "white, red", null, null, null },
                    { "https://swapi.co/api/people/7/", "47BBY", new DateTime(2014, 12, 10, 15, 53, 41, 121, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 319, DateTimeKind.Utc), "blue", "brown", "165", "https://swapi.co/api/planets/1/", "75", "Beru Whitesun lars", "light", null, null, null },
                    { "https://swapi.co/api/people/3/", "33BBY", new DateTime(2014, 12, 10, 15, 11, 50, 376, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 311, DateTimeKind.Utc), "red", "n/a", "96", "https://swapi.co/api/planets/8/", "32", "R2-D2", "white, blue", null, null, null },
                    { "https://swapi.co/api/people/21/", "82BBY", new DateTime(2014, 12, 15, 12, 48, 5, 971, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 347, DateTimeKind.Utc), "yellow", "grey", "170", "https://swapi.co/api/planets/8/", "75", "Palpatine", "pale", null, null, null },
                    { "https://swapi.co/api/people/36/", "52BBY", new DateTime(2014, 12, 19, 17, 29, 32, 489, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 383, DateTimeKind.Utc), "orange", "none", "196", "https://swapi.co/api/planets/8/", "66", "Jar Jar Binks", "orange", null, null, null },
                    { "https://swapi.co/api/people/37/", "unknown", new DateTime(2014, 12, 19, 17, 32, 56, 741, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 385, DateTimeKind.Utc), "orange", "none", "224", "https://swapi.co/api/planets/8/", "82", "Roos Tarpals", "grey", null, null, null },
                    { "https://swapi.co/api/people/38/", "unknown", new DateTime(2014, 12, 19, 17, 33, 38, 909, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 388, DateTimeKind.Utc), "orange", "none", "206", "https://swapi.co/api/planets/8/", "unknown", "Rugor Nass", "green", null, null, null },
                    { "https://swapi.co/api/people/39/", "unknown", new DateTime(2014, 12, 19, 17, 45, 1, 522, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 392, DateTimeKind.Utc), "blue", "brown", "183", "https://swapi.co/api/planets/8/", "unknown", "Ric Olié", "fair", null, null, null },
                    { "https://swapi.co/api/people/83/", "unknown", new DateTime(2014, 12, 20, 20, 35, 4, 260, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 498, DateTimeKind.Utc), "black", "none", "206", "https://swapi.co/api/planets/12/", "80", "Tion Medon", "grey", null, null, null },
                    { "https://swapi.co/api/people/30/", "8BBY", new DateTime(2014, 12, 18, 11, 21, 58, 954, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 369, DateTimeKind.Utc), "brown", "brown", "88", "https://swapi.co/api/planets/7/", "20", "Wicket Systri Warrick", "brown", null, null, null },
                    { "https://swapi.co/api/people/70/", "unknown", new DateTime(2014, 12, 20, 16, 57, 44, 471, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 468, DateTimeKind.Utc), "yellow", "blonde", "168", "https://swapi.co/api/planets/54/", "55", "Zam Wesell", "fair, green, yellow", null, null, null },
                    { "https://swapi.co/api/people/73/", "unknown", new DateTime(2014, 12, 20, 17, 31, 21, 195, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 474, DateTimeKind.Utc), "black", "none", "213", "https://swapi.co/api/planets/10/", "unknown", "Taun We", "grey", null, null, null },
                    { "https://swapi.co/api/people/13/", "200BBY", new DateTime(2014, 12, 10, 16, 42, 45, 66, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 332, DateTimeKind.Utc), "blue", "brown", "228", "https://swapi.co/api/planets/14/", "112", "Chewbacca", "unknown", null, null, null },
                    { "https://swapi.co/api/people/87/", "unknown", new DateTime(2015, 4, 17, 6, 57, 38, 61, DateTimeKind.Utc).AddTicks(3460), new DateTime(2015, 4, 17, 6, 57, 38, 61, DateTimeKind.Utc).AddTicks(4530), "black", "none", "unknown", "https://swapi.co/api/planets/28/", "unknown", "BB8", "none", null, null, null },
                    { "https://swapi.co/api/people/88/", "unknown", new DateTime(2015, 10, 13, 10, 35, 39, 229, DateTimeKind.Utc).AddTicks(8230), new DateTime(2015, 10, 13, 10, 35, 39, 229, DateTimeKind.Utc).AddTicks(8940), "unknown", "unknown", "unknown", "https://swapi.co/api/planets/28/", "unknown", "Captain Phasma", "unknown", null, null, null },
                    { "https://swapi.co/api/people/69/", "66BBY", new DateTime(2014, 12, 20, 16, 54, 41, 620, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 465, DateTimeKind.Utc), "brown", "black", "183", "https://swapi.co/api/planets/53/", "79", "Jango Fett", "tan", null, null, null },
                    { "https://swapi.co/api/people/25/", "31BBY", new DateTime(2014, 12, 15, 12, 56, 32, 683, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 357, DateTimeKind.Utc), "brown", "black", "177", "https://swapi.co/api/planets/30/", "79", "Lando Calrissian", "dark", null, null, null },
                    { "https://swapi.co/api/people/27/", "41BBY", new DateTime(2014, 12, 18, 11, 7, 50, 584, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 362, DateTimeKind.Utc), "orange", "none", "180", "https://swapi.co/api/planets/31/", "83", "Ackbar", "brown mottle", null, null, null },
                    { "https://swapi.co/api/people/28/", "48BBY", new DateTime(2014, 12, 18, 11, 12, 38, 895, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 364, DateTimeKind.Utc), "blue", "auburn", "150", "https://swapi.co/api/planets/32/", "unknown", "Mon Mothma", "fair", null, null, null },
                    { "https://swapi.co/api/people/31/", "unknown", new DateTime(2014, 12, 18, 11, 26, 18, 541, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 371, DateTimeKind.Utc), "black", "none", "160", "https://swapi.co/api/planets/33/", "68", "Nien Nunb", "grey", null, null, null },
                    { "https://swapi.co/api/people/40/", "unknown", new DateTime(2014, 12, 19, 17, 48, 54, 647, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 395, DateTimeKind.Utc), "yellow", "black", "137", "https://swapi.co/api/planets/34/", "unknown", "Watto", "blue, grey", null, null, null },
                    { "https://swapi.co/api/people/41/", "unknown", new DateTime(2014, 12, 19, 17, 53, 2, 586, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 397, DateTimeKind.Utc), "orange", "none", "112", "https://swapi.co/api/planets/35/", "40", "Sebulba", "grey, red", null, null, null },
                    { "https://swapi.co/api/people/44/", "54BBY", new DateTime(2014, 12, 19, 18, 0, 41, 929, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 403, DateTimeKind.Utc), "yellow", "none", "175", "https://swapi.co/api/planets/36/", "80", "Darth Maul", "red", null, null, null },
                    { "https://swapi.co/api/people/45/", "unknown", new DateTime(2014, 12, 20, 9, 47, 2, 512, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 407, DateTimeKind.Utc), "pink", "none", "180", "https://swapi.co/api/planets/37/", "unknown", "Bib Fortuna", "pale", null, null, null },
                    { "https://swapi.co/api/people/46/", "48BBY", new DateTime(2014, 12, 20, 9, 48, 1, 172, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 409, DateTimeKind.Utc), "hazel", "none", "178", "https://swapi.co/api/planets/37/", "55", "Ayla Secura", "blue", null, null, null },
                    { "https://swapi.co/api/people/47/", "unknown", new DateTime(2014, 12, 20, 9, 53, 15, 86, DateTimeKind.Utc), new DateTime(2016, 6, 30, 12, 52, 19, 604, DateTimeKind.Utc).AddTicks(8680), "unknown", "none", "79", "https://swapi.co/api/planets/38/", "15", "Ratts Tyerell", "grey, blue", null, null, null },
                    { "https://swapi.co/api/people/48/", "unknown", new DateTime(2014, 12, 20, 9, 57, 31, 858, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 414, DateTimeKind.Utc), "yellow", "none", "94", "https://swapi.co/api/planets/39/", "45", "Dud Bolt", "blue, grey", null, null, null },
                    { "https://swapi.co/api/people/49/", "unknown", new DateTime(2014, 12, 20, 10, 2, 12, 223, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 416, DateTimeKind.Utc), "black", "none", "122", "https://swapi.co/api/planets/40/", "unknown", "Gasgano", "white, blue", null, null, null },
                    { "https://swapi.co/api/people/50/", "unknown", new DateTime(2014, 12, 20, 10, 8, 33, 777, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 417, DateTimeKind.Utc), "orange", "none", "163", "https://swapi.co/api/planets/41/", "65", "Ben Quadinaros", "grey, green, yellow", null, null, null },
                    { "https://swapi.co/api/people/51/", "72BBY", new DateTime(2014, 12, 20, 10, 12, 30, 846, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 420, DateTimeKind.Utc), "brown", "none", "188", "https://swapi.co/api/planets/42/", "84", "Mace Windu", "dark", null, null, null },
                    { "https://swapi.co/api/people/52/", "92BBY", new DateTime(2014, 12, 20, 10, 15, 32, 293, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 422, DateTimeKind.Utc), "yellow", "white", "198", "https://swapi.co/api/planets/43/", "82", "Ki-Adi-Mundi", "pale", null, null, null },
                    { "https://swapi.co/api/people/53/", "unknown", new DateTime(2014, 12, 20, 10, 18, 57, 202, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 424, DateTimeKind.Utc), "black", "none", "196", "https://swapi.co/api/planets/44/", "87", "Kit Fisto", "green", null, null, null },
                    { "https://swapi.co/api/people/86/", "unknown", new DateTime(2015, 4, 17, 6, 55, 21, 622, DateTimeKind.Utc).AddTicks(7860), new DateTime(2015, 4, 17, 6, 55, 21, 622, DateTimeKind.Utc).AddTicks(8350), "brown", "brown", "unknown", "https://swapi.co/api/planets/28/", "unknown", "Poe Dameron", "light", null, null, null },
                    { "https://swapi.co/api/people/85/", "unknown", new DateTime(2015, 4, 17, 6, 54, 1, 495, DateTimeKind.Utc).AddTicks(770), new DateTime(2015, 4, 17, 6, 54, 1, 495, DateTimeKind.Utc).AddTicks(1280), "hazel", "brown", "unknown", "https://swapi.co/api/planets/28/", "unknown", "Rey", "light", null, null, null },
                    { "https://swapi.co/api/people/24/", "53BBY", new DateTime(2014, 12, 15, 12, 53, 49, 297, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 355, DateTimeKind.Utc), "red", "none", "190", "https://swapi.co/api/planets/29/", "113", "Bossk", "green", null, null, null },
                    { "https://swapi.co/api/people/75/", "unknown", new DateTime(2014, 12, 20, 17, 43, 36, 409, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 478, DateTimeKind.Utc), "red, blue", "none", "96", "https://swapi.co/api/planets/28/", "unknown", "R4-P17", "silver, red", null, null, null },
                    { "https://swapi.co/api/people/80/", "unknown", new DateTime(2014, 12, 20, 19, 46, 34, 209, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 491, DateTimeKind.Utc), "blue", "brown", "234", "https://swapi.co/api/planets/14/", "136", "Tarfful", "brown", null, null, null },
                    { "https://swapi.co/api/people/67/", "102BBY", new DateTime(2014, 12, 20, 16, 52, 14, 726, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 462, DateTimeKind.Utc), "brown", "white", "193", "https://swapi.co/api/planets/52/", "80", "Dooku", "fair", null, null, null },
                    { "https://swapi.co/api/people/65/", "40BBY", new DateTime(2014, 12, 20, 16, 46, 40, 440, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 457, DateTimeKind.Utc), "blue", "black", "166", "https://swapi.co/api/planets/51/", "50", "Barriss Offee", "yellow", null, null, null },
                    { "https://swapi.co/api/people/64/", "58BBY", new DateTime(2014, 12, 20, 16, 45, 53, 668, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 455, DateTimeKind.Utc), "blue", "black", "170", "https://swapi.co/api/planets/51/", "56.2", "Luminara Unduli", "yellow", null, null, null },
                    { "https://swapi.co/api/people/84/", "unknown", new DateTime(2015, 4, 17, 6, 52, 40, 793, DateTimeKind.Utc).AddTicks(6210), new DateTime(2015, 4, 17, 6, 52, 40, 793, DateTimeKind.Utc).AddTicks(6740), "dark", "black", "unknown", "https://swapi.co/api/planets/28/", "unknown", "Finn", "dark", null, null, null },
                    { "https://swapi.co/api/people/33/", "unknown", new DateTime(2014, 12, 19, 17, 5, 57, 357, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 377, DateTimeKind.Utc), "red", "none", "191", "https://swapi.co/api/planets/18/", "90", "Nute Gunray", "mottled green", null, null, null },
                    { "https://swapi.co/api/people/58/", "22BBY", new DateTime(2014, 12, 20, 10, 49, 19, 859, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 439, DateTimeKind.Utc), "black", "none", "188", "https://swapi.co/api/planets/49/", "80", "Plo Koon", "orange", null, null, null },
                    { "https://swapi.co/api/people/10/", "57BBY", new DateTime(2014, 12, 10, 16, 16, 29, 192, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 325, DateTimeKind.Utc), "blue-gray", "auburn, white", "182", "https://swapi.co/api/planets/20/", "77", "Obi-Wan Kenobi", "fair", null, null, null },
                    { "https://swapi.co/api/people/12/", "64BBY", new DateTime(2014, 12, 10, 16, 26, 56, 138, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 330, DateTimeKind.Utc), "blue", "auburn, grey", "180", "https://swapi.co/api/planets/21/", "unknown", "Wilhuff Tarkin", "fair", null, null, null },
                    { "https://swapi.co/api/people/59/", "unknown", new DateTime(2014, 12, 20, 10, 53, 26, 457, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 442, DateTimeKind.Utc), "blue", "none", "196", "https://swapi.co/api/planets/50/", "unknown", "Mas Amedda", "blue", null, null, null },
                    { "https://swapi.co/api/people/18/", "21BBY", new DateTime(2014, 12, 12, 11, 8, 6, 469, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 341, DateTimeKind.Utc), "hazel", "brown", "170", "https://swapi.co/api/planets/22/", "77", "Wedge Antilles", "fair", null, null, null },
                    { "https://swapi.co/api/people/15/", "44BBY", new DateTime(2014, 12, 10, 17, 3, 30, 334, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 336, DateTimeKind.Utc), "black", "n/a", "173", "https://swapi.co/api/planets/23/", "74", "Greedo", "green", null, null, null },
                    { "https://swapi.co/api/people/16/", "600BBY", new DateTime(2014, 12, 10, 17, 11, 31, 638, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 338, DateTimeKind.Utc), "orange", "n/a", "175", "https://swapi.co/api/planets/24/", "1,358", "Jabba Desilijic Tiure", "green-tan, brown", null, null, null },
                    { "https://swapi.co/api/people/19/", "unknown", new DateTime(2014, 12, 12, 11, 16, 56, 569, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 343, DateTimeKind.Utc), "blue", "brown", "180", "https://swapi.co/api/planets/26/", "110", "Jek Tono Porkins", "fair", null, null, null },
                    { "https://swapi.co/api/people/57/", "unknown", new DateTime(2014, 12, 20, 10, 34, 48, 725, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 437, DateTimeKind.Utc), "yellow", "none", "264", "https://swapi.co/api/planets/48/", "unknown", "Yarael Poof", "white", null, null, null },
                    { "https://swapi.co/api/people/20/", "896BBY", new DateTime(2014, 12, 15, 12, 26, 1, 42, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 345, DateTimeKind.Utc), "brown", "white", "66", "https://swapi.co/api/planets/28/", "17", "Yoda", "green", null, null, null },
                    { "https://swapi.co/api/people/23/", "15BBY", new DateTime(2014, 12, 15, 12, 51, 10, 76, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 351, DateTimeKind.Utc), "red", "none", "200", "https://swapi.co/api/planets/28/", "140", "IG-88", "metal", null, null, null },
                    { "https://swapi.co/api/people/29/", "unknown", new DateTime(2014, 12, 18, 11, 16, 33, 20, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 367, DateTimeKind.Utc), "brown", "brown", "unknown", "https://swapi.co/api/planets/28/", "unknown", "Arvel Crynyd", "fair", null, null, null },
                    { "https://swapi.co/api/people/14/", "29BBY", new DateTime(2014, 12, 10, 16, 49, 14, 582, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 334, DateTimeKind.Utc), "brown", "brown", "180", "https://swapi.co/api/planets/22/", "80", "Han Solo", "fair", null, null, null },
                    { "https://swapi.co/api/people/32/", "92BBY", new DateTime(2014, 12, 19, 16, 54, 53, 618, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 375, DateTimeKind.Utc), "blue", "brown", "193", "https://swapi.co/api/planets/28/", "89", "Qui-Gon Jinn", "fair", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "SpecieMovie",
                columns: new[] { "MovieUri", "SpecieUri" },
                values: new object[,]
                {
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/species/2/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/species/1/" },
                    { "https://swapi.co/api/films/2/", "https://swapi.co/api/species/6/" },
                    { "https://swapi.co/api/films/2/", "https://swapi.co/api/species/7/" },
                    { "https://swapi.co/api/films/7/", "https://swapi.co/api/species/2/" },
                    { "https://swapi.co/api/films/2/", "https://swapi.co/api/species/2/" },
                    { "https://swapi.co/api/films/2/", "https://swapi.co/api/species/1/" },
                    { "https://swapi.co/api/films/7/", "https://swapi.co/api/species/3/" },
                    { "https://swapi.co/api/films/7/", "https://swapi.co/api/species/1/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/species/3/" },
                    { "https://swapi.co/api/films/2/", "https://swapi.co/api/species/3/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/species/15/" },
                    { "https://swapi.co/api/films/1/", "https://swapi.co/api/species/5/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/species/9/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/species/22/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/species/23/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/species/24/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/species/25/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/species/26/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/species/27/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/species/2/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/species/1/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/species/10/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/species/15/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/species/19/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/species/20/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/species/21/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/species/23/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/species/25/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/species/26/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/species/27/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/species/28/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/species/29/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/species/30/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/species/33/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/species/34/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/species/35/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/species/36/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/species/37/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/species/3/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/species/24/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/species/2/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/species/20/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/species/18/" },
                    { "https://swapi.co/api/films/1/", "https://swapi.co/api/species/3/" },
                    { "https://swapi.co/api/films/1/", "https://swapi.co/api/species/2/" },
                    { "https://swapi.co/api/films/1/", "https://swapi.co/api/species/1/" },
                    { "https://swapi.co/api/films/1/", "https://swapi.co/api/species/4/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/species/6/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/species/12/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/species/13/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/species/15/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/species/28/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/species/29/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/species/30/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/species/31/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/species/19/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/species/32/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/species/34/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/species/35/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/species/2/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/species/1/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/species/6/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/species/11/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/species/12/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/species/13/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/species/14/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/species/15/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/species/16/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/species/17/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/species/33/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/species/1/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/species/6/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/species/5/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/species/6/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/species/8/" }
                });

            migrationBuilder.InsertData(
                table: "StarshipMovie",
                columns: new[] { "MovieUri", "StarshipUri" },
                values: new object[,]
                {
                    { "https://swapi.co/api/films/2/", "https://swapi.co/api/starships/11/" },
                    { "https://swapi.co/api/films/2/", "https://swapi.co/api/starships/12/" },
                    { "https://swapi.co/api/films/2/", "https://swapi.co/api/starships/21/" },
                    { "https://swapi.co/api/films/2/", "https://swapi.co/api/starships/22/" },
                    { "https://swapi.co/api/films/2/", "https://swapi.co/api/starships/10/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/starships/63/" },
                    { "https://swapi.co/api/films/2/", "https://swapi.co/api/starships/3/" },
                    { "https://swapi.co/api/films/2/", "https://swapi.co/api/starships/17/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/starships/27/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/starships/23/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/starships/31/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/starships/39/" },
                    { "https://swapi.co/api/films/2/", "https://swapi.co/api/starships/23/" },
                    { "https://swapi.co/api/films/2/", "https://swapi.co/api/starships/15/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/starships/29/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/starships/40/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/starships/3/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/starships/17/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/starships/2/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/starships/64/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/starships/21/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/starships/39/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/starships/43/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/starships/47/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/starships/48/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/starships/49/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/starships/32/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/starships/28/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/starships/52/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/starships/41/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/starships/22/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/starships/32/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/starships/61/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/starships/59/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/starships/48/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/starships/65/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/starships/66/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/starships/74/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/starships/75/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/starships/2/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/starships/68/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/starships/15/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/starships/10/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/starships/32/" },
                    { "https://swapi.co/api/films/7/", "https://swapi.co/api/starships/77/" },
                    { "https://swapi.co/api/films/1/", "https://swapi.co/api/starships/5/" },
                    { "https://swapi.co/api/films/1/", "https://swapi.co/api/starships/9/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/starships/12/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/starships/11/" },
                    { "https://swapi.co/api/films/1/", "https://swapi.co/api/starships/2/" },
                    { "https://swapi.co/api/films/7/", "https://swapi.co/api/starships/10/" },
                    { "https://swapi.co/api/films/1/", "https://swapi.co/api/starships/3/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/starships/58/" },
                    { "https://swapi.co/api/films/1/", "https://swapi.co/api/starships/13/" },
                    { "https://swapi.co/api/films/1/", "https://swapi.co/api/starships/12/" },
                    { "https://swapi.co/api/films/1/", "https://swapi.co/api/starships/11/" },
                    { "https://swapi.co/api/films/1/", "https://swapi.co/api/starships/10/" }
                });

            migrationBuilder.InsertData(
                table: "VehicleMovie",
                columns: new[] { "MovieUri", "VehicleUri" },
                values: new object[,]
                {
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/vehicles/8/" },
                    { "https://swapi.co/api/films/1/", "https://swapi.co/api/vehicles/4/" },
                    { "https://swapi.co/api/films/1/", "https://swapi.co/api/vehicles/6/" },
                    { "https://swapi.co/api/films/1/", "https://swapi.co/api/vehicles/7/" },
                    { "https://swapi.co/api/films/1/", "https://swapi.co/api/vehicles/8/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/vehicles/16/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/vehicles/19/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/vehicles/26/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/vehicles/44/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/vehicles/35/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/vehicles/36/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/vehicles/37/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/vehicles/38/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/vehicles/42/" },
                    { "https://swapi.co/api/films/2/", "https://swapi.co/api/vehicles/16/" },
                    { "https://swapi.co/api/films/2/", "https://swapi.co/api/vehicles/18/" },
                    { "https://swapi.co/api/films/2/", "https://swapi.co/api/vehicles/19/" },
                    { "https://swapi.co/api/films/2/", "https://swapi.co/api/vehicles/20/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/vehicles/71/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/vehicles/70/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/vehicles/69/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/vehicles/67/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/vehicles/62/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/vehicles/60/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/vehicles/50/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/vehicles/33/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/vehicles/34/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/vehicles/4/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/vehicles/33/" },
                    { "https://swapi.co/api/films/2/", "https://swapi.co/api/vehicles/8/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/vehicles/45/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/vehicles/46/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/vehicles/50/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/vehicles/51/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/vehicles/53/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/vehicles/54/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/vehicles/55/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/vehicles/56/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/vehicles/57/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/vehicles/24/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/vehicles/25/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/vehicles/30/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/vehicles/56/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/vehicles/53/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/vehicles/76/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/vehicles/73/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/vehicles/72/" },
                    { "https://swapi.co/api/films/2/", "https://swapi.co/api/vehicles/14/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/vehicles/18/" }
                });

            migrationBuilder.InsertData(
                table: "MovieCharacter",
                columns: new[] { "MovieUri", "PersonUri" },
                values: new object[,]
                {
                    { "https://swapi.co/api/films/1/", "https://swapi.co/api/people/5/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/people/51/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/people/51/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/people/51/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/people/52/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/people/52/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/people/52/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/people/53/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/people/53/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/people/53/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/people/54/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/people/54/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/people/56/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/people/56/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/people/57/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/people/58/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/people/58/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/people/58/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/people/50/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/people/49/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/people/48/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/people/47/" },
                    { "https://swapi.co/api/films/7/", "https://swapi.co/api/people/86/" },
                    { "https://swapi.co/api/films/7/", "https://swapi.co/api/people/87/" },
                    { "https://swapi.co/api/films/7/", "https://swapi.co/api/people/88/" },
                    { "https://swapi.co/api/films/2/", "https://swapi.co/api/people/24/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/people/25/" },
                    { "https://swapi.co/api/films/2/", "https://swapi.co/api/people/25/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/people/27/" },
                    { "https://swapi.co/api/films/7/", "https://swapi.co/api/people/27/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/people/59/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/people/28/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/people/40/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/people/40/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/people/41/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/people/44/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/people/45/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/people/46/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/people/46/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/people/46/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/people/31/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/people/59/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/people/64/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/people/64/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/people/2/" },
                    { "https://swapi.co/api/films/2/", "https://swapi.co/api/people/2/" },
                    { "https://swapi.co/api/films/1/", "https://swapi.co/api/people/4/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/people/4/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/people/4/" },
                    { "https://swapi.co/api/films/2/", "https://swapi.co/api/people/4/" },
                    { "https://swapi.co/api/films/1/", "https://swapi.co/api/people/6/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/people/6/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/people/2/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/people/6/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/people/7/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/people/7/" },
                    { "https://swapi.co/api/films/1/", "https://swapi.co/api/people/8/" },
                    { "https://swapi.co/api/films/1/", "https://swapi.co/api/people/9/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/people/11/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/people/11/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/people/11/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/people/43/" },
                    { "https://swapi.co/api/films/1/", "https://swapi.co/api/people/7/" },
                    { "https://swapi.co/api/films/7/", "https://swapi.co/api/people/85/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/people/2/" },
                    { "https://swapi.co/api/films/1/", "https://swapi.co/api/people/2/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/people/65/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/people/67/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/people/67/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/people/69/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/people/70/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/people/71/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/people/76/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/people/77/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/people/2/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/people/78/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/people/79/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/people/82/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/people/82/" },
                    { "https://swapi.co/api/films/1/", "https://swapi.co/api/people/1/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/people/1/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/people/1/" },
                    { "https://swapi.co/api/films/2/", "https://swapi.co/api/people/1/" },
                    { "https://swapi.co/api/films/7/", "https://swapi.co/api/people/1/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/people/78/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/people/43/" },
                    { "https://swapi.co/api/films/7/", "https://swapi.co/api/people/84/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/people/75/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/people/36/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/people/36/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/people/37/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/people/38/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/people/39/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/people/42/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/people/60/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/people/61/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/people/66/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/people/35/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/people/35/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/people/35/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/people/34/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/people/55/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/people/55/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/people/74/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/people/22/" },
                    { "https://swapi.co/api/films/2/", "https://swapi.co/api/people/21/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/people/21/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/people/21/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/people/21/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/people/5/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/people/5/" },
                    { "https://swapi.co/api/films/2/", "https://swapi.co/api/people/5/" },
                    { "https://swapi.co/api/films/7/", "https://swapi.co/api/people/5/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/people/68/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/people/68/" },
                    { "https://swapi.co/api/films/1/", "https://swapi.co/api/people/81/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/people/81/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/people/22/" },
                    { "https://swapi.co/api/films/2/", "https://swapi.co/api/people/26/" },
                    { "https://swapi.co/api/films/1/", "https://swapi.co/api/people/3/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/people/3/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/people/3/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/people/3/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/people/3/" },
                    { "https://swapi.co/api/films/2/", "https://swapi.co/api/people/3/" },
                    { "https://swapi.co/api/films/7/", "https://swapi.co/api/people/3/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/people/21/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/people/30/" },
                    { "https://swapi.co/api/films/2/", "https://swapi.co/api/people/22/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/people/72/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/people/73/" },
                    { "https://swapi.co/api/films/2/", "https://swapi.co/api/people/14/" },
                    { "https://swapi.co/api/films/7/", "https://swapi.co/api/people/14/" },
                    { "https://swapi.co/api/films/1/", "https://swapi.co/api/people/18/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/people/18/" },
                    { "https://swapi.co/api/films/2/", "https://swapi.co/api/people/18/" },
                    { "https://swapi.co/api/films/1/", "https://swapi.co/api/people/15/" },
                    { "https://swapi.co/api/films/1/", "https://swapi.co/api/people/16/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/people/16/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/people/14/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/people/16/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/people/20/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/people/20/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/people/20/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/people/20/" },
                    { "https://swapi.co/api/films/2/", "https://swapi.co/api/people/20/" },
                    { "https://swapi.co/api/films/2/", "https://swapi.co/api/people/23/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/people/29/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/people/32/" },
                    { "https://swapi.co/api/films/1/", "https://swapi.co/api/people/19/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/people/75/" },
                    { "https://swapi.co/api/films/1/", "https://swapi.co/api/people/14/" },
                    { "https://swapi.co/api/films/1/", "https://swapi.co/api/people/12/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/people/63/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/people/63/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/people/83/" },
                    { "https://swapi.co/api/films/1/", "https://swapi.co/api/people/13/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/people/13/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/people/13/" },
                    { "https://swapi.co/api/films/2/", "https://swapi.co/api/people/13/" },
                    { "https://swapi.co/api/films/7/", "https://swapi.co/api/people/13/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/people/12/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/people/80/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/people/33/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/people/33/" },
                    { "https://swapi.co/api/films/1/", "https://swapi.co/api/people/10/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/people/10/" },
                    { "https://swapi.co/api/films/4/", "https://swapi.co/api/people/10/" },
                    { "https://swapi.co/api/films/6/", "https://swapi.co/api/people/10/" },
                    { "https://swapi.co/api/films/3/", "https://swapi.co/api/people/10/" },
                    { "https://swapi.co/api/films/2/", "https://swapi.co/api/people/10/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/people/33/" },
                    { "https://swapi.co/api/films/5/", "https://swapi.co/api/people/62/" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieCharacter_PersonUri",
                table: "MovieCharacter",
                column: "PersonUri");

            migrationBuilder.CreateIndex(
                name: "IX_MoviePlanet_PlanetUri",
                table: "MoviePlanet",
                column: "PlanetUri");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_SpecieUri",
                table: "Movies",
                column: "SpecieUri");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_StarShipUri",
                table: "Movies",
                column: "StarShipUri");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_VehicleUri",
                table: "Movies",
                column: "VehicleUri");

            migrationBuilder.CreateIndex(
                name: "IX_People_HomeWorldUri",
                table: "People",
                column: "HomeWorldUri");

            migrationBuilder.CreateIndex(
                name: "IX_People_SpecieUri",
                table: "People",
                column: "SpecieUri");

            migrationBuilder.CreateIndex(
                name: "IX_People_StarShipUri",
                table: "People",
                column: "StarShipUri");

            migrationBuilder.CreateIndex(
                name: "IX_People_VehicleUri",
                table: "People",
                column: "VehicleUri");

            migrationBuilder.CreateIndex(
                name: "IX_PeopleSpecies_SpecieUri",
                table: "PeopleSpecies",
                column: "SpecieUri");

            migrationBuilder.CreateIndex(
                name: "IX_PeopleStarships_StarShipUri",
                table: "PeopleStarships",
                column: "StarShipUri");

            migrationBuilder.CreateIndex(
                name: "IX_PeopleVehicles_VehicleUri",
                table: "PeopleVehicles",
                column: "VehicleUri");

            migrationBuilder.CreateIndex(
                name: "IX_Specie_HomeworldUri1",
                table: "Specie",
                column: "HomeworldUri1");

            migrationBuilder.CreateIndex(
                name: "IX_SpecieMovie_SpecieUri",
                table: "SpecieMovie",
                column: "SpecieUri");

            migrationBuilder.CreateIndex(
                name: "IX_StarshipMovie_StarshipUri",
                table: "StarshipMovie",
                column: "StarshipUri");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleMovie_VehicleUri",
                table: "VehicleMovie",
                column: "VehicleUri");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieCharacter");

            migrationBuilder.DropTable(
                name: "MoviePlanet");

            migrationBuilder.DropTable(
                name: "PeopleSpecies");

            migrationBuilder.DropTable(
                name: "PeopleStarships");

            migrationBuilder.DropTable(
                name: "PeopleVehicles");

            migrationBuilder.DropTable(
                name: "SpecieMovie");

            migrationBuilder.DropTable(
                name: "StarshipMovie");

            migrationBuilder.DropTable(
                name: "VehicleMovie");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Specie");

            migrationBuilder.DropTable(
                name: "StarShip");

            migrationBuilder.DropTable(
                name: "Vehicle");

            migrationBuilder.DropTable(
                name: "Planets");
        }
    }
}
