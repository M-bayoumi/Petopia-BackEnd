namespace Petopia.Data.Entities
{
    public class Block
    {
        public int Id { get; set; }
        public string BlockedId { get; set; } = string.Empty;
        public string ApplicationUserId { get; set; } = null!;
        public virtual ApplicationUser ApplicationUser { get; set; } = null!;
    }
}