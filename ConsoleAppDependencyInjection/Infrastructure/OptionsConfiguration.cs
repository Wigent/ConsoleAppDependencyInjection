using ConsoleAppDependencyInjection.Models;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ConsoleAppDependencyInjection.Infrastructure
{
    public static class OptionsConfiguration
    {
        public static void RegisterOptions(this IServiceCollection services)
        {
            services.Configure<ConfigurationSettings>(options =>
            {
                options.SqlServerConnectionString = Environment.GetEnvironmentVariable("SqlServiceConnectionString");
                options.Region = Environment.GetEnvironmentVariable("Region");
            });
        }
    }
}
