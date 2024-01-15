using MediatR;
using Petopia.Core.Bases;
using Petopia.Core.Features.Countries.Queries.Results;

namespace Petopia.Core.Features.Countries.Queries.Models
{
    public class GetCountryListQuery : IRequest<Response<List<GetCountryListResponse>>>
    {
    }
}
