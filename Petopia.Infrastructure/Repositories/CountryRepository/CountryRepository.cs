using Microsoft.EntityFrameworkCore;
using Petopia.Data.Entities;
using Petopia.infrastructure.Data;
using Petopia.Infrastructure.Repositories.GenericRepository;

namespace Petopia.Infrastructure.Repositories.CountryRepository
{
    public class CountryRepository : GenericRepository<Country>, ICountryRepository
    {
        #region Fields
        private readonly AppDbContext _appDbContext;
        private readonly DbSet<Country> _countries;
        #endregion

        #region Constructors
        public CountryRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
            _countries = appDbContext.Set<Country>();
        }
        #endregion

        #region Handle Functions
        public async Task<List<Country>> GetCountriesListAsync()
        {
            return await _countries.Include(x => x.Cities).ToListAsync();
        }
        #endregion

    }
}
