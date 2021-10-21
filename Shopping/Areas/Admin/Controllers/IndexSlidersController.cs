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
    public class IndexSlidersController : Controller
    {
        private readonly EcommerceContext _context;
        private readonly IWebHostEnvironment _environment;
        public IndexSlidersController(EcommerceContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        // GET: Admin/IndexSliders
        public async Task<IActionResult> Index()
        {
            return View(await _context.IndexSliders.ToListAsync());
        }

        // GET: Admin/IndexSliders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var indexSlider = await _context.IndexSliders
                .FirstOrDefaultAsync(m => m.ID == id);
            if (indexSlider == null)
            {
                return NotFound();
            }

            return View(indexSlider);
        }

        // GET: Admin/IndexSliders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/IndexSliders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PhotoUrl,Span1,Span2,Description,ID,ModifiedOn")] IndexSlider indexSlider,IFormFile PhotoUrl)
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
                    indexSlider.PhotoUrl = "/img/" + fileName;
                }
                _context.Add(indexSlider);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(indexSlider);
        }

        // GET: Admin/IndexSliders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var indexSlider = await _context.IndexSliders.FindAsync(id);
            if (indexSlider == null)
            {
                return NotFound();
            }
            return View(indexSlider);
        }

        // POST: Admin/IndexSliders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PhotoUrl,Span1,Span2,Description,ID,ModifiedOn")] IndexSlider indexSlider,IFormFile PhotoUrl)
        {
            if (id != indexSlider.ID)
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
                    indexSlider.PhotoUrl = "/img/" + fileName;
                }
                try
                {
                    _context.Update(indexSlider);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IndexSliderExists(indexSlider.ID))
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
            return View(indexSlider);
        }

        // GET: Admin/IndexSliders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var indexSlider = await _context.IndexSliders
                .FirstOrDefaultAsync(m => m.ID == id);
            if (indexSlider == null)
            {
                return NotFound();
            }

            return View(indexSlider);
        }

        // POST: Admin/IndexSliders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var indexSlider = await _context.IndexSliders.FindAsync(id);
            _context.IndexSliders.Remove(indexSlider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IndexSliderExists(int id)
        {
            return _context.IndexSliders.Any(e => e.ID == id);
        }
    }
}
