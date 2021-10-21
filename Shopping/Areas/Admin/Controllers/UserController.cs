using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Shopping.Areas.Admin.ViewModels;
using Shopping.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Areas.Admin.Controllers
{
    [Area(nameof(Admin))]
    public class UserController : Controller
    {
        private readonly UserManager<BadamUser> _userManager;

        private readonly RoleManager<IdentityRole> _roleManager;
        public UserController(UserManager<BadamUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }
        [Authorize(Roles = "Admin,Moderator")] 
        public IActionResult Index()
        {
            return View(_userManager.Users.ToList());
        }
        [Authorize(Roles = "Admin,Moderator")]
        public async Task<IActionResult> AddRole(string id)
        {
            if (id == null) return NotFound();
            BadamUser appUser = await _userManager.FindByIdAsync(id);
            if (appUser == null) return NotFound();
            var userRoles = (await _userManager.GetRolesAsync(appUser)).ToList();
            var allRoles = _roleManager.Roles.Select(r => r.Name).ToList();
            AddRoleVm vm = new()
            {
                User = appUser,
                Roles = allRoles.Except(userRoles)
            };
            return View(vm);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AddRole(string id, string role)
        {
            if (id == null || role == null) return NotFound();
            BadamUser appUser = await _userManager.FindByIdAsync(id);
            if (appUser == null) return NotFound();
            var result = await _userManager.AddToRoleAsync(appUser, role);
            if (result.Succeeded)
            {
                return RedirectToAction(nameof(Index), new { id = id });
            }
            return RedirectToAction(nameof(AddRole), new { id = id });
        }


        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null ) return NotFound();
            BadamUser appUser = await _userManager.FindByIdAsync(id);
            if (appUser == null) return NotFound();

            return View(appUser);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(string userid, string role)
        {
            if (userid == null || role == null) return NotFound();
            BadamUser appUser = await _userManager.FindByIdAsync(userid);
            if (appUser == null) return NotFound();
            IdentityResult result = await _userManager.RemoveFromRoleAsync(appUser, role);
            return RedirectToAction(nameof(Edit), new { id = userid });
        }
    }
}
