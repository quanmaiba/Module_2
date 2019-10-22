﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.IO;
using System.Reflection;
using Microsoft.AspNetCore;

namespace FirstEmptyWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)=>
        WebHost.CreateDefaultBuilder(args)
        .UseStartup<Startup>().UseHttpSys();
        //{
        //    var builder = new WebHostBuilder()
        //    .UseKestrel()
        //    .UseStartup<Startup>()
        //    .UseContentRoot(Directory.GetCurrentDirectory())
        //    .ConfigureAppConfiguration((hostingContext, config) =>
        //    {
        //        var env = hostingContext.HostingEnvironment;
        //        config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
        //        .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true);

        //        if (env.IsDevelopment())
        //        {
        //            var appAssembly = Assembly.Load(new AssemblyName(env.ApplicationName));
        //            if (appAssembly != null)
        //            {
        //                config.AddUserSecrets(appAssembly, optional: true);
        //            }
        //        }
        //        config.AddEnvironmentVariables();
        //        if (args != null)
        //        {
        //            config.AddCommandLine(args);
        //        }

        //    })
        //    .ConfigureLogging((hostingContext, logging) =>
        //    {
        //        logging.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));
        //        logging.AddConsole();
        //        logging.AddDebug();

        //    })
        //    .UseIISIntegration()
        //    .UseDefaultServiceProvider((context, options) =>
        //    {
        //        options.ValidateScopes = context.HostingEnvironment.IsDevelopment();
        //    });
        //    return builder;

        //}
      
    }
}
