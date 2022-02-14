using SampleDotnet.Application.Entities;

namespace SampleDotnet.Application.Query.Item.GetBySearch
{
    public class GetItemsBySearchResponse : Paginated<SearchResponse>
    {
    }

    public partial class SearchResponse
    {
        public string? Title { get; set; }

        public decimal Price { get; set; }

        public string? Currency { get; set; }

        public int AvailableQuantity { get; set; }

        public string? Permalink { get; set; }
    }
}