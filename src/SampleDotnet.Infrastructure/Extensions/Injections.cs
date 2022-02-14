using Microsoft.Extensions.DependencyInjection;
using SampleDotnet.Domain.Interfaces.Repositories;
using SampleDotnet.Infrastructure.Repositories;

namespace SampleDotnet.Infrastructure.Extensions
{
    public static class Injections
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<ICountryRepository, CountryRepository>();
            services.AddScoped<ISiteRepository, SiteRepository>();
            services.AddScoped<IItemRepository, ItemRepository>();

            return services;
        }
    }
}
