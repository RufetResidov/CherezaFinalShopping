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
using System.IO;
using Microsoft.AspNetCore.Http;

namespace Shopping.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BackImageProductsController : Controller
    {
        private readonly EcommerceContext _context;
        private readonly IWebHostEnvironment _environment;
        public BackImageProductsController(EcommerceContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        // GET: Admin/BackImageProducts
        public async Task<IActionResult> Index()
        {
            return View(await _context.BackImageProducts.ToListAsync());
        }

        // GET: Admin/BackImageProducts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var backImageProduct = await _context.BackImageProducts
                .FirstOrDefaultAsync(m => m.ID == id);
            if (backImageProduct == null)
            {
                return NotFound();
            }

            return View(backImageProduct);
        }

        // GET: Admin/BackImageProducts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/BackImageProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PhotoUrl,Color,ID,ModifiedOn,IsActive")] BackImageProduct backImageProduct,IFormFile PhotoUrl)
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
                    backImageProduct.PhotoUrl = "/img/" + fileName;
                }
                _context.Add(backImageProduct);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(backImageProduct);
        }

        // GET: Admin/BackImageProducts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var backImageProduct = await _context.BackImageProducts.FindAsync(id);
            if (backImageProduct == null)
            {
                return NotFound();
            }
            return View(backImageProduct);
        }

        // POST: Admin/BackImageProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PhotoUrl,Color,ID,ModifiedOn,IsActive")] BackImageProduct backImageProduct,IFormFile PhotoUrl)
        {
            if (id != backImageProduct.ID)
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
                    backImageProduct.PhotoUrl = "/img/" + fileName;
                }
                try
                {
                    _context.Update(backImageProduct);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BackImageProductExists(backImageProduct.ID))
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
            return View(backImageProduct);
        }

        // GET: Admin/BackImageProducts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var backImageProduct = await _context.BackImageProducts
                .FirstOrDefaultAsync(m => m.ID == id);
            if (backImageProduct == null)
            {
                return NotFound();
            }

            return View(backImageProduct);
        }

        // POST: Admin/BackImageProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var backImageProduct = await _context.BackImageProducts.FindAsync(id);
            _context.BackImageProducts.Remove(backImageProduct);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BackImageProductExists(int id)
        {
            return _context.BackImageProducts.Any(e => e.ID == id);
        }
    }
}
