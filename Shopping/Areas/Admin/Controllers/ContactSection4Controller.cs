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
    public class ContactSection4Controller : Controller
    {
        private readonly EcommerceContext _context;
        private readonly IWebHostEnvironment _environment;

        public ContactSection4Controller(EcommerceContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        // GET: Admin/ContactSection4
        public async Task<IActionResult> Index()
        {
            return View(await _context.ContactSection4s.ToListAsync());
        }

        // GET: Admin/ContactSection4/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactSection4 = await _context.ContactSection4s
                .FirstOrDefaultAsync(m => m.ID == id);
            if (contactSection4 == null)
            {
                return NotFound();
            }

            return View(contactSection4);
        }

        // GET: Admin/ContactSection4/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/ContactSection4/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PhotoUrl,ID,ModifiedOn")] ContactSection4 contactSection4,IFormFile PhotoUrl)
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
                    contactSection4.PhotoUrl = "/img/" + fileName;
                }
                _context.Add(contactSection4);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contactSection4);
        }

        // GET: Admin/ContactSection4/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactSection4 = await _context.ContactSection4s.FindAsync(id);
            if (contactSection4 == null)
            {
                return NotFound();
            }
            return View(contactSection4);
        }

        // POST: Admin/ContactSection4/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PhotoUrl,ID,ModifiedOn")] ContactSection4 contactSection4,IFormFile PhotoUrl)
        {
            if (id != contactSection4.ID)
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
                    contactSection4.PhotoUrl = "/img/" + fileName;
                }
                try
                {
                    _context.Update(contactSection4);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactSection4Exists(contactSection4.ID))
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
            return View(contactSection4);
        }

        // GET: Admin/ContactSection4/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactSection4 = await _context.ContactSection4s
                .FirstOrDefaultAsync(m => m.ID == id);
            if (contactSection4 == null)
            {
                return NotFound();
            }

            return View(contactSection4);
        }

        // POST: Admin/ContactSection4/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contactSection4 = await _context.ContactSection4s.FindAsync(id);
            _context.ContactSection4s.Remove(contactSection4);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContactSection4Exists(int id)
        {
            return _context.ContactSection4s.Any(e => e.ID == id);
        }
    }
}
