namespace Petopia.Data.Entities
{
    public class ClinicImage
    {
        public int Id { get; set; }

        public string Image { get; set; }

        public int ClinicId { get; set; }

        public Clinic Clinics { get; set; } = null!;

    }
}
