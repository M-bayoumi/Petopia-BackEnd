namespace Petopia.Data.Entities
{
    public class ShelterRate
    {
        public int Id { get; set; }
        public string Comment { get; set; } = null!;
        public string Rate { get; set; } = null!;
        public int ShelterId { get; set; }
        public string UserId { get; set; } = null!;



        public virtual ICollection<ApplicationUser> Users { get; set; } = null!;
        public Shelter shelter { get; set; } = null!;
    }
}
