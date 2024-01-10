using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petopia.Data.Entities
{
    public class Brand
    {
        public int Id { set; get; }
        public string Name { set; get; }=string.Empty;


        public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }
}
