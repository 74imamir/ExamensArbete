//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.EntityFrameworkCore;
//using ExamensArbete.Models;

//namespace ExamensArbete.Areas.Admin.Controllers
//{
//    [Area("Admin")]
//    public class AuthorsController : Controller
//    {
//        private readonly ApplicationDbContext _context;
//        private readonly IWebHostEnvironment _he;

//        public AuthorsController(ApplicationDbContext context, IWebHostEnvironment he)
//        {
//            _context = context;
//            _he = he;
//        }

//        // GET: Admin/Authors
//        public IActionResult Index()
//        {
//           var data=_context.Authors.ToList();
//            return View("Index",data);    
//        }

//        // GET: Admin/Authors/Details/5
//        public async Task<IActionResult> Details(int? id)
//        {
//            if (id == null || _context.Authors == null)
//            {
//                return NotFound();
//            }

//            var author = await _context.Authors
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (author == null)
//            {
//                return NotFound();
//            }

//            return View(author);
//        }

//        // GET: Admin/Authors/Create
//        public IActionResult Create()
//        {
//            return View();
//        }

//        // POST: Admin/Authors/Create
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> CreateAuthors(Author author,IFormFile ImageUpload)
//        {

//            if (ImageUpload != null && ImageUpload.IsImage())
//            {
//                var guid = Guid.NewGuid().ToString();
//                var fileName = Path.Combine(_he.WebRootPath + "/images", guid + Path.GetFileName(ImageUpload.FileName));
//                ImageUpload.CopyTo(new FileStream(fileName, FileMode.Create));
//                author.ImagePath = guid + ImageUpload.FileName;

//            }

//            _context.Add(author);
//            await _context.SaveChangesAsync();
//            return RedirectToAction(nameof(Index));

//        }

//        // GET: Admin/Authors/Edit/5
//        public async Task<IActionResult> Edit(int? id)
//        {
//            if (id == null || _context.Authors == null)
//            {
//                return NotFound();
//            }

//            var author = await _context.Authors.FindAsync(id);
//            if (author == null)
//            {
//                return NotFound();
//            }
//            return View(author);
//        }

//        // POST: Admin/Authors/Edit/5
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(int id,Author author, IFormFile ImageUpload)
//        {
//            var myauthor = _context.Authors.Find(id);

//            if (id != author.Id)
//            {
//                return NotFound();
//            }

//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    if(ImageUpload!=null && ImageUpload.IsImage())
//                    {
//                        var imagePath = Path.Combine(_he.WebRootPath + "/images", myauthor.ImagePath.TrimStart('\\'));
//                        if (System.IO.File.Exists(imagePath))
//                        {
//                            System.IO.File.Delete(imagePath);
//                        }
//                    }
//                    var guid = Guid.NewGuid().ToString();
//                    var fileName = Path.Combine(_he.WebRootPath + "/images", guid + Path.GetFileName(ImageUpload.FileName));
//                    ImageUpload.CopyTo(new FileStream(fileName, FileMode.Create));
//                    myauthor.ImagePath = guid + ImageUpload.FileName;
//                    myauthor.Name = author.Name;
//                    myauthor.Address = author.Address;
//                    myauthor.lastName = author.lastName;
//                    myauthor.Phone = author.Phone;
//                    myauthor.Email = author.Email;
//                    myauthor.Facebook = author.Facebook;
//                    myauthor.Twitter = author.Twitter;

//                    await _context.SaveChangesAsync();
//                }
//                catch (DbUpdateConcurrencyException)
//                {
//                    if (!AuthorExists(author.Id))
//                    {
//                        return NotFound();
//                    }
//                    else
//                    {
//                        throw;
//                    }
//                }
//                return RedirectToAction(nameof(Index));
//            }
//            return View(author);
//        }

//        // GET: Admin/Authors/Delete/5
//        public async Task<IActionResult> Delete(int? id)
//        {
//            if (id == null || _context.Authors == null)
//            {
//                return NotFound();
//            }

