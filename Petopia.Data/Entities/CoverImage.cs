namespace Petopia.Data.Entities
{
    public class CoverImage
    {
        public int Id { get; set; }
        public string Caption { get; set; } = string.Empty;
        public byte[] Image { get; set; } = new byte[0];
        public DateTime Date { get; set; } = new DateTime();
        public string ApplicationUserId { get; set; } = null!;
        public virtual ApplicationUser ApplicationUser { get; set; } = null!;
        public virtual ICollection<Reaction> Reactions { get; set; } = new HashSet<Reaction>();
        public virtual ICollection<Comment> Comments { get; set; } = new HashSet<Comment>();
        public virtual ICollection<Share> Shares { get; set; } = new HashSet<Share>();
    }

}