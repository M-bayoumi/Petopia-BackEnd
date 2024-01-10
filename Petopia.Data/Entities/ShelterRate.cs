namespace Petopia.Data.Entities
{
    public class ShelterRate
    {
        public int Id { get; set; }
        public int Rate { get; set; }
        public string Comment { get; set; } = string.Empty;
        public int ShelterId { get; set; }
        public virtual Shelter Shelter { get; set; } = null!;
        public string ApplicationUserId { get; set; } = null!;
        public virtual ApplicationUser ApplicationUser { get; set; } = null!;
    }
}