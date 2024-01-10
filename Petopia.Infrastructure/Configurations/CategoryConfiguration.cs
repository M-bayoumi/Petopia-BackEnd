using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Petopia.Data.Entities;

namespace Petopia.infrastructure.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
               .HasColumnType("varchar(max)")
               .IsRequired();

            builder.Property(x => x.Image)
              .HasColumnType("varbinary(max)")
              .IsRequired();

            builder.HasMany(x => x.Products)
              .WithOne(x => x.Category)
              .HasForeignKey(x => x.CategoryId)
              .IsRequired();

            builder.ToTable("Categories");

        }
    }
}
