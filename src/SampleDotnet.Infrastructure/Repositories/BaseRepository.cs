namespace SampleDotnet.Infrastructure.Repositories
{
    public class BaseRepository
    {
        private protected readonly HttpClient _httpClient;

        public BaseRepository(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("meliService");
        }
    }
}
