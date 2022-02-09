using MediatR;

namespace SampleDotnet.Application.Query.Country.GetAll
{
    public class GetAllCountriesRequest : IRequest<GetAllCountriesResponse>
    {
    }
}
