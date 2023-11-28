using ExamensArbete.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExamensArbete.Controllers
{
    public class SimpleController : Controller
    {
        private readonly ApplicationDbContext db;

        public SimpleController(ApplicationDbContext _db)
        {
            db = _db;
        }




        public IActionResult Index()
        {
            return View(db.People);
        }

        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
       
        public IActionResult Create(Person person) 
        { 
            db.People.Add(person);
            db.SaveChanges();
            
            return RedirectToAction("Index");
        }
        
        public IActionResult Delete(int id)
        {
            var person = db.People.Find(id);
            db.People.Remove(person);
            db.SaveChanges();

            
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var person = db.People.Find(id);
            return View(person);


        }
        [HttpPost]
        public IActionResult Edit(Person person)
        {
            db.People.Update(person);
            db.SaveChanges();

            
            return RedirectToAction("Index");
        }
    }
}
