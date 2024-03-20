﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SalesUp.Data.Concrete.Contexts;

#nullable disable

namespace SalesUp.Data.Migrations
{
    [DbContext(typeof(SalesUpDbContext))]
    partial class SalesUpDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            UserId = "1a4f5bd5-b4d6-4486-8c4a-0fe3907fb232",
                            RoleId = "9cd5dfce-a16f-408b-a43e-98dd08855faa"
                        },
                        new
                        {
                            UserId = "caa2dc9b-fd25-4757-994e-24de838a8245",
                            RoleId = "2cb1ddfe-1995-4f78-8d2f-3b988a3d80c6"
                        },
                        new
                        {
                            UserId = "6a17ce68-c89f-41a7-89c1-d01d0e7bb564",
                            RoleId = "6420d13b-1c53-478d-a390-c5edb740f274"
                        },
                        new
                        {
                            UserId = "662171e3-f356-47e3-a15a-90b7da55399e",
                            RoleId = "6420d13b-1c53-478d-a390-c5edb740f274"
                        },
                        new
                        {
                            UserId = "dd052b7c-1aa9-43fd-9e2e-468abe335b47",
                            RoleId = "2cb1ddfe-1995-4f78-8d2f-3b988a3d80c6"
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

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Gratis",
                            Url = "gratis"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Watsons",
                            Url = "watsons"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Rossmann",
                            Url = "rossmann"
                        },
                        new
                        {
                            Id = 4,
                            Name = "BeBeauty",
                            Url = "bebeauty"
                        },
                        new
                        {
                            Id = 5,
                            Name = "DM",
                            Url = "dm"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Müller",
                            Url = "muller"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Penny",
                            Url = "penny"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Carrefour",
                            Url = "carrefour"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Migros",
                            Url = "migros"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Macrocenter",
                            Url = "macrocenter"
                        });
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
                            Id = "6420d13b-1c53-478d-a390-c5edb740f274",
                            Description = "Satış Uzmanı haklarını taşıyan rol.",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "2cb1ddfe-1995-4f78-8d2f-3b988a3d80c6",
                            Description = "Satış Temsilcisi haklarını taşıyan rol.",
                            Name = "Employee",
                            NormalizedName = "EMPLOYEE"
                        },
                        new
                        {
                            Id = "9cd5dfce-a16f-408b-a43e-98dd08855faa",
                            Description = "Satış Temsilcisi Yardımcısı haklarını taşıyan rol.",
                            Name = "Assistant",
                            NormalizedName = "ASSISTANT"
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

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1a4f5bd5-b4d6-4486-8c4a-0fe3907fb232",
                            AccessFailedCount = 0,
                            Address = "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy",
                            City = "İstanbul",
                            ConcurrencyStamp = "55a469c5-ba7a-4b49-a96b-f40ca17f0c41",
                            DateofBirth = new DateTime(1992, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "deryademir@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Derya",
                            Gender = "Kadın",
                            LastName = "Demir",
                            LockoutEnabled = false,
                            NormalizedEmail = "DERYADEMIR@GMAIL.COM",
                            NormalizedUserName = "DERYADEMIR",
                            PasswordHash = "AQAAAAIAAYagAAAAEMb6pG98KbjJZfRXebApKzYPgS+EqKym5OKoPUgcwPRwvT1oFGQb6XTqBODj9kcvbA==",
                            PhoneNumber = "5547659843",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2487a2af-3d40-4b3a-9dfb-e688575d7a0c",
                            TwoFactorEnabled = false,
                            UserName = "deryademir"
                        },
                        new
                        {
                            Id = "caa2dc9b-fd25-4757-994e-24de838a8245",
                            AccessFailedCount = 0,
                            Address = "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy",
                            City = "İstanbul",
                            ConcurrencyStamp = "d9c9a2a1-b9bc-49e2-bd5d-e06789c709dd",
                            DateofBirth = new DateTime(1990, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "kadirdevran@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Kadir",
                            Gender = "Erkek",
                            LastName = "Devran",
                            LockoutEnabled = false,
                            NormalizedEmail = "KADIRDEVRAN@GMAIL.COM",
                            NormalizedUserName = "KADIRDEVRAN",
                            PasswordHash = "AQAAAAIAAYagAAAAEKp+WJdYmvo0xO0Ia7oKR5vSFqOjrO7kZu6VJaNR3K3zTjlW2TUM+zR6J3E0MLjzow==",
                            PhoneNumber = "5341459340",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "672e114d-f97c-49e0-a761-40a7e774f43e",
                            TwoFactorEnabled = false,
                            UserName = "kadirdevran"
                        },
                        new
                        {
                            Id = "6a17ce68-c89f-41a7-89c1-d01d0e7bb564",
                            AccessFailedCount = 0,
                            Address = "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy",
                            City = "İstanbul",
                            ConcurrencyStamp = "e182486f-5fe3-4a06-ba9e-f0f989a73cf6",
                            DateofBirth = new DateTime(1983, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ferdabayar@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Ferda",
                            Gender = "Erkek",
                            LastName = "Bayar",
                            LockoutEnabled = false,
                            NormalizedEmail = "FERDABAYAR@GMAIL.COM",
                            NormalizedUserName = "FERDABAYAR",
                            PasswordHash = "AQAAAAIAAYagAAAAEPwX632AExuPHiPmEfWpJKLpFp7XQv/lvSea3oVgP52cycVxQuvEU+yG3A5d8i8/Pw==",
                            PhoneNumber = "5053211815",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "5833740a-5b64-427d-98fb-ac48ea3379e6",
                            TwoFactorEnabled = false,
                            UserName = "ferdabayar"
                        },
                        new
                        {
                            Id = "662171e3-f356-47e3-a15a-90b7da55399e",
                            AccessFailedCount = 0,
                            Address = "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy",
                            City = "İstanbul",
                            ConcurrencyStamp = "34bd0bb6-3b44-41a2-8c0a-7edc392697eb",
                            DateofBirth = new DateTime(1970, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "niluferozdemir@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Nilüfer",
                            Gender = "Kadın",
                            LastName = "Özdemir",
                            LockoutEnabled = false,
                            NormalizedEmail = "NILUFEROZDEMIR@GMAIL.COM",
                            NormalizedUserName = "NILUFEROZDEMIR",
                            PasswordHash = "AQAAAAIAAYagAAAAEMCgfH0pZhsygp85ZRo8K15NP8EtGaIvGfCTRJ5SO9XBIq2D4S9gIcMla3F3xePOSw==",
                            PhoneNumber = "5383458090",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "643f75dc-43f5-4b06-9d1b-24634176bf20",
                            TwoFactorEnabled = false,
                            UserName = "niluferozdemir"
                        },
                        new
                        {
                            Id = "dd052b7c-1aa9-43fd-9e2e-468abe335b47",
                            AccessFailedCount = 0,
                            Address = "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy",
                            City = "İstanbul",
                            ConcurrencyStamp = "b04bfbd1-6fbb-4c38-8018-f7c999b5c7b8",
                            DateofBirth = new DateTime(1989, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "canyener@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Can",
                            Gender = "Erkek",
                            LastName = "Yener",
                            LockoutEnabled = false,
                            NormalizedEmail = "CANYENER@GMAIL.COM",
                            NormalizedUserName = "CANYENER",
                            PasswordHash = "AQAAAAIAAYagAAAAEEoMEpNBgdJb9SIn7MSM45d2Bz+hdPufHMIDdWU89d99vouRioRO3IEyNjwd7lWo5A==",
                            PhoneNumber = "5350931264",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e47f8a05-a523-4d42-88de-e1d8af98453c",
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

            modelBuilder.Entity("SalesUp.Entity.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("real");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Dove Şampuan",
                            Price = 105.90000000000001,
                            Quantity = 100,
                            Url = "dove-sampuan"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Dove Saç Kremi",
                            Price = 70.900000000000006,
                            Quantity = 120,
                            Url = "dove-sac-kremi"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Dove Saç Maskesi",
                            Price = 80.900000000000006,
                            Quantity = 80,
                            Url = "dove-sac-maskesi"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Dove Saç Bakım Spreyi",
                            Price = 40.899999999999999,
                            Quantity = 150,
                            Url = "dove-sac-bakim-spreyi"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Dove Serum",
                            Price = 55.899999999999999,
                            Quantity = 150,
                            Url = "dove-serum"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Dove Saç Köpüğü",
                            Price = 90.900000000000006,
                            Quantity = 150,
                            Url = "dove-sac-kopugu"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Dove Sprey Deodorant",
                            Price = 110.90000000000001,
                            Quantity = 150,
                            Url = "dove-sprey-deodorant"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Dove Roll-On Deodorant",
                            Price = 100.90000000000001,
                            Quantity = 150,
                            Url = "dove-rollon-deodorant"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Dove Bar Sabun",
                            Price = 30.899999999999999,
                            Quantity = 150,
                            Url = "dove-bar-sabun"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Dove Sıvı Sabun",
                            Price = 90.900000000000006,
                            Quantity = 100,
                            Url = "dove-sıvı-sabun"
                        });
                });

            modelBuilder.Entity("SalesUp.Entity.STask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Tasks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 3, 19, 20, 45, 0, 40, DateTimeKind.Local).AddTicks(4260),
                            UserId = "1a4f5bd5-b4d6-4486-8c4a-0fe3907fb232"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 3, 19, 20, 45, 0, 40, DateTimeKind.Local).AddTicks(4350),
                            UserId = "caa2dc9b-fd25-4757-994e-24de838a8245"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 3, 19, 20, 45, 0, 40, DateTimeKind.Local).AddTicks(4360),
                            UserId = "6a17ce68-c89f-41a7-89c1-d01d0e7bb564"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 3, 19, 20, 45, 0, 40, DateTimeKind.Local).AddTicks(4360),
                            UserId = "662171e3-f356-47e3-a15a-90b7da55399e"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 3, 19, 20, 45, 0, 40, DateTimeKind.Local).AddTicks(4370),
                            UserId = "dd052b7c-1aa9-43fd-9e2e-468abe335b47"
                        });
                });

            modelBuilder.Entity("SalesUp.Entity.STaskItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CompletedDate")
                        .HasColumnType("TEXT");

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

                    b.Property<int>("TaskId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TaskState")
                        .HasColumnType("INTEGER");

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

                    b.HasIndex("TaskId");

                    b.HasIndex("UserId");

                    b.ToTable("TaskItems");
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

            modelBuilder.Entity("SalesUp.Entity.STask", b =>
                {
                    b.HasOne("SalesUp.Entity.Identity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("SalesUp.Entity.STaskItem", b =>
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

                    b.HasOne("SalesUp.Entity.STask", "STask")
                        .WithMany("TaskItems")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SalesUp.Entity.Identity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Product");

                    b.Navigation("Role");

                    b.Navigation("STask");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SalesUp.Entity.STask", b =>
                {
                    b.Navigation("TaskItems");
                });
#pragma warning restore 612, 618
        }
    }
}
