﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Petopia.Data.Entities;

namespace Petopia.infrastructure.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
               .HasColumnType("varchar(max)")
               .IsRequired();

            builder.HasMany(x => x.Cities)
               .WithOne(x => x.Country)
               .HasForeignKey(x => x.CountryId)
               .IsRequired();

            builder.HasMany(x => x.ApplicationUsers)
               .WithOne(x => x.Country)
               .HasForeignKey(x => x.CountryId)
               .IsRequired()
               .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.Clinics)
               .WithOne(x => x.Country)
               .HasForeignKey(x => x.CountryId)
               .IsRequired()
               .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.Shelters)
               .WithOne(x => x.Country)
               .HasForeignKey(x => x.CountryId)
               .IsRequired()
               .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.Products)
              .WithOne(x => x.Country)
              .HasForeignKey(x => x.CountryId)
              .IsRequired()
              .OnDelete(DeleteBehavior.NoAction);


            builder.ToTable("Countries");

        }
    }

}
