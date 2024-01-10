namespace Petopia.Data.Entities
{
    public class WishListProduct
    {
        public int Id { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; } = null!;
        public int WishListId { get; set; }
        public virtual WishList WishList { get; set; } = null!;

    }
}