namespace Petopia.Data.Entities
{
    public class Adoption
    {
        public int Id { get; set; }
        public DateOnly DateOfAdoption { get; set; }
        public string UserId { get; set; } = null!;
        public int AnimalId { get; set; }




        public virtual ApplicationUser User { get; set; } = null!;
        public ShelterAnimal shelterAnimal { get; set; } = null!;

    }
}
