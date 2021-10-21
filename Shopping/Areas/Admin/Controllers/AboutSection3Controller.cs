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
    public class AboutSection3Controller : Controller
    {
        private readonly EcommerceContext _context;

        public AboutSection3Controller(EcommerceContext context)
        {
            _context = context;
        }

        // GET: Admin/AboutSection3
        public async Task<IActionResult> Index()
        {
            return View(await _context.AboutSection3s.ToListAsync());
        }

        // GET: Admin/AboutSection3/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aboutSection3 = await _context.AboutSection3s
                .FirstOrDefaultAsync(m => m.ID == id);
            if (aboutSection3 == null)
            {
                return NotFound();
            }

            return View(aboutSection3);
        }

        // GET: Admin/AboutSection3/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/AboutSection3/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Header,Title,Icon,ID,ModifiedOn")] AboutSection3 aboutSection3)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aboutSection3);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aboutSection3);
        }

        // GET: Admin/AboutSection3/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aboutSection3 = await _context.AboutSection3s.FindAsync(id);
            if (aboutSection3 == null)
            {
                return NotFound();
            }
            return View(aboutSection3);
        }

        // POST: Admin/AboutSection3/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Header,Title,Icon,ID,ModifiedOn")] AboutSection3 aboutSection3)
        {
            if (id != aboutSection3.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aboutSection3);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AboutSection3Exists(aboutSection3.ID))
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
            return View(aboutSection3);
        }

        // GET: Admin/AboutSection3/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aboutSection3 = await _context.AboutSection3s
                .FirstOrDefaultAsync(m => m.ID == id);
            if (aboutSection3 == null)
            {
                return NotFound();
            }

            return View(aboutSection3);
        }

        // POST: Admin/AboutSection3/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aboutSection3 = await _context.AboutSection3s.FindAsync(id);
            _context.AboutSection3s.Remove(aboutSection3);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AboutSection3Exists(int id)
        {
            return _context.AboutSection3s.Any(e => e.ID == id);
        }
    }
}
