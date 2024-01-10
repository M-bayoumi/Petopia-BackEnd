using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Petopia.Data.Entities;

namespace Petopia.infrastructure.Configurations
{
    public class AdoptionConfiguration : IEntityTypeConfiguration<Adoption>
    {
        public void Configure(EntityTypeBuilder<Adoption> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Date)
             .HasColumnType("dateTime")
             .IsRequired();

            builder.HasOne(x => x.Animal)
              .WithOne(x => x.Adoption)
              .HasForeignKey<Adoption>(x => x.AnimalId);

            builder.ToTable("Adoptions");
        }
    }

}
