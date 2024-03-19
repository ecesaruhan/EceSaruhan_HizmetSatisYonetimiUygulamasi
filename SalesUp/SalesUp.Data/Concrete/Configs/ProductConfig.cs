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
        builder.Property(p => p.Quantity).IsRequired();
        builder.Property(p => p.Price).IsRequired().HasColumnType("real");
        builder.Property(p => p.Url).IsRequired().HasMaxLength(50);
        builder.HasData(
            new Product
            {
                Id = 1,
                Name = 
            }
            )
    }
}
