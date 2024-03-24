using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesUp.Entity;

namespace SalesUp.Data.Concrete.Configs;

public class CustomerConfig : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id).ValueGeneratedOnAdd();
        builder.Property(c => c.Name).IsRequired().HasMaxLength(20);
        builder.Property(c => c.PhoneNumber).IsRequired().HasMaxLength(20);
        builder.Property(c => c.Address).IsRequired().HasMaxLength(20);

        /*builder.HasData(
            new Customer
            {
                Id = 1,
                Name = "Gratis",
                Url = "gratis"
            },
            new Customer
            {
                Id = 2,
                Name = "Watsons",
                Url = "watsons"
            },
            new Customer
            {
                Id = 3,
                Name = "Rossmann",
                Url = "rossmann"
            },
            new Customer
            {
                Id = 4,
                Name = "BeBeauty",
                Url = "bebeauty"
            },
            new Customer
            {
                Id = 5,
                Name = "DM",
                Url = "dm"
            },
            new Customer
            {
                Id = 6,
                Name = "Müller",
                Url = "muller"
            },
            new Customer
            {
                Id = 7,
                Name = "Penny",
                Url = "penny"
            },
            new Customer
            {
                Id = 8,
                Name = "Carrefour",
                Url = "carrefour"
            },
            new Customer
            {
                Id = 9,
                Name = "Migros",
                Url = "migros"
            },
            new Customer
            {
                Id = 10,
                Name = "Macrocenter",
                Url = "macrocenter"
            }
        );*/
    }
}
