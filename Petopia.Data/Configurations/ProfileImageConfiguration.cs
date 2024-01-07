﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Petopia.Data.Entities;

namespace Petopia.Data.Configurations
{
    public class ProfileImageConfiguration : IEntityTypeConfiguration<ProfileImage>
    {
        public void Configure(EntityTypeBuilder<ProfileImage> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Caption)
               .HasColumnType("varchar(max)")
               .IsRequired();

            builder.Property(x => x.Media)
               .HasColumnType("varbinary(max)")
               .IsRequired();

            builder.Property(x => x.Date)
              .HasColumnType("dateTime")
              .IsRequired();
        }
    }
}