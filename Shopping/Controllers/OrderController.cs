using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Services;
using Shopping.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly ProductService _productService;
        private readonly OrderService _orderService;
        public UserManager<BadamUser> _userManager { get; set; }
        public OrderController(ProductService productService, UserManager<BadamUser> userManager, OrderService orderService)
        {
            _productService = productService;
            _userManager = userManager;
            _orderService = orderService;
        }
        public IActionResult Checkout()
        {
            string productIds = Request.Cookies[("myCart")];
            CheckoutVm vm = new();
            vm.BackImageWishCheck = _productService.GetBackImageWishlist();
            if (!string.IsNullOrEmpty(productIds))
            {
                List<int> proIds = productIds.Split("-").Select(x => int.Parse(x)).ToList();
                List<Product> productList = _productService.GetProductByIDS(proIds);

                vm.Products = productList;
                vm.ProIDs = proIds;
                vm.BadamUser = _userManager.GetUserAsync(User);
                return View(vm);

            }
            return View(vm);
        }
        [HttpPost]
        public IActionResult Checkout(string CustomerAdress,string PhoneNumber,string Message)
        {
            JsonResult res = new(new() { });
            string productIds = Request.Cookies[("myCart")];
            if (!string.IsNullOrEmpty(productIds))
            {
                List<int> proIds = productIds.Split("-").Select(x => int.Parse(x)).ToList();
                List<Product> productList = _productService.GetProductByIDS(proIds);
                var user = _userManager.GetUserAsync(User);

                Order NewOrder = new()
                {
                    CustomerID = user.Result.Id,
                    CustomerName = user.Result.FullName,
                    CustomerEmail = user.Result.Email,
                    CustomerAdress = CustomerAdress,
                    CustomerPhone = PhoneNumber,
                    OrderCode = Guid.NewGuid().ToString(),
                    PaymentMethod = 1,
                    Message = Message,
                    PlacedOn = DateTime.Now,
                    DeliveryChanges = 0
                };
                NewOrder.OrderItems = new List<OrderItem>();
                foreach (var product in productList)
                {
                    var orderItem = new OrderItem
                    {
                        ProductID = product.ID,
                        ProductName = product.Name,
                        ItemPrice = product.Price,
                        Quantity = proIds.Where(x => x == product.ID).Count(),
                        Product=product
                    };
                    NewOrder.OrderItems.Add(orderItem);
                }
                NewOrder.TotalAmount = NewOrder.OrderItems.Sum(x => ((decimal)(x.ItemPrice-x.Product.Discount) * x.Quantity));
                NewOrder.Discount = (decimal)NewOrder.OrderItems.Sum(x => x.Product.Discount * x.Quantity);
                _orderService.SaveOrder(NewOrder);
                res.Value = new
                {
                    Success = true,
                    OrderID = NewOrder.ID
                };
                Response.Cookies.Delete("myCart");
                return Json(res);
            }
            res.Value = new
            {
                Success = false
            };
            return Json(res);
        }
        public IActionResult OrderDetail(int? id)
        {
            var activeUser = _userManager.GetUserAsync(User);
            if (activeUser == null) return NotFound();
            OrderItemDetailVM vm = new()
            {
                OrderItems = _orderService.GetOrderItemsById(id, activeUser.Result.Id)
            };

            return View(vm);
        }

        public async Task<IActionResult> OrderInfo()
        {
            OrderListVM vm = new();
            var activeUser = await _userManager.GetUserAsync(User);
            vm.BackImageWishCheck = await _orderService.GetBackImageWishlistAsync();
            vm.Orders = _orderService.GetOrders(activeUser.Id);
            return View(vm);
        }

    }
}
