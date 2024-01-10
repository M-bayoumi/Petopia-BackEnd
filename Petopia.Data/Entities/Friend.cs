namespace Petopia.Data.Entities
{
    public class Friend
    {
        public int Id { get; set; }
        public string FriendId { get; set; } = string.Empty;
        public DateTime Date { get; set; } = new DateTime();
        public string ApplicationUserId { get; set; } = null!;
        public virtual ApplicationUser ApplicationUser { get; set; } = null!;

    }
}