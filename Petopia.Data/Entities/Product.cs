namespace Petopia.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public int Quantity { get; set; }
        public int Views { get; set; }
        public string ApplicationUserId { get; set; } = null!;
        public virtual ApplicationUser ApplicationUser { get; set; } = null!;
        public virtual ICollection<ProductImage> ProductImages { get; set; } = new HashSet<ProductImage>();
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; } = null!;
        public virtual ICollection<ProductRate> ProductRates { get; set; } = new HashSet<ProductRate>();
        public virtual ICollection<WishList> WishLists { get; set; } = new HashSet<WishList>();
        public virtual ICollection<WishListProduct> WishListProducts { get; set; } = new HashSet<WishListProduct>();
        public virtual ICollection<Cart> Carts { get; set; } = new HashSet<Cart>();
        public virtual ICollection<CartProduct> CartProducts { get; set; } = new HashSet<CartProduct>();

        public virtual ICollection<Order> Orders { get; set; } = new HashSet<Order>();
        public virtual ICollection<OrderProduct> OrderProducts { get; set; } = new HashSet<OrderProduct>();

        public int CountryId { get; set; }
        public virtual Country Country { get; set; } = null!;



    }
}