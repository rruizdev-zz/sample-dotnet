using MediatR;

namespace SampleDotnet.Application.Query.Country.GetByLocale
{
    public record GetCountryByLocaleRequest(string Locale): 
        IRequest<GetCountryByLocaleResponse>;
}
