using Microsoft.Extensions.DependencyInjection;
using SampleDotnet.Application.Mapper;
using System.Diagnostics.CodeAnalysis;

namespace SampleDotnet.Application.Extensions
{
    [ExcludeFromCodeCoverage]
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
