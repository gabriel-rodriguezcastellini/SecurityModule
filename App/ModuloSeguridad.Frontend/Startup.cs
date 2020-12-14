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
using ModuloSeguridad.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using ModuloSeguridad.Frontend.Controllers;
using Microsoft.AspNetCore.Http;
using ModuloSeguridad.Frontend.Authorization;
using Microsoft.AspNetCore.Mvc;
using ModuloSeguridad.Services.Extensions.Mail;

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
            services.AddSingleton(Configuration.GetSection(nameof(MailConfiguration)).Get<MailConfiguration>());

            services.AddScoped((container) =>
            {
                return new MailSender(container.GetRequiredService<MailConfiguration>(), container.GetRequiredService<ILogger<MailSender>>());
            });

            services.AddDbContext<ModuloSeguridadContext>(
                options => options.UseSqlServer(
                    Configuration.GetConnectionString(nameof(ModuloSeguridadContext)), options=>options.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery)));

            services.AddTransient((container)=> 
            {
                return new UsuarioService(container.GetRequiredService<ILogger<UsuarioService>>(), 
                    container.GetRequiredService<ModuloSeguridadContext>(), container.GetRequiredService<MailSender>());
            });

            services.AddTransient((container) =>
            {
                return new GrupoService(container.GetRequiredService<ILogger<GrupoService>>(), container.GetRequiredService<ModuloSeguridadContext>());
            });

            services.AddTransient((container) =>
            {
                return new EstadoUsuarioService(container.GetRequiredService<ILogger<EstadoUsuarioService>>(), container.GetRequiredService<ModuloSeguridadContext>());
            });

            #region Autorizacion
            services.AddSingleton<IAuthorizationPolicyProvider, AccionModuloPolicyProvider>();
            services.AddSingleton<IAuthorizationHandler, AccionModuloAuthorizationHandler>();            
            #endregion

            services.AddMvc(options=> 
            {
                options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute()); //valida AntiforgeryToken en todos los métodos
            });

            #region Autenticacion
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.AccessDeniedPath = "/Usuarios/AccesoDenegado";
                    options.LoginPath = "/Usuarios/Login";
                });            
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            #endregion            
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
                app.UseExceptionHandler(string.Concat("/", nameof(ErrorController.Error)));
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
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
