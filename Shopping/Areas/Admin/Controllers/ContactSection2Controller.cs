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
    public class ContactSection2Controller : Controller
    {
        private readonly EcommerceContext _context;

        public ContactSection2Controller(EcommerceContext context)
        {
            _context = context;
        }

        // GET: Admin/ContactSection2
        public async Task<IActionResult> Index()
        {
            return View(await _context.ContactSection2s.ToListAsync());
        }

        // GET: Admin/ContactSection2/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactSection2 = await _context.ContactSection2s
                .FirstOrDefaultAsync(m => m.ID == id);
            if (contactSection2 == null)
            {
                return NotFound();
            }

            return View(contactSection2);
        }

        // GET: Admin/ContactSection2/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/ContactSection2/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Header,Title,Icon,ID,ModifiedOn")] ContactSection2 contactSection2)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contactSection2);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contactSection2);
        }

        // GET: Admin/ContactSection2/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactSection2 = await _context.ContactSection2s.FindAsync(id);
            if (contactSection2 == null)
            {
                return NotFound();
            }
            return View(contactSection2);
        }

        // POST: Admin/ContactSection2/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Header,Title,Icon,ID,ModifiedOn")] ContactSection2 contactSection2)
        {
            if (id != contactSection2.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contactSection2);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactSection2Exists(contactSection2.ID))
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
            return View(contactSection2);
        }

        // GET: Admin/ContactSection2/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactSection2 = await _context.ContactSection2s
                .FirstOrDefaultAsync(m => m.ID == id);
            if (contactSection2 == null)
            {
                return NotFound();
            }

            return View(contactSection2);
        }

        // POST: Admin/ContactSection2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contactSection2 = await _context.ContactSection2s.FindAsync(id);
            _context.ContactSection2s.Remove(contactSection2);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContactSection2Exists(int id)
        {
            return _context.ContactSection2s.Any(e => e.ID == id);
        }
    }
}
