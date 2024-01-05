namespace Petopia.Data.Entities
{
    public class ClinicImage
    {
        public int Id { get; set; }
        public byte[] Image { get; set; } = new byte[0];
        public int ClinicId { get; set; }
        public virtual Clinic Clinic { get; set; } = null!;
    }
}
