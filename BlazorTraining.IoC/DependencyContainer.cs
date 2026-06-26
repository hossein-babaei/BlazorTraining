using BlazorTraining.Data.Repository;
using BlazorTraining.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorTraining.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IServerRepository, ServerRepository>();
            return services;
        }
    }
}
