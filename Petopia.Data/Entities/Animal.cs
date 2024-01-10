using Petopia.Data.Enums;

namespace Petopia.Data.Entities
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public byte[] Image { get; set; } = new byte[0];
        public GenderEnum Gender { get; set; }
        public DateTime BirthDate { get; set; } = new DateTime();
        public bool Adopted { get; set; } = false;
        public decimal Weight { get; set; }
        public int ShelterId { get; set; }
        public virtual Shelter Shelter { get; set; } = null!;

        public int AnimalTypeId { get; set; }
        public virtual AnimalType AnimalType { get; set; } = null!;

        public virtual Adoption? Adoption { get; set; }
    }
}