using Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Areas.Admin.Controllers
{
    public class SharedController : Controller
    {
        private readonly IWebHostEnvironment _environment;
        private readonly SharedService _sharedService;
        public SharedController(IWebHostEnvironment environment, SharedService sharedService)
        {
            _environment = environment;
            _sharedService = sharedService;
        }

        // GET: SharedController
        public ActionResult UploadPicture()
        {
            JsonResult res = new(new() { });
            List<object> pictureJson = new();
            var pictures = Request.Form.Files;
            for (int i = 0; i < pictures.Count; i++)
            {
                var picture = pictures[i];
                var filename = Guid.NewGuid() + Path.GetExtension(picture.FileName);
                var wwwRootFolder = Path.Combine(_environment.WebRootPath, "img");
                var filePath = Path.Combine(wwwRootFolder, filename);

                using var fileStream = new FileStream(filePath, FileMode.Create);
                picture.CopyTo(fileStream);

                var dbPicture = new Picture()
                {
                    PictureUrl = "/img/" + filename,
                };
                int pictureIDs = _sharedService.SavePicture(dbPicture);
                pictureJson.Add(new { Id = pictureIDs, PictureUrl = filename });
            }

            res.Value = pictureJson;

            return Json(res);
        }

    }
}
