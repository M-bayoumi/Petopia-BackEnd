namespace Petopia.Data.Entities
{
    public class WorkTime
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int ClinicId { get; set; }
        public virtual Clinic Clinic { get; set; } = null!;
        public virtual ClinicBook? ClinicBook { get; set; }
    }
}