﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Petopia.Data.Entities;

namespace Petopia.infrastructure.Configurations
{
    public class ReactionTypeConfiguration : IEntityTypeConfiguration<ReactionType>
    {
        public void Configure(EntityTypeBuilder<ReactionType> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Type)
              .HasColumnType("varchar(max)")
              .IsRequired();

            builder.Property(x => x.Image)
               .HasColumnType("varbinary(max)")
               .IsRequired();

            builder.HasMany(x => x.Reactions)
                .WithOne(x => x.ReactionType)
                .HasForeignKey(x => x.ReactionTypeId)
                .IsRequired();

            builder.ToTable("ReactionTypes");

        }
    }
}
