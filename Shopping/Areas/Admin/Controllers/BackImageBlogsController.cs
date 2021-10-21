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
    public class BackImageBlogsController : Controller
    {
        private readonly EcommerceContext _context;
        private readonly IWebHostEnvironment _environment;

        public BackImageBlogsController(EcommerceContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        // GET: Admin/BackImageBlogs
        public async Task<IActionResult> Index()
        {
            return View(await _context.BackImageBlogs.ToListAsync());
        }

        // GET: Admin/BackImageBlogs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var backImageBlog = await _context.BackImageBlogs
                .FirstOrDefaultAsync(m => m.ID == id);
            if (backImageBlog == null)
            {
                return NotFound();
            }

            return View(backImageBlog);
        }

        // GET: Admin/BackImageBlogs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/BackImageBlogs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PhotoUrl,Color,ID,ModifiedOn,IsActive")] BackImageBlog backImageBlog,IFormFile PhotoUrl)
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
                    backImageBlog.PhotoUrl = "/img/" + fileName;
                }
                _context.Add(backImageBlog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(backImageBlog);
        }

        // GET: Admin/BackImageBlogs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var backImageBlog = await _context.BackImageBlogs.FindAsync(id);
            if (backImageBlog == null)
            {
                return NotFound();
            }
            return View(backImageBlog);
        }

        // POST: Admin/BackImageBlogs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PhotoUrl,Color,ID,ModifiedOn,IsActive")] BackImageBlog backImageBlog, IFormFile PhotoUrl )
        {
            if (id != backImageBlog.ID)
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
                    backImageBlog.PhotoUrl = "/img/" + fileName;
                }
                try
                {
                    _context.Update(backImageBlog);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BackImageBlogExists(backImageBlog.ID))
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
            return View(backImageBlog);
        }

        // GET: Admin/BackImageBlogs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var backImageBlog = await _context.BackImageBlogs
                .FirstOrDefaultAsync(m => m.ID == id);
            if (backImageBlog == null)
            {
                return NotFound();
            }

            return View(backImageBlog);
        }

        // POST: Admin/BackImageBlogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var backImageBlog = await _context.BackImageBlogs.FindAsync(id);
            _context.BackImageBlogs.Remove(backImageBlog);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BackImageBlogExists(int id)
        {
            return _context.BackImageBlogs.Any(e => e.ID == id);
        }
    }
}
