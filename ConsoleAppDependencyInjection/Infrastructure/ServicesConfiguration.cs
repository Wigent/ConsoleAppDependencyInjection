using ConsoleAppDependencyInjection.Interfaces;
using ConsoleAppDependencyInjection.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleAppDependencyInjection.Infrastructure
{
    public static class ServicesConfiguration
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddSingleton<ICuteService, CuteService>();

        }
    }
}
