﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class BlogCategory : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public virtual List<Blog> Blogs { get; set; }
    }
}
