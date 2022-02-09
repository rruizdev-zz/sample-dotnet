using Newtonsoft.Json;
using SampleDotnet.Domain.Entities;
using SampleDotnet.Domain.Interfaces.Repositories;

namespace SampleDotnet.Infrastructure.Repositories
{
    public class SiteRepository : BaseRepository, ISiteRepository
    {
        public SiteRepository(IHttpClientFactory httpClientFactory): base(httpClientFactory)
        {
        }

        public async Task<IList<Site>?> GetAllAsync(CancellationToken cancellationToken)
        {
            var _ = await _httpClient.GetStringAsync("https://api.mercadolibre.com/sites", cancellationToken);

            return JsonConvert.DeserializeObject<IList<Site>?>(_);
        }
    }
}
