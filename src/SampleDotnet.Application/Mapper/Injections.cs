using Microsoft.Extensions.DependencyInjection;

namespace SampleDotnet.Application.Mapper
{
    public static class Injections
    {
        public static IServiceCollection AddMappers(this IServiceCollection services)
        {
            services.AddAutoMapper(c =>
            {
                c.AddProfile<CountryProfile>();
                c.AddProfile<SiteProfile>();
            });

            return services;
        }
    }
}
