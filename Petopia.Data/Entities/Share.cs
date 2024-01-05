namespace Petopia.Data.Entities
{
    public class Share
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string UserId { get; set; } = null!;
        public virtual ApplicationUser User { get; set; } = null!;
    }
}
