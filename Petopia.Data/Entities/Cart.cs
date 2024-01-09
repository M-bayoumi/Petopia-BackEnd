using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petopia.Data.Entities
{
    public class Cart
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; } = null!;
        public virtual ICollection<CartProducts> CartProducts { get; set; } = new HashSet<CartProducts>();
    }
}
