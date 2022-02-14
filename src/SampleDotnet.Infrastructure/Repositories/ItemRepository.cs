using Newtonsoft.Json;
using SampleDotnet.Domain.Entities;
using SampleDotnet.Domain.Interfaces.Repositories;

namespace SampleDotnet.Infrastructure.Repositories
{
    public class ItemRepository : BaseRepository, IItemRepository
    {
        public ItemRepository(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
        }

        public async Task<Item?> GetBySearchAsync(string value, int page, CancellationToken cancellationToken)
        {
            var _ = await _httpClient.GetStringAsync($"https://api.mercadolibre.com/sites/MLA/search?q={value}&offset={page*50}&limit=50", cancellationToken);

            return JsonConvert.DeserializeObject<Item?>(_);
        }
    }
}
