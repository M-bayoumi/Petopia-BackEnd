using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Petopia.Data.Entities;

namespace Petopia.infrastructure.Configurations
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasMany(x => x.Products)
              .WithMany(x => x.Carts)
              .UsingEntity<CartProduct>();

            builder.HasMany(x => x.CartProducts)
              .WithOne(x => x.Cart)
              .HasForeignKey(x => x.CartId)
              .IsRequired();

            builder.ToTable("Carts");

        }
    }
}
