using Petopia.Data.Entities;
using Petopia.Infrastructure.Repositories.CountryRepository;

namespace Petopia.Service.Services.CountryService
{
    public class CountryService : ICountryService
    {

        #region Fields
        private readonly ICountryRepository _countryRepository;
        #endregion

        #region Constructors
        public CountryService(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }
        #endregion

        #region Handle Functions
        public async Task<List<Country>> GetCountriesListAsync()
        {
            return await _countryRepository.GetCountriesListAsync();
        }
        #endregion
    }
}
