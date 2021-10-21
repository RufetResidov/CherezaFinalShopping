using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.ViewModel
{
    public class WishlistVm
    {
        public BackImageWishCheck BackImageWishCheck { get; set; }
        public List<Product> WishlistProduct { get; set; }
        public List<Product> Products { get; set; }
        public List<int> ProIDs { get; set; }

    }
}
