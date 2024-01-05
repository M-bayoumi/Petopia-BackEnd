namespace Petopia.Data.Entities
{
    public class Photo
    {
        public int Id { get; set; }
        public byte[] Image { get; set; } = new byte[0];
        public string UserId { get; set; } = null!;
        public virtual ApplicationUser User { get; set; } = null!;
    }
}
