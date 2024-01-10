namespace Petopia.Data.Entities
{
    public class ProductRate
    {
        public int Id { get; set; }
        public int Rate { get; set; }
        public string Comment { get; set; } = string.Empty;
        public int ProductId { get; set; }
        public virtual Product Product { get; set; } = null!;
        public string ApplicationUserId { get; set; } = null!;
        public virtual ApplicationUser ApplicationUser { get; set; } = null!;

    }
}