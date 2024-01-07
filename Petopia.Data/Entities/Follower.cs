namespace Petopia.Data.Entities
{
    public class Follower
    {
        public int Id { get; set; }
        public string FollowerId { get; set; } = null!;
        public virtual ApplicationUser follower { get; set; } = null!;

        public string UserId { get; set; } = null!;
        public virtual ApplicationUser User { get; set; } = null!;
    }
}