using Fencing.Service.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Fencing.Service
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddFencingService(this IServiceCollection services)
        {
            services.AddScoped<ITournamentService, TournamentService>();
            services.AddScoped<IPoolService, PoolService>();
            return services;
        }
    }
}
