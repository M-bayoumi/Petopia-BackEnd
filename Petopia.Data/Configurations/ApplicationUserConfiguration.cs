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

            builder.HasOne(x => x.WishList)
              .WithOne(x => x.ApplicationUser)
              .HasForeignKey<WishList>(x => x.UserId)
              .IsRequired();


            builder.HasOne(x => x.Cart)
                .WithOne(x => x.ApplicationUser)
                .HasForeignKey<Cart>(x => x.UserId)
                .IsRequired();

            builder.HasOne(x => x.Animal)
                .WithOne(x => x.ApplicationUser)
                .HasForeignKey<Animal>(x => x.UserId)
                .IsRequired();



        }
    }
}
