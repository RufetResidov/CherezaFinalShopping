using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class TagService
    {
        private readonly EcommerceContext _context;

        public TagService(EcommerceContext context)
        {
            _context = context;
        }
        public List<Tag> GetTagNames()
        {
            return _context.myTags.ToList();
        }
        public Tag  GetTagNamesById(int id)
        {
            return _context.myTags.FirstOrDefault(x=>x.ID==id);
        }
    }
}
