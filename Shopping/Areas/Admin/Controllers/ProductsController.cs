using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataAccess;
using Entities;
using Services;
using Shopping.Areas.Admin.ViewModels;

namespace Shopping.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductsController : Controller
    {
        private readonly EcommerceContext _context;
        private readonly ProductService _productService;

        public ProductsController(EcommerceContext context, ProductService productService)
        {
            _context = context;
            _productService = productService;
        }

        // GET: Admin/Products
        public IActionResult Index()
        {
            return View(_productService.GetProducts());
        }

        // GET: Admin/Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Admin/Products/Create
        public IActionResult Create()
        {
            ViewData["CategoryID"] = new SelectList(_context.Categories, "ID", "Name");
            return View();
        }

        // POST: Admin/Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( ProductCreateVM product)
        {
            JsonResult res = new(new() { });
              
            if (ModelState.IsValid)
            {
                Product newProduct = new();
                newProduct.Name = product.Name;
                newProduct.Price = product.Price;
                newProduct.Description = product.Description;
                newProduct.CategoryID = product.CategoryID;
                newProduct.Discount = product.Discount??0;
                newProduct.IsActive = product.IsActive;
                newProduct.isFeatured = product.IsFeatured;
                newProduct.isNew = product.IsNew;
                newProduct.isRating = product.IsRating;
                newProduct.isSale = product.IsSale;
                newProduct.ModifiedOn = DateTime.Now;
                newProduct.Barcode = product.Barcode;
                newProduct.Supplier = product.Supplier;

                if (product.ProductPicturesIds != null && product.ProductPicturesIds.Length > 0)
                {
                    newProduct.ProductPictures = new List<ProductPicture>();
                    List<int> productPicturesIds = product.ProductPicturesIds.Split(',').Select(x => int.Parse(x)).ToList();
                    newProduct.ProductPictures.AddRange(productPicturesIds.Select(picId => new ProductPicture() {PictureID=picId,ProductID=newProduct.ID}));
                    newProduct.ThumbnailPictureID = (int)(product.ThumbnailPictureID == null ? newProduct.ProductPictures[0].PictureID : product.ThumbnailPictureID);
                }
                _context.Add(newProduct);
                await _context.SaveChangesAsync();
                res.Value = new
                {
                    Success = true
                };
                return Json(res);
            }
            ViewData["CategoryID"] = new SelectList(_context.Categories, "ID", "Name", product.CategoryID);
            res.Value = new
            {
                Success = false
            };
            return Json(res);
        }

        // GET: Admin/Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.Include(x=>x.ProductPictures).ThenInclude(x=>x.Picture).FirstOrDefaultAsync(x=>x.ID==id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["CategoryID"] = new SelectList(_context.Categories, "ID", "Name", product.CategoryID);
            return View(product);
        }

        // POST: Admin/Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        public void UpdateProductPictures(int? Id,List<ProductPicture> newProductPictures)
        {
            var oldPicture = _context.ProductPictures.Where(x => x.ProductID == Id).ToList();
            _context.ProductPictures.RemoveRange(oldPicture);
            _context.ProductPictures.AddRange(newProductPictures);
            _context.SaveChanges();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit( int id, Product product,string ProductPicturesIds)
        {
            if (id != product.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (ProductPicturesIds != null && ProductPicturesIds.Length > 0)
                    {
                        List<ProductPicture> ProductPictureList = new List<ProductPicture>();
                        List<int> productPicturesIds = ProductPicturesIds.Split(',').Select(x => int.Parse(x)).ToList();
                        ProductPictureList.AddRange(productPicturesIds.Select(picId => new ProductPicture() { PictureID = picId, ProductID = product.ID }));
                        UpdateProductPictures(product.ID, ProductPictureList);
                        product.ThumbnailPictureID = (int)(product.ThumbnailPictureID == null ? ProductPictureList.FirstOrDefault().PictureID : product.ThumbnailPictureID);
                    }

                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ID))
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
            ViewData["CategoryID"] = new SelectList(_context.Categories, "ID", "Name", product.CategoryID);
            return View(product);
        }

        // GET: Admin/Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Admin/Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ID == id);
        }
    }
}
