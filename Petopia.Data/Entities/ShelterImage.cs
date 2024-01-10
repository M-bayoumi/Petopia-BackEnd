namespace Petopia.Data.Entities
{
    public class ShelterImage
    {
        public int Id { get; set; }
        public byte[] Image { get; set; } = new byte[0];
        public int ShelterId { get; set; }

        public Shelter shelter { get; set; } = null!;
    }
}
