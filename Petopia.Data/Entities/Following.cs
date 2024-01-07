namespace Petopia.Data.Entities
{
    public class Following
    {
        public int Id { get; set; }
        public string FollowingId { get; set; } = null!;
        public virtual ApplicationUser following { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public virtual ApplicationUser User { get; set; } = null!;
    }
}