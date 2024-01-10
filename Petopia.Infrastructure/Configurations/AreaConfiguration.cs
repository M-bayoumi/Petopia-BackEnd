using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Petopia.Data.Entities;

namespace Petopia.infrastructure.Configurations
{
    public class AreaConfiguration : IEntityTypeConfiguration<Area>
    {
        public void Configure(EntityTypeBuilder<Area> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
               .HasColumnType("varchar(max)")
               .IsRequired();

            builder.HasMany(x => x.ApplicationUsers)
               .WithOne(x => x.Area)
               .HasForeignKey(x => x.AreaId)
               .IsRequired()
               .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.Clinics)
              .WithOne(x => x.Area)
              .HasForeignKey(x => x.AreaId)
              .IsRequired()
              .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.Shelters)
             .WithOne(x => x.Area)
             .HasForeignKey(x => x.AreaId)
             .IsRequired()
             .OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("Areas");
        }
    }

}
