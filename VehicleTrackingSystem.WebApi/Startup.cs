using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using NSwag;
using NSwag.Generation.Processors.Security;

using VehicleTrackingSystem.Application.Common.Interfaces;
using VehicleTrackingSystem.Application.IoC;
using VehicleTrackingSystem.Infrastructure.IoC;
using VehicleTrackingSystem.Infrastructure.Services;


namespace VehicleTrackingSystem.WebApi
{
    public class Startup
    {

       
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddControllers().AddNewtonsoftJson();
            services.AddCors();
            services.AddApplication();
            services.AddInfrastructure(Configuration);
            services.AddScoped<ICurrentUserService, CurrentUserService>();

            services.AddOpenApiDocument(configure =>
            {
                configure.Title = "CleanArchitecture API";
                configure.AddSecurity("JWT", Enumerable.Empty<string>(), new NSwag.OpenApiSecurityScheme
                {
                    Type = OpenApiSecuritySchemeType.ApiKey,
                    Name = "Authorization",
                    In = OpenApiSecurityApiKeyLocation.Header,
                    Description = "Type into the textbox: Bearer {your JWT token}."
                });

                configure.OperationProcessors.Add(new AspNetCoreOperationSecurityScopeProcessor("JWT"));
            });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseCustomExceptionHandler();

            // Register the Swagger generator and the Swagger UI middlewares

            app.UseOpenApi(); // serve OpenAPI/Swagger documents
            app.UseSwaggerUi3(); // serve Swagger UI
            //app.UseReDoc(); // serve ReDoc UI


            app.UseRouting();
            app.UseAuthorization();
            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());


            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

    

        }
    }
}
