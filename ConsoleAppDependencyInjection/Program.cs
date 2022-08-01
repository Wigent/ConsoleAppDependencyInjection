using ConsoleAppDependencyInjection.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;

namespace ConsoleAppDependencyInjection
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await Host.CreateDefaultBuilder()
                    .ConfigureServices(services =>
                    {
                        services.RegisterServices();
                        services.RegisterOptions();
                    })
                    .ConfigureServices(services => services.AddSingleton<Executor>())
                    .Build()
                    .Services
                    .GetService<Executor>()
                    .Execute();
        }
    }
}
