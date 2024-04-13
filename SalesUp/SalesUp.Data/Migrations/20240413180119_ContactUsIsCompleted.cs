using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SalesUp.Data.Migrations
{
    /// <inheritdoc />
    public partial class ContactUsIsCompleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<bool>(
                name: "IsCompleted",
                table: "Contacts",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "076754d8-219c-4e44-a2b8-f11bb87a854e", null, "Yönetici haklarını taşıyan rol.", "SuperAdmin", "SUPERADMIN" },
                    { "b73f24a7-c5dd-4c8d-8960-f10bf72fe7ed", null, "Satış Temsilcisi haklarını taşıyan rol.", "Admin", "ADMIN" },
                    { "cf33f11b-a126-465e-b656-596c378df438", null, "Müşteri haklarını taşıyan rol.", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateofBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "SubscriptionId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2adfadd5-b063-4ef4-a030-c97d37051411", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "07ba851a-d89d-4cc2-9da7-a1795a6f77ce", new DateTime(1989, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "canyener@gmail.com", true, "Can", "Erkek", "Yener", false, null, "CANYENER@GMAIL.COM", "CANYENER", "AQAAAAIAAYagAAAAEFg589yNdiVUIknSSqDfo6ibtTPDT38JYVfBOP9S584e/dglIl60ChdoETkEaQyJ2A==", "5350931264", false, "06992aaa-7a3c-4c1f-a14b-781d3a578127", 3, false, "canyener" },
                    { "31105b81-d2c2-4525-9758-3dd659a2125d", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "7a19d7a1-f997-4269-8e54-9d879d686da7", new DateTime(1992, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "deryademir@gmail.com", true, "Derya", "Kadın", "Demir", false, null, "DERYADEMIR@GMAIL.COM", "DERYADEMIR", "AQAAAAIAAYagAAAAEM1Aez7XvdhQyEdT6ZNS83Mn9cvd3eEh0uSaq/K8VPrbWRbgGJAniShIJKqA5HNngA==", "5547659843", false, "43c4f4e0-9907-4d8c-a1e7-37b906053554", 2, false, "deryademir" },
                    { "3d89c51f-7d15-4776-8b08-7b436a975cf3", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "bf8db5c9-cf64-4476-9887-855b90747040", new DateTime(1990, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "kadirdevran@gmail.com", true, "Kadir", "Erkek", "Devran", false, null, "KADIRDEVRAN@GMAIL.COM", "KADIRDEVRAN", "AQAAAAIAAYagAAAAEJtckzV9ZFeXugujp3fDRCw93wGog3zgVbfVLQkzzqjWkHO9RU4TONmEg5nmIyJ73A==", "5341459340", false, "1e1510de-aaa7-45f6-8eb7-740ab48fe4d7", 2, false, "kadirdevran" },
                    { "4e500478-abed-4fc3-9563-88a20f246163", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "0e53b803-43d6-430e-ba07-0c2c82763e6f", new DateTime(1983, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "ferdabayar@gmail.com", true, "Ferda", "Erkek", "Bayar", false, null, "FERDABAYAR@GMAIL.COM", "FERDABAYAR", "AQAAAAIAAYagAAAAEN9+BgTUhkZzXIu4TK2AvRJmQ+TycztJ3f53yjmn92+gNvUOg7s6ZptyTa0/gOnuBQ==", "5053211815", false, "d6c27dc1-6516-4d74-8304-200f3d674668", 3, false, "ferdabayar" },
                    { "f0449bc5-b928-4ba2-b0cb-453ac197dc95", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "89532afd-8382-4f4d-ba1b-b276ded45739", new DateTime(1970, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "niluferozdemir@gmail.com", true, "Nilüfer", "Kadın", "Özdemir", false, null, "NILUFEROZDEMIR@GMAIL.COM", "NILUFEROZDEMIR", "AQAAAAIAAYagAAAAEA1+U7nOHBovAmkei9UT1YQvGYIBz4esewLzvryYW6dQfOeq9IE7zQzvfyWEAorlHQ==", "5383458090", false, "0e8921fc-ae53-4af9-92ef-736c9bdadf3f", 2, false, "niluferozdemir" }
                });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 4, 13, 21, 1, 19, 589, DateTimeKind.Local).AddTicks(1540), new DateTime(2024, 4, 13, 21, 1, 19, 589, DateTimeKind.Local).AddTicks(1610) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 4, 13, 21, 1, 19, 589, DateTimeKind.Local).AddTicks(1620), new DateTime(2024, 4, 13, 21, 1, 19, 589, DateTimeKind.Local).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 4, 13, 21, 1, 19, 589, DateTimeKind.Local).AddTicks(1620), new DateTime(2024, 4, 13, 21, 1, 19, 589, DateTimeKind.Local).AddTicks(1630) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b73f24a7-c5dd-4c8d-8960-f10bf72fe7ed", "2adfadd5-b063-4ef4-a030-c97d37051411" },
                    { "cf33f11b-a126-465e-b656-596c378df438", "31105b81-d2c2-4525-9758-3dd659a2125d" },
                    { "b73f24a7-c5dd-4c8d-8960-f10bf72fe7ed", "3d89c51f-7d15-4776-8b08-7b436a975cf3" },
                    { "076754d8-219c-4e44-a2b8-f11bb87a854e", "4e500478-abed-4fc3-9563-88a20f246163" },
                    { "b73f24a7-c5dd-4c8d-8960-f10bf72fe7ed", "f0449bc5-b928-4ba2-b0cb-453ac197dc95" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b73f24a7-c5dd-4c8d-8960-f10bf72fe7ed", "2adfadd5-b063-4ef4-a030-c97d37051411" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cf33f11b-a126-465e-b656-596c378df438", "31105b81-d2c2-4525-9758-3dd659a2125d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b73f24a7-c5dd-4c8d-8960-f10bf72fe7ed", "3d89c51f-7d15-4776-8b08-7b436a975cf3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "076754d8-219c-4e44-a2b8-f11bb87a854e", "4e500478-abed-4fc3-9563-88a20f246163" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b73f24a7-c5dd-4c8d-8960-f10bf72fe7ed", "f0449bc5-b928-4ba2-b0cb-453ac197dc95" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "076754d8-219c-4e44-a2b8-f11bb87a854e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b73f24a7-c5dd-4c8d-8960-f10bf72fe7ed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf33f11b-a126-465e-b656-596c378df438");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2adfadd5-b063-4ef4-a030-c97d37051411");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31105b81-d2c2-4525-9758-3dd659a2125d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3d89c51f-7d15-4776-8b08-7b436a975cf3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4e500478-abed-4fc3-9563-88a20f246163");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0449bc5-b928-4ba2-b0cb-453ac197dc95");

            migrationBuilder.DropColumn(
                name: "IsCompleted",
                table: "Contacts");

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
    }
}
