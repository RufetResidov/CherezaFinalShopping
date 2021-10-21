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
    public class SocialInfoesController : Controller
    {
        private readonly EcommerceContext _context;

        public SocialInfoesController(EcommerceContext context)
        {
            _context = context;
        }

        // GET: Admin/SocialInfoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.SocialInfos.ToListAsync());
        }

        // GET: Admin/SocialInfoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var socialInfo = await _context.SocialInfos
                .FirstOrDefaultAsync(m => m.ID == id);
            if (socialInfo == null)
            {
                return NotFound();
            }

            return View(socialInfo);
        }

        // GET: Admin/SocialInfoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/SocialInfoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FaceLink,InstLink,WhatsappLink,PhoneFaceLink,EmailFaceLink,ID,ModifiedOn,IsActive")] SocialInfo socialInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(socialInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(socialInfo);
        }

        // GET: Admin/SocialInfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var socialInfo = await _context.SocialInfos.FindAsync(id);
            if (socialInfo == null)
            {
                return NotFound();
            }
            return View(socialInfo);
        }

        // POST: Admin/SocialInfoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FaceLink,InstLink,WhatsappLink,PhoneFaceLink,EmailFaceLink,ID,ModifiedOn,IsActive")] SocialInfo socialInfo)
        {
            if (id != socialInfo.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(socialInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SocialInfoExists(socialInfo.ID))
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
            return View(socialInfo);
        }

        // GET: Admin/SocialInfoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var socialInfo = await _context.SocialInfos
                .FirstOrDefaultAsync(m => m.ID == id);
            if (socialInfo == null)
            {
                return NotFound();
            }

            return View(socialInfo);
        }

        // POST: Admin/SocialInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var socialInfo = await _context.SocialInfos.FindAsync(id);
            _context.SocialInfos.Remove(socialInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SocialInfoExists(int id)
        {
            return _context.SocialInfos.Any(e => e.ID == id);
        }
    }
}
