using Petopia.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petopia.Data.Entities
{
    public class Animal
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public int CategoryId { get; set; }



        public virtual ICollection<AnimalImages> AnimalImages { get; set; } = new HashSet<AnimalImages>();
        public virtual ApplicationUser ApplicationUser { get; set; } = null!;
        public virtual Category Category { get; set; } = null!;


    }
}
