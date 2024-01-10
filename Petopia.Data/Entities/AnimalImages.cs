using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petopia.Data.Entities
{
    public class AnimalImages
    {
        public int ImageId { get; set; }
        public int AnimalId { get; set; }
        public byte[] Image { get; set; } = new byte[0];

        public virtual Animal Animal { get; set; } = null!;
    }
}
