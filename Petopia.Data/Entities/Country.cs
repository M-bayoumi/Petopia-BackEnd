namespace Petopia.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public virtual ICollection<City> Cities { get; set; } = new HashSet<City>();
        public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }
}
