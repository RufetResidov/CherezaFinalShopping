using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.ViewModel
{
    public class OrderCheckoutVm
    {
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string CustomerAddress { get; set; }
        public string Message { get; set; }
        public List<int> ProductIDs { get; set; }
        public List<Product> Products { get; set; }
    }
}
