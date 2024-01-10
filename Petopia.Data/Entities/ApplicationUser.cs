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
        public string Street { get; set; } = string.Empty;
        public bool blocked { get; set; } = false;
        public decimal Weight { get; set; }

        public int AnimalTypeId { get; set; }
        public virtual AnimalType AnimalType { get; set; } = null!;
        public int CountryId { get; set; }
        public virtual Country Country { get; set; } = null!;
        public int CityId { get; set; }
        public virtual City City { get; set; } = null!;
        public int AreaId { get; set; }
        public virtual Area Area { get; set; } = null!;

        public virtual ICollection<Block> Blocks { get; set; } = new HashSet<Block>();
        public virtual ICollection<Friend> Friends { get; set; } = new HashSet<Friend>();
        public virtual ICollection<Follower> Followers { get; set; } = new HashSet<Follower>();
        public virtual ICollection<Following> Followings { get; set; } = new HashSet<Following>();
        public virtual ICollection<Photo> Photos { get; set; } = new HashSet<Photo>();
        public virtual ICollection<Post> Posts { get; set; } = new HashSet<Post>();
        public virtual ICollection<ProfileImage> ProfileImages { get; set; } = new HashSet<ProfileImage>();
        public virtual ICollection<CoverImage> CoverImages { get; set; } = new HashSet<CoverImage>();
        public virtual ICollection<Reaction> Reactions { get; set; } = new HashSet<Reaction>();
        public virtual ICollection<Comment> Comments { get; set; } = new HashSet<Comment>();
        public virtual ICollection<Share> Shares { get; set; } = new HashSet<Share>();

        public virtual ICollection<Clinic> Clinics { get; set; } = new HashSet<Clinic>();
        public virtual ICollection<ClinicBook> ClinicBooks { get; set; } = new HashSet<ClinicBook>();
        public virtual ICollection<ClinicRate> ClinicRates { get; set; } = new HashSet<ClinicRate>();

        public virtual ICollection<Shelter> Shelters { get; set; } = new HashSet<Shelter>();
        public virtual ICollection<Adoption> Adoptions { get; set; } = new HashSet<Adoption>();
        public virtual ICollection<ShelterRate> ShelterRates { get; set; } = new HashSet<ShelterRate>();

        public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();
        public virtual ICollection<ProductRate> ProductRates { get; set; } = new HashSet<ProductRate>();
        public virtual WishList WishList { get; set; } = null!;
        public virtual Cart Cart { get; set; } = null!;
        public virtual ICollection<Order> Orders { get; set; } = new HashSet<Order>();


    }
}