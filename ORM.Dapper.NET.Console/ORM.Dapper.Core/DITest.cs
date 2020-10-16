using System;
using Microsoft.Extensions.DependencyInjection;

namespace ORM.Dapper.Core
{
    public class DITest
    {
        private static IServiceProvider _serviceProvider;
        
        static void Run()
        {
            _serviceProvider = RegisterServices();
            IServiceScope scope = _serviceProvider.CreateScope();
            var obj1 = scope.ServiceProvider.GetRequiredService<Test1>();
            var obj2 = scope.ServiceProvider.GetRequiredService<Test1>();
            Dispose();
        }

        private static IServiceProvider RegisterServices()
        {
            var services = new ServiceCollection();
            services.AddScoped<ITestScoped, Test>();
            services.AddSingleton<ITestSingleTon, Test>();
            services.AddTransient<Test1>();
            return services.BuildServiceProvider(true);
        }

        private static void Dispose()
        {
            ((IDisposable) _serviceProvider)?.Dispose();
        }
    }
    
    public interface ITestSingleTon
    {
        Guid Curr { get; }
    }

    public interface ITestScoped
    {
        Guid Curr { get; }
    }

    public class Test : ITestScoped, ITestSingleTon
    {
        public Test()
        {
            this.Curr = Guid.NewGuid();
        }

        public Guid Curr { get; private set; }
    }

    public class Test1
    {
        public Test1(ITestScoped testScoped, ITestSingleTon testSingleTon)
        {
            Console.WriteLine(testScoped.Curr);
            Console.WriteLine(testSingleTon.Curr);
        }
    }
}