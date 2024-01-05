namespace Petopia.Data.Entities
{
    public class Area
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int CityId { get; set; }
        public City City { get; set; } = null!;
    }
}
