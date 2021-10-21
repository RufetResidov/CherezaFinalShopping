using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Areas.Admin.ViewModels
{
    public class ProductCreateVM
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
        public decimal Price { get; set; }
        public decimal Weight { get; set; }
        public string Description { get; set; }
        public decimal? Discount { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsActive{ get; set; }
        public bool IsSale { get; set; }
        public bool IsRating { get; set; }
        public bool IsNew { get; set; }
        public int? ThumbnailPictureID { get; set; }
        public string Sku { get; set; }
        public string Barcode { get; set; }
        public string Supplier { get; set; }
        public string ProductPicturesIds { get; set; }
        public List<ProductPicture> ProductPictures { get; set; }
    }
}
