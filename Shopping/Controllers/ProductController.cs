using Entities;
using Helpers;
using Microsoft.AspNetCore.Mvc;
using Service;
using Services;
using Shopping.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _productService;
        private readonly IndexService _indexService;
        private readonly CategoryService _categoryService;
        private readonly TagService _tagService;
        public ProductController(ProductService productService, IndexService indexService, CategoryService categoryService, TagService tagService)
        {
            _productService = productService;
            _indexService = indexService;
            _categoryService = categoryService;
            _tagService = tagService;
        }

        public IActionResult PopModelMenu(int? id)
        {
            var productDetail = _productService.GetProductByID(id.Value);
            return PartialView("_ProductPopup", productDetail);
        }
        public IActionResult SingleProduct(int? id)
        {
            if (id == null) return NotFound();
            string productIds = Request.Cookies[("myCart")];
     
            ProductVm Pvm = new()
            {
                BackImageProduct = _productService.GetBackImageProduct(),
                SingleProduct = _productService.GetProductByID(id.Value),
                SameProducts = _productService.GetSameCategoryProducts(id.Value),
                FeaturedProducts = _productService.GetFeaturedProducts(id.Value),
            
            };
            if (!string.IsNullOrEmpty(productIds))
            {
                int quantity = productIds.Split("-").Select(x => int.Parse(x)).Where(x=>x==id).ToList().Count;
                Pvm.Quantity = quantity;
            }
            return View(Pvm);
        }
        public IActionResult Shop(int? id, int? sortBy, string search, int? tagId, int? from, int? to, int? pageNo=1,  int? recordSize=6)
        {
            recordSize ??= 6;
            ShopVm Svm = new()
            {
               
                SearchProductCount = _productService.SearchProductCount(),
                SearchProduct = _productService.SearchProduct(id, sortBy, search, tagId,from, to,  pageNo,recordSize.Value,out int count),
                CategoryID = id,    
                SortBy = sortBy,
                BackImageProduct = _productService.GetBackImageProduct(),
                Categories = _categoryService.GetCategories(),
                TotalProductCount = _productService.SearchProductCount(),
                maxProductPrice = _productService.GetProductPrice(id),
                minPrice = from,
                maxPrice = to,
                PageSize=recordSize,
                PageNo=pageNo,
                TagId=tagId,
                myTagList=_tagService.GetTagNames()
            };
            Svm.Pager = new Pager(count, pageNo, recordSize.Value);
            return View(Svm);
        }
        public IActionResult Wishlist()
        {
            string productIds = Request.Cookies["wishCart"];
            WishlistVm Vvm = new();
            Vvm.BackImageWishCheck = _productService.GetBackImageWishlist();

            if (!string.IsNullOrEmpty(productIds))
            {
                List<int> proIds = productIds.Split("-").Select(x => int.Parse(x)).ToList();
                List<Product> productList = _productService.GetProductByIDS(proIds);
                Vvm.Products = productList;
                Vvm.ProIDs = proIds;
                return View(Vvm);
            }
         
            return View(Vvm);
        }


    }
}
