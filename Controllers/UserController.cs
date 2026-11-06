using Microsoft.AspNetCore.Mvc;

namespace CProject1.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
