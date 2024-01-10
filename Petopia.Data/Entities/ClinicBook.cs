namespace Petopia.Data.Entities
{
    public class ClinicBook
    {
        public int Id { get; set; }
        public int WorkTimeId { get; set; }
        public virtual WorkTime WorkTime { get; set; } = null!;
        public string ApplicationUserId { get; set; } = null!;
        public virtual ApplicationUser ApplicationUser { get; set; } = null!;
    }
}