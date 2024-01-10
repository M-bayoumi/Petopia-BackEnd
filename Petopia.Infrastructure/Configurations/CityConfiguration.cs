using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Petopia.Data.Entities;

namespace Petopia.infrastructure.Configurations
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
               .HasColumnType("varchar(max)")
               .IsRequired();

            builder.HasMany(x => x.Areas)
               .WithOne(x => x.City)
               .HasForeignKey(x => x.CityId)
               .IsRequired();

            builder.HasMany(x => x.ApplicationUsers)
               .WithOne(x => x.City)
               .HasForeignKey(x => x.CityId)
               .IsRequired()
               .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.Clinics)
              .WithOne(x => x.City)
              .HasForeignKey(x => x.CityId)
              .IsRequired()
              .OnDelete(DeleteBehavior.NoAction);


            builder.HasMany(x => x.Shelters)
              .WithOne(x => x.City)
              .HasForeignKey(x => x.CityId)
              .IsRequired()
              .OnDelete(DeleteBehavior.NoAction);


            builder.ToTable("Cities");
        }
    }

}
