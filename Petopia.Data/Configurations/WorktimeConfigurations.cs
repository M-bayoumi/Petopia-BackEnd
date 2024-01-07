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
    public class WorktimeConfigurations : IEntityTypeConfiguration<Worktime>
    {
        public void Configure(EntityTypeBuilder<Worktime> builder)
        {
            builder.HasKey(x => x.Id);

            

            builder.Property(x => x.ClincId)
               .HasColumnType("int")
               .IsRequired();

            builder.Property(x => x.Day)
                .HasColumnType("varchar(max)")
                .IsRequired();

            builder.Property(x => x.Start)
                .HasColumnType("date")
                .IsRequired();

            builder.Property(x => x.End)
              .HasColumnType("date")
              .IsRequired();

            builder.HasOne(x => x.Clinics)
                .WithMany(x => x.Worktimes)
                .HasForeignKey(x => x.ClincId)
                .IsRequired();

            builder.ToTable("Worktime");
        }
    }
}
