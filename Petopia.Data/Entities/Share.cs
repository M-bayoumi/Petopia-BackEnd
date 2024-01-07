namespace Petopia.Data.Entities
{
    public class Share
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public int PostId { get; set; }
        public virtual Post Post { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public virtual ApplicationUser User { get; set; } = null!;
    }
}