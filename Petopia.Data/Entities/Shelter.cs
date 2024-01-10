namespace Petopia.Data.Entities
{
    public class Shelter
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public byte[] Logo { get; set; } = new byte[0];
        public string Phone { get; set; } = string.Empty;
        public int WorkingHours { get; set; }
        public string Street { get; set; } = string.Empty;
        public string UserId { get; set; } = null!;
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public int AreaId { get; set; }






        public virtual ApplicationUser User { get; set; } = null!;
        public City City { get; set; } = null!;
        public Country Country { get; set; } = null!;
        public Area Area { get; set; } = null!;
        public virtual ICollection<ShelterAnimal> shelterAnimal { get; set; } = null!;
        public virtual ICollection<ShelterRate> shelterRate { get; set; } = null!;
        public virtual ICollection<ShelterImage> shelterImage { get; set; } = null!;







    }
}
