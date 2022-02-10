using MediatR;
using Microsoft.AspNetCore.Mvc;
using SampleDotnet.Application.Query.Site.GetAll;

namespace SampleDotnet.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SiteController: ControllerBase
    {
        private readonly IMediator _mediator;

        public SiteController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() =>
            Ok(await _mediator.Send(new GetAllSitesRequest()));
    }
}
