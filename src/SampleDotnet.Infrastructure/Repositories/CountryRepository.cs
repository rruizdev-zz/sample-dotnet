using Newtonsoft.Json;
using SampleDotnet.Domain.Entities;
using SampleDotnet.Domain.Interfaces.Repositories;

namespace SampleDotnet.Infrastructure.Repositories
{
    public class CountryRepository : BaseRepository, ICountryRepository
    {
        public CountryRepository(IHttpClientFactory httpClientFactory): base(httpClientFactory)
        {
        }

        public async Task<IList<Country>?> GetAllAsync(CancellationToken cancellationToken)
        {
            var _ = await _httpClient.GetStringAsync("https://api.mercadolibre.com/classified_locations/countries", cancellationToken);

            return JsonConvert.DeserializeObject<IList<Country>?>(_);
        }
    }
}
