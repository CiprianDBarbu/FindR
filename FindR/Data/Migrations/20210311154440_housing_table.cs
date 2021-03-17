using Microsoft.EntityFrameworkCore.Migrations;

namespace FindR.Data.Migrations
{
    public partial class housing_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompleteAddresses_Addresses_Address_Id",
                table: "CompleteAddresses");

            migrationBuilder.DropIndex(
                name: "IX_CompleteAddresses_Address_Id",
                table: "CompleteAddresses");

            migrationBuilder.DropColumn(
                name: "Address_Id",
                table: "CompleteAddresses");

            migrationBuilder.AlterColumn<string>(
                name: "Longitude",
                table: "CompleteAddresses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Latitude",
                table: "CompleteAddresses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "CompleteAddresses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CompleteAddresses_AddressId",
                table: "CompleteAddresses",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompleteAddresses_Addresses_AddressId",
                table: "CompleteAddresses",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompleteAddresses_Addresses_AddressId",
                table: "CompleteAddresses");

            migrationBuilder.DropIndex(
                name: "IX_CompleteAddresses_AddressId",
                table: "CompleteAddresses");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "CompleteAddresses");

            migrationBuilder.AlterColumn<int>(
                name: "Longitude",
                table: "CompleteAddresses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Latitude",
                table: "CompleteAddresses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Address_Id",
                table: "CompleteAddresses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CompleteAddresses_Address_Id",
                table: "CompleteAddresses",
                column: "Address_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CompleteAddresses_Addresses_Address_Id",
                table: "CompleteAddresses",
                column: "Address_Id",
                principalTable: "Addresses",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
