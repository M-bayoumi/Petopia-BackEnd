using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Petopia.Data.Entities;

namespace Petopia.infrastructure.Configurations
{
    public class FollowingConfiguration : IEntityTypeConfiguration<Following>
    {
        public void Configure(EntityTypeBuilder<Following> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.FollowingId)
               .HasColumnType("varchar(max)")
               .IsRequired();

            builder.ToTable("Followings");

        }
    }

}
