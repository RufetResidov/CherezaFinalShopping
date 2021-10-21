using Entities;
using Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.ViewModel
{
    public class ShopVm
    {
        public int? CategoryID { get; set; }
        public int? SortBy { get; set; }
        public int SearchProductCount { get; set; }
        public List<Product> SearchProduct { get; set; }
        public List<Category> Categories { get; set; }
        public BackImageProduct BackImageProduct { get; set; }
        public int? TotalProductCount { get; set; }
        public decimal? maxProductPrice { get; set; }
        public int? minPrice { get; set; }
        public int? maxPrice { get; set; }
        public List<Product> ProductTags { get; set; }
        public Pager Pager { get; set; }
        public int? PageNo { get; set; }
        public int? PageSize { get; set; }
        public int? TagId{ get; set; }
        public List<Tag> myTagList{ get; set; }


    }
}
