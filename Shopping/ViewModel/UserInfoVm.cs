using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.ViewModel
{
    public class UserInfoVm
    {
        public List<int> ProductIDs { get; set; }
        public List<Product> Products { get; set; }
        public List<Order> Orders { get; set; }
        public List<int> ProIDs { get; set; }
        public Task<BadamUser> BadamUser { get; set; }

    }
}
