using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ILogger = Microsoft.Extensions.Logging.ILogger;
using ModuloSeguridad.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using ModuloSeguridad.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using ModuloSeguridad.Frontend.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using ModuloSeguridad.Frontend.Authorization;
using static ModuloSeguridad.Frontend.Authorization.UsuarioAuthorizationHandler;

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
                    Configuration.GetConnectionString(nameof(ModuloSeguridadContext))));            

            services.AddTransient((container)=> 
            {
                return new UsuarioService(container.GetRequiredService<ILogger<UsuarioService>>(), container.GetRequiredService<ModuloSeguridadContext>());
            });

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddControllersWithViews();

            services.AddAuthorization(options =>
            {
                options.AddPolicy(nameof(UsuarioAuthorizationHandler), policy => policy.Requirements.Add(new UsuarioRequirement()));
            });

            services.AddSingleton<IAuthorizationHandler, UsuarioAuthorizationHandler>();
            services.AddSingleton<IAuthorizationHandler, AccionAuthorizationHandler>();
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
                app.UseExceptionHandler(string.Concat("/", nameof(ErrorController.ErrorHandler)));
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();

            app.UseAuthentication();
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
            logger.LogCritical("Aplicación detenida");
        }
        
        private void ApplicationStopping()
        {
            logger.LogCritical("La aplicación se está deteniendo");
        }
    }
}
