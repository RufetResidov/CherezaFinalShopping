using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public class PictureHelper
    {
        public static string GetCoverImage(int? thumbnailId, List<ProductPicture> pictures)
        {
            var picture = pictures.FirstOrDefault(x => x.PictureID == thumbnailId);
            if (picture != null)
            {
                return picture.Picture.PictureUrl;

            }
            return "~/assets/photo/product-default.png";
        }
    }
}
