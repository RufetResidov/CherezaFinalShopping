using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.ViewModel
{
    public class IndexVm
    {
        public List<IndexSlider> IndexSliders { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> IsSaleProducts { get; set; }
        public List<Product> DiscountProducts { get; set; }
        public List<Product> IsRatingProducts { get; set; }
        public List<Product> IsNewProducts { get; set; }
        public List<Blog> Blogs { get; set; }

    }
}
