﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class ContactUserMessage:BaseEntity
    {
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber{ get; set; }
        public string Message { get; set; }
    }
}
