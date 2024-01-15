using AutoMapper;
using MediatR;
using Petopia.Core.Bases;
using Petopia.Core.Features.Countries.Queries.Models;
using Petopia.Core.Features.Countries.Queries.Results;
using Petopia.Service.Services.CountryService;

namespace Petopia.Core.Features.Countries.Queries.Handlers
{
    public class CountryHandler :ResponseHandler, IRequestHandler<GetCountryListQuery, Response<List<GetCountryListResponse>>>
    {
        #region Fields
        private readonly ICountryService _countryService;
        private readonly IMapper _mapper;
        #endregion

        #region Constructors
        public CountryHandler(ICountryService countryService, IMapper mapper)
        {
            _countryService = countryService;
            _mapper = mapper;
        }
        #endregion

        #region Handle Functions
        public async Task<Response<List<GetCountryListResponse>>> Handle(GetCountryListQuery request, CancellationToken cancellationToken)
        {
            var countryList = await _countryService.GetCountriesListAsync();
            var countryListMapper = _mapper.Map<List<GetCountryListResponse>>(countryList);

            return Success(countryListMapper);
        }
        #endregion

    }
}
