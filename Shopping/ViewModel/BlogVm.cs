using Entities;
using Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.ViewModel
{
    public class BlogVm
    {
        public BackImageBlog BackImageBlogs { get; set; }
        public Blog BlogDetail { get; set; }
        public List<Blog> BlogPop { get; set; }
        public List<Blog> BlogList { get; set; }
        public List<BlogCategory> Categories { get; set; }
        public Pager Pager { get; set; }
        public int? PageNo { get; set; }
        public int? PageSize { get; set; }


    }
}
