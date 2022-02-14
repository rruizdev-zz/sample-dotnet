using AutoMapper;
using MediatR;
using SampleDotnet.Domain.Interfaces.Repositories;

namespace SampleDotnet.Application.Query.Item.GetBySearch
{
    public class GetItemsBySearchQueryHandler : IRequestHandler<GetItemsBySearchRequest, GetItemsBySearchResponse>
    {
        private readonly IItemRepository _itemRepository;

        private readonly IMapper _mapper;

        public GetItemsBySearchQueryHandler(IItemRepository itemRepository, IMapper mapper)
        {
            _itemRepository = itemRepository;

            _mapper = mapper;
        }

        public async Task<GetItemsBySearchResponse> Handle(GetItemsBySearchRequest request, CancellationToken cancellationToken)
        {
            var _ = await _itemRepository.GetBySearchAsync(request.Value, request.Page - 1, cancellationToken);

            return _mapper.Map<GetItemsBySearchResponse>(_);
        }
    }
}
