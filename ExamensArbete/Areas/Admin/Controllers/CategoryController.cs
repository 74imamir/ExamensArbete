using ExamensArbete.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ExamensArbete.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext db;
        public CategoryController(ApplicationDbContext _db)
        {
            db = _db;
        }


        // GET: CategoryController
        public ActionResult Index()
        {
            var list = db.categories.Include(c => c.Language);
            return View(list);
        }

        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
            ViewBag.LanguageId = new SelectList(db.languages, "Id", "Name");
            return PartialView();
        }

        // POST: CategoryController/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create(Category category)
        {
            try
            {
                db.categories.Add(category);
                db.SaveChanges();
                
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            var cat= db.categories.FirstOrDefault(c=>c.Id==id);
            ViewBag.LanguageId = new SelectList(db.languages, "Id", "Name");

            return PartialView(cat);
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id,Category category)
        {
            try
            {
                var mycat= db.categories.FirstOrDefault(c=>c.Id==id);
                mycat.Name=category.Name;
                mycat.LanguageId=category.LanguageId;
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Cate= db.categories.FirstOrDefault(a=>a.Id==id);   

            if (Cate == null)
            {
                return NotFound();
            }
            return PartialView(Cate);
        }

        // POST: CategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Category category)
        {
            try
            {
                var Cate= db.categories.Find(id);
                db.categories.Remove(Cate);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
