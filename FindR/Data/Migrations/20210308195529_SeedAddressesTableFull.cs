using Microsoft.EntityFrameworkCore.Migrations;

namespace FindR.Data.Migrations
{
    public partial class SeedAddressesTableFull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressId", "City", "Country", "Zone" },
                values: new object[,]
                {
                    { 3, "Alexandria", "Romania", 0 },
                    { 63, "Slobozia", "Romania", 1 },
                    { 62, "Slatina", "Romania", 0 },
                    { 61, "Slatina", "Romania", 1 },
                    { 60, "Sibiu", "Romania", 0 },
                    { 59, "Sibiu", "Romania", 1 },
                    { 58, "Sfantu Gheorghe", "Romania", 0 },
                    { 57, "Sfantu Gheorghe", "Romania", 1 },
                    { 56, "Satu Mare", "Romania", 0 },
                    { 55, "Satu Mare", "Romania", 1 },
                    { 54, "Resita", "Romania", 0 },
                    { 53, "Resita", "Romania", 1 },
                    { 52, "Ramnicu Valcea", "Romania", 0 },
                    { 51, "Ramnicu Valcea", "Romania", 1 },
                    { 50, "Ploiesti", "Romania", 0 },
                    { 49, "Ploiesti", "Romania", 1 },
                    { 48, "Pitesti", "Romania", 0 },
                    { 47, "Pitesti", "Romania", 1 },
                    { 64, "Slobozia", "Romania", 0 },
                    { 65, "Suceava", "Romania", 0 },
                    { 66, "Suceava", "Romania", 1 },
                    { 67, "Targoviste", "Romania", 0 },
                    { 85, "Bucuresti, Sector5", "Romania", 0 },
                    { 84, "Bucuresti, Sector4", "Romania", 0 },
                    { 83, "Bucuresti, Sector3", "Romania", 0 },
                    { 82, "Bucuresti, Sector2", "Romania", 0 },
                    { 81, "Bucuresti, Sector1", "Romania", 0 },
                    { 80, "Zalau", "Romania", 0 },
                    { 79, "Zalau", "Romania", 1 },
                    { 78, "Vaslui", "Romania", 1 },
                    { 46, "Piatra Neamt", "Romania", 0 },
                    { 77, "Vaslui", "Romania", 0 },
                    { 75, "Tulcea", "Romania", 0 },
                    { 74, "Timisoara", "Romania", 1 },
                    { 73, "Timisoara", "Romania", 0 },
                    { 72, "Targu Mures", "Romania", 1 },
                    { 71, "Targu Mures", "Romania", 0 },
                    { 70, "Targu Jiu", "Romania", 1 },
                    { 69, "Targu Jiu", "Romania", 0 },
                    { 68, "Targoviste", "Romania", 1 },
                    { 76, "Tulcea", "Romania", 1 },
                    { 86, "Bucuresti, Sector6", "Romania", 0 }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressId", "City", "Country", "Zone" },
                values: new object[,]
                {
                    { 45, "Piatra Neamt", "Romania", 1 },
                    { 43, "Oradea", "Romania", 1 },
                    { 20, "Buzau", "Romania", 1 },
                    { 19, "Buzau", "Romania", 0 },
                    { 18, "Braila", "Romania", 1 },
                    { 17, "Braila", "Romania", 0 },
                    { 16, "Brasov", "Romania", 1 },
                    { 15, "Brasov", "Romania", 0 },
                    { 14, "Botosani", "Romania", 1 },
                    { 13, "Botosani", "Romania", 0 },
                    { 12, "Bistrita", "Romania", 1 },
                    { 11, "Bistrita", "Romania", 0 },
                    { 10, "Baia Mare", "Romania", 1 },
                    { 9, "Baia Mare", "Romania", 0 },
                    { 8, "Bacau", "Romania", 1 },
                    { 7, "Bacau", "Romania", 0 },
                    { 6, "Arad", "Romania", 1 },
                    { 5, "Arad", "Romania", 0 },
                    { 4, "Alexandria", "Romania", 1 },
                    { 21, "Calarasi", "Romania", 0 },
                    { 22, "Calarasi", "Romania", 1 },
                    { 23, "Cluj-Napoca", "Romania", 0 },
                    { 24, "Cluj-Napoca", "Romania", 1 },
                    { 42, "Miercurea-Ciuc", "Romania", 0 },
                    { 41, "Miercurea-Ciuc", "Romania", 1 },
                    { 40, "Iasi", "Romania", 0 },
                    { 39, "Iasi", "Romania", 1 },
                    { 38, "Giurgiu", "Romania", 0 },
                    { 37, "Giurgiu", "Romania", 1 },
                    { 36, "Galati", "Romania", 0 },
                    { 35, "Galati", "Romania", 1 },
                    { 44, "Oradea", "Romania", 0 },
                    { 34, "Focsani", "Romania", 0 },
                    { 32, "Drobeta-Turnu-Severin", "Romania", 1 },
                    { 31, "Drobeta-Turnu-Severin", "Romania", 0 },
                    { 30, "Deva", "Romania", 1 },
                    { 29, "Deva", "Romania", 0 },
                    { 28, "Craiova", "Romania", 1 },
                    { 27, "Craiova", "Romania", 0 },
                    { 26, "Constanta", "Romania", 1 },
                    { 25, "Constanta", "Romania", 0 },
                    { 33, "Focsani", "Romania", 1 }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressId", "City", "Country", "Zone" },
                values: new object[] { 87, "Bucuresti", "Romania", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 87);
        }
    }
}
