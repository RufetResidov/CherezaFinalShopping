using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Service;
using Services;
using Shopping.Models;
using Shopping.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IndexService _indexService;
        private readonly ProductService _productService;
        private readonly CategoryService _categoryService;
        private readonly BlogService _blogService;
        private readonly ContactService _contactService;
        public HomeController(ILogger<HomeController> logger, BlogService blogService, IndexService indexService, ProductService productService, CategoryService categoryService, ContactService contactService)
        {
            _logger = logger;
            _blogService = blogService;
            _indexService = indexService;
            _productService = productService;
            _categoryService = categoryService;
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            IndexVm Ivm = new()
            {
                IndexSliders = _indexService.GetIndexSlider(),
                Categories=_categoryService.GetCategories(),
                IsSaleProducts=_productService.GetSaleProducts(),
                DiscountProducts=_productService.GetDiscountProducts(),
                IsRatingProducts=_productService.GetRatingProducts(),
                IsNewProducts=_productService.GetNewProducts(),
                Blogs=_blogService.GetBlog()
            };
            return View(Ivm);
        }

        public IActionResult About()
        {
            AboutVm Avm = new()
            {
                BackImageAbout=_indexService.GetBackImageAbout(),
                AboutSection2=_indexService.GetAbout2(),
                AboutSection3s=_indexService.GetAbout3()
            };
            return View(Avm);
        }
        public IActionResult Contact()
        {
            ContactVm Cvm = new()
            {
                BackImageAbout = _indexService.GetBackImageAbout(),
                ContactSection2s = _indexService.GetContact2(),
                ContactSection4 = _indexService.GetContact4()
            };
            return View(Cvm);
        }
        [HttpPost]
        public IActionResult Contact(ContactVm vm)
        {

            if (!ModelState.IsValid)
            {
                return View(vm);
            }
            ContactUserMessage user = new()
            {
                Fullname = vm.Fullname,
                Email = vm.Email,
                PhoneNumber = vm.PhoneNumber,
                Message = vm.Message
            };
            vm.BackImageAbout = _indexService.GetBackImageAbout();
            vm.ContactSection2s = _indexService.GetContact2();
            vm.ContactSection4 = _indexService.GetContact4();
            _contactService.SaveContactMessage(user);
            TempData["Success"] = "Mesaj göndərdiyiniz üçün təşəkkür edirik";

            return View(vm);
        }
        public IActionResult Faq()
        {
            FaqVm Fvm = new()
            {
                BackImageAbout = _indexService.GetBackImageAbout(),
                FaqPages=_indexService.GetFaq()
            };
            return View(Fvm);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
