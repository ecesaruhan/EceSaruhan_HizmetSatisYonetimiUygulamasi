using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SalesUp.Data.Migrations
{
    /// <inheritdoc />
    public partial class TotalPriceColumnSubscription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "54d12cb1-6cd1-4c00-8a52-6812ad263dee", "0788e4e2-3dca-4023-8dc3-e94588049871" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ba5bcb45-746c-4927-b3dc-3052d00438c9", "513bd116-dede-4efb-b1c9-b5ae40dda644" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "54d12cb1-6cd1-4c00-8a52-6812ad263dee", "81f43666-72e4-4743-98f8-2ea94045f75d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "54d12cb1-6cd1-4c00-8a52-6812ad263dee", "c0ee7f7a-ef50-4e29-b997-f5ad7c787a78" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b7109a7a-d418-4dbc-8f4c-13e9f1abe297", "cbc13199-1ae8-4346-af5f-48b87310e503" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "54d12cb1-6cd1-4c00-8a52-6812ad263dee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b7109a7a-d418-4dbc-8f4c-13e9f1abe297");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba5bcb45-746c-4927-b3dc-3052d00438c9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0788e4e2-3dca-4023-8dc3-e94588049871");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "513bd116-dede-4efb-b1c9-b5ae40dda644");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "81f43666-72e4-4743-98f8-2ea94045f75d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c0ee7f7a-ef50-4e29-b997-f5ad7c787a78");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cbc13199-1ae8-4346-af5f-48b87310e503");

            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                table: "Subscriptions",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3a350deb-c1fb-4e2a-a3f4-59a47e0efd0f", null, "Yönetici haklarını taşıyan rol.", "SuperAdmin", "SUPERADMIN" },
                    { "cad2080b-1cc8-4130-9257-e4b482feedc5", null, "Müşteri haklarını taşıyan rol.", "Customer", "CUSTOMER" },
                    { "f73fd886-0127-4368-b69d-b8c51b4c121d", null, "Satış Temsilcisi haklarını taşıyan rol.", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateofBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "SubscriptionId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "386264b6-c104-4e2a-b8ee-1875a99dd4e8", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "2f4e3a8a-e253-4528-acc0-bb8e5d1e15d3", new DateTime(1983, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "ferdabayar@gmail.com", true, "Ferda", "Erkek", "Bayar", false, null, "FERDABAYAR@GMAIL.COM", "FERDABAYAR", "AQAAAAIAAYagAAAAEK5V3QZAfUBKqK9EGKi2+pKASKueNXhW34buT4MK1QrBJoTLYa1vojBjutJkW0tIfg==", "5053211815", false, "dc2c7be9-93a9-4c77-8a28-96e774dd9c73", 3, false, "ferdabayar" },
                    { "b3abf057-786e-4a41-911f-88ff30a43afb", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "a099fff7-4c5c-44e4-ba14-5056e65c565e", new DateTime(1990, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "kadirdevran@gmail.com", true, "Kadir", "Erkek", "Devran", false, null, "KADIRDEVRAN@GMAIL.COM", "KADIRDEVRAN", "AQAAAAIAAYagAAAAEJgNBJ1qb5CDn3UJtgtV6Y5nuWZnH4TMDiksiW0xQjbPBmQXlhXICbeNRLGGiprBGA==", "5341459340", false, "9808b849-de97-4ce9-affa-33683fa98236", 2, false, "kadirdevran" },
                    { "d912ab12-9840-42a5-9d75-5e7855b7e9ad", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "e7d314db-77f3-4f3c-987c-d5fd7a4b17d1", new DateTime(1989, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "canyener@gmail.com", true, "Can", "Erkek", "Yener", false, null, "CANYENER@GMAIL.COM", "CANYENER", "AQAAAAIAAYagAAAAEG9GJFn+lKPyPXSTr+XO+LnwDWr8j3ibAYJnP9JvPn34B+tz0yZC+zqMAQaMtfAH4Q==", "5350931264", false, "bb726925-b3fb-4e75-8fdf-ba5d776afe3a", 3, false, "canyener" },
                    { "de9abfee-b22f-4269-b569-ee510a21dc30", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "e106074c-7881-4cbc-8921-1ca854300501", new DateTime(1992, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "deryademir@gmail.com", true, "Derya", "Kadın", "Demir", false, null, "DERYADEMIR@GMAIL.COM", "DERYADEMIR", "AQAAAAIAAYagAAAAEC1Ww6GLTE8upSX1GhjuZmry1Yngoyq8olvuwFX3DTWfrp4maJKV5Uf6Fjx8OuihTQ==", "5547659843", false, "29393aa1-6472-4e62-a5a0-96f6fba8deff", 2, false, "deryademir" },
                    { "f37f6525-4490-455e-a202-b5f9ec82fbef", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "20a35bbd-a5e1-420b-af03-0d500cea6674", new DateTime(1970, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "niluferozdemir@gmail.com", true, "Nilüfer", "Kadın", "Özdemir", false, null, "NILUFEROZDEMIR@GMAIL.COM", "NILUFEROZDEMIR", "AQAAAAIAAYagAAAAEFfDfSsMpL8yo7d/f4uYjdugM21b1KO1tMKzUm19z/wTwhzthivHEchm9p0GVkDVzA==", "5383458090", false, "0b585535-d21d-4c2f-b95d-3391e8cf248c", 2, false, "niluferozdemir" }
                });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "TotalPrice", "UpdateDate" },
                values: new object[] { new DateTime(2024, 4, 12, 16, 40, 43, 627, DateTimeKind.Local).AddTicks(4330), 0m, new DateTime(2024, 4, 12, 16, 40, 43, 627, DateTimeKind.Local).AddTicks(4370) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "TotalPrice", "UpdateDate" },
                values: new object[] { new DateTime(2024, 4, 12, 16, 40, 43, 627, DateTimeKind.Local).AddTicks(4380), 0m, new DateTime(2024, 4, 12, 16, 40, 43, 627, DateTimeKind.Local).AddTicks(4380) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "TotalPrice", "UpdateDate" },
                values: new object[] { new DateTime(2024, 4, 12, 16, 40, 43, 627, DateTimeKind.Local).AddTicks(4380), 0m, new DateTime(2024, 4, 12, 16, 40, 43, 627, DateTimeKind.Local).AddTicks(4390) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "3a350deb-c1fb-4e2a-a3f4-59a47e0efd0f", "386264b6-c104-4e2a-b8ee-1875a99dd4e8" },
                    { "f73fd886-0127-4368-b69d-b8c51b4c121d", "b3abf057-786e-4a41-911f-88ff30a43afb" },
                    { "f73fd886-0127-4368-b69d-b8c51b4c121d", "d912ab12-9840-42a5-9d75-5e7855b7e9ad" },
                    { "cad2080b-1cc8-4130-9257-e4b482feedc5", "de9abfee-b22f-4269-b569-ee510a21dc30" },
                    { "f73fd886-0127-4368-b69d-b8c51b4c121d", "f37f6525-4490-455e-a202-b5f9ec82fbef" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3a350deb-c1fb-4e2a-a3f4-59a47e0efd0f", "386264b6-c104-4e2a-b8ee-1875a99dd4e8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f73fd886-0127-4368-b69d-b8c51b4c121d", "b3abf057-786e-4a41-911f-88ff30a43afb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f73fd886-0127-4368-b69d-b8c51b4c121d", "d912ab12-9840-42a5-9d75-5e7855b7e9ad" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cad2080b-1cc8-4130-9257-e4b482feedc5", "de9abfee-b22f-4269-b569-ee510a21dc30" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f73fd886-0127-4368-b69d-b8c51b4c121d", "f37f6525-4490-455e-a202-b5f9ec82fbef" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a350deb-c1fb-4e2a-a3f4-59a47e0efd0f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cad2080b-1cc8-4130-9257-e4b482feedc5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f73fd886-0127-4368-b69d-b8c51b4c121d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "386264b6-c104-4e2a-b8ee-1875a99dd4e8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3abf057-786e-4a41-911f-88ff30a43afb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d912ab12-9840-42a5-9d75-5e7855b7e9ad");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "de9abfee-b22f-4269-b569-ee510a21dc30");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f37f6525-4490-455e-a202-b5f9ec82fbef");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "Subscriptions");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "54d12cb1-6cd1-4c00-8a52-6812ad263dee", null, "Satış Temsilcisi haklarını taşıyan rol.", "Admin", "ADMIN" },
                    { "b7109a7a-d418-4dbc-8f4c-13e9f1abe297", null, "Müşteri haklarını taşıyan rol.", "Customer", "CUSTOMER" },
                    { "ba5bcb45-746c-4927-b3dc-3052d00438c9", null, "Yönetici haklarını taşıyan rol.", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateofBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "SubscriptionId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0788e4e2-3dca-4023-8dc3-e94588049871", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "b3e82caa-ad33-4ddf-961c-ced0046609a2", new DateTime(1990, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "kadirdevran@gmail.com", true, "Kadir", "Erkek", "Devran", false, null, "KADIRDEVRAN@GMAIL.COM", "KADIRDEVRAN", "AQAAAAIAAYagAAAAEHeCbk6vVMbWphRMHYxfHi8t6BXZ2gutBiJogADkaDDpjvwkRsWUccauQAlqchqW9g==", "5341459340", false, "3d0f8319-61f0-4968-8971-58a1d879c441", 2, false, "kadirdevran" },
                    { "513bd116-dede-4efb-b1c9-b5ae40dda644", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "aa11be36-6fdc-492c-bc89-becc4c8ec9f4", new DateTime(1983, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "ferdabayar@gmail.com", true, "Ferda", "Erkek", "Bayar", false, null, "FERDABAYAR@GMAIL.COM", "FERDABAYAR", "AQAAAAIAAYagAAAAEL5+vagP2QRjUvwR6N308TD2IALSSS3Fhm7kqrvwRGORgC9QdiI554FZIjgZfJnyHQ==", "5053211815", false, "8eb2801b-7a78-4752-ac75-933eac45c72d", 3, false, "ferdabayar" },
                    { "81f43666-72e4-4743-98f8-2ea94045f75d", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "bf76bf78-4f0f-4927-8228-13836df3f2dd", new DateTime(1989, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "canyener@gmail.com", true, "Can", "Erkek", "Yener", false, null, "CANYENER@GMAIL.COM", "CANYENER", "AQAAAAIAAYagAAAAEAdPu5K/XXMlD5WfS5k0+KuCZyV/1YqR2jQ40nuJzPcTDdukDp+ucWGJskw9hEL5Ig==", "5350931264", false, "82a3cba2-44ed-4784-8f6e-9afe0ae86c9a", 3, false, "canyener" },
                    { "c0ee7f7a-ef50-4e29-b997-f5ad7c787a78", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "3b5a5dd3-fccc-4d7b-b32b-eb7c8ad20611", new DateTime(1970, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "niluferozdemir@gmail.com", true, "Nilüfer", "Kadın", "Özdemir", false, null, "NILUFEROZDEMIR@GMAIL.COM", "NILUFEROZDEMIR", "AQAAAAIAAYagAAAAED9FSp29tl5rXaunmfR4ClistEtYSa22DizyM7Kc7kj3ruKxDhhNNer2Zbcei9R1gg==", "5383458090", false, "ac447ccc-c77d-400d-8d81-69d16bde26bf", 2, false, "niluferozdemir" },
                    { "cbc13199-1ae8-4346-af5f-48b87310e503", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "b79489c3-d8b0-47f9-9560-ff86daf96c78", new DateTime(1992, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "deryademir@gmail.com", true, "Derya", "Kadın", "Demir", false, null, "DERYADEMIR@GMAIL.COM", "DERYADEMIR", "AQAAAAIAAYagAAAAELEoaxhggh9T4INchYnu73JpuzKC4EdZ5gT1z4gp1vFFjB3DONW4PBkxkKCDWCzeVA==", "5547659843", false, "d5da1693-baf6-4548-8ff7-645b32f30ccc", 2, false, "deryademir" }
                });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 4, 12, 2, 52, 51, 699, DateTimeKind.Local).AddTicks(2470), new DateTime(2024, 4, 12, 2, 52, 51, 699, DateTimeKind.Local).AddTicks(2570) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 4, 12, 2, 52, 51, 699, DateTimeKind.Local).AddTicks(2580), new DateTime(2024, 4, 12, 2, 52, 51, 699, DateTimeKind.Local).AddTicks(2580) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 4, 12, 2, 52, 51, 699, DateTimeKind.Local).AddTicks(2590), new DateTime(2024, 4, 12, 2, 52, 51, 699, DateTimeKind.Local).AddTicks(2590) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "54d12cb1-6cd1-4c00-8a52-6812ad263dee", "0788e4e2-3dca-4023-8dc3-e94588049871" },
                    { "ba5bcb45-746c-4927-b3dc-3052d00438c9", "513bd116-dede-4efb-b1c9-b5ae40dda644" },
                    { "54d12cb1-6cd1-4c00-8a52-6812ad263dee", "81f43666-72e4-4743-98f8-2ea94045f75d" },
                    { "54d12cb1-6cd1-4c00-8a52-6812ad263dee", "c0ee7f7a-ef50-4e29-b997-f5ad7c787a78" },
                    { "b7109a7a-d418-4dbc-8f4c-13e9f1abe297", "cbc13199-1ae8-4346-af5f-48b87310e503" }
                });
        }
    }
}
