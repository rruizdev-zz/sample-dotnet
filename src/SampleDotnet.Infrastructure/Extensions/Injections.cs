using Microsoft.Extensions.DependencyInjection;
using SampleDotnet.Domain.Interfaces.Repositories;
using SampleDotnet.Infrastructure.Repositories;
using System.Diagnostics.CodeAnalysis;

namespace SampleDotnet.Infrastructure.Extensions
{
    [ExcludeFromCodeCoverage]
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
