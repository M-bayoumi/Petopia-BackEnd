using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petopia.Data.Entities
{
    public class ProductRate
    {
        public int Id { get; set; }
        public string Comment { get; set; } = string.Empty;
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int Rate { get; set; }
        public virtual Product Product { get; set; } = null!;
        public virtual ApplicationUser ApplicationUser { get; set; } = null!;
       

    }
}
