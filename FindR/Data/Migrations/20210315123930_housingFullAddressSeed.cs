using Microsoft.EntityFrameworkCore.Migrations;

namespace FindR.Data.Migrations
{
    public partial class housingFullAddressSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Housings_CompleteAddresses_FullAddressCompleteAddress_Id",
                table: "Housings");

            migrationBuilder.DropIndex(
                name: "IX_Housings_FullAddressCompleteAddress_Id",
                table: "Housings");

            migrationBuilder.DropColumn(
                name: "FullAddressCompleteAddress_Id",
                table: "Housings");

            migrationBuilder.AddColumn<int>(
                name: "HousingId",
                table: "CompleteAddresses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Housings",
                columns: new[] { "HousingId", "IsTaken", "NoOfRooms", "Price" },
                values: new object[,]
                {
                    { 1, false, 1, 600 },
                    { 28, false, 2, 1800 },
                    { 27, false, 1, 500 },
                    { 26, false, 2, 1000 },
                    { 25, false, 3, 1800 },
                    { 24, false, 2, 1450 },
                    { 23, false, 2, 1600 },
                    { 22, false, 1, 1300 },
                    { 21, false, 2, 800 },
                    { 20, false, 2, 1300 },
                    { 19, false, 3, 1500 },
                    { 18, false, 1, 1300 },
                    { 17, false, 3, 2500 },
                    { 16, false, 2, 1200 },
                    { 15, false, 3, 1250 },
                    { 14, false, 2, 900 },
                    { 13, false, 2, 700 },
                    { 12, false, 2, 1400 },
                    { 11, true, 2, 900 },
                    { 10, false, 2, 1000 },
                    { 9, false, 3, 1700 },
                    { 8, false, 2, 900 },
                    { 7, false, 2, 1500 },
                    { 6, false, 2, 1100 },
                    { 5, true, 1, 600 },
                    { 4, false, 4, 2000 },
                    { 3, false, 2, 1200 },
                    { 2, false, 2, 1000 },
                    { 29, false, 3, 1700 },
                    { 30, false, 4, 3000 }
                });

            migrationBuilder.InsertData(
                table: "CompleteAddresses",
                columns: new[] { "CompleteAddressId", "AddressId", "Floor", "HousingId", "Latitude", "Longitude", "Street" },
                values: new object[,]
                {
                    { 1, 1, "2", 1, "46.066828", "23.554441", "Strada Gladiolelor 8" },
                    { 28, 86, "3", 28, "44.435211", "26.036348", "Aleea Cetatuia 10" },
                    { 27, 86, "3", 27, "44.420257", "26.004572", "Aleea Pupaza cu Mot 22" },
                    { 26, 85, "8", 26, "44.404615", "26.059843", "Strada Topolinita 59" },
                    { 25, 85, "Parter", 25, "44.394717", "26.043258", "Strada Botosani 26" },
                    { 24, 84, "1", 24, "44.413708", "26.114010", "Calea Vacaresti 184" },
                    { 23, 84, "Parter", 23, "44.411703", "26.113875", "Calea Vacaresti 232" },
                    { 22, 83, "2", 22, "44.416427", "26.127926", "Strada Zizin 18" },
                    { 21, 83, "3", 21, "44.414781", "26.183618", "Strada Gura Ialomitei 3" },
                    { 20, 82, "9", 20, "44.452571", "26.102739", "Soseaua Stefan cel Mare 11" },
                    { 19, 82, "6", 19, "44.438978", "26.173939", "Strada Bodesti 2" },
                    { 18, 81, "5", 18, "46.794320", "23.524650", "Bulevardul Dinica Golescu 43" },
                    { 17, 24, "3", 17, "46.794320", "23.524650", "Strada Magnoliei 70" },
                    { 16, 73, "5", 16, "45.755140", "21.223142", "Strada Paris 2" },
                    { 15, 73, "1", 15, "45.775033", "21.228275", "Strada Ion Miron 34" },
                    { 14, 60, "4", 14, "45.785642", "24.134520", "Strada Hategului 5" },
                    { 13, 56, "3", 13, "47.785716", "22.860054", "Bulevardul Muncii 36" },
                    { 12, 25, "Parter", 12, "44.197265", "28.627114", "Strada Dorului 53" },
                    { 11, 25, "Parter", 11, "44.187265", "28.627114", "Strada Dorului 57" },
                    { 10, 25, "2", 10, "44.201169", "28.647306", "Strada Ioan Borcea 35" },
                    { 9, 24, "3", 9, "46.794320", "23.524650", "Strada Magnoliei 70" },
                    { 8, 23, "1", 8, "46.763605", "23.596262", "Strada Aviator Badescu 34" },
                    { 7, 23, "Parter", 7, "46.766510", "23.609383", "Strada Vasile Lupu 24" },
                    { 6, 23, "4", 6, "46.756804", "23.559443", "Strada Ion Mester 3" },
                    { 5, 15, "Parter", 5, "45.655480", "25.594241", "Strada Sitei 84" },
                    { 4, 15, "Parter,1", 4, "45.661322", "25.599990", "Strada Vulcan 49" },
                    { 3, 15, "1", 3, "45.640371", "25.624299", "Strada Zorilor 13" },
                    { 2, 2, "Parter", 2, "46.175409", "21.310149", "Strada Octaviang Goga 34" },
                    { 29, 87, "Parter", 29, "43.377385", "26.166757", "Strada Veseliei 29" },
                    { 30, 87, "2", 30, "44.552820", "26.070561", "Strada Floare de Cais 13" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompleteAddresses_HousingId",
                table: "CompleteAddresses",
                column: "HousingId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CompleteAddresses_Housings_HousingId",
                table: "CompleteAddresses",
                column: "HousingId",
                principalTable: "Housings",
                principalColumn: "HousingId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompleteAddresses_Housings_HousingId",
                table: "CompleteAddresses");

            migrationBuilder.DropIndex(
                name: "IX_CompleteAddresses_HousingId",
                table: "CompleteAddresses");

            migrationBuilder.DeleteData(
                table: "CompleteAddresses",
                keyColumn: "CompleteAddressId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CompleteAddresses",
                keyColumn: "CompleteAddressId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CompleteAddresses",
                keyColumn: "CompleteAddressId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CompleteAddresses",
                keyColumn: "CompleteAddressId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CompleteAddresses",
                keyColumn: "CompleteAddressId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CompleteAddresses",
                keyColumn: "CompleteAddressId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CompleteAddresses",
                keyColumn: "CompleteAddressId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CompleteAddresses",
                keyColumn: "CompleteAddressId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CompleteAddresses",
                keyColumn: "CompleteAddressId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CompleteAddresses",
                keyColumn: "CompleteAddressId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CompleteAddresses",
                keyColumn: "CompleteAddressId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CompleteAddresses",
                keyColumn: "CompleteAddressId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CompleteAddresses",
                keyColumn: "CompleteAddressId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CompleteAddresses",
                keyColumn: "CompleteAddressId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CompleteAddresses",
                keyColumn: "CompleteAddressId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CompleteAddresses",
                keyColumn: "CompleteAddressId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CompleteAddresses",
                keyColumn: "CompleteAddressId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CompleteAddresses",
                keyColumn: "CompleteAddressId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "CompleteAddresses",
                keyColumn: "CompleteAddressId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "CompleteAddresses",
                keyColumn: "CompleteAddressId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "CompleteAddresses",
                keyColumn: "CompleteAddressId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "CompleteAddresses",
                keyColumn: "CompleteAddressId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "CompleteAddresses",
                keyColumn: "CompleteAddressId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "CompleteAddresses",
                keyColumn: "CompleteAddressId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "CompleteAddresses",
                keyColumn: "CompleteAddressId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "CompleteAddresses",
                keyColumn: "CompleteAddressId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "CompleteAddresses",
                keyColumn: "CompleteAddressId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "CompleteAddresses",
                keyColumn: "CompleteAddressId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "CompleteAddresses",
                keyColumn: "CompleteAddressId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "CompleteAddresses",
                keyColumn: "CompleteAddressId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Housings",
                keyColumn: "HousingId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Housings",
                keyColumn: "HousingId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Housings",
                keyColumn: "HousingId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Housings",
                keyColumn: "HousingId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Housings",
                keyColumn: "HousingId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Housings",
                keyColumn: "HousingId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Housings",
                keyColumn: "HousingId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Housings",
                keyColumn: "HousingId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Housings",
                keyColumn: "HousingId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Housings",
                keyColumn: "HousingId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Housings",
                keyColumn: "HousingId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Housings",
                keyColumn: "HousingId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Housings",
                keyColumn: "HousingId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Housings",
                keyColumn: "HousingId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Housings",
                keyColumn: "HousingId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Housings",
                keyColumn: "HousingId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Housings",
                keyColumn: "HousingId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Housings",
                keyColumn: "HousingId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Housings",
                keyColumn: "HousingId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Housings",
                keyColumn: "HousingId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Housings",
                keyColumn: "HousingId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Housings",
                keyColumn: "HousingId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Housings",
                keyColumn: "HousingId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Housings",
                keyColumn: "HousingId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Housings",
                keyColumn: "HousingId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Housings",
                keyColumn: "HousingId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Housings",
                keyColumn: "HousingId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Housings",
                keyColumn: "HousingId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Housings",
                keyColumn: "HousingId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Housings",
                keyColumn: "HousingId",
                keyValue: 30);

            migrationBuilder.DropColumn(
                name: "HousingId",
                table: "CompleteAddresses");

            migrationBuilder.AddColumn<int>(
                name: "FullAddressCompleteAddress_Id",
                table: "Housings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Housings_FullAddressCompleteAddress_Id",
                table: "Housings",
                column: "FullAddressCompleteAddress_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Housings_CompleteAddresses_FullAddressCompleteAddress_Id",
                table: "Housings",
                column: "FullAddressCompleteAddress_Id",
                principalTable: "CompleteAddresses",
                principalColumn: "CompleteAddressId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
