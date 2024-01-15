namespace Petopia.Core.Features.Countries.Queries.Results
{
    public class GetCountryListResponse
    {
        public string Name { get; set; } = string.Empty;
        public List<string> CitiesName { get; set; } = new List<string>();
    }
}
