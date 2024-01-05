namespace Petopia.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int AnimalId { get; set; }
        public Animal Animal { get; set; } = null!;
    }
}
