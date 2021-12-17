using AnthillCommon.DataContext;
using AnthillCommon.Services;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using Unity;
using Unity.Lifetime;
using Unity.Microsoft.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace AnthillCommon.WebJob
{
    class Program
    {
        public Program()
        {
        }

        static void Main(string[] args)
        {
            var container = new UnityContainer();
            IConfiguration configuration = null;

            Settings st = new Settings();

            HostBuilder builder = new HostBuilder();
            builder.ConfigureWebJobs(b =>
            {
                b.AddAzureStorageCoreServices();
                b.AddTimers();
                //b.AddAzureStorage();
            })
            .ConfigureAppConfiguration((hostingContext, config) =>
            {
                configuration = config.AddJsonFile($"appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables()
                .Build();

                ContainerConfiguration.RegisterTypes<HierarchicalLifetimeManager>(container, configuration);

            }).ConfigureLogging((hostContext, b) =>
            {
                b.AddConsole();

                var settingsSection = hostContext.Configuration.GetSection("Settings");
                var settings = settingsSection.Get<Settings>();

                //if (!string.IsNullOrEmpty(settings.APPINSIGHTS_INSTRUMENTATIONKEY))
                //{
                //    b.AddApplicationInsightsWebJobs(o => o.InstrumentationKey = settings.APPINSIGHTS_INSTRUMENTATIONKEY);
                //}
            })
            .UseUnityServiceProvider(container)
            .ConfigureContainer<IUnityContainer>(container =>
            {

            }).ConfigureServices((hostContext, services) =>
            {
                var activator = new UnityJobActivator(container);
                services.AddSingleton<IJobActivator>(activator);

                var settingsSection = hostContext.Configuration.GetSection("Settings");
                services.Configure<Settings>(settingsSection);

            });

            IHost host = builder.Build();
            using (host)
            {
                // register DI container


                host.Run();
            }


        }
    }
}
