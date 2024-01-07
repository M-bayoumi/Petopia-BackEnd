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
    public class ClinicRateConfigurations : IEntityTypeConfiguration<ClincRate>
    {
        public void Configure(EntityTypeBuilder<ClincRate> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Comment)
                .HasColumnType("varchar(max)")
                .IsRequired();

            builder.Property(x => x.Rate)
               .HasColumnType("decimal")
               .IsRequired();

            builder.Property(x => x.UserId)
               .HasColumnType("int")
               .IsRequired();

            builder.Property(x => x.ClinicId)
               .HasColumnType("int")
               .IsRequired();

            builder.HasOne(x => x.User)
                .WithMany(x => x.ClincRates)
                .HasForeignKey(x => x.UserId)
                .IsRequired();

            builder.HasOne(x => x.Clinics)
                .WithMany(x => x.ClincRates)
                .HasForeignKey(x => x.ClinicId)
                .IsRequired();

            builder.ToTable("ClincRate");
        }
    }
}