//            var author = await _context.Authors
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (author == null)
//            {
//                return NotFound();
//            }

//            return View(author);
//        }

//        // POST: Admin/Authors/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(int id)
//        {
//            if (_context.Authors == null)
//            {
//                return Problem("Entity set 'ApplicationDbContext.Author'  is null.");
//            }
//            var author = await _context.Authors.FindAsync(id);
//            if (author != null)
//            {
//                _context.Authors.Remove(author);
//            }

//            await _context.SaveChangesAsync();
//            return RedirectToAction(nameof(Index));
//        }

//        private bool AuthorExists(int id)
//        {
//            return (_context.Authors?.Any(e => e.Id == id)).GetValueOrDefault();
//        }
//    }
//}





using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ExamensArbete.Models;

namespace ExamensArbete.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AuthorsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _he;

        public AuthorsController(ApplicationDbContext context, IWebHostEnvironment he)
        {
            _context = context;
            _he = he;
        }

        public IActionResult Index()
        {
            var data = _context.Authors.ToList();
            return View("Index", data);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || !_context.Authors.Any())
            {
                return NotFound();
            }

            var author = await _context.Authors.FirstOrDefaultAsync(m => m.Id == id);
            if (author == null)
            {
                return NotFound();
            }

            return PartialView(author);
        }

        public IActionResult Create()
        {
            return PartialView();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAuthors(Author author, IFormFile ImageUpload)
        {
            if (ImageUpload != null && ImageUpload.IsImage())
            {
                var guid = Guid.NewGuid().ToString();
                var fileName = Path.Combine(_he.WebRootPath, "images", guid + Path.GetFileName(ImageUpload.FileName));
                ImageUpload.CopyTo(new FileStream(fileName, FileMode.Create));
                author.ImagePath = guid + ImageUpload.FileName;// Path.Combine("images", guid + ImageUpload.FileName);
            }

            _context.Add(author);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || !_context.Authors.Any())
            {
                return NotFound();
            }

            var author = await _context.Authors.FindAsync(id);
            if (author == null)
            {
                return NotFound();
            }
            return PartialView(author);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Author author, IFormFile ImageUpload)
        {
            var myauthor = await _context.Authors.FindAsync(author.Id);

            if (myauthor == null)
            {
                return NotFound();
            }
            if (ImageUpload != null && ImageUpload.IsImage())
            {
                var imagePath = Path.Combine(_he.WebRootPath, myauthor.ImagePath.TrimStart('\\'));
                if (System.IO.File.Exists(imagePath))
                {
                    System.IO.File.Delete(imagePath);
                }

                var guid = Guid.NewGuid().ToString();
                var fileName = Path.Combine(_he.WebRootPath, "images", guid + Path.GetFileName(ImageUpload.FileName));
                ImageUpload.CopyTo(new FileStream(fileName, FileMode.Create));
                //myauthor.ImagePath = Path.Combine("images", guid + ImageUpload.FileName);
                myauthor.ImagePath = guid + ImageUpload.FileName;
                author.ImagePath = guid + ImageUpload.FileName;
            }
            if (ModelState.IsValid)
            {
                try
                {
                   

                    myauthor.Name = author.Name;
                    myauthor.Address = author.Address;
                    myauthor.lastName = author.lastName;
                    myauthor.Phone = author.Phone;
                    myauthor.Email = author.Email;
                    myauthor.Facebook = author.Facebook;
                    myauthor.Twitter = author.Twitter;

                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AuthorExists(author.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(author);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || !_context.Authors.Any())
            {
                return NotFound();
            }

            var author = await _context.Authors.FirstOrDefaultAsync(m => m.Id == id);
            if (author == null)
            {
                return NotFound();
            }

            return PartialView(author);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Authors == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Author' is null.");
            }

            var author = await _context.Authors.FindAsync(id);
            if (author != null)
            {
                _context.Authors.Remove(author);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AuthorExists(int id)
        {
            return (_context.Authors?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}









