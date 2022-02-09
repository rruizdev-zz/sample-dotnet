using AutoMapper;
using MediatR;
using SampleDotnet.Domain.Interfaces.Repositories;

namespace SampleDotnet.Application.Query.Country.GetAll
{
    public class GetAllCountriesQueryHandler : IRequestHandler<GetAllCountriesRequest, GetAllCountriesResponse>
    {
        private readonly ICountryRepository _countryRepository;

        private readonly IMapper _mapper;

        public GetAllCountriesQueryHandler(ICountryRepository countryRepository, IMapper mapper)
        {
            _countryRepository = countryRepository;

            _mapper = mapper;
        }

        public async Task<GetAllCountriesResponse> Handle(GetAllCountriesRequest request, CancellationToken cancellationToken)
        {
            var _ = await _countryRepository.GetAllAsync(cancellationToken);

            return _mapper.Map<GetAllCountriesResponse>(_);
        }
    }
}
