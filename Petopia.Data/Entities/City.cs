namespace Petopia.Data.Entities
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public int CountryId { get; set; }
        public virtual Country Country { get; set; } = null!;
        public virtual ICollection<Area> Areas { get; set; } = new HashSet<Area>();
        public virtual ICollection<ApplicationUser> ApplicationUsers { get; set; } = new HashSet<ApplicationUser>();
        public virtual ICollection<Clinic> Clinics { get; set; } = new HashSet<Clinic>();
        public virtual ICollection<Shelter> Shelters { get; set; } = new HashSet<Shelter>();





    }

}