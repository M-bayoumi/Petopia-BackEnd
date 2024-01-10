using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Petopia.Data.Entities;

namespace Petopia.infrastructure.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.TotalPrice)
               .HasColumnType("decimal")
               .IsRequired();

            builder.HasMany(x => x.Products)
              .WithMany(x => x.Orders)
              .UsingEntity<OrderProduct>();

            builder.HasMany(x => x.OrderProducts)
              .WithOne(x => x.Order)
              .HasForeignKey(x => x.OrderId)
              .IsRequired();

            builder.ToTable("Orders");

        }
    }
}
