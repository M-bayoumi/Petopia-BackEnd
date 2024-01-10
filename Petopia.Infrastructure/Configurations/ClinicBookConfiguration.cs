using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Petopia.Data.Entities;

namespace Petopia.infrastructure.Configurations
{
    public class ClinicBookConfiguration : IEntityTypeConfiguration<ClinicBook>
    {
        public void Configure(EntityTypeBuilder<ClinicBook> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.WorkTime)
              .WithOne(x => x.ClinicBook)
              .HasForeignKey<ClinicBook>(x => x.WorkTimeId)
              .OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("ClinicBooks");

        }
    }

}
