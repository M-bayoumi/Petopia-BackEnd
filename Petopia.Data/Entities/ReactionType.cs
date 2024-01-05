namespace Petopia.Data.Entities
{
    public class ReactionType
    {
        public int Id { get; set; }
        public string Type { get; set; } = null!;
        public virtual ICollection<Reaction> Reactions { get; set; } = new HashSet<Reaction>();

    }
}
