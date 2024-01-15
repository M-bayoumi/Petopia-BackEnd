using Microsoft.Extensions.DependencyInjection;
using Petopia.Service.Services.CountryService;

namespace Petopia.Service
{
    public static class ModuleServiceDependencies
    {
        public static IServiceCollection AddServiceDependencies(this IServiceCollection services)
        {
            services.AddTransient<ICountryService, CountryService>();
            return services;
        }
    }
}