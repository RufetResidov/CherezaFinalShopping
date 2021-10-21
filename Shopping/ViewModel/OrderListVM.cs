using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.ViewModel
{
    public class OrderListVM
    {
        public List<Order> Orders { get; set; }
        public BackImageWishCheck BackImageWishCheck { get; set; }

    }
}
