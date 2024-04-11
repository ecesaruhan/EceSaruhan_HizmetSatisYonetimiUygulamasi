using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SalesUp.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SendingDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Text = table.Column<string>(type: "TEXT", nullable: false),
                    ToId = table.Column<string>(type: "TEXT", nullable: false),
                    ToName = table.Column<string>(type: "TEXT", nullable: false),
                    FromId = table.Column<string>(type: "TEXT", nullable: false),
                    FromName = table.Column<string>(type: "TEXT", nullable: false),
                    IsRead = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "real", nullable: false),
                    Duration = table.Column<int>(type: "INTEGER", nullable: false),
                    DurationUnit = table.Column<string>(type: "TEXT", nullable: false),
                    SubscriptionType = table.Column<int>(type: "INTEGER", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CustomerId = table.Column<int>(type: "INTEGER", nullable: false),
                    SaleDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sales_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    Gender = table.Column<string>(type: "TEXT", nullable: false),
                    DateofBirth = table.Column<DateTime>(type: "TEXT", nullable: true),
                    SubscriptionId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Subscriptions_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "Subscriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderNumber = table.Column<string>(type: "TEXT", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Note = table.Column<string>(type: "TEXT", nullable: false),
                    PaymentType = table.Column<int>(type: "INTEGER", nullable: false),
                    PaymentId = table.Column<string>(type: "TEXT", nullable: false),
                    ConversationId = table.Column<string>(type: "TEXT", nullable: false),
                    CustomerId = table.Column<string>(type: "TEXT", nullable: false),
                    CustomerId1 = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId1",
                        column: x => x.CustomerId1,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Properties = table.Column<string>(type: "TEXT", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false),
                    UserId1 = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    CustomerName = table.Column<string>(type: "TEXT", nullable: false),
                    ProductName = table.Column<string>(type: "TEXT", nullable: false),
                    IsCompleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    Note = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tasks_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderId = table.Column<int>(type: "INTEGER", nullable: false),
                    SubscriptionId = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    Duration = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Subscriptions_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "Subscriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SaleDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SaleId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SaleDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SaleDetails_Sales_SaleId",
                        column: x => x.SaleId,
                        principalTable: "Sales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                table: "Subscriptions",
                columns: new[] { "Id", "CreatedDate", "Description", "Duration", "DurationUnit", "IsActive", "Name", "Price", "SubscriptionType", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 10, 16, 23, 16, 14, DateTimeKind.Local).AddTicks(7840), "Her ay düzenli olarak ödenecek olan abonelik sistemidir.", 6, "Ay", true, "6 Aylık Abonelik", 1000m, 0, new DateTime(2024, 4, 10, 16, 23, 16, 14, DateTimeKind.Local).AddTicks(7900) },
                    { 2, new DateTime(2024, 4, 10, 16, 23, 16, 14, DateTimeKind.Local).AddTicks(7910), "Her ay düzenli olarak ödenecek olan abonelik sistemidir.", 12, "Ay", true, "12 Aylık Abonelik", 800m, 1, new DateTime(2024, 4, 10, 16, 23, 16, 14, DateTimeKind.Local).AddTicks(7910) },
                    { 3, new DateTime(2024, 4, 10, 16, 23, 16, 14, DateTimeKind.Local).AddTicks(7920), "Her ay düzenli olarak ödenecek olan abonelik sistemidir.", 24, "Ay", true, "24 Aylık Abonelik", 500m, 2, new DateTime(2024, 4, 10, 16, 23, 16, 14, DateTimeKind.Local).AddTicks(7920) }
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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_SubscriptionId",
                table: "AspNetUsers",
                column: "SubscriptionId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_SubscriptionId",
                table: "OrderDetails",
                column: "SubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId1",
                table: "Orders",
                column: "CustomerId1");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_RoleId",
                table: "Orders",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_UserId1",
                table: "Products",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_SaleDetails_ProductId",
                table: "SaleDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleDetails_SaleId",
                table: "SaleDetails",
                column: "SaleId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_CustomerId",
                table: "Sales",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_UserId",
                table: "Tasks",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "SaleDetails");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Subscriptions");
        }
    }
}
