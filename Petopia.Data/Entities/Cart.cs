namespace Petopia.Data.Entities
{
    public class Cart
    {
        public int Id { get; set; }
        public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();
        public virtual ICollection<CartProduct> CartProducts { get; set; } = new HashSet<CartProduct>();

        public string ApplicationUserId { get; set; } = null!;
        public virtual ApplicationUser ApplicationUser { get; set; } = null!;

    }
}