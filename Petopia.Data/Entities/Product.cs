namespace Petopia.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; } = null!;
        public virtual ICollection<ProductImage> ProductImages { get; set; } = new HashSet<ProductImage>();
        public virtual ICollection<ProductRate> ProductRates { get; set; } = new HashSet<ProductRate>();
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
        public int BrandId { get; set; }
        public Brand Brand { get; set; } = null!;
        public decimal Weight { get; set; }
        public int MaterialId { get; set; }
        public Material Material { get; set; } = null!;
        public int AvaQuantity { get; set; }
        public string UserId { get; set; } = null!;
        public ApplicationUser User { get; set; } = null!;
        public int Views { get; set; }
        public virtual ICollection<WishListProduct> WishListProducts { get; set; } = new HashSet<WishListProduct>();
        public virtual ICollection<CartProduct> CartProducts { get; set; } = new HashSet<CartProduct>();

    }
}
