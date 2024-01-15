using AutoMapper;

namespace Petopia.Core.Mapping.Countries
{
    public partial class CountryProfile : Profile
    {
        public CountryProfile()
        {
            GetCountryListMapping();
        }
    }
}
