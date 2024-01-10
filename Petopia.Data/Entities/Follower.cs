namespace Petopia.Data.Entities
{
    public class Follower
    {
        public int Id { get; set; }
        public string FollowerId { get; set; } = string.Empty;
        public string ApplicationUserId { get; set; } = null!;
        public virtual ApplicationUser ApplicationUser { get; set; } = null!;
    }
}