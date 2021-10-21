using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
   public class ContactService
    {
        private readonly EcommerceContext _context;

        public ContactService(EcommerceContext context)
        {
            _context = context;
        }
        public void SaveContactMessage(ContactUserMessage contactUserMessage)
        {

            _context.Add(contactUserMessage);
            _context.SaveChanges();
        }
    }
}
