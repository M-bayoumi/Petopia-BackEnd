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
    public class OrderProductsConfiguration : IEntityTypeConfiguration<OrderProducts>
    {
        public void Configure(EntityTypeBuilder<OrderProducts> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Order)
                .WithMany(x => x.OrderProducts)
                .HasForeignKey(x => x.OrderId)
                .IsRequired();

            builder.HasOne(x => x.Product)
              .WithMany(x => x.OrderProducts)
              .HasForeignKey(x => x.ProductId)
              .IsRequired();



        }
    }
}
