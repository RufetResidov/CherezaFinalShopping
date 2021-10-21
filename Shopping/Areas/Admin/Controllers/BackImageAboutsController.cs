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
    public class BackImageAboutsController : Controller
    {
        private readonly EcommerceContext _context;
        private readonly IWebHostEnvironment _environment;

        public BackImageAboutsController(EcommerceContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        // GET: Admin/BackImageAbouts
        public async Task<IActionResult> Index()
        {
            return View(await _context.BackImageAbouts.ToListAsync());
        }

        // GET: Admin/BackImageAbouts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var backImageAbout = await _context.BackImageAbouts
                .FirstOrDefaultAsync(m => m.ID == id);
            if (backImageAbout == null)
            {
                return NotFound();
            }

            return View(backImageAbout);
        }

        // GET: Admin/BackImageAbouts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/BackImageAbouts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PhotoUrl,Color,ID,ModifiedOn")] BackImageAbout backImageAbout,IFormFile PhotoUrl)
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
                    backImageAbout.PhotoUrl = "/img/" + fileName;
                }
                _context.Add(backImageAbout);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(backImageAbout);
        }

        // GET: Admin/BackImageAbouts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var backImageAbout = await _context.BackImageAbouts.FindAsync(id);
            if (backImageAbout == null)
            {
                return NotFound();
            }
            return View(backImageAbout);
        }

        // POST: Admin/BackImageAbouts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PhotoUrl,Color,ID,ModifiedOn")] BackImageAbout backImageAbout,IFormFile PhotoUrl)
        {
            if (id != backImageAbout.ID)
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
                    backImageAbout.PhotoUrl = "/img/" + fileName;
                }
                try
                {
                    _context.Update(backImageAbout);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BackImageAboutExists(backImageAbout.ID))
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
            return View(backImageAbout);
        }

        // GET: Admin/BackImageAbouts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var backImageAbout = await _context.BackImageAbouts
                .FirstOrDefaultAsync(m => m.ID == id);
            if (backImageAbout == null)
            {
                return NotFound();
            }

            return View(backImageAbout);
        }

        // POST: Admin/BackImageAbouts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var backImageAbout = await _context.BackImageAbouts.FindAsync(id);
            _context.BackImageAbouts.Remove(backImageAbout);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BackImageAboutExists(int id)
        {
            return _context.BackImageAbouts.Any(e => e.ID == id);
        }
    }
}
