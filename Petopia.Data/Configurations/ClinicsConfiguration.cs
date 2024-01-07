using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Petopia.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petopia.Data.Configurations
{
    public class ClinicsConfiguration : IEntityTypeConfiguration<Clinics>
    {
        public void Configure(EntityTypeBuilder<Clinics> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Fees)
                .HasColumnType("decimal")
                .IsRequired();

            builder.Property(x => x.CountryId)
               .HasColumnType("int")
               .IsRequired();

            builder.Property(x => x.AreaID)
              .HasColumnType("int")
              .IsRequired();

            builder.Property(x => x.CityId)
              .HasColumnType("int")
              .IsRequired();

            builder.Property(x => x.WaitingTime)
              .HasColumnType("date")
              .IsRequired();

            builder.Property(x => x.Name)
              .HasColumnType("varchar(max)")
              .IsRequired();

            builder.Property(x => x.Phone)
              .HasColumnType("int")
              .IsRequired();

            builder.Property(x => x.Logo)
              .HasColumnType("varchar(max)")
              .IsRequired();

            builder.HasOne(x => x.User)
                .WithMany(x => x.Clinics)
                .HasForeignKey(x => x.UserId)
                .IsRequired();

            builder.ToTable("Clinics");
        }
    }
}
