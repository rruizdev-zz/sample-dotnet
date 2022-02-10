using AutoMapper;
using SampleDotnet.Application.Query.Country.GetAll;
using SampleDotnet.Application.Query.Country.GetByLocale;
using SampleDotnet.Domain.Entities;

namespace SampleDotnet.Application.Mapper
{
    public class CountryProfile : Profile
    {
        public CountryProfile()
        {
            CreateMap<IList<Country>, GetAllCountriesResponse>()
                .ForMember(x => x.Countries, y => y.MapFrom(z => z.Select(MapToCountry)));

            CreateMap<Tuple<Country, Site>, GetCountryByLocaleResponse>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Item1.Id))
                .ForMember(x => x.Name, y => y.MapFrom(z => z.Item1.Name))
                .ForMember(x => x.Site, y => y.MapFrom(z => z.Item2.Id))
                .ForMember(x => x.Currency, y => y.MapFrom(z => z.Item2.DefaultCurrencyId));
        }

        private CountryResponse MapToCountry(Country country) =>
            new(country.Id, country.Name, country.CurrencyId);
    }
}