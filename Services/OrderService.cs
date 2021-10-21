using DataAccess;
using Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class OrderService
    {
        private readonly EcommerceContext _context;
        private readonly UserManager<BadamUser> _userManager;
        public OrderService(EcommerceContext context, UserManager<BadamUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public void SaveOrder(Order order)
        {
            _context.Add(order);
            _context.SaveChanges();
        }
        public List<Order> GetOrders(string userId)
        {
            
            return _context.Orders.Where(x=>x.CustomerID== userId).Include(x=>x.OrderHistory).OrderByDescending(x=>x.PlacedOn).ToList();
        }
        public async Task<BackImageWishCheck> GetBackImageWishlistAsync()
        {
            return await _context.BackImageWishChecks.FirstOrDefaultAsync();
        }

        public List<OrderItem> GetOrderItemsById(int? id,string userId)
        {
            return _context.OrderItems.Include(x=>x.Order).Where(x => x.OrderID == id && x.Order.CustomerID==userId).ToList();
        }
    }
}
