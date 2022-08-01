using ConsoleAppDependencyInjection.Interfaces;
using System.Threading.Tasks;

namespace ConsoleAppDependencyInjection.Services
{
    public class CuteService : ICuteService
    {
        public async Task GetCuteAnimals()
        {
            //Do something cute...
        }
    }
}
