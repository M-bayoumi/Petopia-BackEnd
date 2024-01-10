using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Petopia.Data.Entities;

namespace Petopia.infrastructure.Configurations
{
    public class FollowerConfiguration : IEntityTypeConfiguration<Follower>
    {
        public void Configure(EntityTypeBuilder<Follower> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.FollowerId)
               .HasColumnType("varchar(max)")
               .IsRequired();

            builder.ToTable("Followers");

        }
    }

}
