using System;
using Microsoft.Extensions.DependencyInjection;
using Controller;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new ServiceCollection();

            collection.AddTransient<IProgramRunner, ProgramRunner>();
            collection.AddSingleton<IClient, Client>();
            collection.AddSingleton<IMenu, Menu>();

            collection.BuildServiceProvider().GetService<IProgramRunner>().Run();
        }
    }
}
