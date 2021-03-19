using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FindR.Data.Migrations
{
    public partial class testUse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0a21f40-7f42-4fc0-8a27-820655e124ac");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "Age", "AttendsTo", "BirthDate", "ConcurrencyStamp", "Details", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f86bab36-20fe-450a-9181-4b27c5bd70b7", 0, 1, 20, 0, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "a45e4efe-27ff-400b-b741-c7243a94fc4b", "Hi, I am Bot1!", "Testbot1@yahoo.com", true, "Test1", 0, "Bot1", false, null, "TESTBOT1@YAHOO.COM", "TESTBOT1@YAHOO.COM", "AQAAAAEAACcQAAAAEDpaZVe1tsPksF9SAMKI1PeYilJso5K9nJTpFyXMRP97/O2pV7zCX1LQwjfs8ydSrA==", null, false, null, "437c322e-64af-42cf-8cf2-93f1a0e35bb8", false, "Testbot1@yahoo.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f86bab36-20fe-450a-9181-4b27c5bd70b7");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "Age", "AttendsTo", "BirthDate", "ConcurrencyStamp", "Details", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f0a21f40-7f42-4fc0-8a27-820655e124ac", 0, 1, 20, 0, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "07000f38-e393-4245-a830-12e4460b9b25", "Hi, I am Bot1!", "Testbot1@yahoo.com", true, "Test1", 0, "Bot1", false, null, "TESTBOT1@YAHOO.COM", "TESTBOT1@YAHOO.COM", "AQAAAAEAACcQAAAAEH3CjKu3mM7tcf+jE9bodDGHHZCz7AXV51Vwrp0bjEsiquIRMspVzjorkzfKbiayUQ==", null, false, null, "0440d79e-5b2c-479a-b523-b301fbbf42f3", false, "Testbot1@yahoo.com" });
        }
    }
}
