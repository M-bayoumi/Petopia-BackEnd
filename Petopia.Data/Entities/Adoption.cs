namespace Petopia.Data.Entities
{
    public class Adoption
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = new DateTime();
        public int AnimalId { get; set; }
        public virtual Animal Animal { get; set; } = null!;

        public int ShelterId { get; set; }
        public virtual Shelter Shelter { get; set; } = null!;
        public string ApplicationUserId { get; set; } = null!;
        public virtual ApplicationUser ApplicationUser { get; set; } = null!;
    }
}