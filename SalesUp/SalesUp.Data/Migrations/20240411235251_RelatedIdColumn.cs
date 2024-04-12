using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SalesUp.Data.Migrations
{
    /// <inheritdoc />
    public partial class RelatedIdColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5ef4dac7-d3c6-4a0e-850f-f526bd05977f", "1687bad9-7852-49b5-9598-2931eb04aa28" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5ef4dac7-d3c6-4a0e-850f-f526bd05977f", "69d90984-b30e-4d7e-be07-ecdbe2f1fd93" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5ef4dac7-d3c6-4a0e-850f-f526bd05977f", "8774e355-4e17-4574-9724-99f5533b41cb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "895016d3-6150-4c1f-8307-a118a723d839", "8ae11b8a-9c9f-451d-bf13-2cc781c62d1d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "20f4929f-322a-48fe-8abe-d26276fcd911", "f6ea74a5-57ef-4e5a-8a8d-9b9cfaaab46f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20f4929f-322a-48fe-8abe-d26276fcd911");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ef4dac7-d3c6-4a0e-850f-f526bd05977f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "895016d3-6150-4c1f-8307-a118a723d839");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1687bad9-7852-49b5-9598-2931eb04aa28");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69d90984-b30e-4d7e-be07-ecdbe2f1fd93");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8774e355-4e17-4574-9724-99f5533b41cb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ae11b8a-9c9f-451d-bf13-2cc781c62d1d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6ea74a5-57ef-4e5a-8a8d-9b9cfaaab46f");

            migrationBuilder.AddColumn<int>(
                name: "RelatedId",
                table: "Messages",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "RelatedId",
                table: "Messages");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "20f4929f-322a-48fe-8abe-d26276fcd911", null, "Müşteri haklarını taşıyan rol.", "Customer", "CUSTOMER" },
                    { "5ef4dac7-d3c6-4a0e-850f-f526bd05977f", null, "Satış Temsilcisi haklarını taşıyan rol.", "Admin", "ADMIN" },
                    { "895016d3-6150-4c1f-8307-a118a723d839", null, "Yönetici haklarını taşıyan rol.", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateofBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "SubscriptionId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1687bad9-7852-49b5-9598-2931eb04aa28", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "98d39221-23d3-46d1-bf49-49aacd2d6b17", new DateTime(1970, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "niluferozdemir@gmail.com", true, "Nilüfer", "Kadın", "Özdemir", false, null, "NILUFEROZDEMIR@GMAIL.COM", "NILUFEROZDEMIR", "AQAAAAIAAYagAAAAEIQolj9n1q3Lc5rYasPUfUrKr7Isz5z1xgdR1MzIrZ16IzAsNu7XovWWo9w6oF/N0Q==", "5383458090", false, "599396ee-aeec-4808-9145-8d641ed8716f", 2, false, "niluferozdemir" },
                    { "69d90984-b30e-4d7e-be07-ecdbe2f1fd93", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "babf5bae-427f-4a24-aac4-cd02381c2a80", new DateTime(1990, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "kadirdevran@gmail.com", true, "Kadir", "Erkek", "Devran", false, null, "KADIRDEVRAN@GMAIL.COM", "KADIRDEVRAN", "AQAAAAIAAYagAAAAEPeXYfmQ6EyC/2ZwUdb6+9T5gDMOIt+tvpHQbuk8xa1yvRzjb5yuYSIfp2oTVqB1vw==", "5341459340", false, "8826b670-2674-490a-a4c7-97c0ccd29a75", 2, false, "kadirdevran" },
                    { "8774e355-4e17-4574-9724-99f5533b41cb", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "ea247ff9-2f8b-438e-a3e7-ab3e0b43adf6", new DateTime(1989, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "canyener@gmail.com", true, "Can", "Erkek", "Yener", false, null, "CANYENER@GMAIL.COM", "CANYENER", "AQAAAAIAAYagAAAAEJzwtczmXKgjN7hSQRRCCDvDFH043ayt6pFMyQT44lwe8c1OWzM2pI8c87Ht43CgDQ==", "5350931264", false, "5df3e590-f778-486d-8d12-4106fa6fa520", 3, false, "canyener" },
                    { "8ae11b8a-9c9f-451d-bf13-2cc781c62d1d", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "6d6190a8-c3aa-413e-8ed8-05cb5dd432b3", new DateTime(1983, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "ferdabayar@gmail.com", true, "Ferda", "Erkek", "Bayar", false, null, "FERDABAYAR@GMAIL.COM", "FERDABAYAR", "AQAAAAIAAYagAAAAEMqFMDA+lNKGXVJvPcVgpHFSOS0qfUN07kjR4L+asKx501XId/7XT66O+jCOesAp7Q==", "5053211815", false, "95987827-7d03-4ddd-9fc9-4d97567516a8", 3, false, "ferdabayar" },
                    { "f6ea74a5-57ef-4e5a-8a8d-9b9cfaaab46f", 0, "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy", "İstanbul", "6408c941-7919-4f19-a914-b27b557626db", new DateTime(1992, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "deryademir@gmail.com", true, "Derya", "Kadın", "Demir", false, null, "DERYADEMIR@GMAIL.COM", "DERYADEMIR", "AQAAAAIAAYagAAAAEPCRqAbpPstQ1rchAkUqRDQeP37sgdoucn9KFTgTI8uSDIc43Pz+Wg1fz0p1lPgWSg==", "5547659843", false, "acd47552-5224-4aad-8731-7f0a6e59882e", 2, false, "deryademir" }
                });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 4, 10, 16, 23, 16, 14, DateTimeKind.Local).AddTicks(7840), new DateTime(2024, 4, 10, 16, 23, 16, 14, DateTimeKind.Local).AddTicks(7900) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 4, 10, 16, 23, 16, 14, DateTimeKind.Local).AddTicks(7910), new DateTime(2024, 4, 10, 16, 23, 16, 14, DateTimeKind.Local).AddTicks(7910) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 4, 10, 16, 23, 16, 14, DateTimeKind.Local).AddTicks(7920), new DateTime(2024, 4, 10, 16, 23, 16, 14, DateTimeKind.Local).AddTicks(7920) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "5ef4dac7-d3c6-4a0e-850f-f526bd05977f", "1687bad9-7852-49b5-9598-2931eb04aa28" },
                    { "5ef4dac7-d3c6-4a0e-850f-f526bd05977f", "69d90984-b30e-4d7e-be07-ecdbe2f1fd93" },
                    { "5ef4dac7-d3c6-4a0e-850f-f526bd05977f", "8774e355-4e17-4574-9724-99f5533b41cb" },
                    { "895016d3-6150-4c1f-8307-a118a723d839", "8ae11b8a-9c9f-451d-bf13-2cc781c62d1d" },
                    { "20f4929f-322a-48fe-8abe-d26276fcd911", "f6ea74a5-57ef-4e5a-8a8d-9b9cfaaab46f" }
                });
        }
    }
}
