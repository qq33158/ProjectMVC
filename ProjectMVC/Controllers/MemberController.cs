using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public IActionResult Create() { 
        
            return View();
        }
        [HttpPost]
        public IActionResult Create(Member member) {
            if (ModelState.IsValid)
            {   
                _db.Members.Add(member);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }        
            return View();
        }
    }
}
