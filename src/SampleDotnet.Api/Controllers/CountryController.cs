using MediatR;
using Microsoft.AspNetCore.Mvc;
using SampleDotnet.Application.Query.Country.GetAll;
using SampleDotnet.Application.Query.Country.GetByLocale;

namespace SampleDotnet.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountryController : Controller
    {
        private readonly IMediator _mediator;

        public CountryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() =>
            Ok(await _mediator.Send(new GetAllCountriesRequest()));

        [HttpGet("locale/{value}")]
        public async Task<IActionResult> GetByLocale([FromRoute] string value) =>
            Ok(await _mediator.Send(new GetCountryByLocaleRequest(value)));
    }
}
