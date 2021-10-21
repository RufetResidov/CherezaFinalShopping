using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ProductToTag:BaseEntity
    {
        public int ProductId{ get; set; }
        public virtual Product Product{ get; set; }
        public int TagId{ get; set; }
        public virtual Tag myTag{ get; set; }
    }
}
