using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petopia.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double Weight { get; set; }
        public int MaterialId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
        public int Views { get; set; }
        public int UserId { get; set; }
        public int CountryId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; } = null!;
        public virtual Brand Brand { get; set; } = null!;
        public virtual Material Material { get; set; } = null!;
        public virtual Category Category { get; set; } = null!;
        public virtual ICollection<ProductImages> ProductImages { get; set; } = new HashSet<ProductImages>();
        public virtual ICollection<ProductRate> ProductRates { get; set; } = new HashSet<ProductRate>();
        public virtual ICollection<WishListProducts> WishListProducts { get; set; } = new HashSet<WishListProducts>();
        public virtual ICollection<CartProducts> CartProducts { get; set; } = new HashSet<CartProducts>();
        public virtual ICollection<OrderProducts> OrderProducts { get; set; } = new HashSet<OrderProducts>();


    }

}
