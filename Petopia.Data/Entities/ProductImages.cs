using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petopia.Data.Entities
{
    public class ProductImages
    {
        public int ProductImageId { get; set; }
        public int ProductId { get; set; }

        public byte[] Image { get; set; } = new byte[0];
        public virtual Product Product { get; set; } = null!;

       


    }
}