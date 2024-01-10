using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Petopia.Data.Entities;

namespace Petopia.infrastructure.Configurations
{
    public class ShelterConfiguration : IEntityTypeConfiguration<Shelter>
    {
        public void Configure(EntityTypeBuilder<Shelter> builder)
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

            builder.Property(x => x.OpenTime)
              .HasColumnType("dateTime")
              .IsRequired();

            builder.Property(x => x.CloseTime)
             .HasColumnType("dateTime")
             .IsRequired();

            builder.Property(x => x.Street)
              .HasColumnType("varchar(max)")
              .IsRequired();

            builder.HasMany(x => x.Animals)
               .WithOne(x => x.Shelter)
               .HasForeignKey(x => x.ShelterId)
               .IsRequired();

            builder.HasMany(x => x.Adoptions)
              .WithOne(x => x.Shelter)
              .HasForeignKey(x => x.ShelterId)
              .IsRequired();

            builder.HasMany(x => x.ShelterRates)
              .WithOne(x => x.Shelter)
              .HasForeignKey(x => x.ShelterId)
              .IsRequired();


            builder.ToTable("Shelters");
        }
    }

}
