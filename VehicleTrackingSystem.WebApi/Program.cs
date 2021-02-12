using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
 

namespace VehicleTrackingSystem.WebApi
{
    public class Program
    {
       
        public static void Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build();
            SeedDatabase(host);
            host.Run();

        }
        private static void SeedDatabase(IWebHost host)
        {

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    //var context = services.GetRequiredService<ApplicationDbContext>();
                    //var userManager = services.GetRequiredService<UserManager<User>>();
                    //var roleManager = services.GetRequiredService<RoleManager<Role>>();
                    //var actionDescriptor = services.GetRequiredService<IActionDescriptorCollectionProvider>();

                    //context.Database.Migrate();
                    //Seed.SeedUsers(userManager, roleManager, actionDescriptor, context);

                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occured during migration or sedding...");
                }
            }

        }
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        WebHost.CreateDefaultBuilder(args)
        .UseStartup<Startup>();
    }
}
