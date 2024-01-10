using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Petopia.Data.Entities;

namespace Petopia.infrastructure.Configurations
{
    public class CoverImageConfiguration : IEntityTypeConfiguration<CoverImage>
    {
        public void Configure(EntityTypeBuilder<CoverImage> builder)
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
              .WithOne(x => x.CoverImage)
              .HasForeignKey(x => x.CoverImageId)
              .IsRequired();

            builder.HasMany(x => x.Comments)
               .WithOne(x => x.CoverImage)
               .HasForeignKey(x => x.CoverImageId)
               .IsRequired();

            builder.HasMany(x => x.Shares)
               .WithOne(x => x.CoverImage)
               .HasForeignKey(x => x.CoverImageId)
               .IsRequired();


            builder.ToTable("CoverImages");

        }
    }
}
