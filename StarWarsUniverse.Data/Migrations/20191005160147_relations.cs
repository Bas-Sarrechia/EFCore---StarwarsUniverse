using Microsoft.EntityFrameworkCore.Migrations;

namespace StarWarsUniverse.Data.Migrations
{
    public partial class relations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PeopleSpecies",
                columns: new[] { "PersonUri", "SpecieUri" },
                values: new object[,]
                {
                    { "https://swapi.co/api/people/1/", "https://swapi.co/api/species/1/" },
                    { "https://swapi.co/api/people/65/", "https://swapi.co/api/species/29/" },
                    { "https://swapi.co/api/people/64/", "https://swapi.co/api/species/29/" },
                    { "https://swapi.co/api/people/63/", "https://swapi.co/api/species/28/" },
                    { "https://swapi.co/api/people/62/", "https://swapi.co/api/species/1/" },
                    { "https://swapi.co/api/people/61/", "https://swapi.co/api/species/1/" },
                    { "https://swapi.co/api/people/60/", "https://swapi.co/api/species/1/" },
                    { "https://swapi.co/api/people/59/", "https://swapi.co/api/species/27/" },
                    { "https://swapi.co/api/people/58/", "https://swapi.co/api/species/26/" },
                    { "https://swapi.co/api/people/57/", "https://swapi.co/api/species/25/" },
                    { "https://swapi.co/api/people/56/", "https://swapi.co/api/species/24/" },
                    { "https://swapi.co/api/people/55/", "https://swapi.co/api/species/23/" },
                    { "https://swapi.co/api/people/54/", "https://swapi.co/api/species/22/" },
                    { "https://swapi.co/api/people/53/", "https://swapi.co/api/species/21/" },
                    { "https://swapi.co/api/people/52/", "https://swapi.co/api/species/20/" },
                    { "https://swapi.co/api/people/51/", "https://swapi.co/api/species/1/" },
                    { "https://swapi.co/api/people/50/", "https://swapi.co/api/species/19/" },
                    { "https://swapi.co/api/people/49/", "https://swapi.co/api/species/18/" },
                    { "https://swapi.co/api/people/66/", "https://swapi.co/api/species/1/" },
                    { "https://swapi.co/api/people/48/", "https://swapi.co/api/species/17/" },
                    { "https://swapi.co/api/people/67/", "https://swapi.co/api/species/1/" },
                    { "https://swapi.co/api/people/70/", "https://swapi.co/api/species/30/" },
                    { "https://swapi.co/api/people/35/", "https://swapi.co/api/species/1/" },
                    { "https://swapi.co/api/people/87/", "https://swapi.co/api/species/2/" },
                    { "https://swapi.co/api/people/86/", "https://swapi.co/api/species/1/" },
                    { "https://swapi.co/api/people/85/", "https://swapi.co/api/species/1/" },
                    { "https://swapi.co/api/people/84/", "https://swapi.co/api/species/1/" },
                    { "https://swapi.co/api/people/83/", "https://swapi.co/api/species/37/" },
                    { "https://swapi.co/api/people/81/", "https://swapi.co/api/species/1/" },
                    { "https://swapi.co/api/people/80/", "https://swapi.co/api/species/3/" },
                    { "https://swapi.co/api/people/79/", "https://swapi.co/api/species/36/" },
                    { "https://swapi.co/api/people/78/", "https://swapi.co/api/species/35/" },
                    { "https://swapi.co/api/people/77/", "https://swapi.co/api/species/34/" },
                    { "https://swapi.co/api/people/76/", "https://swapi.co/api/species/33/" },
                    { "https://swapi.co/api/people/47/", "https://swapi.co/api/species/16/" },
                    { "https://swapi.co/api/people/74/", "https://swapi.co/api/species/1/" },
                    { "https://swapi.co/api/people/73/", "https://swapi.co/api/species/32/" },
                    { "https://swapi.co/api/people/72/", "https://swapi.co/api/species/32/" },
                    { "https://swapi.co/api/people/71/", "https://swapi.co/api/species/31/" },
                    { "https://swapi.co/api/people/69/", "https://swapi.co/api/species/1/" },
                    { "https://swapi.co/api/people/46/", "https://swapi.co/api/species/15/" },
                    { "https://swapi.co/api/people/68/", "https://swapi.co/api/species/1/" },
                    { "https://swapi.co/api/people/44/", "https://swapi.co/api/species/22/" },
                    { "https://swapi.co/api/people/19/", "https://swapi.co/api/species/1/" },
                    { "https://swapi.co/api/people/18/", "https://swapi.co/api/species/1/" },
                    { "https://swapi.co/api/people/16/", "https://swapi.co/api/species/5/" },
                    { "https://swapi.co/api/people/15/", "https://swapi.co/api/species/4/" },
                    { "https://swapi.co/api/people/13/", "https://swapi.co/api/species/3/" },
                    { "https://swapi.co/api/people/12/", "https://swapi.co/api/species/1/" },
                    { "https://swapi.co/api/people/11/", "https://swapi.co/api/species/1/" },
                    { "https://swapi.co/api/people/10/", "https://swapi.co/api/species/1/" },
                    { "https://swapi.co/api/people/9/", "https://swapi.co/api/species/1/" },
                    { "https://swapi.co/api/people/8/", "https://swapi.co/api/species/2/" },
                    { "https://swapi.co/api/people/7/", "https://swapi.co/api/species/1/" },
                    { "https://swapi.co/api/people/6/", "https://swapi.co/api/species/1/" },
                    { "https://swapi.co/api/people/5/", "https://swapi.co/api/species/1/" },
                    { "https://swapi.co/api/people/4/", "https://swapi.co/api/species/1/" },
                    { "https://swapi.co/api/people/3/", "https://swapi.co/api/species/2/" },
                    { "https://swapi.co/api/people/2/", "https://swapi.co/api/species/2/" },
                    { "https://swapi.co/api/people/45/", "https://swapi.co/api/species/15/" },
                    { "https://swapi.co/api/people/20/", "https://swapi.co/api/species/6/" },
                    { "https://swapi.co/api/people/21/", "https://swapi.co/api/species/1/" },
                    { "https://swapi.co/api/people/14/", "https://swapi.co/api/species/1/" },
                    { "https://swapi.co/api/people/22/", "https://swapi.co/api/species/1/" },
                    { "https://swapi.co/api/people/43/", "https://swapi.co/api/species/1/" },
                    { "https://swapi.co/api/people/41/", "https://swapi.co/api/species/14/" },
                    { "https://swapi.co/api/people/40/", "https://swapi.co/api/species/13/" },
                    { "https://swapi.co/api/people/37/", "https://swapi.co/api/species/12/" },
                    { "https://swapi.co/api/people/36/", "https://swapi.co/api/species/12/" },
                    { "https://swapi.co/api/people/34/", "https://swapi.co/api/species/1/" },
                    { "https://swapi.co/api/people/33/", "https://swapi.co/api/species/11/" },
                    { "https://swapi.co/api/people/32/", "https://swapi.co/api/species/1/" },
                    { "https://swapi.co/api/people/31/", "https://swapi.co/api/species/10/" },
                    { "https://swapi.co/api/people/38/", "https://swapi.co/api/species/12/" },
                    { "https://swapi.co/api/people/29/", "https://swapi.co/api/species/1/" },
                    { "https://swapi.co/api/people/28/", "https://swapi.co/api/species/1/" },
                    { "https://swapi.co/api/people/27/", "https://swapi.co/api/species/8/" },
                    { "https://swapi.co/api/people/26/", "https://swapi.co/api/species/1/" },
                    { "https://swapi.co/api/people/25/", "https://swapi.co/api/species/1/" },
                    { "https://swapi.co/api/people/24/", "https://swapi.co/api/species/7/" },
                    { "https://swapi.co/api/people/23/", "https://swapi.co/api/species/2/" },
                    { "https://swapi.co/api/people/30/", "https://swapi.co/api/species/9/" }
                });

            migrationBuilder.InsertData(
                table: "PeopleStarships",
                columns: new[] { "PersonUri", "StarShipUri" },
                values: new object[,]
                {
                    { "https://swapi.co/api/people/22/", "https://swapi.co/api/starships/21/" },
                    { "https://swapi.co/api/people/25/", "https://swapi.co/api/starships/10/" },
                    { "https://swapi.co/api/people/29/", "https://swapi.co/api/starships/28/" },
                    { "https://swapi.co/api/people/31/", "https://swapi.co/api/starships/10/" },
                    { "https://swapi.co/api/people/39/", "https://swapi.co/api/starships/40/" },
                    { "https://swapi.co/api/people/44/", "https://swapi.co/api/starships/41/" },
                    { "https://swapi.co/api/people/86/", "https://swapi.co/api/starships/77/" },
                    { "https://swapi.co/api/people/60/", "https://swapi.co/api/starships/39/" },
                    { "https://swapi.co/api/people/79/", "https://swapi.co/api/starships/74/" },
                    { "https://swapi.co/api/people/35/", "https://swapi.co/api/starships/39/" },
                    { "https://swapi.co/api/people/35/", "https://swapi.co/api/starships/49/" },
                    { "https://swapi.co/api/people/35/", "https://swapi.co/api/starships/64/" },
                    { "https://swapi.co/api/people/19/", "https://swapi.co/api/starships/12/" },
                    { "https://swapi.co/api/people/58/", "https://swapi.co/api/starships/48/" },
                    { "https://swapi.co/api/people/18/", "https://swapi.co/api/starships/12/" },
                    { "https://swapi.co/api/people/1/", "https://swapi.co/api/starships/22/" },
                    { "https://swapi.co/api/people/14/", "https://swapi.co/api/starships/10/" },
                    { "https://swapi.co/api/people/14/", "https://swapi.co/api/starships/22/" },
                    { "https://swapi.co/api/people/4/", "https://swapi.co/api/starships/13/" },
                    { "https://swapi.co/api/people/9/", "https://swapi.co/api/starships/12/" },
                    { "https://swapi.co/api/people/10/", "https://swapi.co/api/starships/48/" },
                    { "https://swapi.co/api/people/10/", "https://swapi.co/api/starships/59/" },
                    { "https://swapi.co/api/people/10/", "https://swapi.co/api/starships/64/" },
                    { "https://swapi.co/api/people/1/", "https://swapi.co/api/starships/12/" },
                    { "https://swapi.co/api/people/10/", "https://swapi.co/api/starships/74/" },
                    { "https://swapi.co/api/people/11/", "https://swapi.co/api/starships/39/" },
                    { "https://swapi.co/api/people/11/", "https://swapi.co/api/starships/59/" },
                    { "https://swapi.co/api/people/11/", "https://swapi.co/api/starships/65/" },
                    { "https://swapi.co/api/people/13/", "https://swapi.co/api/starships/10/" },
                    { "https://swapi.co/api/people/13/", "https://swapi.co/api/starships/22/" },
                    { "https://swapi.co/api/people/10/", "https://swapi.co/api/starships/65/" }
                });

            migrationBuilder.InsertData(
                table: "PeopleVehicles",
                columns: new[] { "PersonUri", "VehicleUri" },
                values: new object[,]
                {
                    { "https://swapi.co/api/people/67/", "https://swapi.co/api/vehicles/55/" },
                    { "https://swapi.co/api/people/44/", "https://swapi.co/api/vehicles/42/" },
                    { "https://swapi.co/api/people/32/", "https://swapi.co/api/vehicles/38/" },
                    { "https://swapi.co/api/people/18/", "https://swapi.co/api/vehicles/14/" },
                    { "https://swapi.co/api/people/13/", "https://swapi.co/api/vehicles/19/" },
                    { "https://swapi.co/api/people/5/", "https://swapi.co/api/vehicles/30/" },
                    { "https://swapi.co/api/people/11/", "https://swapi.co/api/vehicles/44/" },
                    { "https://swapi.co/api/people/10/", "https://swapi.co/api/vehicles/38/" },
                    { "https://swapi.co/api/people/1/", "https://swapi.co/api/vehicles/30/" },
                    { "https://swapi.co/api/people/1/", "https://swapi.co/api/vehicles/14/" },
                    { "https://swapi.co/api/people/70/", "https://swapi.co/api/vehicles/45/" },
                    { "https://swapi.co/api/people/11/", "https://swapi.co/api/vehicles/46/" },
                    { "https://swapi.co/api/people/79/", "https://swapi.co/api/vehicles/60/" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/1/", "https://swapi.co/api/species/1/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/10/", "https://swapi.co/api/species/1/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/11/", "https://swapi.co/api/species/1/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/12/", "https://swapi.co/api/species/1/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/13/", "https://swapi.co/api/species/3/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/14/", "https://swapi.co/api/species/1/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/15/", "https://swapi.co/api/species/4/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/16/", "https://swapi.co/api/species/5/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/18/", "https://swapi.co/api/species/1/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/19/", "https://swapi.co/api/species/1/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/2/", "https://swapi.co/api/species/2/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/20/", "https://swapi.co/api/species/6/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/21/", "https://swapi.co/api/species/1/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/22/", "https://swapi.co/api/species/1/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/23/", "https://swapi.co/api/species/2/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/24/", "https://swapi.co/api/species/7/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/25/", "https://swapi.co/api/species/1/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/26/", "https://swapi.co/api/species/1/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/27/", "https://swapi.co/api/species/8/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/28/", "https://swapi.co/api/species/1/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/29/", "https://swapi.co/api/species/1/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/3/", "https://swapi.co/api/species/2/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/30/", "https://swapi.co/api/species/9/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/31/", "https://swapi.co/api/species/10/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/32/", "https://swapi.co/api/species/1/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/33/", "https://swapi.co/api/species/11/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/34/", "https://swapi.co/api/species/1/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/35/", "https://swapi.co/api/species/1/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/36/", "https://swapi.co/api/species/12/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/37/", "https://swapi.co/api/species/12/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/38/", "https://swapi.co/api/species/12/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/4/", "https://swapi.co/api/species/1/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/40/", "https://swapi.co/api/species/13/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/41/", "https://swapi.co/api/species/14/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/43/", "https://swapi.co/api/species/1/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/44/", "https://swapi.co/api/species/22/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/45/", "https://swapi.co/api/species/15/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/46/", "https://swapi.co/api/species/15/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/47/", "https://swapi.co/api/species/16/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/48/", "https://swapi.co/api/species/17/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/49/", "https://swapi.co/api/species/18/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/5/", "https://swapi.co/api/species/1/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/50/", "https://swapi.co/api/species/19/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/51/", "https://swapi.co/api/species/1/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/52/", "https://swapi.co/api/species/20/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/53/", "https://swapi.co/api/species/21/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/54/", "https://swapi.co/api/species/22/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/55/", "https://swapi.co/api/species/23/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/56/", "https://swapi.co/api/species/24/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/57/", "https://swapi.co/api/species/25/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/58/", "https://swapi.co/api/species/26/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/59/", "https://swapi.co/api/species/27/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/6/", "https://swapi.co/api/species/1/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/60/", "https://swapi.co/api/species/1/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/61/", "https://swapi.co/api/species/1/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/62/", "https://swapi.co/api/species/1/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/63/", "https://swapi.co/api/species/28/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/64/", "https://swapi.co/api/species/29/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/65/", "https://swapi.co/api/species/29/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/66/", "https://swapi.co/api/species/1/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/67/", "https://swapi.co/api/species/1/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/68/", "https://swapi.co/api/species/1/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/69/", "https://swapi.co/api/species/1/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/7/", "https://swapi.co/api/species/1/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/70/", "https://swapi.co/api/species/30/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/71/", "https://swapi.co/api/species/31/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/72/", "https://swapi.co/api/species/32/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/73/", "https://swapi.co/api/species/32/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/74/", "https://swapi.co/api/species/1/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/76/", "https://swapi.co/api/species/33/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/77/", "https://swapi.co/api/species/34/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/78/", "https://swapi.co/api/species/35/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/79/", "https://swapi.co/api/species/36/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/8/", "https://swapi.co/api/species/2/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/80/", "https://swapi.co/api/species/3/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/81/", "https://swapi.co/api/species/1/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/83/", "https://swapi.co/api/species/37/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/84/", "https://swapi.co/api/species/1/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/85/", "https://swapi.co/api/species/1/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/86/", "https://swapi.co/api/species/1/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/87/", "https://swapi.co/api/species/2/" });

            migrationBuilder.DeleteData(
                table: "PeopleSpecies",
                keyColumns: new[] { "PersonUri", "SpecieUri" },
                keyValues: new object[] { "https://swapi.co/api/people/9/", "https://swapi.co/api/species/1/" });

            migrationBuilder.DeleteData(
                table: "PeopleStarships",
                keyColumns: new[] { "PersonUri", "StarShipUri" },
                keyValues: new object[] { "https://swapi.co/api/people/1/", "https://swapi.co/api/starships/12/" });

            migrationBuilder.DeleteData(
                table: "PeopleStarships",
                keyColumns: new[] { "PersonUri", "StarShipUri" },
                keyValues: new object[] { "https://swapi.co/api/people/1/", "https://swapi.co/api/starships/22/" });

            migrationBuilder.DeleteData(
                table: "PeopleStarships",
                keyColumns: new[] { "PersonUri", "StarShipUri" },
                keyValues: new object[] { "https://swapi.co/api/people/10/", "https://swapi.co/api/starships/48/" });

            migrationBuilder.DeleteData(
                table: "PeopleStarships",
                keyColumns: new[] { "PersonUri", "StarShipUri" },
                keyValues: new object[] { "https://swapi.co/api/people/10/", "https://swapi.co/api/starships/59/" });

            migrationBuilder.DeleteData(
                table: "PeopleStarships",
                keyColumns: new[] { "PersonUri", "StarShipUri" },
                keyValues: new object[] { "https://swapi.co/api/people/10/", "https://swapi.co/api/starships/64/" });

            migrationBuilder.DeleteData(
                table: "PeopleStarships",
                keyColumns: new[] { "PersonUri", "StarShipUri" },
                keyValues: new object[] { "https://swapi.co/api/people/10/", "https://swapi.co/api/starships/65/" });

            migrationBuilder.DeleteData(
                table: "PeopleStarships",
                keyColumns: new[] { "PersonUri", "StarShipUri" },
                keyValues: new object[] { "https://swapi.co/api/people/10/", "https://swapi.co/api/starships/74/" });

            migrationBuilder.DeleteData(
                table: "PeopleStarships",
                keyColumns: new[] { "PersonUri", "StarShipUri" },
                keyValues: new object[] { "https://swapi.co/api/people/11/", "https://swapi.co/api/starships/39/" });

            migrationBuilder.DeleteData(
                table: "PeopleStarships",
                keyColumns: new[] { "PersonUri", "StarShipUri" },
                keyValues: new object[] { "https://swapi.co/api/people/11/", "https://swapi.co/api/starships/59/" });

            migrationBuilder.DeleteData(
                table: "PeopleStarships",
                keyColumns: new[] { "PersonUri", "StarShipUri" },
                keyValues: new object[] { "https://swapi.co/api/people/11/", "https://swapi.co/api/starships/65/" });

            migrationBuilder.DeleteData(
                table: "PeopleStarships",
                keyColumns: new[] { "PersonUri", "StarShipUri" },
                keyValues: new object[] { "https://swapi.co/api/people/13/", "https://swapi.co/api/starships/10/" });

            migrationBuilder.DeleteData(
                table: "PeopleStarships",
                keyColumns: new[] { "PersonUri", "StarShipUri" },
                keyValues: new object[] { "https://swapi.co/api/people/13/", "https://swapi.co/api/starships/22/" });

            migrationBuilder.DeleteData(
                table: "PeopleStarships",
                keyColumns: new[] { "PersonUri", "StarShipUri" },
                keyValues: new object[] { "https://swapi.co/api/people/14/", "https://swapi.co/api/starships/10/" });

            migrationBuilder.DeleteData(
                table: "PeopleStarships",
                keyColumns: new[] { "PersonUri", "StarShipUri" },
                keyValues: new object[] { "https://swapi.co/api/people/14/", "https://swapi.co/api/starships/22/" });

            migrationBuilder.DeleteData(
                table: "PeopleStarships",
                keyColumns: new[] { "PersonUri", "StarShipUri" },
                keyValues: new object[] { "https://swapi.co/api/people/18/", "https://swapi.co/api/starships/12/" });

            migrationBuilder.DeleteData(
                table: "PeopleStarships",
                keyColumns: new[] { "PersonUri", "StarShipUri" },
                keyValues: new object[] { "https://swapi.co/api/people/19/", "https://swapi.co/api/starships/12/" });

            migrationBuilder.DeleteData(
                table: "PeopleStarships",
                keyColumns: new[] { "PersonUri", "StarShipUri" },
                keyValues: new object[] { "https://swapi.co/api/people/22/", "https://swapi.co/api/starships/21/" });

            migrationBuilder.DeleteData(
                table: "PeopleStarships",
                keyColumns: new[] { "PersonUri", "StarShipUri" },
                keyValues: new object[] { "https://swapi.co/api/people/25/", "https://swapi.co/api/starships/10/" });

            migrationBuilder.DeleteData(
                table: "PeopleStarships",
                keyColumns: new[] { "PersonUri", "StarShipUri" },
                keyValues: new object[] { "https://swapi.co/api/people/29/", "https://swapi.co/api/starships/28/" });

            migrationBuilder.DeleteData(
                table: "PeopleStarships",
                keyColumns: new[] { "PersonUri", "StarShipUri" },
                keyValues: new object[] { "https://swapi.co/api/people/31/", "https://swapi.co/api/starships/10/" });

            migrationBuilder.DeleteData(
                table: "PeopleStarships",
                keyColumns: new[] { "PersonUri", "StarShipUri" },
                keyValues: new object[] { "https://swapi.co/api/people/35/", "https://swapi.co/api/starships/39/" });

            migrationBuilder.DeleteData(
                table: "PeopleStarships",
                keyColumns: new[] { "PersonUri", "StarShipUri" },
                keyValues: new object[] { "https://swapi.co/api/people/35/", "https://swapi.co/api/starships/49/" });

            migrationBuilder.DeleteData(
                table: "PeopleStarships",
                keyColumns: new[] { "PersonUri", "StarShipUri" },
                keyValues: new object[] { "https://swapi.co/api/people/35/", "https://swapi.co/api/starships/64/" });

            migrationBuilder.DeleteData(
                table: "PeopleStarships",
                keyColumns: new[] { "PersonUri", "StarShipUri" },
                keyValues: new object[] { "https://swapi.co/api/people/39/", "https://swapi.co/api/starships/40/" });

            migrationBuilder.DeleteData(
                table: "PeopleStarships",
                keyColumns: new[] { "PersonUri", "StarShipUri" },
                keyValues: new object[] { "https://swapi.co/api/people/4/", "https://swapi.co/api/starships/13/" });

            migrationBuilder.DeleteData(
                table: "PeopleStarships",
                keyColumns: new[] { "PersonUri", "StarShipUri" },
                keyValues: new object[] { "https://swapi.co/api/people/44/", "https://swapi.co/api/starships/41/" });

            migrationBuilder.DeleteData(
                table: "PeopleStarships",
                keyColumns: new[] { "PersonUri", "StarShipUri" },
                keyValues: new object[] { "https://swapi.co/api/people/58/", "https://swapi.co/api/starships/48/" });

            migrationBuilder.DeleteData(
                table: "PeopleStarships",
                keyColumns: new[] { "PersonUri", "StarShipUri" },
                keyValues: new object[] { "https://swapi.co/api/people/60/", "https://swapi.co/api/starships/39/" });

            migrationBuilder.DeleteData(
                table: "PeopleStarships",
                keyColumns: new[] { "PersonUri", "StarShipUri" },
                keyValues: new object[] { "https://swapi.co/api/people/79/", "https://swapi.co/api/starships/74/" });

            migrationBuilder.DeleteData(
                table: "PeopleStarships",
                keyColumns: new[] { "PersonUri", "StarShipUri" },
                keyValues: new object[] { "https://swapi.co/api/people/86/", "https://swapi.co/api/starships/77/" });

            migrationBuilder.DeleteData(
                table: "PeopleStarships",
                keyColumns: new[] { "PersonUri", "StarShipUri" },
                keyValues: new object[] { "https://swapi.co/api/people/9/", "https://swapi.co/api/starships/12/" });

            migrationBuilder.DeleteData(
                table: "PeopleVehicles",
                keyColumns: new[] { "PersonUri", "VehicleUri" },
                keyValues: new object[] { "https://swapi.co/api/people/1/", "https://swapi.co/api/vehicles/14/" });

            migrationBuilder.DeleteData(
                table: "PeopleVehicles",
                keyColumns: new[] { "PersonUri", "VehicleUri" },
                keyValues: new object[] { "https://swapi.co/api/people/1/", "https://swapi.co/api/vehicles/30/" });

            migrationBuilder.DeleteData(
                table: "PeopleVehicles",
                keyColumns: new[] { "PersonUri", "VehicleUri" },
                keyValues: new object[] { "https://swapi.co/api/people/10/", "https://swapi.co/api/vehicles/38/" });

            migrationBuilder.DeleteData(
                table: "PeopleVehicles",
                keyColumns: new[] { "PersonUri", "VehicleUri" },
                keyValues: new object[] { "https://swapi.co/api/people/11/", "https://swapi.co/api/vehicles/44/" });

            migrationBuilder.DeleteData(
                table: "PeopleVehicles",
                keyColumns: new[] { "PersonUri", "VehicleUri" },
                keyValues: new object[] { "https://swapi.co/api/people/11/", "https://swapi.co/api/vehicles/46/" });

            migrationBuilder.DeleteData(
                table: "PeopleVehicles",
                keyColumns: new[] { "PersonUri", "VehicleUri" },
                keyValues: new object[] { "https://swapi.co/api/people/13/", "https://swapi.co/api/vehicles/19/" });

            migrationBuilder.DeleteData(
                table: "PeopleVehicles",
                keyColumns: new[] { "PersonUri", "VehicleUri" },
                keyValues: new object[] { "https://swapi.co/api/people/18/", "https://swapi.co/api/vehicles/14/" });

            migrationBuilder.DeleteData(
                table: "PeopleVehicles",
                keyColumns: new[] { "PersonUri", "VehicleUri" },
                keyValues: new object[] { "https://swapi.co/api/people/32/", "https://swapi.co/api/vehicles/38/" });

            migrationBuilder.DeleteData(
                table: "PeopleVehicles",
                keyColumns: new[] { "PersonUri", "VehicleUri" },
                keyValues: new object[] { "https://swapi.co/api/people/44/", "https://swapi.co/api/vehicles/42/" });

            migrationBuilder.DeleteData(
                table: "PeopleVehicles",
                keyColumns: new[] { "PersonUri", "VehicleUri" },
                keyValues: new object[] { "https://swapi.co/api/people/5/", "https://swapi.co/api/vehicles/30/" });

            migrationBuilder.DeleteData(
                table: "PeopleVehicles",
                keyColumns: new[] { "PersonUri", "VehicleUri" },
                keyValues: new object[] { "https://swapi.co/api/people/67/", "https://swapi.co/api/vehicles/55/" });

            migrationBuilder.DeleteData(
                table: "PeopleVehicles",
                keyColumns: new[] { "PersonUri", "VehicleUri" },
                keyValues: new object[] { "https://swapi.co/api/people/70/", "https://swapi.co/api/vehicles/45/" });

            migrationBuilder.DeleteData(
                table: "PeopleVehicles",
                keyColumns: new[] { "PersonUri", "VehicleUri" },
                keyValues: new object[] { "https://swapi.co/api/people/79/", "https://swapi.co/api/vehicles/60/" });
        }
    }
}
