using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SharedService
    {
        private readonly EcommerceContext _context;

        public SharedService(EcommerceContext context)
        {
            _context = context;
        }
        public int SavePicture(Picture picture)
        {

            _context.Add(picture);
            _context.SaveChanges();
            return picture.ID;
        }

    }
}
