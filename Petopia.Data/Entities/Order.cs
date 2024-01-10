using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Petopia.Data.Entities
{
    public class Order
    {
        public int Id { get; set; } 
        public double TotalPrice { get; set; }

        public int UserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; } = null!;
        public virtual ICollection<OrderProducts> OrderProducts { get; set; } = new HashSet<OrderProducts>();

    }
}