using MediatR;
using Microsoft.AspNetCore.Mvc;
using SampleDotnet.Application.Query.Item.GetBySearch;

namespace SampleDotnet.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ItemController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{value}")]
        public async Task<IActionResult> GetByQuery([FromRoute] string value, [FromQuery] int page = 1) =>
            Ok(await _mediator.Send(new GetItemsBySearchRequest(value, page)));
    }
}
