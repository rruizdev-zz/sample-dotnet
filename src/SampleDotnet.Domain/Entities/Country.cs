using Newtonsoft.Json;

namespace SampleDotnet.Domain.Entities
{
    public class Country
    {
        public string? Id { get; set; }

        public string? Name { get; set; }

        public string? Locale { get; set; }

        [JsonProperty(PropertyName = "currency_id")]
        public string? CurrencyId { get; set; }
    }
}
