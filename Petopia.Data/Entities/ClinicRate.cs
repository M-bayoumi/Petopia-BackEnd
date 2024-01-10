namespace Petopia.Data.Entities
{
    public class ClinicRate
    {
        public int Id { get; set; }
        public int Rate { get; set; }
        public string Comment { get; set; } = string.Empty;
        public int ClinicId { get; set; }
        public virtual Clinic Clinic { get; set; } = null!;
        public string ApplicationUserId { get; set; } = null!;
        public virtual ApplicationUser ApplicationUser { get; set; } = null!;
    }
}