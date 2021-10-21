using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataAccess;
using Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace Shopping.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutSection2Controller : Controller
    {
        private readonly EcommerceContext _context;
        private readonly IWebHostEnvironment _environment;
        public AboutSection2Controller(EcommerceContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        // GET: Admin/AboutSection2
        public async Task<IActionResult> Index()
        {
            return View(await _context.AboutSection2s.ToListAsync());
        }

        // GET: Admin/AboutSection2/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aboutSection2 = await _context.AboutSection2s
                .FirstOrDefaultAsync(m => m.ID == id);
            if (aboutSection2 == null)
            {
                return NotFound();
            }

            return View(aboutSection2);
        }

        // GET: Admin/AboutSection2/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/AboutSection2/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Header1,Header2,Title,Photo,CountNum1,CountTitle1,CountNum2,CountTitle2,CountNum3,CountTitle3,ID,ModifiedOn")] AboutSection2 aboutSection2,IFormFile PhotoUrl)
        {
            if (ModelState.IsValid)
            {
                if (PhotoUrl != null)
                {
                    var fileName = Guid.NewGuid() + PhotoUrl.FileName;
                    var wwwFolder = Path.Combine(_environment.WebRootPath, "img");
                    var imgFolder = Path.Combine(wwwFolder, fileName);
                    using var fileStream = new FileStream(imgFolder, FileMode.Create);
                    PhotoUrl.CopyTo(fileStream);
                    aboutSection2.Photo = "/img/" + fileName;
                }
                _context.Add(aboutSection2);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aboutSection2);
        }

        // GET: Admin/AboutSection2/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aboutSection2 = await _context.AboutSection2s.FindAsync(id);
            if (aboutSection2 == null)
            {
                return NotFound();
            }
            return View(aboutSection2);
        }

        // POST: Admin/AboutSection2/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Header1,Header2,Title,Photo,CountNum1,CountTitle1,CountNum2,CountTitle2,CountNum3,CountTitle3,ID,ModifiedOn")] AboutSection2 aboutSection2,IFormFile PhotoUrl)
        {
            if (id != aboutSection2.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                if (PhotoUrl != null)
                {
                    var fileName = Guid.NewGuid() + PhotoUrl.FileName;
                    var wwwFolder = Path.Combine(_environment.WebRootPath, "img");
                    var imgFolder = Path.Combine(wwwFolder, fileName);
                    using var fileStream = new FileStream(imgFolder, FileMode.Create);
                    PhotoUrl.CopyTo(fileStream);
                    aboutSection2.Photo = "/img/" + fileName;
                }
                try
                {
                    _context.Update(aboutSection2);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AboutSection2Exists(aboutSection2.ID))
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
            return View(aboutSection2);
        }

        // GET: Admin/AboutSection2/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aboutSection2 = await _context.AboutSection2s
                .FirstOrDefaultAsync(m => m.ID == id);
            if (aboutSection2 == null)
            {
                return NotFound();
            }

            return View(aboutSection2);
        }

        // POST: Admin/AboutSection2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aboutSection2 = await _context.AboutSection2s.FindAsync(id);
            _context.AboutSection2s.Remove(aboutSection2);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AboutSection2Exists(int id)
        {
            return _context.AboutSection2s.Any(e => e.ID == id);
        }
    }
}
