using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ILogger = Microsoft.Extensions.Logging.ILogger;
using ModuloSeguridad.Entities;
using Microsoft.EntityFrameworkCore;
using ModuloSeguridad.Entities.Repository;

namespace ModuloSeguridad.Frontend
{
    public class Startup
    {
        private ILogger logger;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<ModuloSeguridadContext>(
                options => options.UseSqlServer(
                    Configuration.GetConnectionString("ModuloSeguridadContext")));

            services.AddTransient(typeof(GenericRepository<>));

            services.AddDatabaseDeveloperPageExceptionFilter();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IHostApplicationLifetime applicationLifetime, ILoggerFactory loggerFactory)
        {
            applicationLifetime.ApplicationStarted.Register(ApplicationStarted);
            applicationLifetime.ApplicationStopped.Register(ApplicationStopped);
            applicationLifetime.ApplicationStopping.Register(ApplicationStopping);
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseSerilogRequestLogging(options =>
            {
                //Customize the message template
                options.MessageTemplate = "Handled {RequestPath}";

                // Emit debug-level events instead of the defaults
                options.GetLevel = (httpContext, elapsed, ex) => LogEventLevel.Debug;

                // Attach additional properties to the request completion event
                options.EnrichDiagnosticContext = (diagnosticContext, httpContext) =>
                {
                    diagnosticContext.Set("RequestHost", httpContext.Request.Host.Value);
                    diagnosticContext.Set("RequestScheme", httpContext.Request.Scheme);
                };
            });
            logger = loggerFactory.CreateLogger(typeof(Startup));

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }

        private void ApplicationStarted()
        {
            logger.LogInformation("Aplicación iniciada");
        }

        private void ApplicationStopped()
        {
            logger.LogInformation("Aplicación detenida");
        }
        
        private void ApplicationStopping()
        {
            logger.LogInformation("La aplicación se está deteniendo");
        }
    }
}
