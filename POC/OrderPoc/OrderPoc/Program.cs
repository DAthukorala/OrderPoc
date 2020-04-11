using Microsoft.Extensions.DependencyInjection;
using System;

namespace OrderPoc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        private static IServiceProvider SetUpDIContainer()
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<NetworkServices, NetworkServices>()
        }
    }
}
