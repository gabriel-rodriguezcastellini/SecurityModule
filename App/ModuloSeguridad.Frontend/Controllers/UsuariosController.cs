using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ModuloSeguridad.Entities.Model;
using ModuloSeguridad.Frontend.Authorization;
using ModuloSeguridad.Frontend.Extensions;
using ModuloSeguridad.Frontend.Models;
using ModuloSeguridad.Frontend.Models.Usuarios;
using ModuloSeguridad.Services;
using Newtonsoft.Json;

namespace ModuloSeguridad.Frontend.Controllers
{
    public class UsuariosController : BaseController
    {
        private readonly UsuarioService usuarioService;
        public UsuariosController(ILogger<UsuariosController> logger, IAuthorizationService authorizationService, UsuarioService usuarioService) : base(logger, authorizationService)
        {
            this.usuarioService = usuarioService;
        }
        
        [AllowAnonymous]
        public IActionResult AccesoDenegado()
        {
            return View();
        }

        [AllowAnonymous]
        public async Task<IActionResult> Login(string returnUrl = null)
        {
            if (User?.Identity?.IsAuthenticated == true)
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
            await HttpContext.SignOutAsync(
                CookieAuthenticationDefaults.AuthenticationScheme);
            ReturnUrl = returnUrl;
            return View(new UsuariosLoginViewModel());
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(UsuariosLoginViewModel model, string returnUrl = null)
        {
            try
            {
                logger.InicioMetodo(MethodBase.GetCurrentMethod().Name);
                logger.LogInformation("Usuario: " + model.NombreUsuario);
                Usuario usuario;
                List<Claim> claims;
                ClaimsIdentity claimsIdentity;
                var accionModulos = new List<UsuarioViewModel.AccionModulo>();
                ReturnUrl = returnUrl;
                if (!ModelState.IsValid) return View(model);
                usuario = await usuarioService.GetUsuarioAsync(model.NombreUsuario, model.Clave);
                logger.LogInformation("usuario " + (usuario == null ? "no encontrado" : usuario.NombreUsuario + "encontrado"));
                if (usuario == null)
                {
                    model.InfoMessage = "Usuario inexistente.";
                    return View(model);
                }
                AccionModuloHelper.GuardarModulos(usuario.UsuarioGrupos, ref accionModulos); //carga las acciones/modulos para luego guardarlas en los claims
                claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, usuario.NombreUsuario),
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
                User.FindFirstValue(ClaimTypes.NameIdentifier), DateTime.UtcNow);
            
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction(nameof(Login));
        }

        [AllowAnonymous]        
        public IActionResult RecuperarClave(string nombreUsuario, string mail)
        {
            return View();
        }

        public IActionResult Perfil()
        {
            return View(/*Cookie.GetUsuarioViewModel(User)*/);
        }

        [AccionModuloAuthorize("Leer", "Usuarios")]
        // GET: Usuarios
        public async Task<IActionResult> Index()
        {
            //var moduloSeguridadContext = _context.Usuarios.Include(u => u.EstadoUsuario);
            //return View(await moduloSeguridadContext.ToListAsync());
            using (usuarioService)
            {
                var usuariosViewModel = new List<UsuariosIndexViewModel>();
                var usuarios = await usuarioService.GetUsuariosAsync();
                foreach (var item in usuarios)
                {
                    usuariosViewModel.Add(new UsuariosIndexViewModel()
                    {
                        NombreUsuario = item.NombreUsuario,
                        ApellidoNombre = string.Format(item.Apellido, " ", item.Nombre),
                        Grupos = string.Join(", ", item.UsuarioGrupos?.Select(ug => ug.Grupo?.Codigo)),
                        Email = item.Mail,
                        Estado = item.EstadoUsuario.Nombre
                    });
                }
                return View(usuariosViewModel.AsQueryable());
            }
        }

        //// GET: Usuarios/Details/5
        //public async Task<IActionResult> Details(string id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var usuario = await _context.Usuarios
        //        .Include(u => u.EstadoUsuario)
        //        .FirstOrDefaultAsync(m => m.NombreUsuario == id);
        //    if (usuario == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(usuario);
        //}

        //// GET: Usuarios/Create
        //public IActionResult Create()
        //{
        //    ViewData["EstadoUsuarioId"] = new SelectList(_context.EstadoUsuarios, "EstadoUsuarioId", "Nombre");
        //    return View();
        //}

        //// POST: Usuarios/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("NombreUsuario,Nombre,Apellido,Clave,Mail,EstadoUsuarioId,Eliminado,FechaCreacion,FechaActualizacion,FechaEliminacion,CreadoPor,ActualizadoPor,EliminadoPor")] Usuario usuario)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(usuario);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["EstadoUsuarioId"] = new SelectList(_context.EstadoUsuarios, "EstadoUsuarioId", "Nombre", usuario.EstadoUsuarioId);
        //    return View(usuario);
        //}

        //// GET: Usuarios/Edit/5
        //public async Task<IActionResult> Edit(string id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var usuario = await _context.Usuarios.FindAsync(id);
        //    if (usuario == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["EstadoUsuarioId"] = new SelectList(_context.EstadoUsuarios, "EstadoUsuarioId", "Nombre", usuario.EstadoUsuarioId);
        //    return View(usuario);
        //}

        //// POST: Usuarios/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(string id, [Bind("NombreUsuario,Nombre,Apellido,Clave,Mail,EstadoUsuarioId,Eliminado,FechaCreacion,FechaActualizacion,FechaEliminacion,CreadoPor,ActualizadoPor,EliminadoPor")] Usuario usuario)
        //{
        //    if (id != usuario.NombreUsuario)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(usuario);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!UsuarioExists(usuario.NombreUsuario))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["EstadoUsuarioId"] = new SelectList(_context.EstadoUsuarios, "EstadoUsuarioId", "Nombre", usuario.EstadoUsuarioId);
        //    return View(usuario);
        //}

        //// GET: Usuarios/Delete/5
        //public async Task<IActionResult> Delete(string id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var usuario = await _context.Usuarios
        //        .Include(u => u.EstadoUsuario)
        //        .FirstOrDefaultAsync(m => m.NombreUsuario == id);
        //    if (usuario == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(usuario);
        //}

        //// POST: Usuarios/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(string id)
        //{
        //    var usuario = await _context.Usuarios.FindAsync(id);
        //    _context.Usuarios.Remove(usuario);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool UsuarioExists(string id)
        //{
        //    return _context.Usuarios.Any(e => e.NombreUsuario == id);
        //}
    }
}
