using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectMVC.Data;
using ProjectMVC.Models;

namespace ProjectMVC.Controllers
{
    public class MemberController : Controller
    {
        private readonly ApplicationDbContext _db;
        public MemberController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Member> objMemberList = _db.Members.ToList();
            return View(objMemberList);
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Member member)
        {
            if (ModelState.IsValid)
            {
                _db.Members.Add(member);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int? id)
        {
            Member? memberFormDb = _db.Members.Find(id);
            if (memberFormDb == null)
            {
                return NotFound();
            }
            return View(memberFormDb);
        }
        [HttpPost]
        public IActionResult Edit(Member member)
        {
            if (ModelState.IsValid)
            {
                _db.Members.Update(member);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int? id)
        {
            Member? memberFormDb = _db.Members.Find(id);
            if (memberFormDb == null)
            {
                return NotFound();
            }
            return View(memberFormDb);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Member? memberFormDb = _db.Members.Find(id);
            if (memberFormDb == null)
            {
                return NotFound();
            }

            _db.Members.Remove(memberFormDb);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
