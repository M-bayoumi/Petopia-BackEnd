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
               .HasColumnType("varchar(max)")
               .IsRequired();

            builder.Property(x => x.LastName)
               .HasColumnType("varchar(max)")
               .IsRequired();

            builder.Property(x => x.BirthDate)
              .HasColumnType("dateTime")
              .IsRequired();

            builder.Property(x => x.Gender)
               .HasColumnType("int")
               .IsRequired();

            builder.Property(x => x.blocked)
              .HasColumnType("bit")
              .IsRequired();

            builder.Property(x => x.Street)
               .HasColumnType("varchar(max)")
               .IsRequired();
        }
    }
    public class AreaConfiguration : IEntityTypeConfiguration<Area>
    {
        public void Configure(EntityTypeBuilder<Area> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
               .HasColumnType("varchar(max)")
               .IsRequired();
        }
    }
    public class BlockConfiguration : IEntityTypeConfiguration<Block>
    {
        public void Configure(EntityTypeBuilder<Block> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.BlockedUserId)
               .HasColumnType("varchar(max)")
               .IsRequired();

            builder.Property(x => x.Date)
              .HasColumnType("dateTime")
              .IsRequired();
        }
    }
}
