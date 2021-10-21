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
    public class ContactUserMessagesController : Controller
    {
        private readonly EcommerceContext _context;

        public ContactUserMessagesController(EcommerceContext context)
        {
            _context = context;
        }

        // GET: Admin/ContactUserMessages
        public async Task<IActionResult> Index()
        {
            return View(await _context.ContactUserMessages.ToListAsync());
        }

        // GET: Admin/ContactUserMessages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactUserMessage = await _context.ContactUserMessages
                .FirstOrDefaultAsync(m => m.ID == id);
            if (contactUserMessage == null)
            {
                return NotFound();
            }

            return View(contactUserMessage);
        }

        // GET: Admin/ContactUserMessages/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/ContactUserMessages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Fullname,Email,PhoneNumber,Message,ID,ModifiedOn")] ContactUserMessage contactUserMessage)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contactUserMessage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contactUserMessage);
        }

        // GET: Admin/ContactUserMessages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactUserMessage = await _context.ContactUserMessages.FindAsync(id);
            if (contactUserMessage == null)
            {
                return NotFound();
            }
            return View(contactUserMessage);
        }

        // POST: Admin/ContactUserMessages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Fullname,Email,PhoneNumber,Message,ID,ModifiedOn")] ContactUserMessage contactUserMessage)
        {
            if (id != contactUserMessage.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contactUserMessage);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactUserMessageExists(contactUserMessage.ID))
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
            return View(contactUserMessage);
        }

        // GET: Admin/ContactUserMessages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactUserMessage = await _context.ContactUserMessages
                .FirstOrDefaultAsync(m => m.ID == id);
            if (contactUserMessage == null)
            {
                return NotFound();
            }

            return View(contactUserMessage);
        }

        // POST: Admin/ContactUserMessages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contactUserMessage = await _context.ContactUserMessages.FindAsync(id);
            _context.ContactUserMessages.Remove(contactUserMessage);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContactUserMessageExists(int id)
        {
            return _context.ContactUserMessages.Any(e => e.ID == id);
        }
    }
}
