﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petopia.Data.Entities
{
    public class WishListProducts
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int WishListId { get; set; }
        public virtual Product Product { get; set; } = null!;
        public virtual WishList WishList { get; set; } = null!;
      
    }
}
