using Newtonsoft.Json;

namespace SampleDotnet.Domain.Entities
{
    public class Site
    {
        [JsonProperty(PropertyName = "default_currency_id")]
        public string? DefaultCurrencyId { get; set; }

        public string? Id { get; set; }

        public string? Name { get; set; }
    }
}
