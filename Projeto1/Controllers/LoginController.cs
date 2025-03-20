using Microsoft.AspNetCore.Mvc;

namespace Projeto1.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
