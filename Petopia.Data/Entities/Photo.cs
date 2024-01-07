namespace Petopia.Data.Entities
{
    public class Photo
    {
        public int Id { get; set; }
        public string Caption { get; set; } = null!;
        public byte[] Media { get; set; } = new byte[0];
        public DateTime Date { get; set; } = DateTime.Now;
        public string UserId { get; set; } = null!;
        public virtual ApplicationUser User { get; set; } = null!;
        public virtual ICollection<Reaction> Reactions { get; set; } = new HashSet<Reaction>();
        public virtual ICollection<Comment> Comments { get; set; } = new HashSet<Comment>();
        public virtual ICollection<Share> Shares { get; set; } = new HashSet<Share>();
    }
}