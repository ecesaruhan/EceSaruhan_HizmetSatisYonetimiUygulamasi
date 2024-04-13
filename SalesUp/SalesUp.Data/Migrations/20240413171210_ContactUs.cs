using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SalesUp.Data.Migrations
{
    /// <inheritdoc />
    public partial class ContactUs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "597c415b-6d8f-4873-8c3e-0640d8307526", null, "Yönetici haklarını taşıyan rol.", "SuperAdmin", "SUPERADMIN" },
                    { "8ef7a844-f2c4-4585-a9bf-35e10fb75e57", null, "Müşteri haklarını taşıyan rol.", "Customer", "CUSTOMER" },
                    { "e64c3967-5106-4f6f-8069-493179224b3d", null, "Satış Temsilcisi haklarını taşıyan rol.", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateofBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "SubscriptionId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4ce5fbc6-70be-460c-97fe-7f603d4b5716", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "32c8ed21-0987-424a-98a2-1a701686bf9d", new DateTime(1970, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "niluferozdemir@gmail.com", true, "Nilüfer", "Kadın", "Özdemir", false, null, "NILUFEROZDEMIR@GMAIL.COM", "NILUFEROZDEMIR", "AQAAAAIAAYagAAAAECDIUmfGnobUdyDe5UDouWxkYsVk4AqJhbQ9yhDTkJ+BstAgiGKc2XRHNVmtRqEOvg==", "5383458090", false, "f2b654b2-44c6-48ef-b718-ed5007400e70", 2, false, "niluferozdemir" },
                    { "5b52f37b-52a3-41f9-ab8f-a8e17731cdef", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "dd656559-bace-4e63-9e92-896f7bf29dd4", new DateTime(1983, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "ferdabayar@gmail.com", true, "Ferda", "Erkek", "Bayar", false, null, "FERDABAYAR@GMAIL.COM", "FERDABAYAR", "AQAAAAIAAYagAAAAECO67dyFt07zhXEkuntNBSULp2pu5Ig0FMgizLXrhmOZLq6KsWvvEinc2QCb5X1JxQ==", "5053211815", false, "6addf0f3-6903-4bb5-9380-c9377b31a244", 3, false, "ferdabayar" },
                    { "735d36e8-236a-463c-bb7c-1928125d3dd4", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "8364f03f-5967-4563-8f9c-90fb1d2d5c76", new DateTime(1990, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "kadirdevran@gmail.com", true, "Kadir", "Erkek", "Devran", false, null, "KADIRDEVRAN@GMAIL.COM", "KADIRDEVRAN", "AQAAAAIAAYagAAAAEJZiqoFU11pBU7Gr7sauRRFaTUdNa33klMGmEtHSJVR2QzHKhBc83mOfvv4zZdsu0Q==", "5341459340", false, "96113b48-4987-4d0f-ae23-eb46aaea7560", 2, false, "kadirdevran" },
                    { "77346360-0ff0-46d5-b538-d1efec4829ce", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "cbf28e1e-9c58-4d00-ac6b-706fd845c258", new DateTime(1989, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "canyener@gmail.com", true, "Can", "Erkek", "Yener", false, null, "CANYENER@GMAIL.COM", "CANYENER", "AQAAAAIAAYagAAAAEHvnflyiZwmIJkFDxuzj+g/uODbGZsaMwSWagvvRj4vs5+MVrNVuH3xAhPZ1SFUaRw==", "5350931264", false, "b5797210-ba95-4445-a20f-32f96b6e56e7", 3, false, "canyener" },
                    { "eae2178d-29e7-4feb-84f9-131e1a52ebba", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "affdf910-513b-4dba-9d1b-abd792b797d1", new DateTime(1992, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "deryademir@gmail.com", true, "Derya", "Kadın", "Demir", false, null, "DERYADEMIR@GMAIL.COM", "DERYADEMIR", "AQAAAAIAAYagAAAAEBjOVn+bjZmPinzlW1Ji3Pz3ai1eHHQlOzBp2nGZdJ0vKnJrehPBCsLQx9Vx4Xlszg==", "5547659843", false, "f2bd6658-ccb0-448a-a609-d340eb259f43", 2, false, "deryademir" }
                });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 4, 13, 20, 12, 10, 400, DateTimeKind.Local).AddTicks(4150), new DateTime(2024, 4, 13, 20, 12, 10, 400, DateTimeKind.Local).AddTicks(4170) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 4, 13, 20, 12, 10, 400, DateTimeKind.Local).AddTicks(4180), new DateTime(2024, 4, 13, 20, 12, 10, 400, DateTimeKind.Local).AddTicks(4180) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 4, 13, 20, 12, 10, 400, DateTimeKind.Local).AddTicks(4190), new DateTime(2024, 4, 13, 20, 12, 10, 400, DateTimeKind.Local).AddTicks(4200) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "e64c3967-5106-4f6f-8069-493179224b3d", "4ce5fbc6-70be-460c-97fe-7f603d4b5716" },
                    { "597c415b-6d8f-4873-8c3e-0640d8307526", "5b52f37b-52a3-41f9-ab8f-a8e17731cdef" },
                    { "e64c3967-5106-4f6f-8069-493179224b3d", "735d36e8-236a-463c-bb7c-1928125d3dd4" },
                    { "e64c3967-5106-4f6f-8069-493179224b3d", "77346360-0ff0-46d5-b538-d1efec4829ce" },
                    { "8ef7a844-f2c4-4585-a9bf-35e10fb75e57", "eae2178d-29e7-4feb-84f9-131e1a52ebba" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e64c3967-5106-4f6f-8069-493179224b3d", "4ce5fbc6-70be-460c-97fe-7f603d4b5716" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "597c415b-6d8f-4873-8c3e-0640d8307526", "5b52f37b-52a3-41f9-ab8f-a8e17731cdef" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e64c3967-5106-4f6f-8069-493179224b3d", "735d36e8-236a-463c-bb7c-1928125d3dd4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e64c3967-5106-4f6f-8069-493179224b3d", "77346360-0ff0-46d5-b538-d1efec4829ce" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8ef7a844-f2c4-4585-a9bf-35e10fb75e57", "eae2178d-29e7-4feb-84f9-131e1a52ebba" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "597c415b-6d8f-4873-8c3e-0640d8307526");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ef7a844-f2c4-4585-a9bf-35e10fb75e57");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e64c3967-5106-4f6f-8069-493179224b3d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ce5fbc6-70be-460c-97fe-7f603d4b5716");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b52f37b-52a3-41f9-ab8f-a8e17731cdef");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "735d36e8-236a-463c-bb7c-1928125d3dd4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77346360-0ff0-46d5-b538-d1efec4829ce");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eae2178d-29e7-4feb-84f9-131e1a52ebba");

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
    }
}
