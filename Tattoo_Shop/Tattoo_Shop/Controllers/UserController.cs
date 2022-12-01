using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tattoo_Shop.Areas.Identity.data;
using Tattoo_Shop.ViewModels;

namespace Tattoo_Shop.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UserController : Controller
    {
        private UserManager<CustomUser> _userManager;
        private RoleManager<IdentityRole> _roleManager;
        public UserController(UserManager<CustomUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            UserListViewmodel viewModel = new UserListViewmodel()
            {
                Users = _userManager.Users.ToList()
            };
            return View(viewModel);
        }

        public IActionResult Details(string id)
        {
            CustomUser user = _userManager.Users.Where(u => u.Id == id).FirstOrDefault();
            if(user != null)
            {
                UserDetailViewmodel viewModel = new UserDetailViewmodel()
                {
                    Id = user.Id,
                    VoorNaam = user.VoorNaam,
                    AchterNaam = user.AchterNaam,
                    Email = user.Email,
                    PhoneNumber = user.PhoneNumber,
                    Gemeente = user.Gemeente,
                    Adres = user.Adres,
                    Postcode = user.Postcode
                };
                return View(viewModel);
            }
            else
            {
                UserListViewmodel viewModel = new UserListViewmodel()
                {
                    Users = _userManager.Users.ToList()
                };
                return View("Index", viewModel);
            }
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateUserViewmodel viewModel)
        {
            if (ModelState.IsValid)
            {
                CustomUser user = new CustomUser
                {
                    VoorNaam = viewModel.VoorNaam,
                    AchterNaam = viewModel.AchterNaam,
                    UserName = viewModel.Email,
                    Email = viewModel.Email,
                    PhoneNumber = viewModel.PhoneNumber,
                    Gemeente = viewModel.Gemeente,
                    Adres = viewModel.Adres,
                    Postcode = viewModel.Postcode
                };
                IdentityResult result = await _userManager.CreateAsync(user, viewModel.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                        ModelState.AddModelError("", error.Description);
                }
            }
            return View(viewModel);
        }
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CustomUser user = await _userManager.Users.FirstOrDefaultAsync(u => u.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            DeleteUserViewModel viewModel = new DeleteUserViewModel()
            {
                Id = user.Id,
                VoorNaam = user.VoorNaam,
                AchterNaam = user.AchterNaam
            };
            return View(viewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            CustomUser user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                IdentityResult result = await _userManager.DeleteAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            else
            {
                ModelState.AddModelError("", "User Not Found");
            }
            return View("Index", _userManager.Users.ToList());
        }


        public IActionResult GrantPermissions()
        {
            GrantRolesViewModel viewModel = new GrantRolesViewModel()
            {
                Users = new SelectList(_userManager.Users.ToList(), "Id", "UserName"),
                Roles = new SelectList(_roleManager.Roles.ToList(), "Id", "Name")
            };
            return View(viewModel);
        }
        public async Task<IActionResult> GrantPermissions(GrantRolesViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                CustomUser user = await _userManager.FindByIdAsync(viewModel.UserId);
                IdentityRole role = await _roleManager.FindByIdAsync(viewModel.RoleId);
                if (user != null && role != null)
                {
                    IdentityResult result = await _userManager.AddToRoleAsync(user, role.Name);
                    if (result.Succeeded)
                        return RedirectToAction("Index");
                    else
                    {
                        foreach (IdentityError error in result.Errors)
                            ModelState.AddModelError("", error.Description);
                    }
                }
                else
                    ModelState.AddModelError("", "User or role Not found");
            }
            return (View(viewModel));
        }
    }
}
