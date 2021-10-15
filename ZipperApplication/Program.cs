using Microsoft.AspNetCore.Hosting; //import Microsoft.AspNetCore.Hosting
using Microsoft.Extensions.DependencyInjection; //import Microsoft.Extensions.DependencyInjection
using Microsoft.Extensions.Hosting; //import Microsoft.Extensions.Hosting
using Microsoft.Extensions.Logging; //import Microsoft.Extensions.Logging
using System; //import System
using ZipperApplication.Data; //import ZipperApplication.Data
using ZipperApplication.Models; //import ZipperApplication.Models

namespace ZipperApplication //start of ZipperApplication namespace
{
    public class Program //start of Program class
    {
        public static void Main(string[] args) //start of Main method
        {
            var host = CreateHostBuilder(args).Build(); //creates and configures a host builder object and then builds it, storing it in host

            using(var scope = host.Services.CreateScope()) //creates a new scope object and stores it in variable scope
            {
                var services = scope.ServiceProvider; //gets value stored in scope object's ServiceProvider property and stores it in variable services

                try //start of try
                {
                    SeedData.Initialize(services); //calls the SeedData.Initialize method and passes it the value stored in services
                } //end of try
                catch (Exception ex) //start of catch
                {
                    var logger = services.GetRequiredService<ILogger<Program>>(); //creates logger variable
                    logger.LogError(ex, "An error occurred seeding the DB"); //logs error passed to catch
                } //end of catch
            } //end of using statement, scope object is disposed of

            host.Run(); //runs host builder object stored in host
        }

        public static IHostBuilder CreateHostBuilder(string[] args) => //start of CreateHostBuilder method 
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    } //end of Program class
} //end of ZipperApplication namespace
