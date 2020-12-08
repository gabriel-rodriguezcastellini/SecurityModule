using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ModuloSeguridad.Entities.Model;
using ModuloSeguridad.Frontend.Authorization;
using ModuloSeguridad.Frontend.Extensions;
using ModuloSeguridad.Frontend.Models;
using ModuloSeguridad.Frontend.Models.Account;
using ModuloSeguridad.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ModuloSeguridad.Frontend.Controllers
{
    public class AccountController : BaseController
    {
        private readonly UsuarioService usuarioService;

        public AccountController(ILogger<AccountController> logger, IAuthorizationService authorizationService, UsuarioService usuarioService) : base(logger, authorizationService)
        {
            this.usuarioService = usuarioService;
        }

        public IActionResult AccessDenied()
        {
            return View();
        }

        public async Task<IActionResult> Login(string returnUrl = null)
        {
            if (User?.Identity?.IsAuthenticated == true)
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
            await HttpContext.SignOutAsync(
                CookieAuthenticationDefaults.AuthenticationScheme);
            ReturnUrl = returnUrl;
            return View(new AccountLoginViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Login(AccountLoginViewModel model, string returnUrl = null)
        {
            try
            {
                logger.InicioMetodo(MethodBase.GetCurrentMethod().Name);
                logger.LogInformation("Usuario: " + model.NombreUsuario);
                var accionModuloHelper = new AccionModuloHelper(logger);
                Usuario usuario;
                List<Claim> claims;
                ClaimsIdentity claimsIdentity;
                var accionModulos = new List<UsuarioViewModel.AccionModulo>();
                ReturnUrl = returnUrl;
                if (!ModelState.IsValid) return View(model);
                usuario = usuarioService.GetUsuario(model.NombreUsuario, model.Clave);
                logger.LogInformation("usuario " + (usuario == null ? "no encontrado" : usuario.NombreUsuario + "encontrado"));
                if (usuario == null)
                {
                    model.InfoMessage = "Usuario inexistente.";
                    return View(model);
                }
                accionModuloHelper.GuardarModulos(usuario.UsuarioGrupos, ref accionModulos); //carga las acciones/modulos para luego guardarlas en los claims
                claims = new List<Claim>
                {
                    new Claim(JwtRegisteredClaimNames.UniqueName, usuario.NombreUsuario),
                    new Claim(ClaimTypes.Name, usuario.Nombre),
                    new Claim(ClaimTypes.Surname, usuario.Apellido),
                    new Claim(ClaimTypes.Email, usuario.Mail),
                    new Claim(ClaimTypes.UserData, JsonConvert.SerializeObject(accionModulos))
                };
                claimsIdentity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity));
                logger.LogInformation("Usuario {usuario} inició sesión a las {tiempo}.",
                    usuario.NombreUsuario, DateTime.UtcNow);
                CargarNotificacion("Inicio de sesión exitoso", "success-color", "fas fa-check");
                return LocalRedirect(Url.GetLocalUrl(returnUrl));
            }
            catch (Exception e)
            {
                return RetornarError500(e, "Login");
            }
            finally
            {
                logger.FinMetodo(MethodBase.GetCurrentMethod().Name);
                usuarioService?.Dispose();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            logger.LogInformation("Usuario {Name} cerró sesión a las {Time}.",
                User.Identity.Name, DateTime.UtcNow);

            #region snippet1
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            #endregion

            return RedirectToAction(nameof(Login), "Account");
        }
    }
}