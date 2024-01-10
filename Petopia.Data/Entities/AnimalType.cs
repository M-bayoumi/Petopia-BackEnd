namespace Petopia.Data.Entities
{
    public class AnimalType
    {
        public int Id { get; set; }
        public byte[] Image { get; set; } = new byte[0];
        public string Type { get; set; } = string.Empty;
        public virtual ICollection<ApplicationUser> ApplicationUsers { get; set; } = new HashSet<ApplicationUser>();
        public virtual ICollection<Animal> Animals { get; set; } = new HashSet<Animal>();

    }
}