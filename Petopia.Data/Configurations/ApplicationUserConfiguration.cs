using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Petopia.Data.Entities;

namespace Petopia.Data.Configurations
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.FirstName)
               .HasColumnType("varchar")
               .HasMaxLength(10)
               .IsRequired();

            builder.Property(x => x.LastName)
               .HasColumnType("varchar")
               .HasMaxLength(10)

               .IsRequired();
        }
    }
}
