using Microsoft.AspNetCore.Mvc;
using Projeto1.Views.Home.Repositorio;

namespace Projeto1.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string email, string senha)
        {
            var usuario = _usuarioRepositorio.ObterUsuario(email);
            if (usuario != null && usuario.Senha = senha)
            {
                //Autenticação bem-sucedida
                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("", "Email ou senha inválidos.");
            return View();
        }
    }
}

