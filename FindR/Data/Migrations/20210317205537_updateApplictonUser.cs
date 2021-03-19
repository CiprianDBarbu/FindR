using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FindR.Data.Migrations
{
    public partial class updateApplictonUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd65c42b-df31-4da1-b771-56f276477732");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "Age", "AttendsTo", "BirthDate", "ConcurrencyStamp", "Details", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "cd65c42b-df31-4da1-b771-56f276477732", 0, 1, 20, 0, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "26ad65af-1edf-4a74-a8f6-fe7c351b5107", "Hi, I am Bot1!", "Testbot1@mail.com", true, "Test1", 0, "Bot1", false, null, "TESTBOT1@MAIL.COM", "TESTBOT1", "AQAAAAEAACcQAAAAELfovtxs0hwk/POicSqhe6qW76eWxsvPjmLZPVPyz78RlGyuGe6v3TEl2HnWEHnb3g==", null, false, null, "b2ee0186-2145-4a1c-85bf-d06621d2b957", false, "Testbot1" });
        }
    }
}
