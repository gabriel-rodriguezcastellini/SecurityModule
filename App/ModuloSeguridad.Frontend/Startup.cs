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
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using ModuloSeguridad.Services;
using ModuloSeguridad.Services.Helpers;
using ModuloSeguridad.Services.Common;
using Microsoft.AspNetCore.Authentication.Cookies;

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
            services.AddDbContext<ModuloSeguridadContext>(
                options => options.UseSqlServer(
                    Configuration.GetConnectionString("ModuloSeguridadContext")));
            services.AddTransient((container)=> 
            {
                return new UsuarioService(container.GetRequiredService<ILogger<UsuarioService>>(), container.GetRequiredService<ModuloSeguridadContext>());
            });
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(options =>
            {
                options.LoginPath = "/Account/Unauthorized/";
                options.AccessDeniedPath = "/Account/Forbidden/";
                options.Cookie.Name = Enums.Cookies.Autenticacion.ToString();
            });
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IHostApplicationLifetime applicationLifetime, ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger(typeof(Startup));

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

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseCookiePolicy();

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
            logger.LogCritical("Aplicación detenida");
        }
        
        private void ApplicationStopping()
        {
            logger.LogCritical("La aplicación se está deteniendo");
        }
    }
}
