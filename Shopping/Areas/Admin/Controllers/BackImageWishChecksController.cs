using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataAccess;
using Entities;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace Shopping.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BackImageWishChecksController : Controller
    {
        private readonly EcommerceContext _context;
        private readonly IWebHostEnvironment _environment;
        public BackImageWishChecksController(EcommerceContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        // GET: Admin/BackImageWishChecks
        public async Task<IActionResult> Index()
        {
            return View(await _context.BackImageWishChecks.ToListAsync());
        }

        // GET: Admin/BackImageWishChecks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var backImageWishCheck = await _context.BackImageWishChecks
                .FirstOrDefaultAsync(m => m.ID == id);
            if (backImageWishCheck == null)
            {
                return NotFound();
            }

            return View(backImageWishCheck);
        }

        // GET: Admin/BackImageWishChecks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/BackImageWishChecks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PhotoUrl,Color,ID,ModifiedOn,IsActive")] BackImageWishCheck backImageWishCheck,IFormFile PhotoUrl)
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
                    backImageWishCheck.PhotoUrl = "/img/" + fileName;
                }
                _context.Add(backImageWishCheck);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(backImageWishCheck);
        }

        // GET: Admin/BackImageWishChecks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var backImageWishCheck = await _context.BackImageWishChecks.FindAsync(id);
            if (backImageWishCheck == null)
            {
                return NotFound();
            }
            return View(backImageWishCheck);
        }

        // POST: Admin/BackImageWishChecks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PhotoUrl,Color,ID,ModifiedOn,IsActive")] BackImageWishCheck backImageWishCheck,IFormFile PhotoUrl)
        {
            if (id != backImageWishCheck.ID)
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
                    backImageWishCheck.PhotoUrl = "/img/" + fileName;
                }
                try
                {
                    _context.Update(backImageWishCheck);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BackImageWishCheckExists(backImageWishCheck.ID))
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
            return View(backImageWishCheck);
        }

        // GET: Admin/BackImageWishChecks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var backImageWishCheck = await _context.BackImageWishChecks
                .FirstOrDefaultAsync(m => m.ID == id);
            if (backImageWishCheck == null)
            {
                return NotFound();
            }

            return View(backImageWishCheck);
        }

        // POST: Admin/BackImageWishChecks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var backImageWishCheck = await _context.BackImageWishChecks.FindAsync(id);
            _context.BackImageWishChecks.Remove(backImageWishCheck);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BackImageWishCheckExists(int id)
        {
            return _context.BackImageWishChecks.Any(e => e.ID == id);
        }
    }
}
