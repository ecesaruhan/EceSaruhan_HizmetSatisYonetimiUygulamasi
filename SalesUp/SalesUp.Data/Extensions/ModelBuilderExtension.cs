using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SalesUp.Entity.Identity;

namespace SalesUp.Data.Extensions;

public static class ModelBuilderExtension
{
    public static void SeedData(this ModelBuilder modelBuilder)
    {
        #region Rol Bilgileri

        var roles = new List<Role>
        {
            new Role
            {
                Name = "Admin",
                Description = "Satış Uzmanı haklarını taşıyan rol.",
                NormalizedName = "ADMIN"
            },
            new Role
            {
                Name = "Employee",
                Description = "Satış Temsilcisi haklarını taşıyan rol.",
                NormalizedName = "EMPLOYEE"
            },
            new Role
            {
                Name = "Assistant",
                Description = "Satış Temsilcisi Yardımcısı haklarını taşıyan rol.",
                NormalizedName = "ASSISTANT"
            }
        };
        modelBuilder.Entity<Role>().HasData(roles);

        #endregion

        #region Kullanıcı Bilgileri

        var users = new List<User>
        {
            new User
            {
                FirstName = "Derya",
                LastName = "Demir",
                UserName = "deryademir",
                NormalizedUserName = "DERYADEMIR",
                Email = "deryademir@gmail.com",
                NormalizedEmail = "DERYADEMIR@GMAIL.COM",
                Gender = "Kadın",
                DateofBirth = new DateTime(1992, 7, 10),
                Address = "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy",
                City = "İstanbul",
                PhoneNumber = "5547659843",
                EmailConfirmed = true
            },
            new User
            {
                FirstName = "Kadir",
                LastName = "Devran",
                UserName = "kadirdevran",
                NormalizedUserName = "KADIRDEVRAN",
                Email = "kadirdevran@gmail.com",
                NormalizedEmail = "KADIRDEVRAN@GMAIL.COM",
                Gender = "Erkek",
                DateofBirth = new DateTime(1990, 3, 16),
                Address = "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy",
                City = "İstanbul",
                PhoneNumber = "5341459340",
                EmailConfirmed = true
            },
            new User
            {
                FirstName = "Ferda",
                LastName = "Bayar",
                UserName = "ferdabayar",
                NormalizedUserName = "FERDABAYAR",
                Email = "ferdabayar@gmail.com",
                NormalizedEmail = "FERDABAYAR@GMAIL.COM",
                Gender = "Erkek",
                DateofBirth = new DateTime(1983, 4, 15),
                Address = "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy",
                City = "İstanbul",
                PhoneNumber = "5053211815",
                EmailConfirmed = true
            },
            new User
            {
                FirstName = "Nilüfer",
                LastName = "Özdemir",
                UserName = "niluferozdemir",
                NormalizedUserName = "NILUFEROZDEMIR",
                Email = "niluferozdemir@gmail.com",
                NormalizedEmail = "NILUFEROZDEMIR@GMAIL.COM",
                Gender = "Kadın",
                DateofBirth = new DateTime(1970, 9, 13),
                Address = "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy",
                City = "İstanbul",
                PhoneNumber = "5383458090",
                EmailConfirmed = true
            },
            new User
            {
                FirstName = "Can",
                LastName = "Yener",
                UserName = "canyener",
                NormalizedUserName = "CANYENER",
                Email = "canyener@gmail.com",
                NormalizedEmail = "CANYENER@GMAIL.COM",
                Gender = "Erkek",
                DateofBirth = new DateTime(1989, 3, 3),
                Address = "TaşMektep Caddesi Ömerpaşa Sokak No:3 D:12 Kadıköy",
                City = "İstanbul",
                PhoneNumber = "5350931264",
                EmailConfirmed = true
            }
        };
        modelBuilder.Entity<User>().HasData(users);

        #endregion

        #region Şifre İşlemleri

        var passwordHasher = new PasswordHasher<User>();
        users[0].PasswordHash = passwordHasher.HashPassword(users[0], "Evet123.");
        users[1].PasswordHash = passwordHasher.HashPassword(users[1], "Evet123.");
        users[2].PasswordHash = passwordHasher.HashPassword(users[2], "Evet123.");
        users[3].PasswordHash = passwordHasher.HashPassword(users[3], "Evet123.");
        users[4].PasswordHash = passwordHasher.HashPassword(users[4], "Evet123.");
        #endregion

        #region Rol Atama İşlemleri

        List<IdentityUserRole<string>> userRoles = new List<IdentityUserRole<string>>
        {
            new IdentityUserRole<string>
            {
                UserId = users[0].Id,
                RoleId = roles[2].Id
            },
            new IdentityUserRole<string>
            {
                UserId = users[1].Id,
                RoleId = roles[1].Id
            },
            new IdentityUserRole<string>
            {
                UserId = users[2].Id,
                RoleId = roles[0].Id
            },
            new IdentityUserRole<string>
            {
                UserId = users[3].Id,
                RoleId = roles[0].Id
            },
            new IdentityUserRole<string>
            {
                UserId = users[4].Id,
                RoleId = roles[1].Id
            },
        };
        modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);

        #endregion

        #region Görev İşlemleri

        List<Entity.Task> tasks = new List<Entity.Task>
        {
            new Entity.Task { Id = 1, UserId = users[0].Id },
            new Entity.Task { Id = 2, UserId = users[1].Id },
            new Entity.Task { Id = 3, UserId = users[2].Id },
            new Entity.Task { Id = 4, UserId = users[3].Id },
            new Entity.Task { Id = 5, UserId = users[4].Id },
        };
        modelBuilder.Entity<Entity.Task>().HasData(tasks);

        #endregion
    }
}