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
    public class CardProductsConfigruations : IEntityTypeConfiguration<CartProducts>
    {
        public void Configure(EntityTypeBuilder<CartProducts> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Cart)
                .WithMany(x => x.CartProducts)
                .HasForeignKey(x => x.CartId)
                .IsRequired();

            builder.HasOne(x => x.Product)
              .WithMany(x => x.CartProducts)
              .HasForeignKey(x => x.ProductId)
              .IsRequired();

        }
    }
}
