using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Petopia.Data.Entities;

namespace Petopia.infrastructure.Configurations
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

            builder.Property(x => x.Street)
               .HasColumnType("varchar(max)")
               .IsRequired();

            builder.Property(x => x.Weight)
               .HasColumnType("decimal")
               .IsRequired();

            builder.Property(x => x.blocked)
               .HasColumnType("bit")
               .IsRequired();

            builder.HasMany(x => x.Blocks)
               .WithOne(x => x.ApplicationUser)
               .HasForeignKey(x => x.ApplicationUserId)
               .IsRequired();

            builder.HasMany(x => x.Friends)
               .WithOne(x => x.ApplicationUser)
               .HasForeignKey(x => x.ApplicationUserId)
               .IsRequired();

            builder.HasMany(x => x.Followers)
               .WithOne(x => x.ApplicationUser)
               .HasForeignKey(x => x.ApplicationUserId)
               .IsRequired();

            builder.HasMany(x => x.Followings)
               .WithOne(x => x.ApplicationUser)
               .HasForeignKey(x => x.ApplicationUserId)
               .IsRequired();

            builder.HasMany(x => x.Photos)
               .WithOne(x => x.ApplicationUser)
               .HasForeignKey(x => x.ApplicationUserId)
               .IsRequired();

            builder.HasMany(x => x.Posts)
               .WithOne(x => x.ApplicationUser)
               .HasForeignKey(x => x.ApplicationUserId)
               .IsRequired();

            builder.HasMany(x => x.ProfileImages)
               .WithOne(x => x.ApplicationUser)
               .HasForeignKey(x => x.ApplicationUserId)
               .IsRequired();

            builder.HasMany(x => x.CoverImages)
               .WithOne(x => x.ApplicationUser)
               .HasForeignKey(x => x.ApplicationUserId)
               .IsRequired();

            builder.HasMany(x => x.Reactions)
               .WithOne(x => x.ApplicationUser)
               .HasForeignKey(x => x.ApplicationUserId)
               .IsRequired();

            builder.HasMany(x => x.Comments)
               .WithOne(x => x.ApplicationUser)
               .HasForeignKey(x => x.ApplicationUserId)
               .IsRequired();

            builder.HasMany(x => x.Shares)
               .WithOne(x => x.ApplicationUser)
               .HasForeignKey(x => x.ApplicationUserId)
               .IsRequired();

            builder.HasMany(x => x.Clinics)
               .WithOne(x => x.ApplicationUser)
               .HasForeignKey(x => x.ApplicationUserId)
               .IsRequired();

            builder.HasMany(x => x.ClinicRates)
              .WithOne(x => x.ApplicationUser)
              .HasForeignKey(x => x.ApplicationUserId)
              .IsRequired();

            builder.HasMany(x => x.ClinicBooks)
              .WithOne(x => x.ApplicationUser)
              .HasForeignKey(x => x.ApplicationUserId)
              .IsRequired();

            builder.HasMany(x => x.Shelters)
              .WithOne(x => x.ApplicationUser)
              .HasForeignKey(x => x.ApplicationUserId)
              .IsRequired();

            builder.HasMany(x => x.Adoptions)
              .WithOne(x => x.ApplicationUser)
              .HasForeignKey(x => x.ApplicationUserId)
              .IsRequired();

            builder.HasMany(x => x.ShelterRates)
              .WithOne(x => x.ApplicationUser)
              .HasForeignKey(x => x.ApplicationUserId)
              .IsRequired();

            builder.HasMany(x => x.Products)
              .WithOne(x => x.ApplicationUser)
              .HasForeignKey(x => x.ApplicationUserId)
              .IsRequired();

            builder.HasMany(x => x.ProductRates)
              .WithOne(x => x.ApplicationUser)
              .HasForeignKey(x => x.ApplicationUserId)
              .IsRequired();

            builder.HasOne(x => x.Cart)
              .WithOne(x => x.ApplicationUser)
              .HasForeignKey<Cart>(x => x.ApplicationUserId);

            builder.HasOne(x => x.WishList)
              .WithOne(x => x.ApplicationUser)
              .HasForeignKey<WishList>(x => x.ApplicationUserId);

            builder.HasMany(x => x.Orders)
              .WithOne(x => x.ApplicationUser)
              .HasForeignKey(x => x.ApplicationUserId)
              .IsRequired();

            builder.ToTable("ApplicationUsers");

        }
    }
}
