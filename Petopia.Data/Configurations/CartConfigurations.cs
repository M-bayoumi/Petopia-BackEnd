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
    public class CartConfigurations : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.HasKey(x => x.Id);  


        }
    }
}
