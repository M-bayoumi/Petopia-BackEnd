namespace Petopia.Data.Entities
{
    public class Following
    {
        public int Id { get; set; }
        public string FollowingId { get; set; } = string.Empty;
        public string ApplicationUserId { get; set; } = null!;
        public virtual ApplicationUser ApplicationUser { get; set; } = null!;
    }
}