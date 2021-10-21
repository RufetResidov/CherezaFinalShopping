using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        [Area(nameof(Admin))]
        [Authorize(Roles = "Admin,Moderator")]

        public IActionResult Index()
        {
            return View();
        }
    }
}
