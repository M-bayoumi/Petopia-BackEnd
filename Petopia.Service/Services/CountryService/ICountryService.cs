using Petopia.Data.Entities;

namespace Petopia.Service.Services.CountryService
{
    public interface ICountryService
    {
        Task<List<Country>> GetCountriesListAsync();
    }
}
