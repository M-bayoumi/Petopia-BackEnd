namespace Petopia.Data.Entities
{
    public class Block
    {
        public int Id { get; set; }
        public string BlockedUserId { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public virtual ApplicationUser User { get; set; } = null!;
    }
}
