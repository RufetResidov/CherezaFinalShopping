using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.ViewModel
{
    public class ContactVm
    {
        public BackImageAbout BackImageAbout { get; set; }
        public List<ContactSection2>ContactSection2s { get; set; }
        public ContactSection4 ContactSection4 { get; set; }

        [Required]
        public string Fullname { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string Message { get; set; }
    }
}
