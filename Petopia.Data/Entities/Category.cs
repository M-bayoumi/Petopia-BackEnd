using Petopia.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petopia.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int AnimalId { get; set; }


        public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();
        public virtual ICollection<Animal> Animals { get; set; } = new HashSet<Animal>();


    }
}
