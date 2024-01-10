using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Petopia.Data.Entities;

namespace Petopia.infrastructure.Configurations
{
    public class WishListProductConfiguration : IEntityTypeConfiguration<WishListProduct>
    {
        public void Configure(EntityTypeBuilder<WishListProduct> builder)
        {
            builder.HasKey(x => x.Id);

            builder.ToTable("WishListProducts");

        }
    }
}
