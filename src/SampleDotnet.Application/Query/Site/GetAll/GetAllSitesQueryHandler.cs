using AutoMapper;
using MediatR;
using SampleDotnet.Domain.Interfaces.Repositories;

namespace SampleDotnet.Application.Query.Site.GetAll
{
    public class GetAllSitesQueryHandler : IRequestHandler<GetAllSitesRequest, GetAllSitesResponse>
    {
        private readonly ISiteRepository _siteRepository;

        private readonly IMapper _mapper;

        public GetAllSitesQueryHandler(ISiteRepository siteRepository, IMapper mapper)
        {
            _siteRepository = siteRepository;

            _mapper = mapper;
        }

        public async Task<GetAllSitesResponse> Handle(GetAllSitesRequest request, CancellationToken cancellationToken)
        {
            var _ = await _siteRepository.GetAllAsync(cancellationToken);

            return _mapper.Map<GetAllSitesResponse>(_);
        }
    }
}
