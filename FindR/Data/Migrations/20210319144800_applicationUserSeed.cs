using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FindR.Data.Migrations
{
    public partial class applicationUserSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f86bab36-20fe-450a-9181-4b27c5bd70b7");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "Age", "AttendsTo", "BirthDate", "ConcurrencyStamp", "Details", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "80b5322a-d630-4597-bd16-a269294b2db2", 0, 1, 20, 0, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6d681635-a51e-43da-aba5-2e822ec8acf1", "Hi, I am Bot1!", "Testbot1@yahoo.com", true, "Test1", 0, "Bot1", false, null, "TESTBOT1@YAHOO.COM", "TESTBOT1@YAHOO.COM", "AQAAAAEAACcQAAAAEFV7tZnWSCOsiFC/a7MsS3JRjbbl8y+rEHzv6ZZBIXHXOk6a/9zcSYqcTa4JBfrruw==", null, false, null, "2571835b-c23b-4de4-8d37-55fa427fd086", false, "Testbot1@yahoo.com" },
                    { "199d4954-34f3-4c1c-85d5-84ab3ddc57f8", 0, 6, 19, 0, new DateTime(2001, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "843dcb87-0394-43f1-be4b-8177fc00009d", "Hi, I am Bot2!", "Testbot2@yahoo.com", true, "Test2", 0, "Bot2", false, null, "TESTBOT2@YAHOO.COM", "TESTBOT2@YAHOO.COM", "AQAAAAEAACcQAAAAECBrMcZ/XYw/7hnxpm1yFJXVZ0XaEwNK4r47360bfrGNpxo+vnJsnfomynv+Hu/cAw==", null, false, null, "e7223e93-fa61-4a2b-abfc-34364d0a7055", false, "Testbot2@yahoo.com" },
                    { "8a4f4dcb-467a-49c5-a4a7-37d204ee8d13", 0, 10, 22, 0, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "30a96a0f-74c2-46f5-9008-aefa60ff3ce9", "Hi, I am Bot3!", "Testbot3@yahoo.com", true, "Test3", 1, "Bot3", false, null, "TESTBOT3@YAHOO.COM", "TESTBOT3@YAHOO.COM", "AQAAAAEAACcQAAAAEKeAKuN4i5LOMavM9TM00B0wPl/e1EoqzasRlkSIeV/6di2pLQWnmwnwaPFNvi41tA==", null, false, null, "60eb5e6f-7ab3-4708-8e01-7b65f82bd5ea", false, "Testbot3@yahoo.com" },
                    { "abb9bda8-83d0-4ba5-a2b9-b7a6f2edbffa", 0, 35, 21, 0, new DateTime(2000, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "1d87a76e-f8c4-4a1e-aa3c-f94d4c61a943", "Hi, I am Bot4!", "Testbot4@yahoo.com", true, "Test4", 0, "Bot4", false, null, "TESTBOT4@YAHOO.COM", "TESTBOT4@YAHOO.COM", "AQAAAAEAACcQAAAAEKBc3hsF24VNflfPe0/Fy+aUvgsq9AMw5Y8X815MYBCr/17ulDdzf3T1/TVa0xWN2w==", null, false, null, "e1092e0a-10ed-4d44-a0a5-fea040c94b71", false, "Testbot4@yahoo.com" },
                    { "47c7300f-4a75-422b-8dda-b82c12698fca", 0, 39, 23, 0, new DateTime(1998, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "8c102370-4e59-4707-8c8d-3450fbd077a4", "Hi, I am Bot5!", "Testbot5@yahoo.com", true, "Test5", 1, "Bot5", false, null, "TESTBOT5@YAHOO.COM", "TESTBOT5@YAHOO.COM", "AQAAAAEAACcQAAAAEFJBvWstLOT84SiM9nWYAuQMu2wKTKORarc/sX1wwcczjfIVcfDOR4AkV3w6nVUljw==", null, false, null, "3581eedc-b7b2-4a89-81e8-c057706bee48", false, "Testbot5@yahoo.com" },
                    { "4edc8a08-7ee0-4947-a649-1489313a1e9e", 0, 48, 18, 0, new DateTime(2002, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5175e124-6df4-476c-9b4e-35e056d06420", "Hi, I am Bot6!", "Testbot6@yahoo.com", true, "Test6", 0, "Bot6", false, null, "TESTBOT6@YAHOO.COM", "TESTBOT6@YAHOO.COM", "AQAAAAEAACcQAAAAEG9KCszhijAc8gqPMjLyMUrWzQxtKqEWi/ON+aIELhBr6l83jra7R6S/fuydWx+J8A==", null, false, null, "d11d64d8-73f0-43b9-a831-48fc902fc03b", false, "Testbot6@yahoo.com" },
                    { "7309fd85-5f62-4217-8dee-4e941aa0987d", 0, 52, 22, 0, new DateTime(1999, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "9ecf896a-fd74-4451-a614-a070f7e6e166", "Hi, I am Bot7!", "Testbot7@yahoo.com", true, "Test7", 1, "Bot7", false, null, "TESTBOT7@YAHOO.COM", "TESTBOT7@YAHOO.COM", "AQAAAAEAACcQAAAAEAFWXaNMmEmZQKxt6+hYPdlnUbk4kKdPieq0rn31YkocPwDzgVc4UeWOOOg/AeWAuw==", null, false, null, "8d2401af-2eee-4d74-91d2-4a46a73404df", false, "Testbot7@yahoo.com" },
                    { "2a1023b0-8493-4d0d-a53f-375ea8f2887b", 0, 68, 20, 0, new DateTime(2000, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "243d4f90-db1b-4f51-985e-b1348213de2e", "Hi, I am Bot8!", "Testbot8@yahoo.com", true, "Test8", 1, "Bot8", false, null, "TESTBOT8@YAHOO.COM", "TESTBOT8@YAHOO.COM", "AQAAAAEAACcQAAAAEMS3i6iU7dVkvyCzq8ASBUeeoQbiiNxQZxLpuVuOuw5epaJt7IvqewlPR295EhFPmA==", null, false, null, "0bea2b26-0cdf-47c5-8357-a853ff64a69f", false, "Testbot8@yahoo.com" },
                    { "f7eead64-c249-4fc8-8769-63d6e6fc32c5", 0, 81, 22, 0, new DateTime(1999, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "b62e6458-e665-4e90-b726-5177fea17978", "Hi, I am Bot9!", "Testbot9@yahoo.com", true, "Test9", 0, "Bot9", false, null, "TESTBOT9@YAHOO.COM", "TESTBOT9@YAHOO.COM", "AQAAAAEAACcQAAAAEDCYq9SvCyjg9hBQzqBHI7r2AnOHfuFYPVPWL+4AZ91FrkD3F5/a4ck6bnKigLN+ZA==", null, false, null, "18ba0908-3b3b-4b78-aafe-5ecd20857bbb", false, "Testbot9@yahoo.com" },
                    { "22c35d7d-b2d2-48e8-8278-ef6fd2ad1d73", 0, 84, 20, 0, new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "d1232b5e-bc67-446a-8b83-ae893c5f0252", "Hi, I am Bot10!", "Testbot10@yahoo.com", true, "Test10", 1, "Bot10", false, null, "TESTBOT10@YAHOO.COM", "TESTBOT10@YAHOO.COM", "AQAAAAEAACcQAAAAEJN/HaHKlPxUHk13FN7KhphCqovnm6Rxone6KvY3lut9+dIQtF0nQxMCWRsCUDB1lg==", null, false, null, "badbccc3-d6ff-4a2d-a5a8-1c5995cac1a7", false, "Testbot10@yahoo.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "199d4954-34f3-4c1c-85d5-84ab3ddc57f8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22c35d7d-b2d2-48e8-8278-ef6fd2ad1d73");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a1023b0-8493-4d0d-a53f-375ea8f2887b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47c7300f-4a75-422b-8dda-b82c12698fca");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4edc8a08-7ee0-4947-a649-1489313a1e9e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7309fd85-5f62-4217-8dee-4e941aa0987d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "80b5322a-d630-4597-bd16-a269294b2db2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a4f4dcb-467a-49c5-a4a7-37d204ee8d13");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abb9bda8-83d0-4ba5-a2b9-b7a6f2edbffa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f7eead64-c249-4fc8-8769-63d6e6fc32c5");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "Age", "AttendsTo", "BirthDate", "ConcurrencyStamp", "Details", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f86bab36-20fe-450a-9181-4b27c5bd70b7", 0, 1, 20, 0, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "a45e4efe-27ff-400b-b741-c7243a94fc4b", "Hi, I am Bot1!", "Testbot1@yahoo.com", true, "Test1", 0, "Bot1", false, null, "TESTBOT1@YAHOO.COM", "TESTBOT1@YAHOO.COM", "AQAAAAEAACcQAAAAEDpaZVe1tsPksF9SAMKI1PeYilJso5K9nJTpFyXMRP97/O2pV7zCX1LQwjfs8ydSrA==", null, false, null, "437c322e-64af-42cf-8cf2-93f1a0e35bb8", false, "Testbot1@yahoo.com" });
        }
    }
}
