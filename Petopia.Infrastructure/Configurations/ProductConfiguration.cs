using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Petopia.Data.Entities;

namespace Petopia.infrastructure.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
               .HasColumnType("varchar(max)")
               .IsRequired();

            builder.Property(x => x.Description)
               .HasColumnType("varchar(max)")
               .IsRequired();

            builder.Property(x => x.Price)
               .HasColumnType("decimal")
               .IsRequired();

            builder.Property(x => x.Discount)
               .HasColumnType("decimal")
               .IsRequired();

            builder.Property(x => x.Quantity)
               .HasColumnType("int")
               .IsRequired();

            builder.Property(x => x.Views)
              .HasColumnType("int")
              .IsRequired();

            builder.HasMany(x => x.ProductImages)
              .WithOne(x => x.Product)
              .HasForeignKey(x => x.ProductId)
              .IsRequired()
              .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.ProductRates)
              .WithOne(x => x.Product)
              .HasForeignKey(x => x.ProductId)
              .IsRequired()
              .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.WishListProducts)
              .WithOne(x => x.Product)
              .HasForeignKey(x => x.ProductId)
              .IsRequired()
              .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.CartProducts)
              .WithOne(x => x.Product)
              .HasForeignKey(x => x.ProductId)
              .IsRequired()
              .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.OrderProducts)
             .WithOne(x => x.Product)
             .HasForeignKey(x => x.ProductId)
             .IsRequired()
             .OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("Products");

        }
    }
}
