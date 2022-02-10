using AutoMapper;
using MediatR;
using SampleDotnet.Domain.Entities;
using SampleDotnet.Domain.Interfaces.Repositories;

namespace SampleDotnet.Application.Query.Country.GetByLocale
{
    public class GetCountryByLocaleQueryHandler : IRequestHandler<GetCountryByLocaleRequest, GetCountryByLocaleResponse>
    {
        private readonly ICountryRepository _countryRepository;

        private readonly ISiteRepository _siteRepository;

        private readonly IMapper _mapper;

        public GetCountryByLocaleQueryHandler(ICountryRepository countryRepository, 
            ISiteRepository siteRepository, IMapper mapper)
        {
            _countryRepository = countryRepository;

            _siteRepository = siteRepository;

            _mapper = mapper;
        }

        public async Task<GetCountryByLocaleResponse> Handle(GetCountryByLocaleRequest request, CancellationToken cancellationToken)
        {
            var country = (await _countryRepository.GetAllAsync(cancellationToken))?
                .First(c => c.Locale == request.Locale);

            var site = (await _siteRepository.GetAllAsync(cancellationToken))?
                .First(s => s.Name == country?.Name);

            return _mapper.Map<GetCountryByLocaleResponse>(Tuple.Create(country, site));
        }
    }
}
