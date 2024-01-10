namespace Petopia.Data.Entities
{
    public class WishList
    {
        public int Id { get; set; }
        public string ApplicationUserId { get; set; } = null!;
        public virtual ApplicationUser ApplicationUser { get; set; } = null!;
        public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();
        public virtual ICollection<WishListProduct> WishListProducts { get; set; } = new HashSet<WishListProduct>();

    }
}