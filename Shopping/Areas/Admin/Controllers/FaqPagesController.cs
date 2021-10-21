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
    public class FaqPagesController : Controller
    {
        private readonly EcommerceContext _context;

        public FaqPagesController(EcommerceContext context)
        {
            _context = context;
        }

        // GET: Admin/FaqPages
        public async Task<IActionResult> Index()
        {
            return View(await _context.FaqPages.ToListAsync());
        }

        // GET: Admin/FaqPages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var faqPage = await _context.FaqPages
                .FirstOrDefaultAsync(m => m.ID == id);
            if (faqPage == null)
            {
                return NotFound();
            }

            return View(faqPage);
        }

        // GET: Admin/FaqPages/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/FaqPages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Header,Title,ID,ModifiedOn")] FaqPage faqPage)
        {
            if (ModelState.IsValid)
            {
                _context.Add(faqPage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(faqPage);
        }

        // GET: Admin/FaqPages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var faqPage = await _context.FaqPages.FindAsync(id);
            if (faqPage == null)
            {
                return NotFound();
            }
            return View(faqPage);
        }

        // POST: Admin/FaqPages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Header,Title,ID,ModifiedOn")] FaqPage faqPage)
        {
            if (id != faqPage.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(faqPage);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FaqPageExists(faqPage.ID))
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
            return View(faqPage);
        }

        // GET: Admin/FaqPages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var faqPage = await _context.FaqPages
                .FirstOrDefaultAsync(m => m.ID == id);
            if (faqPage == null)
            {
                return NotFound();
            }

            return View(faqPage);
        }

        // POST: Admin/FaqPages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var faqPage = await _context.FaqPages.FindAsync(id);
            _context.FaqPages.Remove(faqPage);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FaqPageExists(int id)
        {
            return _context.FaqPages.Any(e => e.ID == id);
        }
    }
}
