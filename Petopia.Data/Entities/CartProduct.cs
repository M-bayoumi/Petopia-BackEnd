namespace Petopia.Data.Entities
{
    public class CartProduct
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; } = null!;
        public int CartId { get; set; }
        public virtual Cart Cart { get; set; } = null!;
    }
}