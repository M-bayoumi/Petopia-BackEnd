using Petopia.Data.Entities;
using Petopia.Infrastructure.Repositories.GenericRepository;

namespace Petopia.Infrastructure.Repositories.CountryRepository
{
    public interface ICountryRepository : IGenericRepository<Country>
    {
        Task<List<Country>> GetCountriesListAsync();
    }
}
