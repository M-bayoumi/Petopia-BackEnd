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
    public class ProductRateConfiguration : IEntityTypeConfiguration<ProductRate>
    {
        public void Configure(EntityTypeBuilder<ProductRate> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Comment)
                  .HasColumnType("varchar(max)")
                .IsRequired();
            builder.HasOne(x => x.Product)
              .WithMany(x => x.ProductRates)
              .HasForeignKey(x => x.ProductId)
              .IsRequired();
            builder.HasOne(x => x.ApplicationUser)
           .WithMany(x => x.ProductRates)
           .HasForeignKey(x => x.UserId)
           .IsRequired();
        }
    }
}
