using Microsoft.AspNetCore.Mvc;

namespace ProjectMVC.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
