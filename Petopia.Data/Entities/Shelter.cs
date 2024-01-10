namespace Petopia.Data.Entities
{
    public class Shelter
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public byte[] Logo { get; set; } = new byte[0];
        public DateTime OpenTime { get; set; }
        public DateTime CloseTime { get; set; }
        public string Street { get; set; } = string.Empty;

        public int CountryId { get; set; }
        public virtual Country Country { get; set; } = null!;
        public int CityId { get; set; }
        public virtual City City { get; set; } = null!;
        public int AreaId { get; set; }
        public virtual Area Area { get; set; } = null!;
        public virtual ICollection<Animal> Animals { get; set; } = new HashSet<Animal>();
        public virtual ICollection<Adoption> Adoptions { get; set; } = new HashSet<Adoption>();

        public string ApplicationUserId { get; set; } = null!;
        public virtual ApplicationUser ApplicationUser { get; set; } = null!;

        public virtual ICollection<ShelterRate> ShelterRates { get; set; } = new HashSet<ShelterRate>();


    }
}