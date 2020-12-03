using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ModuloSeguridad.Entities.Model;
using ModuloSeguridad.Frontend.Authorization;
using ModuloSeguridad.Frontend.Models;
using ModuloSeguridad.Frontend.Models.Account;
using ModuloSeguridad.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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

        [AllowAnonymous]
        public async Task<IActionResult> Login(string returnUrl = null)
        {
            if (HttpContext.User?.Identity?.IsAuthenticated == true)
            {                
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
            await HttpContext.SignOutAsync(
                CookieAuthenticationDefaults.AuthenticationScheme);
            ReturnUrl = returnUrl;
            return View(new AccountLoginViewModel());
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(AccountLoginViewModel model, string returnUrl = null)
        {
            try
            {
                logger.InicioMetodo(MethodBase.GetCurrentMethod().Name);
                logger.LogInformation("Usuario: " + model.NombreUsuario);
                Usuario usuario;
                List<Claim> claims;
                ClaimsIdentity claimsIdentity;
                ReturnUrl = returnUrl;
                if (!ModelState.IsValid) return View(model);
                usuario = usuarioService.GetUsuario(model.NombreUsuario, model.Clave);
                if (usuario == null)
                {
                    model.ErrorMessage = "Usuario inexistente.";
                    return View(model);
                }                
                claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, usuario.NombreUsuario),
                    new Claim(ClaimTypes.Name, usuario.Nombre),
                    new Claim(ClaimTypes.Surname, usuario.Apellido),
                    new Claim(ClaimTypes.Email, usuario.Mail)
                };
                claimsIdentity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);                
                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity));
                logger.LogInformation("Usuario {usuario} inició sesión a las {tiempo}.",
                    usuario.NombreUsuario, DateTime.UtcNow);
                return LocalRedirect(Url.GetLocalUrl(returnUrl));
            }
            catch (Exception e)
            {
                logger.LogError(e, "Ocurrió un error en Login");
                return View(model);
            }
            finally
            {
                logger.FinMetodo(MethodBase.GetCurrentMethod().Name);
                usuarioService?.Dispose();
            }
        }
    }
}
