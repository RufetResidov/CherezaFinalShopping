using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class SocialInfo : BaseEntity
    {
        public string FaceLink { get; set; }
        public string InstLink { get; set; }
        public string WhatsappLink { get; set; }
        public string PhoneFaceLink { get; set; }
        public string EmailFaceLink { get; set; }
    }
}
