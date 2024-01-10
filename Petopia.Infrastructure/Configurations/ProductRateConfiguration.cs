using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Petopia.Data.Entities;

namespace Petopia.infrastructure.Configurations
{
    public class ProductRateConfiguration : IEntityTypeConfiguration<ProductRate>
    {
        public void Configure(EntityTypeBuilder<ProductRate> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Rate)
              .HasColumnType("int")
              .IsRequired();

            builder.Property(x => x.Comment)
               .HasColumnType("varchar(max)")
               .IsRequired();

            builder.ToTable("ProductRates");

        }
    }
}
