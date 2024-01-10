namespace Petopia.Data.Entities
{
    public class Area
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int CityId { get; set; }
        public virtual City City { get; set; } = null!;
        public virtual ICollection<ApplicationUser> ApplicationUsers { get; set; } = new HashSet<ApplicationUser>();
        public virtual ICollection<Clinic> Clinics { get; set; } = new HashSet<Clinic>();
        public virtual ICollection<Shelter> Shelters { get; set; } = new HashSet<Shelter>();


    }

}