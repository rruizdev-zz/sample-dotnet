using MediatR;

namespace SampleDotnet.Application.Query.Item.GetBySearch
{
    public record GetItemsBySearchRequest(string Value, int Page) : 
        IRequest<GetItemsBySearchResponse>;
}
