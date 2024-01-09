using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Petopia.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petopia.Data.Configurations
{
    public class WishListProductsConfiguration : IEntityTypeConfiguration<WishListProducts>
    {
        public void Configure(EntityTypeBuilder<WishListProducts> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Product)
              .WithMany(x => x.WishListProducts)
              .HasForeignKey(x => x.ProductId)
              .IsRequired();

            builder.HasOne(x => x.WishList)
                   .WithMany(x => x.WishListsProducts)
                   .HasForeignKey(x => x.WishListId)
                   .IsRequired();
                
        }
    }
}
