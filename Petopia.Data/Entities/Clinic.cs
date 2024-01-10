namespace Petopia.Data.Entities
{
    public class Clinic
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public decimal Fees { get; set; }
        public byte[] Logo { get; set; } = new byte[0];
        public int WaitingTime { get; set; }

        public string UserId { get; set; } = string.Empty;
        public ApplicationUser User { get; set; } = null!;

        public int CountryId { get; set; }
        public Country Country { get; set; } = null!;
        public int CityId { get; set; }
        public City City { get; set; } = null!;
        public int AreaId { get; set; }
        public Area Area { get; set; } = null!;

        public string Street { get; set; } = string.Empty;


        public IEnumerable<Worktime> Worktimes { get; set; } = new List<Worktime>();
        public IEnumerable<ClinicImage> ClinicImages { get; set; } = new List<ClinicImage>();

        public IEnumerable<ClincRate> ClincRates { get; set; } = new List<ClincRate>();

    }
}
