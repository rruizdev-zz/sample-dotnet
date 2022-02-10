namespace SampleDotnet.Application.Query.Site.GetAll
{
    public class GetAllSitesResponse
    {
        public IEnumerable<SiteResponse>? Sites { get; set; }
    }

    public record SiteResponse(string? Id, string? Name, string? Currency);
}