namespace Petopia.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public byte[] Image { get; set; } = new byte[0];
        public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();

    }
}