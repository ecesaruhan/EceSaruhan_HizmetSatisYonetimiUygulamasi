using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SalesUp.Data.Migrations
{
    /// <inheritdoc />
    public partial class TotalPriceColumnSubscription2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "7c4bbfd6-179e-450f-a02f-9bc3a01620db", null, "Satış Temsilcisi haklarını taşıyan rol.", "Admin", "ADMIN" },
                    { "978de20e-c6e2-432a-bf8a-4a7538341ee6", null, "Müşteri haklarını taşıyan rol.", "Customer", "CUSTOMER" },
                    { "a22d046d-763b-4b58-952a-75fc86d97c50", null, "Yönetici haklarını taşıyan rol.", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateofBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "SubscriptionId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "144845fd-dc4f-41fa-a2b6-c92c5ca04286", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "c64eabd2-e2d3-468d-803b-85edfd0ace50", new DateTime(1989, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "canyener@gmail.com", true, "Can", "Erkek", "Yener", false, null, "CANYENER@GMAIL.COM", "CANYENER", "AQAAAAIAAYagAAAAEI/7rRw860202sYRWBAMkzPcxAaWtoxG6HBVuXgmZsI/pVd+SGOzo8ok5BjAZPg0kg==", "5350931264", false, "865657e3-aec6-4e12-ab62-d8487df54682", 3, false, "canyener" },
                    { "7dbec3e2-e9e9-4e75-bc70-30d76434809f", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "0368423a-dd6c-4fde-b53b-c546a91dd091", new DateTime(1992, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "deryademir@gmail.com", true, "Derya", "Kadın", "Demir", false, null, "DERYADEMIR@GMAIL.COM", "DERYADEMIR", "AQAAAAIAAYagAAAAEKApkJ0OM/ttCMtZ5i8egvfOa0U58fhup89+Of6C2U0EQE6We/WDV3kmaMKvtaabvQ==", "5547659843", false, "00ae250d-4885-4ebe-835f-5207d0960283", 2, false, "deryademir" },
                    { "b4b089e8-54bb-48e2-a754-82d7ea8da5b3", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "09bac890-d49a-4ea8-a235-ceccc41bfab8", new DateTime(1970, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "niluferozdemir@gmail.com", true, "Nilüfer", "Kadın", "Özdemir", false, null, "NILUFEROZDEMIR@GMAIL.COM", "NILUFEROZDEMIR", "AQAAAAIAAYagAAAAEFHeYw2qREf3N1sVjRMuze9AXeYXZ8Kr8As2/RakAXumwaw643XnhpiISOKYlqFF9g==", "5383458090", false, "6b92f4b7-22e8-4543-9aeb-7b1a6ded8004", 2, false, "niluferozdemir" },
                    { "dfa2e333-d108-43c4-80e7-b5677f201f41", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "b31c6686-3861-4730-85ee-49c2c3ab111d", new DateTime(1983, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "ferdabayar@gmail.com", true, "Ferda", "Erkek", "Bayar", false, null, "FERDABAYAR@GMAIL.COM", "FERDABAYAR", "AQAAAAIAAYagAAAAEH/B5dXXJTluJ56an/drtQFLT03T8s9pAFlUv1HwPEUgWIIBaFUuMlhjxpD6yOxILQ==", "5053211815", false, "1a9de5d2-4887-4f9f-a498-101556d73ff0", 3, false, "ferdabayar" },
                    { "fd8454cc-0a91-4a30-b38e-af45b914cb13", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "770fbd9e-10f7-46e4-8007-59d7629359e4", new DateTime(1990, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "kadirdevran@gmail.com", true, "Kadir", "Erkek", "Devran", false, null, "KADIRDEVRAN@GMAIL.COM", "KADIRDEVRAN", "AQAAAAIAAYagAAAAEDW8I8b9M9A6oXardA750BI6rpafEaRuMdaOoANjEKknpJUM3gluFaR5Pmsws/dntQ==", "5341459340", false, "49630cb8-a1dc-4d86-84be-f4680dec8a7f", 2, false, "kadirdevran" }
                });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 5, 51, 428, DateTimeKind.Local).AddTicks(6830), new DateTime(2024, 4, 12, 22, 5, 51, 428, DateTimeKind.Local).AddTicks(6880) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 5, 51, 428, DateTimeKind.Local).AddTicks(6890), new DateTime(2024, 4, 12, 22, 5, 51, 428, DateTimeKind.Local).AddTicks(6890) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 5, 51, 428, DateTimeKind.Local).AddTicks(6890), new DateTime(2024, 4, 12, 22, 5, 51, 428, DateTimeKind.Local).AddTicks(6900) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "7c4bbfd6-179e-450f-a02f-9bc3a01620db", "144845fd-dc4f-41fa-a2b6-c92c5ca04286" },
                    { "978de20e-c6e2-432a-bf8a-4a7538341ee6", "7dbec3e2-e9e9-4e75-bc70-30d76434809f" },
                    { "7c4bbfd6-179e-450f-a02f-9bc3a01620db", "b4b089e8-54bb-48e2-a754-82d7ea8da5b3" },
                    { "a22d046d-763b-4b58-952a-75fc86d97c50", "dfa2e333-d108-43c4-80e7-b5677f201f41" },
                    { "7c4bbfd6-179e-450f-a02f-9bc3a01620db", "fd8454cc-0a91-4a30-b38e-af45b914cb13" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7c4bbfd6-179e-450f-a02f-9bc3a01620db", "144845fd-dc4f-41fa-a2b6-c92c5ca04286" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "978de20e-c6e2-432a-bf8a-4a7538341ee6", "7dbec3e2-e9e9-4e75-bc70-30d76434809f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7c4bbfd6-179e-450f-a02f-9bc3a01620db", "b4b089e8-54bb-48e2-a754-82d7ea8da5b3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a22d046d-763b-4b58-952a-75fc86d97c50", "dfa2e333-d108-43c4-80e7-b5677f201f41" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7c4bbfd6-179e-450f-a02f-9bc3a01620db", "fd8454cc-0a91-4a30-b38e-af45b914cb13" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c4bbfd6-179e-450f-a02f-9bc3a01620db");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "978de20e-c6e2-432a-bf8a-4a7538341ee6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a22d046d-763b-4b58-952a-75fc86d97c50");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "144845fd-dc4f-41fa-a2b6-c92c5ca04286");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7dbec3e2-e9e9-4e75-bc70-30d76434809f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4b089e8-54bb-48e2-a754-82d7ea8da5b3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dfa2e333-d108-43c4-80e7-b5677f201f41");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd8454cc-0a91-4a30-b38e-af45b914cb13");

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
    }
}
