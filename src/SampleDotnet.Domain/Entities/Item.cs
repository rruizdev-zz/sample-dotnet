using Newtonsoft.Json;

namespace SampleDotnet.Domain.Entities
{
    public class Item
    {
        [JsonProperty(PropertyName = "site_id")]
        public string? SiteId { get; set; }

        [JsonProperty(PropertyName = "country_default_time_zone")]
        public string? CountryDefaultTimeZone { get; set; }

        public string? Query { get; set; }

        public Paginated? Paging { get; set; }

        public IList<ItemResult>? Results { get; set; }

        public ItemIdName? Sort { get; set; }

        [JsonProperty(PropertyName = "available_sorts")]
        public IList<ItemIdName>? AvailableSorts { get; set; }

        public IList<ItemIdNameFilter>? Filters { get; set; }

        [JsonProperty(PropertyName = "available_filters")]
        public IList<ItemIdNameFilter>? AvailableFilters { get; set; }
    }

    public partial class ItemResult
    {
        public string? Id { get; set; }

        [JsonProperty(PropertyName = "site_id")]
        public string? SiteId { get; set; }

        public string? Title { get; set; }

        public decimal Price { get; set; }

        [JsonProperty(PropertyName = "sale_price")]
        public string? SalePrice { get; set; }

        [JsonProperty(PropertyName = "currency_id")]
        public string? CurrencyId { get; set; }

        [JsonProperty(PropertyName = "available_quantity")]
        public int AvailableQuantity { get; set; }

        [JsonProperty(PropertyName = "sold_quantity")]
        public int SoldQuantity { get; set; }

        [JsonProperty(PropertyName = "buying_mode")]
        public string? BuyingMode { get; set; }

        [JsonProperty(PropertyName = "listing_type_id")]
        public string? ListingTypeId { get; set; }

        [JsonProperty(PropertyName = "stop_time")]
        public DateTime StopTime { get; set; }

        public string? Condition { get; set; }

        public string? Permalink { get; set; }

        public string? Thumbnail { get; set; }

        [JsonProperty(PropertyName = "thumbnail_id")]
        public string? ThumbnailId { get; set; }

        [JsonProperty(PropertyName = "accepts_mercadopago")]
        public bool AcceptsMercadoPago { get; set; }

        [JsonProperty(PropertyName = "original_price")]
        public string? OriginalPrice { get; set; }

        [JsonProperty(PropertyName = "category_id")]
        public string? CategoryId { get; set; }

        [JsonProperty(PropertyName = "official_store_id")]
        public string? OfficialStoreId { get; set; }

        [JsonProperty(PropertyName = "domain_id")]
        public string? DomainId { get; set; }

        [JsonProperty(PropertyName = "catalog_product_id")]
        public string? CatalogProductId { get; set; }

        [JsonProperty(PropertyName = "order_backend")]
        public int OrderBackend { get; set; }

        [JsonProperty(PropertyName = "use_thumbnail_id")]
        public bool UseThumbnailId { get; set; }

        [JsonProperty(PropertyName = "offer_score")]
        public string? OfferScore { get; set; }

        [JsonProperty(PropertyName = "offer_share")]
        public string? OfferShare { get; set; }

        [JsonProperty(PropertyName = "match_score")]
        public string? MatchScore { get; set; }

        [JsonProperty(PropertyName = "winner_item_id")]
        public string? WinnerItemId { get; set; }

        [JsonProperty(PropertyName = "melicoin")]
        public string? MeliCoin { get; set; }
    }

    public partial class Paginated
    {
        public int Total { get; set; }

        [JsonProperty(PropertyName = "primary_results")]
        public int PrimaryResults { get; set; }

        public int Offset { get; set; }

        public int Limit { get; set; }

        public int TotalPages =>
            ((PrimaryResults < Limit ? Total : PrimaryResults) / Limit) + 1;

        public int Current =>
            Offset / Limit + 1;
    }

    public partial class ItemIdName
    {
        public string? Id { get; set; }

        public string? Name { get; set; }
    }

    public partial class ItemIdNameFilter : ItemIdName
    {
        public string? Type { get; set; }

        public IList<ItemIdNameFilterValue>? Values { get; set; }
    }

    public partial class ItemIdNameFilterValue : ItemIdName
    {
        [JsonProperty(PropertyName = "path_from_root")]
        public IList<ItemIdName>? PathFromRoot { get; set; }

        public int? Results { get; set; }
    }
}
