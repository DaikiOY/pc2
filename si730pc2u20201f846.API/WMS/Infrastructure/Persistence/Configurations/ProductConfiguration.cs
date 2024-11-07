using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using si730pc2u20201f846.Domain.Entities;

namespace si730pc2u20201f846.Infrastructure.Persistence.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ProductId); 

            builder.Property(p => p.ProductName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p => p.Sku)
                .IsRequired()
                .HasMaxLength(50); 
            builder.HasIndex(p => p.Sku).IsUnique();
            builder.Property(p => p.Quantity)
                .HasDefaultValue(0);

            builder.Property(p => p.CreatedAt)
                .IsRequired()
                .HasDefaultValueSql("CURRENT_TIMESTAMP"); 
        }
    }
}
