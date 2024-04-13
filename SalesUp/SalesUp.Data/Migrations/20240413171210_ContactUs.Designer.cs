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
    [Migration("20240413171210_ContactUs")]
    partial class ContactUs
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
                            UserId = "eae2178d-29e7-4feb-84f9-131e1a52ebba",
                            RoleId = "8ef7a844-f2c4-4585-a9bf-35e10fb75e57"
                        },
                        new
                        {
                            UserId = "735d36e8-236a-463c-bb7c-1928125d3dd4",
                            RoleId = "e64c3967-5106-4f6f-8069-493179224b3d"
                        },
                        new
                        {
                            UserId = "5b52f37b-52a3-41f9-ab8f-a8e17731cdef",
                            RoleId = "597c415b-6d8f-4873-8c3e-0640d8307526"
                        },
                        new
                        {
                            UserId = "4ce5fbc6-70be-460c-97fe-7f603d4b5716",
                            RoleId = "e64c3967-5106-4f6f-8069-493179224b3d"
                        },
                        new
                        {
                            UserId = "77346360-0ff0-46d5-b538-d1efec4829ce",
                            RoleId = "e64c3967-5106-4f6f-8069-493179224b3d"
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
                            Id = "597c415b-6d8f-4873-8c3e-0640d8307526",
                            Description = "Yönetici haklarını taşıyan rol.",
                            Name = "SuperAdmin",
                            NormalizedName = "SUPERADMIN"
                        },
                        new
                        {
                            Id = "e64c3967-5106-4f6f-8069-493179224b3d",
                            Description = "Satış Temsilcisi haklarını taşıyan rol.",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "8ef7a844-f2c4-4585-a9bf-35e10fb75e57",
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
                            Id = "eae2178d-29e7-4feb-84f9-131e1a52ebba",
                            AccessFailedCount = 0,
                            Address = "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy",
                            City = "İstanbul",
                            ConcurrencyStamp = "affdf910-513b-4dba-9d1b-abd792b797d1",
                            DateofBirth = new DateTime(1992, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "deryademir@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Derya",
                            Gender = "Kadın",
                            LastName = "Demir",
                            LockoutEnabled = false,
                            NormalizedEmail = "DERYADEMIR@GMAIL.COM",
                            NormalizedUserName = "DERYADEMIR",
                            PasswordHash = "AQAAAAIAAYagAAAAEBjOVn+bjZmPinzlW1Ji3Pz3ai1eHHQlOzBp2nGZdJ0vKnJrehPBCsLQx9Vx4Xlszg==",
                            PhoneNumber = "5547659843",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f2bd6658-ccb0-448a-a609-d340eb259f43",
                            SubscriptionId = 2,
                            TwoFactorEnabled = false,
                            UserName = "deryademir"
                        },
                        new
                        {
                            Id = "735d36e8-236a-463c-bb7c-1928125d3dd4",
                            AccessFailedCount = 0,
                            Address = "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy",
                            City = "İstanbul",
                            ConcurrencyStamp = "8364f03f-5967-4563-8f9c-90fb1d2d5c76",
                            DateofBirth = new DateTime(1990, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "kadirdevran@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Kadir",
                            Gender = "Erkek",
                            LastName = "Devran",
                            LockoutEnabled = false,
                            NormalizedEmail = "KADIRDEVRAN@GMAIL.COM",
                            NormalizedUserName = "KADIRDEVRAN",
                            PasswordHash = "AQAAAAIAAYagAAAAEJZiqoFU11pBU7Gr7sauRRFaTUdNa33klMGmEtHSJVR2QzHKhBc83mOfvv4zZdsu0Q==",
                            PhoneNumber = "5341459340",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "96113b48-4987-4d0f-ae23-eb46aaea7560",
                            SubscriptionId = 2,
                            TwoFactorEnabled = false,
                            UserName = "kadirdevran"
                        },
                        new
                        {
                            Id = "5b52f37b-52a3-41f9-ab8f-a8e17731cdef",
                            AccessFailedCount = 0,
                            Address = "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy",
                            City = "İstanbul",
                            ConcurrencyStamp = "dd656559-bace-4e63-9e92-896f7bf29dd4",
                            DateofBirth = new DateTime(1983, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ferdabayar@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Ferda",
                            Gender = "Erkek",
                            LastName = "Bayar",
                            LockoutEnabled = false,
                            NormalizedEmail = "FERDABAYAR@GMAIL.COM",
                            NormalizedUserName = "FERDABAYAR",
                            PasswordHash = "AQAAAAIAAYagAAAAECO67dyFt07zhXEkuntNBSULp2pu5Ig0FMgizLXrhmOZLq6KsWvvEinc2QCb5X1JxQ==",
                            PhoneNumber = "5053211815",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6addf0f3-6903-4bb5-9380-c9377b31a244",
                            SubscriptionId = 3,
                            TwoFactorEnabled = false,
                            UserName = "ferdabayar"
                        },
                        new
                        {
                            Id = "4ce5fbc6-70be-460c-97fe-7f603d4b5716",
                            AccessFailedCount = 0,
                            Address = "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy",
                            City = "İstanbul",
                            ConcurrencyStamp = "32c8ed21-0987-424a-98a2-1a701686bf9d",
                            DateofBirth = new DateTime(1970, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "niluferozdemir@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Nilüfer",
                            Gender = "Kadın",
                            LastName = "Özdemir",
                            LockoutEnabled = false,
                            NormalizedEmail = "NILUFEROZDEMIR@GMAIL.COM",
                            NormalizedUserName = "NILUFEROZDEMIR",
                            PasswordHash = "AQAAAAIAAYagAAAAECDIUmfGnobUdyDe5UDouWxkYsVk4AqJhbQ9yhDTkJ+BstAgiGKc2XRHNVmtRqEOvg==",
                            PhoneNumber = "5383458090",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f2b654b2-44c6-48ef-b718-ed5007400e70",
                            SubscriptionId = 2,
                            TwoFactorEnabled = false,
                            UserName = "niluferozdemir"
                        },
                        new
                        {
                            Id = "77346360-0ff0-46d5-b538-d1efec4829ce",
                            AccessFailedCount = 0,
                            Address = "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy",
                            City = "İstanbul",
                            ConcurrencyStamp = "cbf28e1e-9c58-4d00-ac6b-706fd845c258",
                            DateofBirth = new DateTime(1989, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "canyener@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Can",
                            Gender = "Erkek",
                            LastName = "Yener",
                            LockoutEnabled = false,
                            NormalizedEmail = "CANYENER@GMAIL.COM",
                            NormalizedUserName = "CANYENER",
                            PasswordHash = "AQAAAAIAAYagAAAAEHvnflyiZwmIJkFDxuzj+g/uODbGZsaMwSWagvvRj4vs5+MVrNVuH3xAhPZ1SFUaRw==",
                            PhoneNumber = "5350931264",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b5797210-ba95-4445-a20f-32f96b6e56e7",
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
                            CreatedDate = new DateTime(2024, 4, 13, 20, 12, 10, 400, DateTimeKind.Local).AddTicks(4150),
                            Description = "Her ay düzenli olarak ödenecek olan abonelik sistemidir.",
                            Duration = 6,
                            DurationUnit = "Ay",
                            IsActive = true,
                            Name = "6 Aylık Abonelik",
                            Price = 1000m,
                            SubscriptionType = 0,
                            UpdateDate = new DateTime(2024, 4, 13, 20, 12, 10, 400, DateTimeKind.Local).AddTicks(4170)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 4, 13, 20, 12, 10, 400, DateTimeKind.Local).AddTicks(4180),
                            Description = "Her ay düzenli olarak ödenecek olan abonelik sistemidir.",
                            Duration = 12,
                            DurationUnit = "Ay",
                            IsActive = true,
                            Name = "12 Aylık Abonelik",
                            Price = 800m,
                            SubscriptionType = 1,
                            UpdateDate = new DateTime(2024, 4, 13, 20, 12, 10, 400, DateTimeKind.Local).AddTicks(4180)
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 4, 13, 20, 12, 10, 400, DateTimeKind.Local).AddTicks(4190),
                            Description = "Her ay düzenli olarak ödenecek olan abonelik sistemidir.",
                            Duration = 24,
                            DurationUnit = "Ay",
                            IsActive = true,
                            Name = "24 Aylık Abonelik",
                            Price = 500m,
                            SubscriptionType = 2,
                            UpdateDate = new DateTime(2024, 4, 13, 20, 12, 10, 400, DateTimeKind.Local).AddTicks(4200)
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
