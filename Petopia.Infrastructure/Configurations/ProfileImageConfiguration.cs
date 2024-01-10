using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Petopia.Data.Entities;

namespace Petopia.infrastructure.Configurations
{
    public class ProfileImageConfiguration : IEntityTypeConfiguration<ProfileImage>
    {
        public void Configure(EntityTypeBuilder<ProfileImage> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Caption)
               .HasColumnType("varchar(max)")
               .IsRequired();

            builder.Property(x => x.Image)
               .HasColumnType("varbinary(max)")
               .IsRequired();

            builder.Property(x => x.Date)
              .HasColumnType("dateTime")
              .IsRequired();

            builder.HasMany(x => x.Reactions)
              .WithOne(x => x.ProfileImage)
              .HasForeignKey(x => x.ProfileImageId)
              .IsRequired();

            builder.HasMany(x => x.Comments)
               .WithOne(x => x.ProfileImage)
               .HasForeignKey(x => x.ProfileImageId)
               .IsRequired();

            builder.HasMany(x => x.Shares)
               .WithOne(x => x.ProfileImage)
               .HasForeignKey(x => x.ProfileImageId)
               .IsRequired();

            builder.ToTable("ProfileImages");

        }
    }
}
