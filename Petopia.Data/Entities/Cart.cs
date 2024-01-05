namespace Petopia.Data.Entities
{
    public class Cart
    {
        public int Id { get; set; }
        public string UserId { get; set; } = null!;
        public ApplicationUser User { get; set; } = null!;
        public virtual ICollection<CartProduct> CartProducts { get; set; } = new HashSet<CartProduct>();
    }
}
