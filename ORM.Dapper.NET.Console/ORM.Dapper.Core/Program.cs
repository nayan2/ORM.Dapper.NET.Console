﻿using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ORM.Dapper.Core
{
    public static class Program
    {
        private static IServiceProvider _serviceProvider;
        
        static async Task Main(string[] args)
        {
            _serviceProvider = RegisterServices();
            var scope = _serviceProvider.CreateScope();
            await scope.ServiceProvider.GetService<App>()?.Run(args);
            Dispose();
        }

        private static IServiceProvider RegisterServices()
        {
            var services = new ServiceCollection();
            services.AddSingleton(typeof(IConfiguration), new ConfigurationBuilder().AddJsonFile("appsettings.json", true, true).Build());
            services.AddSingleton<Helper>();
            services.AddTransient<App>();
            return services.BuildServiceProvider(true);
        }

        private static void Dispose()
        {
            ((IDisposable) _serviceProvider)?.Dispose();
        }
    }
}