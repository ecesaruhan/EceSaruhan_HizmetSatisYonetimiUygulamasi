using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesUp.Entity;

namespace SalesUp.Data.Concrete.Configs;

public class ProductConfig : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Id).ValueGeneratedOnAdd();
        builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
        builder.Property(p => p.Properties).IsRequired().HasMaxLength(100);

        builder.Property(p => p.Quantity).IsRequired();
        builder.Property(p => p.UnitPrice).IsRequired().HasColumnType("real");
        builder.Property(p => p.Url).IsRequired().HasMaxLength(50);
        builder.HasData(
            new Product
            {
                Id = 1,
                Name = "",
                Quantity = 100,
                Price = 105.90,
                Url="dove-sampuan"
            },
            new Product
            {
                Id = 2,
                Name = "Dove Saç Kremi",
                Quantity = 120,
                Price = 70.90,
                Url="dove-sac-kremi"
            },
            new Product
            {
                Id = 3,
                Name = "Dove Saç Maskesi",
                Quantity = 80,
                Price = 80.90,
                Url="dove-sac-maskesi"
            },
            new Product
            {
                Id = 4,
                Name = "Dove Saç Bakım Spreyi",
                Quantity = 150,
                Price = 40.90,
                Url="dove-sac-bakim-spreyi"
            },
            new Product
            {
                Id = 5,
                Name = "Dove Serum",
                Quantity = 150,
                Price = 55.90,
                Url="dove-serum"
            },
            new Product
            {
                Id = 6,
                Name = "Dove Saç Köpüğü",
                Quantity = 150,
                Price = 90.90,
                Url="dove-sac-kopugu"
            },
            new Product
            {
                Id = 7,
                Name = "Dove Sprey Deodorant",
                Quantity = 150,
                Price = 110.90,
                Url="dove-sprey-deodorant"
            },
            new Product
            {
                Id = 8,
                Name = "Dove Roll-On Deodorant",
                Quantity = 150,
                Price = 100.90,
                Url="dove-rollon-deodorant"
            },
            new Product
            {
                Id = 9,
                Name = "Dove Bar Sabun",
                Quantity = 150,
                Price = 30.90,
                Url="dove-bar-sabun"
            },
            new Product
            {
                Id = 10,
                Name = "Dove Sıvı Sabun",
                Quantity = 100,
                Price = 90.90,
                Url="dove-sıvı-sabun"
            }
        );
    }
}
