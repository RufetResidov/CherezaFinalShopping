using Entities;
using Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.ViewModel
{
    public class ProductVm
    {
        public BackImageProduct BackImageProduct { get; set; }
        public Product SingleProduct { get; set; }
        public List<Product> Products { get; set; }
        public int? Quantity { get; set; }
        public List<Product> SameProducts { get; set; }
        public List<Product> FeaturedProducts { get; set; }
        public List<Category> IsFeaturedCategories { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> SearchProduct { get; set; }
        public int SearchProductCount { get; set; }
        public int? CategoryID { get; set; }
        public Pager Pager { get; set; }
        public int? PageNo { get; set; }
        public int? PageSize { get; set; }

    }
}
