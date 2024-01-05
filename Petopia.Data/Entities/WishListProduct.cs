namespace Petopia.Data.Entities
{
    public class WishListProduct
    {
        public int WishListId { get; set; }
        public WishList WishList { get; set; } = null!;
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
    }
}
