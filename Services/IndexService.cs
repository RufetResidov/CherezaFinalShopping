using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class IndexService
    {
        private readonly EcommerceContext _context;

        public IndexService(EcommerceContext context)
        {
            _context = context;
        }
        public BackImageAbout GetBackImageAbout()
        {
            return _context.BackImageAbouts.FirstOrDefault();
        }
        public List<IndexSlider> GetIndexSlider()
        {
            return _context.IndexSliders.ToList();
        }
        public AboutSection2 GetAbout2()
        {
            return _context.AboutSection2s.FirstOrDefault();
        }
        public List<AboutSection3> GetAbout3()
        {
            return _context.AboutSection3s.OrderByDescending(x=>x.ModifiedOn).Take(4).ToList();
        }
        public List<ContactSection2> GetContact2()
        {
            return _context.ContactSection2s.Take(3).OrderByDescending(x=>x.ModifiedOn).ToList();
        }
        public ContactSection4 GetContact4()
        {
            return _context.ContactSection4s.FirstOrDefault();
        }

        public List<FaqPage> GetFaq()
        {
            return _context.FaqPages.OrderByDescending(x => x.ModifiedOn).Take(5).ToList();
        }


    }
}
