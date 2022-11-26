using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tattoo_Shop.Areas.Identity.data;
using Tattoo_Shop.ViewModels;

namespace Tattoo_Shop.Controllers
{
    public class UserController : Controller
    {
        private UserManager<CustomUser> _userManager;
        public UserController(UserManager<CustomUser> userManager)
        {
            _userManager = userManager;
        }

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
        public IActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult>Delete(string id)
        {
            CustomUser user = await _userManager.FindByIdAsync(id);
                if(user != null)
                {
                    IdentityResult result = await _userManager.DeleteAsync(user);
                    if (result.Succeeded)
                        return RedirectToAction("Index");
                    else
                        foreach (IdentityError error in result.Errors)
                            ModelState.AddModelError("", error.Description);
                }
                else
                    ModelState.AddModelError("", "User Not Found");
                return View("Index", _userManager.Users.ToList());
        }
    }
}
