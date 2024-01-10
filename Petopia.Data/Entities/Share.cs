namespace Petopia.Data.Entities
{
    public class Share
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = new DateTime();
        public string ApplicationUserId { get; set; } = null!;
        public virtual ApplicationUser ApplicationUser { get; set; } = null!;
        public int PostId { get; set; }
        public virtual Post Post { get; set; } = null!;
        public int PhotoId { get; set; }
        public virtual Photo Photo { get; set; } = null!;
        public int ProfileImageId { get; set; }
        public virtual ProfileImage ProfileImage { get; set; } = null!;
        public int CoverImageId { get; set; }
        public virtual CoverImage CoverImage { get; set; } = null!;
    }

}