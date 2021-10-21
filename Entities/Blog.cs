using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Blog:BaseEntity
    {
        public string Header { get; set; }
        public string Title { get; set; }
        public DateTime PublishDate { get; set; }
        public string PhotoUrl { get; set; }
        public int BlogCategoryID { get; set; }
        public virtual BlogCategory BlogCategory { get; set; }

    }
}
