using DataAccess;
using Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Areas.Admin.Controllers
{
    public class MultiplePicture : Controller
    {
        private readonly EcommerceContext _context;
        private IWebHostEnvironment Environment;


        public JsonResult UploadPicture()
        {
            JsonResult result = new JsonResult(new { });
            List<object> picturesJSON = new List<object>();

            var pictures = Request.Form.Files;
            for (int i = 0; i < pictures.Count; i++)
            {
                var picture = pictures[i];
                var fileName = Guid.NewGuid() + Path.GetExtension(picture.FileName);
                string uploadsFolder = Path.Combine(Environment.WebRootPath, "img");
                string filePath = Path.Combine(uploadsFolder, fileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    picture.CopyTo(fileStream);
                }
                var dbPicture = new Picture
                {
                    PictureUrl = fileName
                };
                _context.Pictures.Add(dbPicture);
                _context.SaveChanges();
                picturesJSON.Add(new { dbPicture.ID, PictureUrl = fileName });
            }
            result = new JsonResult(new { Data = picturesJSON });
            return result;
        }
    }
}

