namespace Petopia.Data.Entities
{
    public class Friend
    {
        public int Id { get; set; }
        public string FriendId { get; set; } = null!;
        public virtual ApplicationUser friend { get; set; } = null!;
        public DateTime Date { get; set; } = DateTime.Now;
        public string UserId { get; set; } = null!;
        public virtual ApplicationUser User { get; set; } = null!;
    }
}