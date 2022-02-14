using AutoMapper;
using SampleDotnet.Application.Query.Item.GetBySearch;
using SampleDotnet.Domain.Entities;

namespace SampleDotnet.Application.Mapper
{
    public class ItemProfile : Profile
    {
        public ItemProfile()
        {
            CreateMap<Item, GetItemsBySearchResponse>()
                .ForMember(x => x.Page, y => y.MapFrom(z => z.Paging == null ? 0 : z.Paging.Current))
                .ForMember(x => x.Pages, y => y.MapFrom(z => z.Paging == null ? 0 : z.Paging.TotalPages))
                .ForMember(x => x.ItemsPerPage, y => y.MapFrom(z => z.Paging == null ? 0 : z.Paging.Limit))
                .ForMember(x => x.Items, y => y.MapFrom(z => z.Results != null ? z.Results.Select(res => new SearchResponse()
                {
                    AvailableQuantity = res.AvailableQuantity,
                    Currency = res.CurrencyId,
                    Permalink = res.Permalink,
                    Price = res.Price,
                    Title = res.Title
                }) : new List<SearchResponse>()));
        }
    }
}
