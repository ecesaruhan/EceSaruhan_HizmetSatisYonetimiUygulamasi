using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SalesUp.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e8f0db49-7270-4cca-bfba-945562f75d0c", "294813b1-f834-4e58-a7d3-8d5d836584b7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "40a52e03-4a6b-48dc-826a-a396e43792c3", "2efa214a-2e24-4d49-a4cf-942e622b4167" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "40a52e03-4a6b-48dc-826a-a396e43792c3", "5a352939-1577-41c3-842f-4791ce5bb16d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "78d1af46-9f66-4620-b3be-d3b96e0ae61b", "b7b89812-6421-4251-8f98-bef3715e66c1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "40a52e03-4a6b-48dc-826a-a396e43792c3", "d5727b1f-7620-4bf9-9120-0ae094c6664e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40a52e03-4a6b-48dc-826a-a396e43792c3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78d1af46-9f66-4620-b3be-d3b96e0ae61b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e8f0db49-7270-4cca-bfba-945562f75d0c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "294813b1-f834-4e58-a7d3-8d5d836584b7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2efa214a-2e24-4d49-a4cf-942e622b4167");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5a352939-1577-41c3-842f-4791ce5bb16d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b7b89812-6421-4251-8f98-bef3715e66c1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5727b1f-7620-4bf9-9120-0ae094c6664e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "00ddf9bb-a429-4634-93e5-600463c67d36", null, "Müşteri haklarını taşıyan rol.", "User", "USER" },
                    { "7dfd24d1-0253-4dda-b92d-f0015fae68d7", null, "Satış Temsilcisi haklarını taşıyan rol.", "Admin", "ADMIN" },
                    { "ac5bd86f-551a-44bd-8aef-81279308fae2", null, "Yönetici haklarını taşıyan rol.", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateofBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "SubscriptionId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "080edcaf-fa45-4791-9491-b12320dbe7f0", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "be8bd9ee-9829-4b9d-b1ba-ba9c254631f5", new DateTime(1983, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "ferdabayar@gmail.com", true, "Ferda", "Erkek", "Bayar", false, null, "FERDABAYAR@GMAIL.COM", "FERDABAYAR", "AQAAAAIAAYagAAAAELoVb87mY1RT8wqsXab5iv4kUx0YEU98N0XjmDlZZOboIBxqOhUktbCWwVH3ZRJS2g==", "5053211815", false, "54e462f9-853c-4d54-80ac-57fd20cddffd", 3, false, "ferdabayar" },
                    { "2e5a3921-1c72-41e6-b2ab-81905a547fb1", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "2dafe4a8-7ff4-4cc6-829a-284481771a73", new DateTime(1989, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "canyener@gmail.com", true, "Can", "Erkek", "Yener", false, null, "CANYENER@GMAIL.COM", "CANYENER", "AQAAAAIAAYagAAAAEKKiC+9/G+ABaXU2UQOtvY7I4FNAg7reeHA93M+LrG/peAX7SuScat8mt9lGeRflYw==", "5350931264", false, "2f55f415-d3fd-4d4f-9207-a7935ae8afc1", 3, false, "canyener" },
                    { "310004a6-87b6-4a73-9a23-24d61daff68f", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "b6668127-1dd1-4611-aff6-1d384a0b19d7", new DateTime(1992, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "deryademir@gmail.com", true, "Derya", "Kadın", "Demir", false, null, "DERYADEMIR@GMAIL.COM", "DERYADEMIR", "AQAAAAIAAYagAAAAEBrD92zPpXpkukDe7e4KH73XDBAQNsp3ItF75nEYtoOTQ58TTugwn+4rbyv1qP1WeA==", "5547659843", false, "e540881e-1e19-422c-af67-1a0a77449d28", 2, false, "deryademir" },
                    { "64fd4df6-717d-488c-be29-6f5acd9546cb", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "ba966028-becd-4fb2-afcb-5ae4242e3b2b", new DateTime(1990, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "kadirdevran@gmail.com", true, "Kadir", "Erkek", "Devran", false, null, "KADIRDEVRAN@GMAIL.COM", "KADIRDEVRAN", "AQAAAAIAAYagAAAAEOviIWBfkotr4w730BbLOmydZKnaOAca4KpisA5CDUIl8siIZIWEklJfmbVISlR9Yw==", "5341459340", false, "bc0e8eb9-60a7-465c-ad24-44d7a24082e5", 2, false, "kadirdevran" },
                    { "d57f54fe-374f-41dd-abee-e611c6cfe294", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "a26d3342-f975-4073-a0d5-0f77816d2b44", new DateTime(1970, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "niluferozdemir@gmail.com", true, "Nilüfer", "Kadın", "Özdemir", false, null, "NILUFEROZDEMIR@GMAIL.COM", "NILUFEROZDEMIR", "AQAAAAIAAYagAAAAEDK6+wukPymTOpouX5x6c6uJY9XTPNp3oACwcWQduQwqZ/rrUrIe8QN4bEtW3/tL2g==", "5383458090", false, "8fc180ed-6558-42e9-af11-7ec02ec625e2", 2, false, "niluferozdemir" }
                });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 33, 31, 406, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 3, 30, 4, 33, 31, 406, DateTimeKind.Local).AddTicks(6260) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 33, 31, 406, DateTimeKind.Local).AddTicks(6260), new DateTime(2024, 3, 30, 4, 33, 31, 406, DateTimeKind.Local).AddTicks(6270) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 33, 31, 406, DateTimeKind.Local).AddTicks(6270), new DateTime(2024, 3, 30, 4, 33, 31, 406, DateTimeKind.Local).AddTicks(6270) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 33, 31, 406, DateTimeKind.Local).AddTicks(1230), "310004a6-87b6-4a73-9a23-24d61daff68f" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 33, 31, 406, DateTimeKind.Local).AddTicks(1290), "64fd4df6-717d-488c-be29-6f5acd9546cb" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 33, 31, 406, DateTimeKind.Local).AddTicks(1290), "080edcaf-fa45-4791-9491-b12320dbe7f0" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 33, 31, 406, DateTimeKind.Local).AddTicks(1290), "d57f54fe-374f-41dd-abee-e611c6cfe294" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 33, 31, 406, DateTimeKind.Local).AddTicks(1300), "2e5a3921-1c72-41e6-b2ab-81905a547fb1" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ac5bd86f-551a-44bd-8aef-81279308fae2", "080edcaf-fa45-4791-9491-b12320dbe7f0" },
                    { "7dfd24d1-0253-4dda-b92d-f0015fae68d7", "2e5a3921-1c72-41e6-b2ab-81905a547fb1" },
                    { "00ddf9bb-a429-4634-93e5-600463c67d36", "310004a6-87b6-4a73-9a23-24d61daff68f" },
                    { "7dfd24d1-0253-4dda-b92d-f0015fae68d7", "64fd4df6-717d-488c-be29-6f5acd9546cb" },
                    { "7dfd24d1-0253-4dda-b92d-f0015fae68d7", "d57f54fe-374f-41dd-abee-e611c6cfe294" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ac5bd86f-551a-44bd-8aef-81279308fae2", "080edcaf-fa45-4791-9491-b12320dbe7f0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7dfd24d1-0253-4dda-b92d-f0015fae68d7", "2e5a3921-1c72-41e6-b2ab-81905a547fb1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "00ddf9bb-a429-4634-93e5-600463c67d36", "310004a6-87b6-4a73-9a23-24d61daff68f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7dfd24d1-0253-4dda-b92d-f0015fae68d7", "64fd4df6-717d-488c-be29-6f5acd9546cb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7dfd24d1-0253-4dda-b92d-f0015fae68d7", "d57f54fe-374f-41dd-abee-e611c6cfe294" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00ddf9bb-a429-4634-93e5-600463c67d36");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7dfd24d1-0253-4dda-b92d-f0015fae68d7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac5bd86f-551a-44bd-8aef-81279308fae2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "080edcaf-fa45-4791-9491-b12320dbe7f0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e5a3921-1c72-41e6-b2ab-81905a547fb1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "310004a6-87b6-4a73-9a23-24d61daff68f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64fd4df6-717d-488c-be29-6f5acd9546cb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d57f54fe-374f-41dd-abee-e611c6cfe294");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "40a52e03-4a6b-48dc-826a-a396e43792c3", null, "Satış Temsilcisi haklarını taşıyan rol.", "Admin", "EMPLOYEE" },
                    { "78d1af46-9f66-4620-b3be-d3b96e0ae61b", null, "Yönetici haklarını taşıyan rol.", "Super Admin", "ADMIN" },
                    { "e8f0db49-7270-4cca-bfba-945562f75d0c", null, "Müşteri haklarını taşıyan rol.", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateofBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "SubscriptionId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "294813b1-f834-4e58-a7d3-8d5d836584b7", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "8b9b8267-a640-4333-b965-6f7c7989a14f", new DateTime(1992, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "deryademir@gmail.com", true, "Derya", "Kadın", "Demir", false, null, "DERYADEMIR@GMAIL.COM", "DERYADEMIR", "AQAAAAIAAYagAAAAEDHOT0M4AvOhxcuhG8J9sXAJG4OFNUxq3y6fq7OYtWhinKXexSXcW76+j2FBlktuww==", "5547659843", false, "6f85abaf-61fc-44a1-aa55-7e40db36f069", 2, false, "deryademir" },
                    { "2efa214a-2e24-4d49-a4cf-942e622b4167", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "d940dee9-4858-4ef4-8633-38eb7b3b724a", new DateTime(1989, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "canyener@gmail.com", true, "Can", "Erkek", "Yener", false, null, "CANYENER@GMAIL.COM", "CANYENER", "AQAAAAIAAYagAAAAEN9UF5i8m7JZ7+/jcJRvmzzibj/hZgljNaUvCk5YOqQ3lB1r/OerTL105KwAyV8EPQ==", "5350931264", false, "de8f6900-4ec6-4fc2-b28b-38c4d1a785c7", 3, false, "canyener" },
                    { "5a352939-1577-41c3-842f-4791ce5bb16d", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "74393775-8ff9-4950-b5b6-65eaf5d0f2a6", new DateTime(1990, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "kadirdevran@gmail.com", true, "Kadir", "Erkek", "Devran", false, null, "KADIRDEVRAN@GMAIL.COM", "KADIRDEVRAN", "AQAAAAIAAYagAAAAEDdSQRIE9lRHOo1q95KZ1xxKEIFFPUMuffiKfsNK0MCI23bqE/Z9yNo2RCjr/iS0fw==", "5341459340", false, "1f4cfbac-b298-4730-a9d1-28769ae5ec0b", 2, false, "kadirdevran" },
                    { "b7b89812-6421-4251-8f98-bef3715e66c1", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "6625bcff-deab-49d3-aca1-39883d9d609d", new DateTime(1983, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "ferdabayar@gmail.com", true, "Ferda", "Erkek", "Bayar", false, null, "FERDABAYAR@GMAIL.COM", "FERDABAYAR", "AQAAAAIAAYagAAAAEIfVwdBmReKHjYi0RH/RHCIKb1z1QeD+dHSOaB6A0LheeIFtcs+4g86f5Oq3YT5xqg==", "5053211815", false, "8d4e179c-54f7-4298-bd03-45a1b7ca6075", 3, false, "ferdabayar" },
                    { "d5727b1f-7620-4bf9-9120-0ae094c6664e", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "266e1fc7-32d7-419a-90df-af7255a25270", new DateTime(1970, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "niluferozdemir@gmail.com", true, "Nilüfer", "Kadın", "Özdemir", false, null, "NILUFEROZDEMIR@GMAIL.COM", "NILUFEROZDEMIR", "AQAAAAIAAYagAAAAEO2qIOS0+XbCxiT40hb6Hj+wRR609s08fsWNvHZX9gS0h5JSp0o1Awxvt1Ph2cf+lg==", "5383458090", false, "dac690ac-fbfc-4262-80e3-000aa3c5789c", 2, false, "niluferozdemir" }
                });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 3, 25, 12, 16, 56, 37, DateTimeKind.Local).AddTicks(6200), new DateTime(2024, 3, 25, 12, 16, 56, 37, DateTimeKind.Local).AddTicks(6210) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 3, 25, 12, 16, 56, 37, DateTimeKind.Local).AddTicks(6220), new DateTime(2024, 3, 25, 12, 16, 56, 37, DateTimeKind.Local).AddTicks(6220) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 3, 25, 12, 16, 56, 37, DateTimeKind.Local).AddTicks(6220), new DateTime(2024, 3, 25, 12, 16, 56, 37, DateTimeKind.Local).AddTicks(6220) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 25, 12, 16, 56, 37, DateTimeKind.Local).AddTicks(1070), "294813b1-f834-4e58-a7d3-8d5d836584b7" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 25, 12, 16, 56, 37, DateTimeKind.Local).AddTicks(1160), "5a352939-1577-41c3-842f-4791ce5bb16d" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 25, 12, 16, 56, 37, DateTimeKind.Local).AddTicks(1170), "b7b89812-6421-4251-8f98-bef3715e66c1" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 25, 12, 16, 56, 37, DateTimeKind.Local).AddTicks(1170), "d5727b1f-7620-4bf9-9120-0ae094c6664e" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 25, 12, 16, 56, 37, DateTimeKind.Local).AddTicks(1180), "2efa214a-2e24-4d49-a4cf-942e622b4167" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "e8f0db49-7270-4cca-bfba-945562f75d0c", "294813b1-f834-4e58-a7d3-8d5d836584b7" },
                    { "40a52e03-4a6b-48dc-826a-a396e43792c3", "2efa214a-2e24-4d49-a4cf-942e622b4167" },
                    { "40a52e03-4a6b-48dc-826a-a396e43792c3", "5a352939-1577-41c3-842f-4791ce5bb16d" },
                    { "78d1af46-9f66-4620-b3be-d3b96e0ae61b", "b7b89812-6421-4251-8f98-bef3715e66c1" },
                    { "40a52e03-4a6b-48dc-826a-a396e43792c3", "d5727b1f-7620-4bf9-9120-0ae094c6664e" }
                });
        }
    }
}
