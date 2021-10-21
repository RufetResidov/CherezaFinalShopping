using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class AboutSection2: BaseEntity
    {
        public string Header1 { get; set; }
        public string Header2 { get; set; }
        public string Title { get; set; }
        public string Photo { get; set; }
        public int CountNum1 { get; set; }
        public string CountTitle1 { get; set; }
        public int CountNum2 { get; set; }
        public string CountTitle2 { get; set; }
        public int CountNum3 { get; set; }
        public string CountTitle3 { get; set; }

    }
}
