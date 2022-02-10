using AutoMapper;
using SampleDotnet.Application.Query.Site.GetAll;
using SampleDotnet.Domain.Entities;

namespace SampleDotnet.Application.Mapper
{
    public class SiteProfile : Profile
    {
        public SiteProfile()
        {
            CreateMap<IList<Site>, GetAllSitesResponse>()
                .ForMember(x => x.Sites, y => y.MapFrom(z => z.Select(MapToSite)));
        }

        private SiteResponse MapToSite(Site site) =>
            new(site.Id, site.Name, site.DefaultCurrencyId);
    }
}
