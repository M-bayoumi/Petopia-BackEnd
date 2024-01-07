namespace Petopia.Data.Entities
{
    public class Reaction
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public virtual Post Post { get; set; } = null!;
        public int ReactionTypeId { get; set; }
        public virtual ReactionType ReactionType { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public virtual ApplicationUser User { get; set; } = null!;
    }
}