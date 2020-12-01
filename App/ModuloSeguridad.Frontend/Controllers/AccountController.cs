using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ModuloSeguridad.Frontend.Models;
using ModuloSeguridad.Frontend.Models.Account;
using ModuloSeguridad.Services;
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
        public AccountController(ILogger<AccountController> logger, IAuthorizationService authorizationService) : base(logger, authorizationService)
        {
            
        }

        [AllowAnonymous]
        public async Task<IActionResult> Login(string returnUrl = null)
        {
            await HttpContext.SignOutAsync(
                CookieAuthenticationDefaults.AuthenticationScheme);
            ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(AccountLoginViewModel model, string returnUrl = null)
        {            
            try
            {
                logger.InicioMetodo(MethodBase.GetCurrentMethod().Name);
                logger.LogInformation("Usuario: " + model.NombreUsuario);
                ReturnUrl = returnUrl;
                if (!ModelState.IsValid) return View(model);
                


            }
            catch (Exception e)
            {
                logger.LogError(e, "Ocurrió un error en Login");
            }
            finally
            {
                logger.FinMetodo(MethodBase.GetCurrentMethod().Name);
            }

            

            var authProperties = new AuthenticationProperties
            {
                //AllowRefresh = <bool>,
                // Refreshing the authentication session should be allowed.

                ExpiresUtc = DateTimeOffset.UtcNow.AddSeconds(10)
                // The time at which the authentication ticket expires. A 
                // value set here overrides the ExpireTimeSpan option of 
                // CookieAuthenticationOptions set with AddCookie.

                //IsPersistent = true,
                // Whether the authentication session is persisted across 
                // multiple requests. When used with cookies, controls
                // whether the cookie's lifetime is absolute (matching the
                // lifetime of the authentication ticket) or session-based.

                //IssuedUtc = <DateTimeOffset>,
                // The time at which the authentication ticket was issued.

                //RedirectUri = <string>
                // The full path or absolute URI to be used as an http 
                // redirect response value.
            };

            await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(new ClaimsIdentity(
                    new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, model.NombreUsuario),
                        new Claim(ClaimTypes.Role, "Administrator"),
                    }, CookieAuthenticationDefaults.AuthenticationScheme)), authProperties);
            
            return LocalRedirect(Url.GetLocalUrl(returnUrl));
        }
    }
}
