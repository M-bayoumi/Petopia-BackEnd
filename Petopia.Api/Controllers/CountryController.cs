using MediatR;
using Microsoft.AspNetCore.Mvc;
using Petopia.Core.Features.Countries.Queries.Models;

namespace Petopia.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CountryController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetCountryList()
        {
            var response = await _mediator.Send(new GetCountryListQuery());
            return Ok(response);
        }
    }
}
