using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Petopia.Data.Entities;

namespace Petopia.infrastructure.Configurations
{
    public class AnimalTypeConfiguration : IEntityTypeConfiguration<AnimalType>
    {
        public void Configure(EntityTypeBuilder<AnimalType> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Image)
              .HasColumnType("varbinary(max)")
              .HasMaxLength(10)
              .IsRequired();

            builder.Property(x => x.Type)
               .HasColumnType("varchar(max)")
               .IsRequired();

            builder.HasMany(x => x.ApplicationUsers)
                .WithOne(x => x.AnimalType)
                .HasForeignKey(x => x.AnimalTypeId)
                .IsRequired();

            builder.HasMany(x => x.Animals)
               .WithOne(x => x.AnimalType)
               .HasForeignKey(x => x.AnimalTypeId)
               .IsRequired();

            builder.ToTable("AnimalTypes");

        }
    }
}
