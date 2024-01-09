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
    public class AnimalImagesConfigurations : IEntityTypeConfiguration<AnimalImages>
    {
        public void Configure(EntityTypeBuilder<AnimalImages> builder)
        {
            builder.HasKey(x => x.ImageId);
            builder.HasOne(x => x.Animal)
                .WithMany(x => x.AnimalImages)
                .HasForeignKey(x => x.AnimalId)
                .IsRequired();


        }
    }
}
