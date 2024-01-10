using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Petopia.Data.Entities;

namespace Petopia.infrastructure.Configurations
{
    public class WishListConfiguration : IEntityTypeConfiguration<WishList>
    {
        public void Configure(EntityTypeBuilder<WishList> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasMany(x => x.Products)
              .WithMany(x => x.WishLists)
              .UsingEntity<WishListProduct>();

            builder.HasMany(x => x.WishListProducts)
              .WithOne(x => x.WishList)
              .HasForeignKey(x => x.WishListId)
              .IsRequired();

            builder.ToTable("WishLists");

        }
    }
}
