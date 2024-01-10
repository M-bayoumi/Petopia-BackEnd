namespace Petopia.Data.Entities
{
    public class ProductImage
    {
        public int Id { get; set; }
        public byte[] Image { get; set; } = new byte[0];
        public int ProductId { get; set; }
        public virtual Product Product { get; set; } = null!;
    }
}