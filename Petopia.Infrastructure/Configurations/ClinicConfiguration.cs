using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Petopia.Data.Entities;

namespace Petopia.infrastructure.Configurations
{
    public class ClinicConfiguration : IEntityTypeConfiguration<Clinic>
    {
        public void Configure(EntityTypeBuilder<Clinic> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
               .HasColumnType("varchar(max)")
               .IsRequired();

            builder.Property(x => x.Phone)
               .HasColumnType("varchar(max)")
               .IsRequired();

            builder.Property(x => x.Logo)
               .HasColumnType("varbinary(max)")
               .IsRequired();

            builder.Property(x => x.Fees)
               .HasColumnType("decimal")
               .IsRequired();

            builder.Property(x => x.WaitingTime)
               .HasColumnType("int")
               .IsRequired();

            builder.Property(x => x.Street)
              .HasColumnType("varchar(max)")
              .IsRequired();

            builder.HasMany(x => x.ClinicRates)
              .WithOne(x => x.Clinic)
              .HasForeignKey(x => x.ClinicId)
              .IsRequired();

            builder.HasMany(x => x.WorkTimes)
              .WithOne(x => x.Clinic)
              .HasForeignKey(x => x.ClinicId)
              .IsRequired();

            builder.ToTable("Clinics");

        }
    }

}
