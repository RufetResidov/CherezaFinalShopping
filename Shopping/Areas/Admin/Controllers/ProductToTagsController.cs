using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataAccess;
using Entities;

namespace Shopping.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductToTagsController : Controller
    {
        private readonly EcommerceContext _context;

        public ProductToTagsController(EcommerceContext context)
        {
            _context = context;
        }

        // GET: Admin/ProductToTags
        public async Task<IActionResult> Index()
        {
            var ecommerceContext = _context.ProductToTags.Include(p => p.Product).Include(p => p.myTag);
            return View(await ecommerceContext.ToListAsync());
        }

        // GET: Admin/ProductToTags/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productToTag = await _context.ProductToTags
                .Include(p => p.Product)
                .Include(p => p.myTag)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (productToTag == null)
            {
                return NotFound();
            }

            return View(productToTag);
        }

        // GET: Admin/ProductToTags/Create
        public IActionResult Create()
        {
            ViewData["ProductId"] = new SelectList(_context.Products, "ID", "Name");
            ViewData["TagId"] = new SelectList(_context.myTags, "ID", "Name");
            return View();
        }

        // POST: Admin/ProductToTags/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductId,TagId,ID,ModifiedOn,IsActive")] ProductToTag productToTag)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productToTag);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "ID", "Name", productToTag.ProductId);
            ViewData["TagId"] = new SelectList(_context.myTags, "ID", "ID", productToTag.TagId);
            return View(productToTag);
        }

        // GET: Admin/ProductToTags/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productToTag = await _context.ProductToTags.FindAsync(id);
            if (productToTag == null)
            {
                return NotFound();
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "ID", "Name", productToTag.ProductId);
            ViewData["TagId"] = new SelectList(_context.myTags, "ID", "ID", productToTag.TagId);
            return View(productToTag);
        }

        // POST: Admin/ProductToTags/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductId,TagId,ID,ModifiedOn,IsActive")] ProductToTag productToTag)
        {
            if (id != productToTag.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productToTag);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductToTagExists(productToTag.ID))
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
            ViewData["ProductId"] = new SelectList(_context.Products, "ID", "Name", productToTag.ProductId);
            ViewData["TagId"] = new SelectList(_context.myTags, "ID", "ID", productToTag.TagId);
            return View(productToTag);
        }

        // GET: Admin/ProductToTags/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productToTag = await _context.ProductToTags
                .Include(p => p.Product)
                .Include(p => p.myTag)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (productToTag == null)
            {
                return NotFound();
            }

            return View(productToTag);
        }

        // POST: Admin/ProductToTags/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productToTag = await _context.ProductToTags.FindAsync(id);
            _context.ProductToTags.Remove(productToTag);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductToTagExists(int id)
        {
            return _context.ProductToTags.Any(e => e.ID == id);
        }
    }
}
