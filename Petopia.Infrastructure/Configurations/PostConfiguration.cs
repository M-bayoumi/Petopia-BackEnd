using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Petopia.Data.Entities;

namespace Petopia.infrastructure.Configurations
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
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
               .WithOne(x => x.Post)
               .HasForeignKey(x => x.PostId)
               .IsRequired();

            builder.HasMany(x => x.Comments)
               .WithOne(x => x.Post)
               .HasForeignKey(x => x.PostId)
               .IsRequired();

            builder.HasMany(x => x.Shares)
               .WithOne(x => x.Post)
               .HasForeignKey(x => x.PostId)
               .IsRequired();


            builder.ToTable("Posts");

        }
    }
}
