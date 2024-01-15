using Microsoft.Extensions.DependencyInjection;
using Petopia.Infrastructure.Repositories.CountryRepository;
using Petopia.Infrastructure.Repositories.GenericRepository;

namespace Petopia.Infrastructure
{
    public static class ModuleInfrastructureDependencies
    {
        public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
        {
            services.AddTransient<ICountryRepository, CountryRepository>();
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            return services;
        }
    }
}