using Microsoft.AspNetCore.Identity;
using Petopia.Data.Enums;

namespace Petopia.Data.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; } = new DateTime();
        public GenderEnum Gender { get; set; }
        public bool blocked { get; set; } = false;

        public int CountryId { get; set; }
        public Country Country { get; set; } = null!;
        public int CityId { get; set; }
        public City City { get; set; } = null!;
        public int AreaId { get; set; }
        public Area Area { get; set; } = null!;
        public string Street { get; set; } = string.Empty;

        public virtual ICollection<ProfileImage> ProfileImages { get; set; } = new HashSet<ProfileImage>();
        public virtual ICollection<CoverImage> CoverImages { get; set; } = new HashSet<CoverImage>();
        public virtual ICollection<Friend> Friends { get; set; } = new HashSet<Friend>();
        public virtual ICollection<Follower> Followers { get; set; } = new HashSet<Follower>();
        public virtual ICollection<Following> Followings { get; set; } = new HashSet<Following>();
        public virtual ICollection<Block> BlockList { get; set; } = new HashSet<Block>();
        public virtual ICollection<Post> Posts { get; set; } = new HashSet<Post>();
        public virtual ICollection<Reaction> Reactions { get; set; } = new HashSet<Reaction>();
        public virtual ICollection<Comment> Comments { get; set; } = new HashSet<Comment>();
        public virtual ICollection<Share> Shares { get; set; } = new HashSet<Share>();
        public virtual ICollection<Photo> Photos { get; set; } = new HashSet<Photo>();
        public virtual ICollection<Clinic> Clinics { get; set; } = new List<Clinic>();
        public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
        public virtual ICollection<ClincRate> ClincRates { get; set; } = new List<ClincRate>();

    }
}