namespace Petopia.Data.Entities
{
    public class ClinicRate
    {
        public int Id { get; set; }
        public string Comment { get; set; } = string.Empty;
        public int Rate { get; set; }
        public int ClinicId { get; set; }
        public Clinic Clinic { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public ApplicationUser User { get; set; } = null!;
    }
}
