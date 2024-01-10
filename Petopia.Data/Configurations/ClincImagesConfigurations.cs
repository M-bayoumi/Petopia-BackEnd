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
    public class ClincImagesConfigurations : IEntityTypeConfiguration<ClinicImage>
    {
        public void Configure(EntityTypeBuilder<ClinicImage> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Image)
                .HasColumnType("varchar(max)")
                .IsRequired();    

            builder.Property(x => x.ClinicId)
               .HasColumnType("int")
               .IsRequired();
    
            builder.HasOne(x => x.Clinics)
                .WithMany(x => x.ClinicImages)
                .HasForeignKey(x => x.ClinicId)
                .IsRequired();

            builder.ToTable("ClinicImages");
        }
    }
}
