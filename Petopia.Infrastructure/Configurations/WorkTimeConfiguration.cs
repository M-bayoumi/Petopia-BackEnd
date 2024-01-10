using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Petopia.Data.Entities;

namespace Petopia.infrastructure.Configurations
{
    public class WorkTimeConfiguration : IEntityTypeConfiguration<WorkTime>
    {
        public void Configure(EntityTypeBuilder<WorkTime> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Start)
               .HasColumnType("dateTime")
               .IsRequired();

            builder.Property(x => x.End)
              .HasColumnType("dateTime")
              .IsRequired();



            builder.ToTable("WorkTimes");

        }
    }

}
