using DataAccess;
using Helpers;
using Microsoft.AspNetCore.Mvc;
using Service;
using Services;
using Shopping.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Controllers
{

    public class BlogController : Controller
    {
        private readonly IndexService _indexService;
        private readonly BlogService _blogService;
        private readonly CategoryService _categoryService;

        public BlogController(IndexService indexService, BlogService blogService, CategoryService categoryService)
        {
            _indexService = indexService;
            _blogService = blogService;
            _categoryService = categoryService;
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            BlogVm Bvm = new()
            {
                BlogPop = _blogService.GetBlog(),
                BlogDetail = _blogService.GetBlogDetail(id),
                BackImageBlogs =_blogService.GetBackImageBlog(),
                Categories = _categoryService.GetBlogCategories()

            };
            if (Bvm == null)
            {
                return NotFound();
            }
            return View(Bvm);
        }
        public IActionResult List(int? pageNo = 1, int? recordSize = 9)
        {
            recordSize ??= 9;
            BlogVm Bvm = new()
            {
                BackImageBlogs = _blogService.GetBackImageBlog(),
                BlogPop = _blogService.GetBlog(),
                BlogList = _blogService.GetBlogList(pageNo, recordSize.Value, out int count),
                Categories= _categoryService.GetBlogCategories(),
                PageSize = recordSize,
                PageNo = pageNo
            };
            Bvm.Pager = new Pager(count, pageNo, recordSize.Value);

            return View(Bvm);
        }
    }
}
