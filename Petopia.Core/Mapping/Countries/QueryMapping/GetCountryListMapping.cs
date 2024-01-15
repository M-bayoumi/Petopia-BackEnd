using AutoMapper;
using Petopia.Core.Features.Countries.Queries.Results;
using Petopia.Data.Entities;

namespace Petopia.Core.Mapping.Countries
{
    public partial class CountryProfile : Profile
    {
        public void GetCountryListMapping()
        {
            CreateMap<Country, GetCountryListResponse>()
                    .ForMember(dest => dest.CitiesName, opt => opt.MapFrom(src => src.Cities.Select(x => x.Name)));
        }
    }
}
