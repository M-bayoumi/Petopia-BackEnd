using Microsoft.AspNetCore.Identity;
using Petopia.Data.Enums;

namespace Petopia.Data.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public GenderEnum Gender { get; set; }
        public DateOnly BirthDate { get; set; }
        public byte[] ProfileImage { get; set; } = new byte[0];
        public byte[] Cover { get; set; } = new byte[0];
        public bool blocked { get; set; } = false;


        public int CountryId { get; set; }
        public Country Country { get; set; } = null!;
        public int CityId { get; set; }
        public City City { get; set; } = null!;
        public int AreaId { get; set; }
        public Area Area { get; set; } = null!;
        public string Street { get; set; } = string.Empty;


        public virtual ICollection<Friend> Friends { get; set; } = new HashSet<Friend>();
        public virtual ICollection<Follower> Followers { get; set; } = new HashSet<Follower>();
        public virtual ICollection<Following> Followings { get; set; } = new HashSet<Following>();
        public virtual ICollection<Photo> Photos { get; set; } = new HashSet<Photo>();
        public virtual ICollection<Block> BlockList { get; set; } = new HashSet<Block>();
        public virtual ICollection<Post> Posts { get; set; } = new HashSet<Post>();
        public virtual ICollection<Reaction> Reactions { get; set; } = new HashSet<Reaction>();
        public virtual ICollection<Comment> Comments { get; set; } = new HashSet<Comment>();
        public virtual ICollection<Share> Shares { get; set; } = new HashSet<Share>();
        public virtual ICollection<ProductRate> ProductRates { get; set; } = new HashSet<ProductRate>();
        public virtual ICollection<WishList> WishLists { get; set; } = new HashSet<WishList>();
        public virtual ICollection<Cart> Carts { get; set; } = new HashSet<Cart>();
        public virtual ICollection<Clinic> Clinics { get; set; } = new HashSet<Clinic>();
        public virtual ICollection<ClinicRate> ClinicRates { get; set; } = new HashSet<ClinicRate>();


        public int? AnimalId { get; set; }
        public Animal? Animal { get; set; }
        public double? Weight { get; set; }
    }
    public class Clinic
    {
        public int Id { get; set; }
        public byte[] Logo { get; set; } = new byte[0];
        public string Name { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string UserId { get; set; } = null!;
        public ApplicationUser User { get; set; } = null!;
        public decimal Fees { get; set; }
        public int WaitingTime { get; set; }

        public int CountryId { get; set; }
        public Country Country { get; set; } = null!;
        public int CityId { get; set; }
        public City City { get; set; } = null!;
        public int AreaId { get; set; }
        public Area Area { get; set; } = null!;
        public string Street { get; set; } = string.Empty;
        public virtual ICollection<ClinicImage> ClinicImages { get; set; } = new HashSet<ClinicImage>();
        public virtual ICollection<ClinicRate> ClinicRates { get; set; } = new HashSet<ClinicRate>();

    }
    public class Worktime
    {
        public int Id { get; set; }
        public string Comment { get; set; } = string.Empty;
        public int Rate { get; set; }
        public int ClinicId { get; set; }
        public Clinic Clinic { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public ApplicationUser User { get; set; } = null!;
    }
}
