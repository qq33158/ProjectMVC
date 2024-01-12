using Microsoft.AspNetCore.Mvc;
using ProjectMVC.Data;
using ProjectMVC.Models;

namespace ProjectMVC.Controllers
{
    public class MemberController : Controller
    {
        private readonly ApplicationDbContext _db;
        public MemberController( ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Member> objMemberList = _db.Members.ToList();
            return View(objMemberList);
        }
    }
}
