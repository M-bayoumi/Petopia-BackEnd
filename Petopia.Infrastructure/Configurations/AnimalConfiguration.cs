using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Petopia.Data.Entities;

namespace Petopia.infrastructure.Configurations
{
    public class AnimalConfiguration : IEntityTypeConfiguration<Animal>
    {
        public void Configure(EntityTypeBuilder<Animal> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
               .HasColumnType("varchar(max)")
               .IsRequired();

            builder.Property(x => x.Image)
             .HasColumnType("varbinary(max)")
             .IsRequired();

            builder.Property(x => x.Gender)
              .HasColumnType("int")
              .IsRequired();

            builder.Property(x => x.BirthDate)
             .HasColumnType("dateTime")
             .IsRequired();

            builder.Property(x => x.Adopted)
              .HasColumnType("bit")
              .IsRequired();

            builder.Property(x => x.Weight)
              .HasColumnType("decimal")
              .IsRequired();



            builder.ToTable("Animals");
        }
    }

}
