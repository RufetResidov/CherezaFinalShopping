using Entities;
using Shopping.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Furn.Controllers
{
    public class SharedController : Controller
    {
        private readonly ProductService _productService;

        public SharedController(ProductService productService)
        {
            _productService = productService;
        }

        public IActionResult GetCartProduct()
        {
            string productIds = Request.Cookies[("myCart")];
            if (!string.IsNullOrEmpty(productIds))
            {
                List<int> proIds = productIds.Split("-").Select(x => int.Parse(x)).ToList();
                List<Product> productList = _productService.GetProductByIDS(proIds);

                CartVM vm = new()
                {
                    Products = productList,
                    ProIDs = proIds,
                };
                return PartialView("_CartPopup",vm);
            }
            return PartialView("_CartPopup");

        }
        public IActionResult GetWishlistProduct()
        {
         
            return PartialView("_WishPopUp");

        }
    }
}
