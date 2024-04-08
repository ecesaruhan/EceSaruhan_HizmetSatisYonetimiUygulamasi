using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SalesUp.Data.Migrations
{
    /// <inheritdoc />
    public partial class StaskUpdate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_AspNetRoles_RoleId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_RoleId",
                table: "Tasks");

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
                name: "Email",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "Tasks");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1e319729-8398-4c8a-840b-21dfde86b2fe", null, "Satış Temsilcisi haklarını taşıyan rol.", "Admin", "ADMIN" },
                    { "e30502bd-2d08-46bd-a056-2c514bd77c8f", null, "Yönetici haklarını taşıyan rol.", "SuperAdmin", "SUPERADMIN" },
                    { "f60ae262-7fad-4feb-a444-c0f4ba7a5970", null, "Müşteri haklarını taşıyan rol.", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateofBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "SubscriptionId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "39b0038d-6d80-4c97-92f7-e849f135b916", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "12dd4bf7-2c16-4640-a2b5-e7e5da7e0604", new DateTime(1990, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "kadirdevran@gmail.com", true, "Kadir", "Erkek", "Devran", false, null, "KADIRDEVRAN@GMAIL.COM", "KADIRDEVRAN", "AQAAAAIAAYagAAAAEJMGyqmypap8/4OAxT/+AZRL9Leo+tRO5HOaYPoNfucA3AveuZg6moNMbIco4Nl/7g==", "5341459340", false, "3a5fa73d-0b6c-4fa5-84fe-44dc2e12339f", 2, false, "kadirdevran" },
                    { "a3b32648-8d9b-4b25-b56e-b0fedf403df7", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "95f42eb3-11ff-4fed-a055-c948a35bdfe8", new DateTime(1992, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "deryademir@gmail.com", true, "Derya", "Kadın", "Demir", false, null, "DERYADEMIR@GMAIL.COM", "DERYADEMIR", "AQAAAAIAAYagAAAAEAU6xbSZPFgkqJC76x9XxDMkmA9d0Irq+pSjie1G6WVWRuxmn62mGr+Gs75gupN81A==", "5547659843", false, "4593e52f-d8d1-4323-8b0c-e316dc4c4649", 2, false, "deryademir" },
                    { "b7b3a155-6db0-420d-a63a-332b54f78e58", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "0f977640-b482-4cde-ae37-04cad72d4ff6", new DateTime(1970, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "niluferozdemir@gmail.com", true, "Nilüfer", "Kadın", "Özdemir", false, null, "NILUFEROZDEMIR@GMAIL.COM", "NILUFEROZDEMIR", "AQAAAAIAAYagAAAAEEhWwl9FPtBr5KUo8cCpxG2FzHgb74zCrh1Pz5T1BRXTpe2vD3hh0cr98GdnhKK8Tw==", "5383458090", false, "9753c45b-1b9b-40f1-bbc3-1fcdd43a680b", 2, false, "niluferozdemir" },
                    { "b7bc4a47-c784-4465-8dd6-247dc1f8ea76", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "3706e387-5f80-478a-a705-cc04d5a7d1e0", new DateTime(1983, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "ferdabayar@gmail.com", true, "Ferda", "Erkek", "Bayar", false, null, "FERDABAYAR@GMAIL.COM", "FERDABAYAR", "AQAAAAIAAYagAAAAEL1gse73rvjV38CFOZkSKDyVaVyME4RDmVlTFyfmkTGGNXy22OEiazzSdpZufUgUkA==", "5053211815", false, "2bdbfc10-71ed-4cf5-8953-d2be53341b54", 3, false, "ferdabayar" },
                    { "cc679997-060c-4830-bcc2-ded96b0288bd", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "35ad5af6-1cbc-4ee6-a1bb-5e46b325a3cf", new DateTime(1989, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "canyener@gmail.com", true, "Can", "Erkek", "Yener", false, null, "CANYENER@GMAIL.COM", "CANYENER", "AQAAAAIAAYagAAAAEKtqPpdb2ZHt6jyppVXs5Hw0bV7nkw2qS+rjcxigO3l8oA7Lh5V0bJZY8rXEMmx19g==", "5350931264", false, "d3c06aff-ce7f-4392-b1af-abdb337c93f4", 3, false, "canyener" }
                });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 4, 4, 19, 43, 56, 256, DateTimeKind.Local).AddTicks(8840), new DateTime(2024, 4, 4, 19, 43, 56, 256, DateTimeKind.Local).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 4, 4, 19, 43, 56, 256, DateTimeKind.Local).AddTicks(8920), new DateTime(2024, 4, 4, 19, 43, 56, 256, DateTimeKind.Local).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 4, 4, 19, 43, 56, 256, DateTimeKind.Local).AddTicks(8920), new DateTime(2024, 4, 4, 19, 43, 56, 256, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1e319729-8398-4c8a-840b-21dfde86b2fe", "39b0038d-6d80-4c97-92f7-e849f135b916" },
                    { "f60ae262-7fad-4feb-a444-c0f4ba7a5970", "a3b32648-8d9b-4b25-b56e-b0fedf403df7" },
                    { "1e319729-8398-4c8a-840b-21dfde86b2fe", "b7b3a155-6db0-420d-a63a-332b54f78e58" },
                    { "e30502bd-2d08-46bd-a056-2c514bd77c8f", "b7bc4a47-c784-4465-8dd6-247dc1f8ea76" },
                    { "1e319729-8398-4c8a-840b-21dfde86b2fe", "cc679997-060c-4830-bcc2-ded96b0288bd" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1e319729-8398-4c8a-840b-21dfde86b2fe", "39b0038d-6d80-4c97-92f7-e849f135b916" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f60ae262-7fad-4feb-a444-c0f4ba7a5970", "a3b32648-8d9b-4b25-b56e-b0fedf403df7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1e319729-8398-4c8a-840b-21dfde86b2fe", "b7b3a155-6db0-420d-a63a-332b54f78e58" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e30502bd-2d08-46bd-a056-2c514bd77c8f", "b7bc4a47-c784-4465-8dd6-247dc1f8ea76" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1e319729-8398-4c8a-840b-21dfde86b2fe", "cc679997-060c-4830-bcc2-ded96b0288bd" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e319729-8398-4c8a-840b-21dfde86b2fe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e30502bd-2d08-46bd-a056-2c514bd77c8f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f60ae262-7fad-4feb-a444-c0f4ba7a5970");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39b0038d-6d80-4c97-92f7-e849f135b916");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3b32648-8d9b-4b25-b56e-b0fedf403df7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b7b3a155-6db0-420d-a63a-332b54f78e58");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b7bc4a47-c784-4465-8dd6-247dc1f8ea76");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc679997-060c-4830-bcc2-ded96b0288bd");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Tasks",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Tasks",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Tasks",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Tasks",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RoleId",
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

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_RoleId",
                table: "Tasks",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_AspNetRoles_RoleId",
                table: "Tasks",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
