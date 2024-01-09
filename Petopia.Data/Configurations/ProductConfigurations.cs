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
    public class ProductConfigurations : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);


            builder.HasOne(x => x.Category)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.CategoryId)
                .IsRequired();

            builder.HasOne(x => x.Brand)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.BrandId)
                .IsRequired();


            builder.HasOne(x => x.Material)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.MaterialId)
                .IsRequired();

            builder.HasOne(x => x.ApplicationUser)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.UserId)
                .IsRequired();









        }
    }
}

