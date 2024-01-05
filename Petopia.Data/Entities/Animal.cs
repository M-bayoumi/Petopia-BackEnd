namespace Petopia.Data.Entities
{
    public class Animal
    {
        public int Id { get; set; }
        public string Type { get; set; } = string.Empty;
        public byte[] Photo { get; set; } = new byte[0];
        public virtual ICollection<Category> Categories { get; set; } = new HashSet<Category>();
        public ApplicationUser? User { get; set; }
    }
}
