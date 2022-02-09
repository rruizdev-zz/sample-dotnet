using AutoMapper;
using SampleDotnet.Application.Query.Country.GetAll;
using SampleDotnet.Domain.Entities;

namespace SampleDotnet.Application.Mapper
{
    public class CountryProfile : Profile
    {
        public CountryProfile()
        {
            CreateMap<IList<Country>, GetAllCountriesResponse>()
                .ForMember(x => x.Countries, y => y.MapFrom(z => z
                .Select(c => new CountryResponse(c.Id, c.Name, c.CurrencyId))));
        }
    }
}