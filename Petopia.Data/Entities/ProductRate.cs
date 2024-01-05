namespace Petopia.Data.Entities
{
    public class ProductRate
    {
        public int Id { get; set; }
        public string Comment { get; set; } = string.Empty;
        public int Rate { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public ApplicationUser User { get; set; } = null!;
    }
}
