using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class ProductService
    {
        private readonly EcommerceContext _context;

        public ProductService(EcommerceContext context)
        {
            _context = context;
        }
        public BackImageProduct GetBackImageProduct()
        {
            return _context.BackImageProducts.FirstOrDefault();
        }
        public List<Product> GetSaleProducts()
        {
            return _context.Products.Include("ProductPictures.Picture").Where(x => x.isSale).OrderByDescending(x => x.ID).Take(8).ToList();
        }
        public List<Product> GetRatingProducts()
        {
            return _context.Products.Include("ProductPictures.Picture").Where(x => x.isRating).OrderByDescending(x => x.ID).Take(8).ToList();
        }
        public List<Product> GetDiscountProducts()
        {
            return _context.Products.Include("ProductPictures.Picture").Where(x => x.Discount > 0 && x.Discount != null).OrderByDescending(x => x.ID).Take(8).ToList();
        }
        public List<Product> GetNewProducts()
        {
            return _context.Products.Include("ProductPictures.Picture").Where(x => x.isNew).ToList();
        }
        public List<Product> SearchedProductsByTag(int? TagId)
        {
            if (TagId.HasValue)
            {
                return _context.Products.Include("ProductPictures.Picture").Where(x => x.ProductToTags.Any(x => x.TagId == TagId)).ToList();

            }
            return _context.Products.Include("ProductPictures.Picture").ToList();
        }
        public List<Product> GetProducts()
        {
            return _context.Products.Include(x => x.Category).Include("ProductPictures.Picture").ToList();
        }
        public Product GetProductByID(int? id)
        {
            return _context.Products.Include("ProductPictures.Picture").FirstOrDefault(x => x.ID == id);
        }
        public List<Product> GetFeaturedProducts(int id)
        {
            return _context.Products.Where(x => x.isFeatured && x.ID != id && x.IsActive).OrderByDescending(x => x.ID)
                .Include("ProductPictures.Picture").ToList();
        }
        public List<Product> GetSameCategoryProducts(int id)
        {
            var selectedProduct = GetProductByID(id);
            return _context.Products.Include("ProductPictures.Picture").OrderByDescending(x => x.ID)
                .Where(x => x.ID != id && x.IsActive && x.CategoryID == selectedProduct.CategoryID).ToList();
        }
        public List<Product> GetProductByIDS(List<int> ids)
        {
            return _context.Products.Where(x =>x.IsActive &&  ids.Contains(x.ID)).Include("ProductPictures.Picture").ToList();
        }
        public List<Product> SearchProduct(int? id, int? sortBy, string search, int? tagId, int? from, int? to,int? pageNo, int recordSize, out int count)
        {
            var productList = _context.Products.Where(x=>x.IsActive).AsQueryable();
            if (id.HasValue)
            {
                productList = productList.Where(x => x.CategoryID == id);
            }
           
            if (!string.IsNullOrWhiteSpace(search))
            {
                productList = productList.Where(x => x.Name.StartsWith(search));
            }
            if(from.HasValue && to.HasValue)
            {
                productList = productList.Where(x => x.Price > from && x.Price < to);
            }
            if (sortBy.HasValue)
            {
                productList = sortBy switch
                {
                    1 => productList.OrderByDescending(x => x.Price),
                    2 => productList.OrderBy(x => x.Price),
                    3 => productList.OrderByDescending(x => x.Name),
                    _ => productList.OrderBy(x => x.Name),
                };
            }
            count = productList.Count();
            pageNo ??= 1;
            var skipCount = (pageNo.Value- 1) * recordSize;
            if (tagId.HasValue)
            {
                productList = productList.Where(x => x.ProductToTags.Any(x => x.TagId == tagId));
            }
            return productList.Include("ProductPictures.Picture").Skip(skipCount).Take(recordSize).ToList();
        }
        public int SearchProductCount()
        {
            var productList = _context.Products.AsQueryable();
            return productList.Count();
        }

        //public Product SearchProductTag()
        //{
        //    return _context.Products.Include("ProductPictures.Picture").ToList();
        //}
        public int GetProductPrice(int ? id)
        {
            var productList = _context.Products.AsQueryable();
            if (id.HasValue) 
            {
                productList = productList.Where(x => x.CategoryID == id);
            }
            return (int)productList.Max(x=>(x.Price-x.Discount));
        }

        public BackImageWishCheck GetBackImageWishlist()
        {
            return _context.BackImageWishChecks.FirstOrDefault();
        }

    }
}
