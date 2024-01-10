namespace Petopia.Data.Entities
{
    public class ShelterAnimal
    {
        public int Id { get; set; }
        public string Type { get; set; } = string.Empty;
        public byte[] Image { get; set; } = new byte[0];
        public string Name { get; set; } = string.Empty;
        public DateOnly BirthDate { get; set; }
        public string Gender { get; set; } = string.Empty;
        public string Weight { get; set; } = string.Empty;
        public string Adopted { get; set; } = string.Empty;
        public int ShelterId { get; set; }



        public Shelter shelter { get; set; } = null!;
        public virtual ICollection<Adoption> adoption { get; set; } = null!;




    }
}
