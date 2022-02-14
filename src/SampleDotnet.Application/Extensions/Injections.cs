using Microsoft.Extensions.DependencyInjection;
using SampleDotnet.Application.Mapper;

namespace SampleDotnet.Application.Extensions
{
    public static class Injections
    {
        public static IServiceCollection AddMappers(this IServiceCollection services)
        {
            services.AddAutoMapper(c =>
            {
                c.AddProfile<CountryProfile>();
                c.AddProfile<SiteProfile>();
                c.AddProfile<ItemProfile>();
            });

            return services;
        }
    }
}
