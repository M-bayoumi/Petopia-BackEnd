namespace Petopia.Data.Entities
{
    public class ReactionType
    {
        public int Id { get; set; }
        public string Type { get; set; } = string.Empty;
        public byte[] Image { get; set; } = new byte[0];
        public virtual ICollection<Reaction> Reactions { get; set; } = new HashSet<Reaction>();

    }

}