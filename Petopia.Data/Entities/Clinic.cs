namespace Petopia.Data.Entities
{
    public class Clinic
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public byte[] Logo { get; set; } = new byte[0];
        public decimal Fees { get; set; }
        public int WaitingTime { get; set; }
        public string Street { get; set; } = string.Empty;
        public string ApplicationUserId { get; set; } = null!;
        public virtual ApplicationUser ApplicationUser { get; set; } = null!;
        public int CountryId { get; set; }
        public virtual Country Country { get; set; } = null!;
        public int CityId { get; set; }
        public virtual City City { get; set; } = null!;
        public int AreaId { get; set; }
        public virtual Area Area { get; set; } = null!;
        public virtual ICollection<ClinicRate> ClinicRates { get; set; } = new HashSet<ClinicRate>();
        public virtual ICollection<WorkTime> WorkTimes { get; set; } = new HashSet<WorkTime>();

    }
}