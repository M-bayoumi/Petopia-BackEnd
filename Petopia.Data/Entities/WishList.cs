namespace Petopia.Data.Entities
{
    public class WishList
    {
        public int Id { get; set; }
        public string UserId { get; set; } = null!;
        public ApplicationUser User { get; set; } = null!;
        public virtual ICollection<WishListProduct> WishListProducts { get; set; } = new HashSet<WishListProduct>();
    }
}
