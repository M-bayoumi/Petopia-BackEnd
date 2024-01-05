namespace Petopia.Data.Entities
{
    public class Following
    {
        public string FollowingId { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public virtual ApplicationUser User { get; set; } = null!;
    }
}
