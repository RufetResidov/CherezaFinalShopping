using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.ViewModel
{
    public class OrderItemDetailVM
    {
        public List<OrderItem> OrderItems { get; set; }
        public Order Order { get; set; }
    }
}
