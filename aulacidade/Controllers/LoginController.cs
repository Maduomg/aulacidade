using Microsoft.AspNetCore.Mvc;

namespace aulacidade.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
