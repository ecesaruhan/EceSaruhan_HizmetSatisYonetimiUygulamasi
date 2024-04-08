using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SalesUp.Data.Migrations
{
    /// <inheritdoc />
    public partial class StaskUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Customers_CustomerId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Products_ProductId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_CustomerId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_ProductId",
                table: "Tasks");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "69666bc1-4018-4ee5-89ec-07d5db137c6b", "14de594c-8182-4ed3-8377-f9a9e462798e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fb6bca6d-2062-4d64-81b5-704c22bce215", "6f2596c8-c0ea-4092-a8ee-cd416d94a452" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "18643164-0a28-425b-a8fb-f716f3bfe28f", "8bbbcd0a-9d46-4ca3-ab6d-19ffbd42cfe9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fb6bca6d-2062-4d64-81b5-704c22bce215", "cd358d60-d1ac-49a7-a278-f9f3d78f217e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fb6bca6d-2062-4d64-81b5-704c22bce215", "f217abbc-8f4f-4d71-af00-89cd891f6b36" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18643164-0a28-425b-a8fb-f716f3bfe28f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69666bc1-4018-4ee5-89ec-07d5db137c6b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb6bca6d-2062-4d64-81b5-704c22bce215");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14de594c-8182-4ed3-8377-f9a9e462798e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f2596c8-c0ea-4092-a8ee-cd416d94a452");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8bbbcd0a-9d46-4ca3-ab6d-19ffbd42cfe9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd358d60-d1ac-49a7-a278-f9f3d78f217e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f217abbc-8f4f-4d71-af00-89cd891f6b36");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Tasks");

            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "Tasks",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "Tasks",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2cd82129-5a0f-450b-8afe-84eac536cbc4", null, "Yönetici haklarını taşıyan rol.", "SuperAdmin", "SUPERADMIN" },
                    { "6244f9d6-6ca1-4065-a26f-1bf104433ec5", null, "Satış Temsilcisi haklarını taşıyan rol.", "Admin", "ADMIN" },
                    { "d1d7b0a0-751a-46d3-969d-33dc5be93999", null, "Müşteri haklarını taşıyan rol.", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateofBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "SubscriptionId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "23b38c85-65ed-456c-8fd1-5338a65ab8e7", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "236a4624-ead9-4e9a-b120-65bfdd988bc0", new DateTime(1990, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "kadirdevran@gmail.com", true, "Kadir", "Erkek", "Devran", false, null, "KADIRDEVRAN@GMAIL.COM", "KADIRDEVRAN", "AQAAAAIAAYagAAAAECOYq4ZMqhnFS4GTbW4GA8O6PYsCctZGLi1/iEo9OlgDaW1NTsPVeL2Tb9XhOQH82g==", "5341459340", false, "b6567194-ddb6-4c24-8173-fc6f51ab1a8f", 2, false, "kadirdevran" },
                    { "5fd17dfa-fa04-4618-84cc-6968eba7d5ad", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "92a68d11-e0e6-4379-95e6-7e0f26965fa8", new DateTime(1992, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "deryademir@gmail.com", true, "Derya", "Kadın", "Demir", false, null, "DERYADEMIR@GMAIL.COM", "DERYADEMIR", "AQAAAAIAAYagAAAAEDKV8pc25fM7x5vglbg9Op/IfQqC6HuwdT8dMgyDp27gdZmb9r72Uf3Ft3IQRHGO0w==", "5547659843", false, "7f916af0-1bee-4695-8c42-97d56938a798", 2, false, "deryademir" },
                    { "d648e8c1-2009-4cd1-bbc3-2556bd51aa8f", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "e477906f-1399-4f13-be8c-f5c2d0330c95", new DateTime(1989, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "canyener@gmail.com", true, "Can", "Erkek", "Yener", false, null, "CANYENER@GMAIL.COM", "CANYENER", "AQAAAAIAAYagAAAAEHecdbEDLwTVcDTBh8tGxCl1dOW4+NbOUqYm9B7pOSDzLxvAeFy6Jf/WhHkIxFk8yA==", "5350931264", false, "6b47746b-e65f-4091-9bf9-cd34701bf8ff", 3, false, "canyener" },
                    { "f5a86119-abf3-4e57-a1a1-a4e2d29b54a1", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "d9655f61-6e33-4cb7-8670-d9e88c68c422", new DateTime(1983, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "ferdabayar@gmail.com", true, "Ferda", "Erkek", "Bayar", false, null, "FERDABAYAR@GMAIL.COM", "FERDABAYAR", "AQAAAAIAAYagAAAAEGarLVa5VKRMOOQL7upvoO0eA7F7p1WBqyH5sU255ZrS2niWiYOkJf25Gn2nfMhCVw==", "5053211815", false, "da66a472-c77c-410f-a600-06ab3dadbed1", 3, false, "ferdabayar" },
                    { "fb0ee441-c55f-456f-b921-556960247e5c", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "d6f8fce8-dc92-4cdc-9d9f-874db6f27197", new DateTime(1970, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "niluferozdemir@gmail.com", true, "Nilüfer", "Kadın", "Özdemir", false, null, "NILUFEROZDEMIR@GMAIL.COM", "NILUFEROZDEMIR", "AQAAAAIAAYagAAAAEBCrKu1hm3D8KovvOvZfcnUBtq9P0XjqD4qoOJqEgOv3wShfDJ8ZMmJ1p0WZjTXxTg==", "5383458090", false, "76ebcf6a-0cf7-4940-902b-be466ed358cb", 2, false, "niluferozdemir" }
                });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 4, 4, 19, 40, 17, 802, DateTimeKind.Local).AddTicks(4400), new DateTime(2024, 4, 4, 19, 40, 17, 802, DateTimeKind.Local).AddTicks(4470) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 4, 4, 19, 40, 17, 802, DateTimeKind.Local).AddTicks(4480), new DateTime(2024, 4, 4, 19, 40, 17, 802, DateTimeKind.Local).AddTicks(4480) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 4, 4, 19, 40, 17, 802, DateTimeKind.Local).AddTicks(4490), new DateTime(2024, 4, 4, 19, 40, 17, 802, DateTimeKind.Local).AddTicks(4490) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "6244f9d6-6ca1-4065-a26f-1bf104433ec5", "23b38c85-65ed-456c-8fd1-5338a65ab8e7" },
                    { "d1d7b0a0-751a-46d3-969d-33dc5be93999", "5fd17dfa-fa04-4618-84cc-6968eba7d5ad" },
                    { "6244f9d6-6ca1-4065-a26f-1bf104433ec5", "d648e8c1-2009-4cd1-bbc3-2556bd51aa8f" },
                    { "2cd82129-5a0f-450b-8afe-84eac536cbc4", "f5a86119-abf3-4e57-a1a1-a4e2d29b54a1" },
                    { "6244f9d6-6ca1-4065-a26f-1bf104433ec5", "fb0ee441-c55f-456f-b921-556960247e5c" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6244f9d6-6ca1-4065-a26f-1bf104433ec5", "23b38c85-65ed-456c-8fd1-5338a65ab8e7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d1d7b0a0-751a-46d3-969d-33dc5be93999", "5fd17dfa-fa04-4618-84cc-6968eba7d5ad" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6244f9d6-6ca1-4065-a26f-1bf104433ec5", "d648e8c1-2009-4cd1-bbc3-2556bd51aa8f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2cd82129-5a0f-450b-8afe-84eac536cbc4", "f5a86119-abf3-4e57-a1a1-a4e2d29b54a1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6244f9d6-6ca1-4065-a26f-1bf104433ec5", "fb0ee441-c55f-456f-b921-556960247e5c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2cd82129-5a0f-450b-8afe-84eac536cbc4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6244f9d6-6ca1-4065-a26f-1bf104433ec5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1d7b0a0-751a-46d3-969d-33dc5be93999");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23b38c85-65ed-456c-8fd1-5338a65ab8e7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5fd17dfa-fa04-4618-84cc-6968eba7d5ad");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d648e8c1-2009-4cd1-bbc3-2556bd51aa8f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f5a86119-abf3-4e57-a1a1-a4e2d29b54a1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fb0ee441-c55f-456f-b921-556960247e5c");

            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "Tasks");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Tasks",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Tasks",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "18643164-0a28-425b-a8fb-f716f3bfe28f", null, "Müşteri haklarını taşıyan rol.", "Customer", "CUSTOMER" },
                    { "69666bc1-4018-4ee5-89ec-07d5db137c6b", null, "Yönetici haklarını taşıyan rol.", "SuperAdmin", "SUPERADMIN" },
                    { "fb6bca6d-2062-4d64-81b5-704c22bce215", null, "Satış Temsilcisi haklarını taşıyan rol.", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateofBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "SubscriptionId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "14de594c-8182-4ed3-8377-f9a9e462798e", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "86463942-5cea-455d-95e3-f2deeaa1a535", new DateTime(1983, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "ferdabayar@gmail.com", true, "Ferda", "Erkek", "Bayar", false, null, "FERDABAYAR@GMAIL.COM", "FERDABAYAR", "AQAAAAIAAYagAAAAEMo9X0jhzVdAyrBle1qHk6CpQQNJ/PcK0uK1AyhSVwSZJbtIfaoSf+u/e6gBJswl2Q==", "5053211815", false, "5d87695d-1dba-4070-9010-936cd8ab6e5a", 3, false, "ferdabayar" },
                    { "6f2596c8-c0ea-4092-a8ee-cd416d94a452", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "4c73c412-0eaf-4611-8c6e-d65a1e70ba61", new DateTime(1989, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "canyener@gmail.com", true, "Can", "Erkek", "Yener", false, null, "CANYENER@GMAIL.COM", "CANYENER", "AQAAAAIAAYagAAAAEP4YcuE0wFMNNxs8oBD0uzA2KCOxY9i2lznwEEhbRSkUy15hsvfNQvdTsu5Bm8hBOg==", "5350931264", false, "eeaa4788-25b9-4739-b478-f1c8b48a65bb", 3, false, "canyener" },
                    { "8bbbcd0a-9d46-4ca3-ab6d-19ffbd42cfe9", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "98a38b93-3db9-4a50-a9a1-f5422da1be6b", new DateTime(1992, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "deryademir@gmail.com", true, "Derya", "Kadın", "Demir", false, null, "DERYADEMIR@GMAIL.COM", "DERYADEMIR", "AQAAAAIAAYagAAAAEITzuZyy4HZU2Kx3NsevISp71SOapngokFXQ7w208o6wYbvgNVDfpInevkbc9Ga86A==", "5547659843", false, "63adaf42-fcbf-47c7-bf96-b4cb8d37172a", 2, false, "deryademir" },
                    { "cd358d60-d1ac-49a7-a278-f9f3d78f217e", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "171e5f73-7b0f-4452-87c5-f65919b5d4a2", new DateTime(1990, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "kadirdevran@gmail.com", true, "Kadir", "Erkek", "Devran", false, null, "KADIRDEVRAN@GMAIL.COM", "KADIRDEVRAN", "AQAAAAIAAYagAAAAEOZad04POBgvGxqVxVhRowZsDSaaqN9zQg3j5x7QPBn2ODUtP9MAmfXex+MfU634GQ==", "5341459340", false, "d998c3b0-4686-4eae-bb52-bbb2823873b0", 2, false, "kadirdevran" },
                    { "f217abbc-8f4f-4d71-af00-89cd891f6b36", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "d760e07c-bcc2-4910-b739-b3487215b21a", new DateTime(1970, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "niluferozdemir@gmail.com", true, "Nilüfer", "Kadın", "Özdemir", false, null, "NILUFEROZDEMIR@GMAIL.COM", "NILUFEROZDEMIR", "AQAAAAIAAYagAAAAEEeYPOeaIsVgi1P+3KWaGcKc6Buhc2ZUbL8OSxohVgtMu2qaSbx6lRuN9+VI6H4g1g==", "5383458090", false, "5516fd64-4ca9-48e1-ac85-7b0b41b60be5", 2, false, "niluferozdemir" }
                });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 4, 4, 18, 11, 39, 742, DateTimeKind.Local).AddTicks(80), new DateTime(2024, 4, 4, 18, 11, 39, 742, DateTimeKind.Local).AddTicks(120) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 4, 4, 18, 11, 39, 742, DateTimeKind.Local).AddTicks(130), new DateTime(2024, 4, 4, 18, 11, 39, 742, DateTimeKind.Local).AddTicks(130) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 4, 4, 18, 11, 39, 742, DateTimeKind.Local).AddTicks(130), new DateTime(2024, 4, 4, 18, 11, 39, 742, DateTimeKind.Local).AddTicks(140) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "69666bc1-4018-4ee5-89ec-07d5db137c6b", "14de594c-8182-4ed3-8377-f9a9e462798e" },
                    { "fb6bca6d-2062-4d64-81b5-704c22bce215", "6f2596c8-c0ea-4092-a8ee-cd416d94a452" },
                    { "18643164-0a28-425b-a8fb-f716f3bfe28f", "8bbbcd0a-9d46-4ca3-ab6d-19ffbd42cfe9" },
                    { "fb6bca6d-2062-4d64-81b5-704c22bce215", "cd358d60-d1ac-49a7-a278-f9f3d78f217e" },
                    { "fb6bca6d-2062-4d64-81b5-704c22bce215", "f217abbc-8f4f-4d71-af00-89cd891f6b36" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_CustomerId",
                table: "Tasks",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_ProductId",
                table: "Tasks",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Customers_CustomerId",
                table: "Tasks",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Products_ProductId",
                table: "Tasks",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
