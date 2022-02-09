namespace SampleDotnet.Application.Query.Country.GetAll
{
    public class GetAllCountriesResponse
    {
        public IEnumerable<CountryResponse>? Countries { get; set; }
    }

    public record CountryResponse(string? Id, string? Name, string? Currency);
}