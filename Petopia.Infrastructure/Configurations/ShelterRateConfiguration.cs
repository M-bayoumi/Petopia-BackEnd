using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Petopia.Data.Entities;

namespace Petopia.infrastructure.Configurations
{
    public class ShelterRateConfiguration : IEntityTypeConfiguration<ShelterRate>
    {
        public void Configure(EntityTypeBuilder<ShelterRate> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Rate)
              .HasColumnType("int")
              .IsRequired();

            builder.Property(x => x.Comment)
               .HasColumnType("varchar(max)")
               .IsRequired();


            builder.ToTable("ShelterRates");

        }
    }

}
