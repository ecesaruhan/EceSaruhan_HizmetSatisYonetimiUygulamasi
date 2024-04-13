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
    [Migration("20240413180119_ContactUsIsCompleted")]
    partial class ContactUsIsCompleted
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
                            UserId = "31105b81-d2c2-4525-9758-3dd659a2125d",
                            RoleId = "cf33f11b-a126-465e-b656-596c378df438"
                        },
                        new
                        {
                            UserId = "3d89c51f-7d15-4776-8b08-7b436a975cf3",
                            RoleId = "b73f24a7-c5dd-4c8d-8960-f10bf72fe7ed"
                        },
                        new
                        {
                            UserId = "4e500478-abed-4fc3-9563-88a20f246163",
                            RoleId = "076754d8-219c-4e44-a2b8-f11bb87a854e"
                        },
                        new
                        {
                            UserId = "f0449bc5-b928-4ba2-b0cb-453ac197dc95",
                            RoleId = "b73f24a7-c5dd-4c8d-8960-f10bf72fe7ed"
                        },
                        new
                        {
                            UserId = "2adfadd5-b063-4ef4-a030-c97d37051411",
                            RoleId = "b73f24a7-c5dd-4c8d-8960-f10bf72fe7ed"
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

            modelBuilder.Entity("SalesUp.Entity.ContactUs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
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

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
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
                            Id = "076754d8-219c-4e44-a2b8-f11bb87a854e",
                            Description = "Yönetici haklarını taşıyan rol.",
                            Name = "SuperAdmin",
                            NormalizedName = "SUPERADMIN"
                        },
                        new
                        {
                            Id = "b73f24a7-c5dd-4c8d-8960-f10bf72fe7ed",
                            Description = "Satış Temsilcisi haklarını taşıyan rol.",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "cf33f11b-a126-465e-b656-596c378df438",
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
                            Id = "31105b81-d2c2-4525-9758-3dd659a2125d",
                            AccessFailedCount = 0,
                            Address = "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy",
                            City = "İstanbul",
                            ConcurrencyStamp = "7a19d7a1-f997-4269-8e54-9d879d686da7",
                            DateofBirth = new DateTime(1992, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "deryademir@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Derya",
                            Gender = "Kadın",
                            LastName = "Demir",
                            LockoutEnabled = false,
                            NormalizedEmail = "DERYADEMIR@GMAIL.COM",
                            NormalizedUserName = "DERYADEMIR",
                            PasswordHash = "AQAAAAIAAYagAAAAEM1Aez7XvdhQyEdT6ZNS83Mn9cvd3eEh0uSaq/K8VPrbWRbgGJAniShIJKqA5HNngA==",
                            PhoneNumber = "5547659843",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "43c4f4e0-9907-4d8c-a1e7-37b906053554",
                            SubscriptionId = 2,
                            TwoFactorEnabled = false,
                            UserName = "deryademir"
                        },
                        new
                        {
                            Id = "3d89c51f-7d15-4776-8b08-7b436a975cf3",
                            AccessFailedCount = 0,
                            Address = "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy",
                            City = "İstanbul",
                            ConcurrencyStamp = "bf8db5c9-cf64-4476-9887-855b90747040",
                            DateofBirth = new DateTime(1990, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "kadirdevran@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Kadir",
                            Gender = "Erkek",
                            LastName = "Devran",
                            LockoutEnabled = false,
                            NormalizedEmail = "KADIRDEVRAN@GMAIL.COM",
                            NormalizedUserName = "KADIRDEVRAN",
                            PasswordHash = "AQAAAAIAAYagAAAAEJtckzV9ZFeXugujp3fDRCw93wGog3zgVbfVLQkzzqjWkHO9RU4TONmEg5nmIyJ73A==",
                            PhoneNumber = "5341459340",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1e1510de-aaa7-45f6-8eb7-740ab48fe4d7",
                            SubscriptionId = 2,
                            TwoFactorEnabled = false,
                            UserName = "kadirdevran"
                        },
                        new
                        {
                            Id = "4e500478-abed-4fc3-9563-88a20f246163",
                            AccessFailedCount = 0,
                            Address = "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy",
                            City = "İstanbul",
                            ConcurrencyStamp = "0e53b803-43d6-430e-ba07-0c2c82763e6f",
                            DateofBirth = new DateTime(1983, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ferdabayar@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Ferda",
                            Gender = "Erkek",
                            LastName = "Bayar",
                            LockoutEnabled = false,
                            NormalizedEmail = "FERDABAYAR@GMAIL.COM",
                            NormalizedUserName = "FERDABAYAR",
                            PasswordHash = "AQAAAAIAAYagAAAAEN9+BgTUhkZzXIu4TK2AvRJmQ+TycztJ3f53yjmn92+gNvUOg7s6ZptyTa0/gOnuBQ==",
                            PhoneNumber = "5053211815",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d6c27dc1-6516-4d74-8304-200f3d674668",
                            SubscriptionId = 3,
                            TwoFactorEnabled = false,
                            UserName = "ferdabayar"
                        },
                        new
                        {
                            Id = "f0449bc5-b928-4ba2-b0cb-453ac197dc95",
                            AccessFailedCount = 0,
                            Address = "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy",
                            City = "İstanbul",
                            ConcurrencyStamp = "89532afd-8382-4f4d-ba1b-b276ded45739",
                            DateofBirth = new DateTime(1970, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "niluferozdemir@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Nilüfer",
                            Gender = "Kadın",
                            LastName = "Özdemir",
                            LockoutEnabled = false,
                            NormalizedEmail = "NILUFEROZDEMIR@GMAIL.COM",
                            NormalizedUserName = "NILUFEROZDEMIR",
                            PasswordHash = "AQAAAAIAAYagAAAAEA1+U7nOHBovAmkei9UT1YQvGYIBz4esewLzvryYW6dQfOeq9IE7zQzvfyWEAorlHQ==",
                            PhoneNumber = "5383458090",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "0e8921fc-ae53-4af9-92ef-736c9bdadf3f",
                            SubscriptionId = 2,
                            TwoFactorEnabled = false,
                            UserName = "niluferozdemir"
                        },
                        new
                        {
                            Id = "2adfadd5-b063-4ef4-a030-c97d37051411",
                            AccessFailedCount = 0,
                            Address = "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy",
                            City = "İstanbul",
                            ConcurrencyStamp = "07ba851a-d89d-4cc2-9da7-a1795a6f77ce",
                            DateofBirth = new DateTime(1989, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "canyener@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Can",
                            Gender = "Erkek",
                            LastName = "Yener",
                            LockoutEnabled = false,
                            NormalizedEmail = "CANYENER@GMAIL.COM",
                            NormalizedUserName = "CANYENER",
                            PasswordHash = "AQAAAAIAAYagAAAAEFg589yNdiVUIknSSqDfo6ibtTPDT38JYVfBOP9S584e/dglIl60ChdoETkEaQyJ2A==",
                            PhoneNumber = "5350931264",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "06992aaa-7a3c-4c1f-a14b-781d3a578127",
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

                    b.Property<int>("RelatedId")
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

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

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
                            CreatedDate = new DateTime(2024, 4, 13, 21, 1, 19, 589, DateTimeKind.Local).AddTicks(1540),
                            Description = "Her ay düzenli olarak ödenecek olan abonelik sistemidir.",
                            Duration = 6,
                            DurationUnit = "Ay",
                            IsActive = true,
                            Name = "6 Aylık Abonelik",
                            Price = 1000m,
                            SubscriptionType = 0,
                            UpdateDate = new DateTime(2024, 4, 13, 21, 1, 19, 589, DateTimeKind.Local).AddTicks(1610)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 4, 13, 21, 1, 19, 589, DateTimeKind.Local).AddTicks(1620),
                            Description = "Her ay düzenli olarak ödenecek olan abonelik sistemidir.",
                            Duration = 12,
                            DurationUnit = "Ay",
                            IsActive = true,
                            Name = "12 Aylık Abonelik",
                            Price = 800m,
                            SubscriptionType = 1,
                            UpdateDate = new DateTime(2024, 4, 13, 21, 1, 19, 589, DateTimeKind.Local).AddTicks(1620)
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 4, 13, 21, 1, 19, 589, DateTimeKind.Local).AddTicks(1620),
                            Description = "Her ay düzenli olarak ödenecek olan abonelik sistemidir.",
                            Duration = 24,
                            DurationUnit = "Ay",
                            IsActive = true,
                            Name = "24 Aylık Abonelik",
                            Price = 500m,
                            SubscriptionType = 2,
                            UpdateDate = new DateTime(2024, 4, 13, 21, 1, 19, 589, DateTimeKind.Local).AddTicks(1630)
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
                    b.HasOne("SalesUp.Entity.Identity.User", "User")
                        .WithMany("STaskList")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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
