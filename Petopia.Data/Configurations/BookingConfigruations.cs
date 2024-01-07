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
    public class BookingConfigruations : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.UserId)
               .HasColumnType("int")
               .IsRequired();

            builder.Property(x => x.WorktimeId)
               .HasColumnType("int")
               .IsRequired();

            builder.HasOne(x => x.User)
                .WithMany(x => x.Bookings)
                .HasForeignKey(x => x.UserId)
                .IsRequired();



            builder.ToTable("Booking");
        }
    }
}
