using MediatR;

namespace SampleDotnet.Application.Query.Country.GetByLocale
{
    public class GetCountryByLocaleQueryHandler : IRequestHandler<GetCountryByLocaleRequest, GetCountryByLocaleResponse>
    {
        public async Task<GetCountryByLocaleResponse> Handle(GetCountryByLocaleRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
