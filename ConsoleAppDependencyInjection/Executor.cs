using ConsoleAppDependencyInjection.Interfaces;
using ConsoleAppDependencyInjection.Models;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;

namespace ConsoleAppDependencyInjection
{
    public class Executor
    {
        private readonly ICuteService _cuteService;
        private readonly ILogger<Executor> _logger;
        private readonly IOptions<ConfigurationSettings> _options;

        public Executor(ICuteService cuteService, ILogger<Executor> logger, IOptions<ConfigurationSettings> options )
        {
            _cuteService = cuteService;
            _logger = logger;
            _options = options;
        }

        public async Task Execute()
        {
            _logger.LogInformation($"Starting Execute in region {_options.Value.Region}");

            await _cuteService.GetCuteAnimals();
        }
    }
}
