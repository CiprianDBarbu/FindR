using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FindR.Data.Migrations
{
    public partial class models : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FullAddressCompleteAddress_Id",
                table: "Housings",
                type: "int",
                nullable: true);

            
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zone = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressId);
                });

            migrationBuilder.CreateTable(
                name: "Advertisements",
                columns: table => new
                {
                    AdvertisementId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Housing_Id = table.Column<int>(type: "int", nullable: true),
                    CheckInDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advertisements", x => x.AdvertisementId);
                    table.ForeignKey(
                        name: "FK_Advertisements_AspNetUsers_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Advertisements_Housings_Housing_Id",
                        column: x => x.Housing_Id,
                        principalTable: "Housings",
                        principalColumn: "HousingId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompleteAddresses",
                columns: table => new
                {
                    CompleteAddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address_Id = table.Column<int>(type: "int", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Floor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Longitude = table.Column<int>(type: "int", nullable: false),
                    Latitude = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompleteAddresses", x => x.CompleteAddressId);
                    table.ForeignKey(
                        name: "FK_CompleteAddresses_Addresses_Address_Id",
                        column: x => x.Address_Id,
                        principalTable: "Addresses",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Restrict);
                });

            
            migrationBuilder.CreateIndex(
                name: "IX_Housings_FullAddressCompleteAddress_Id",
                table: "Housings",
                column: "FullAddressCompleteAddress_Id");

            
            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_Housing_Id",
                table: "Advertisements",
                column: "Housing_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_ProfileId",
                table: "Advertisements",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_CompleteAddresses_Address_Id",
                table: "CompleteAddresses",
                column: "Address_Id");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalAddresses_Address_Id",
                table: "PersonalAddresses",
                column: "Address_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_PersonalAddresses_AdressPersonalAddress_Id",
                table: "AspNetUsers",
                column: "AdressPersonalAddress_Id",
                principalTable: "PersonalAddresses",
                principalColumn: "PersonalAddressId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Housings_CompleteAddresses_FullAddressCompleteAddress_Id",
                table: "Housings",
                column: "FullAddressCompleteAddress_Id",
                principalTable: "CompleteAddresses",
                principalColumn: "CompleteAddressId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_PersonalAddresses_AdressPersonalAddress_Id",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Housings_CompleteAddresses_FullAddressCompleteAddress_Id",
                table: "Housings");

            migrationBuilder.DropTable(
                name: "Advertisements");

            migrationBuilder.DropTable(
                name: "CompleteAddresses");

            migrationBuilder.DropTable(
                name: "PersonalAddresses");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Housings_FullAddressCompleteAddress_Id",
                table: "Housings");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_AdressPersonalAddress_Id",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FullAddressCompleteAddress_Id",
                table: "Housings");

            migrationBuilder.DropColumn(
                name: "AdressPersonalAddress_Id",
                table: "AspNetUsers");
        }
    }
}
