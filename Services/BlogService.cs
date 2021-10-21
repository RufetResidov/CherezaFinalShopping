using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BlogService
    {
        private readonly EcommerceContext _context;

        public BlogService(EcommerceContext context)
        {
            _context = context;
        }
        public BackImageBlog GetBackImageBlog()
        {
            return _context.BackImageBlogs.FirstOrDefault();
        }
        public List<Blog> GetBlog()
        {
            return _context.Blogs.Include(x=>x.BlogCategory).OrderByDescending(x=>x.ModifiedOn).Take(3).ToList();
        }

        public int GetBlogCount(int id)
        {
            var singleBlog = GetBlogDetail(id);

           return _context.Blogs.Where(x => x.BlogCategoryID == id).OrderByDescending(x => x.ModifiedOn).Take(4).ToList().Count;
        }

        public Blog GetBlogDetail(int? id)
        {
            return _context.Blogs.Include(x =>x.BlogCategory).FirstOrDefault(x => x.ID == id);
        }
        public List<Blog> GetBlogList(int? pageNo, int recordSize, out int count)
        {
            var productList = _context.Blogs.AsQueryable();
            count = productList.Count();
            pageNo ??= 1;
            var skipCount = (pageNo.Value - 1) * recordSize;
            return _context.Blogs.Include(x => x.BlogCategory).OrderByDescending(x => x.ModifiedOn).Skip(skipCount).Take(recordSize).ToList();
        }
       

    }
}
