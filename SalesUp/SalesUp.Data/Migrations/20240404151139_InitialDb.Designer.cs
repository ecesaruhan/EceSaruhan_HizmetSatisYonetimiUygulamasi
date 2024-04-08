﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SalesUp.Data.Concrete.Contexts;

#nullable disable

namespace SalesUp.Data.Migrations
{
    [DbContext(typeof(SalesUpDbContext))]
    [Migration("20240404151139_InitialDb")]
    partial class InitialDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.17");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "8bbbcd0a-9d46-4ca3-ab6d-19ffbd42cfe9",
                            RoleId = "18643164-0a28-425b-a8fb-f716f3bfe28f"
                        },
                        new
                        {
                            UserId = "cd358d60-d1ac-49a7-a278-f9f3d78f217e",
                            RoleId = "fb6bca6d-2062-4d64-81b5-704c22bce215"
                        },
                        new
                        {
                            UserId = "14de594c-8182-4ed3-8377-f9a9e462798e",
                            RoleId = "69666bc1-4018-4ee5-89ec-07d5db137c6b"
                        },
                        new
                        {
                            UserId = "f217abbc-8f4f-4d71-af00-89cd891f6b36",
                            RoleId = "fb6bca6d-2062-4d64-81b5-704c22bce215"
                        },
                        new
                        {
                            UserId = "6f2596c8-c0ea-4092-a8ee-cd416d94a452",
                            RoleId = "fb6bca6d-2062-4d64-81b5-704c22bce215"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("SalesUp.Entity.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("SalesUp.Entity.Identity.Role", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "69666bc1-4018-4ee5-89ec-07d5db137c6b",
                            Description = "Yönetici haklarını taşıyan rol.",
                            Name = "SuperAdmin",
                            NormalizedName = "SUPERADMIN"
                        },
                        new
                        {
                            Id = "fb6bca6d-2062-4d64-81b5-704c22bce215",
                            Description = "Satış Temsilcisi haklarını taşıyan rol.",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "18643164-0a28-425b-a8fb-f716f3bfe28f",
                            Description = "Müşteri haklarını taşıyan rol.",
                            Name = "Customer",
                            NormalizedName = "CUSTOMER"
                        });
                });

            modelBuilder.Entity("SalesUp.Entity.Identity.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DateofBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<int>("SubscriptionId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.HasIndex("SubscriptionId");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "8bbbcd0a-9d46-4ca3-ab6d-19ffbd42cfe9",
                            AccessFailedCount = 0,
                            Address = "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy",
                            City = "İstanbul",
                            ConcurrencyStamp = "98a38b93-3db9-4a50-a9a1-f5422da1be6b",
                            DateofBirth = new DateTime(1992, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "deryademir@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Derya",
                            Gender = "Kadın",
                            LastName = "Demir",
                            LockoutEnabled = false,
                            NormalizedEmail = "DERYADEMIR@GMAIL.COM",
                            NormalizedUserName = "DERYADEMIR",
                            PasswordHash = "AQAAAAIAAYagAAAAEITzuZyy4HZU2Kx3NsevISp71SOapngokFXQ7w208o6wYbvgNVDfpInevkbc9Ga86A==",
                            PhoneNumber = "5547659843",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "63adaf42-fcbf-47c7-bf96-b4cb8d37172a",
                            SubscriptionId = 2,
                            TwoFactorEnabled = false,
                            UserName = "deryademir"
                        },
                        new
                        {
                            Id = "cd358d60-d1ac-49a7-a278-f9f3d78f217e",
                            AccessFailedCount = 0,
                            Address = "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy",
                            City = "İstanbul",
                            ConcurrencyStamp = "171e5f73-7b0f-4452-87c5-f65919b5d4a2",
                            DateofBirth = new DateTime(1990, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "kadirdevran@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Kadir",
                            Gender = "Erkek",
                            LastName = "Devran",
                            LockoutEnabled = false,
                            NormalizedEmail = "KADIRDEVRAN@GMAIL.COM",
                            NormalizedUserName = "KADIRDEVRAN",
                            PasswordHash = "AQAAAAIAAYagAAAAEOZad04POBgvGxqVxVhRowZsDSaaqN9zQg3j5x7QPBn2ODUtP9MAmfXex+MfU634GQ==",
                            PhoneNumber = "5341459340",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d998c3b0-4686-4eae-bb52-bbb2823873b0",
                            SubscriptionId = 2,
                            TwoFactorEnabled = false,
                            UserName = "kadirdevran"
                        },
                        new
                        {
                            Id = "14de594c-8182-4ed3-8377-f9a9e462798e",
                            AccessFailedCount = 0,
                            Address = "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy",
                            City = "İstanbul",
                            ConcurrencyStamp = "86463942-5cea-455d-95e3-f2deeaa1a535",
                            DateofBirth = new DateTime(1983, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ferdabayar@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Ferda",
                            Gender = "Erkek",
                            LastName = "Bayar",
                            LockoutEnabled = false,
                            NormalizedEmail = "FERDABAYAR@GMAIL.COM",
                            NormalizedUserName = "FERDABAYAR",
                            PasswordHash = "AQAAAAIAAYagAAAAEMo9X0jhzVdAyrBle1qHk6CpQQNJ/PcK0uK1AyhSVwSZJbtIfaoSf+u/e6gBJswl2Q==",
                            PhoneNumber = "5053211815",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "5d87695d-1dba-4070-9010-936cd8ab6e5a",
                            SubscriptionId = 3,
                            TwoFactorEnabled = false,
                            UserName = "ferdabayar"
                        },
                        new
                        {
                            Id = "f217abbc-8f4f-4d71-af00-89cd891f6b36",
                            AccessFailedCount = 0,
                            Address = "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy",
                            City = "İstanbul",
                            ConcurrencyStamp = "d760e07c-bcc2-4910-b739-b3487215b21a",
                            DateofBirth = new DateTime(1970, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "niluferozdemir@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Nilüfer",
                            Gender = "Kadın",
                            LastName = "Özdemir",
                            LockoutEnabled = false,
                            NormalizedEmail = "NILUFEROZDEMIR@GMAIL.COM",
                            NormalizedUserName = "NILUFEROZDEMIR",
                            PasswordHash = "AQAAAAIAAYagAAAAEEeYPOeaIsVgi1P+3KWaGcKc6Buhc2ZUbL8OSxohVgtMu2qaSbx6lRuN9+VI6H4g1g==",
                            PhoneNumber = "5383458090",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "5516fd64-4ca9-48e1-ac85-7b0b41b60be5",
                            SubscriptionId = 2,
                            TwoFactorEnabled = false,
                            UserName = "niluferozdemir"
                        },
                        new
                        {
                            Id = "6f2596c8-c0ea-4092-a8ee-cd416d94a452",
                            AccessFailedCount = 0,
                            Address = "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy",
                            City = "İstanbul",
                            ConcurrencyStamp = "4c73c412-0eaf-4611-8c6e-d65a1e70ba61",
                            DateofBirth = new DateTime(1989, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "canyener@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Can",
                            Gender = "Erkek",
                            LastName = "Yener",
                            LockoutEnabled = false,
                            NormalizedEmail = "CANYENER@GMAIL.COM",
                            NormalizedUserName = "CANYENER",
                            PasswordHash = "AQAAAAIAAYagAAAAEP4YcuE0wFMNNxs8oBD0uzA2KCOxY9i2lznwEEhbRSkUy15hsvfNQvdTsu5Bm8hBOg==",
                            PhoneNumber = "5350931264",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "eeaa4788-25b9-4739-b478-f1c8b48a65bb",
                            SubscriptionId = 3,
                            TwoFactorEnabled = false,
                            UserName = "canyener"
                        });
                });

            modelBuilder.Entity("SalesUp.Entity.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FromId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FromName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsRead")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("SendingDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ToId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ToName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("SalesUp.Entity.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ConversationId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("CustomerId1")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("OrderNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PaymentId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PaymentType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId1");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("SalesUp.Entity.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Duration")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<int>("SubscriptionId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("SubscriptionId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("SalesUp.Entity.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Properties")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserId1")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId1");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("SalesUp.Entity.STask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("SalesUp.Entity.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Amount")
                        .HasColumnType("TEXT");

                    b.Property<int>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("SaleDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("SalesUp.Entity.SaleDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SaleId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("SaleId");

                    b.ToTable("SaleDetails");
                });

            modelBuilder.Entity("SalesUp.Entity.Subscription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int>("Duration")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DurationUnit")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("real");

                    b.Property<int>("SubscriptionType")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Subscriptions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 4, 4, 18, 11, 39, 742, DateTimeKind.Local).AddTicks(80),
                            Description = "Her hafta düzenli olarak ödenecek olan abonelik sistemidir.",
                            Duration = 1,
                            DurationUnit = "Hafta",
                            IsActive = true,
                            Name = "Haftalık Abonelik",
                            Price = 500m,
                            SubscriptionType = 0,
                            UpdateDate = new DateTime(2024, 4, 4, 18, 11, 39, 742, DateTimeKind.Local).AddTicks(120)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 4, 4, 18, 11, 39, 742, DateTimeKind.Local).AddTicks(130),
                            Description = "Her ay düzenli olarak ödenecek olan abonelik sistemidir.",
                            Duration = 1,
                            DurationUnit = "Ay",
                            IsActive = true,
                            Name = "Aylık Abonelik",
                            Price = 1500m,
                            SubscriptionType = 1,
                            UpdateDate = new DateTime(2024, 4, 4, 18, 11, 39, 742, DateTimeKind.Local).AddTicks(130)
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 4, 4, 18, 11, 39, 742, DateTimeKind.Local).AddTicks(130),
                            Description = "Her yıl düzenli olarak ödenecek olan abonelik sistemidir.",
                            Duration = 1,
                            DurationUnit = "Yıl",
                            IsActive = true,
                            Name = "Yıllık Abonelik",
                            Price = 5000m,
                            SubscriptionType = 2,
                            UpdateDate = new DateTime(2024, 4, 4, 18, 11, 39, 742, DateTimeKind.Local).AddTicks(140)
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("SalesUp.Entity.Identity.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("SalesUp.Entity.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SalesUp.Entity.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("SalesUp.Entity.Identity.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SalesUp.Entity.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("SalesUp.Entity.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SalesUp.Entity.Identity.User", b =>
                {
                    b.HasOne("SalesUp.Entity.Subscription", "Subscription")
                        .WithMany("Users")
                        .HasForeignKey("SubscriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subscription");
                });

            modelBuilder.Entity("SalesUp.Entity.Order", b =>
                {
                    b.HasOne("SalesUp.Entity.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SalesUp.Entity.Identity.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SalesUp.Entity.Identity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SalesUp.Entity.OrderDetail", b =>
                {
                    b.HasOne("SalesUp.Entity.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SalesUp.Entity.Subscription", "Subscription")
                        .WithMany()
                        .HasForeignKey("SubscriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Subscription");
                });

            modelBuilder.Entity("SalesUp.Entity.Product", b =>
                {
                    b.HasOne("SalesUp.Entity.Identity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId1");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SalesUp.Entity.STask", b =>
                {
                    b.HasOne("SalesUp.Entity.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SalesUp.Entity.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SalesUp.Entity.Identity.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SalesUp.Entity.Identity.User", "User")
                        .WithMany("STaskList")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Product");

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SalesUp.Entity.Sale", b =>
                {
                    b.HasOne("SalesUp.Entity.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("SalesUp.Entity.SaleDetail", b =>
                {
                    b.HasOne("SalesUp.Entity.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SalesUp.Entity.Sale", "Sale")
                        .WithMany("SaleDetails")
                        .HasForeignKey("SaleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Sale");
                });

            modelBuilder.Entity("SalesUp.Entity.Identity.User", b =>
                {
                    b.Navigation("STaskList");
                });

            modelBuilder.Entity("SalesUp.Entity.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("SalesUp.Entity.Sale", b =>
                {
                    b.Navigation("SaleDetails");
                });

            modelBuilder.Entity("SalesUp.Entity.Subscription", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}