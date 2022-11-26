using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Tattoo_Shop.Areas.Identity.data;

namespace Tattoo_Shop.Areas.Identity.Pages.Account.Manage
{
    public partial class IndexModel : PageModel
    {
        private readonly UserManager<CustomUser> _userManager;
        private readonly SignInManager<CustomUser> _signInManager;

        public IndexModel(
            UserManager<CustomUser> userManager,
            SignInManager<CustomUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public string Username { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Phone]
            [Display(Name = "Phone number")]
            [Required]
            public string PhoneNumber { get; set; }
            [Required]
            public string VoorNaam { get; set; }
            [Required]
            public string Gemeente { get; set; }
            [Required]
            public string Postcode { get; set; }
            [Required]
            public string Adres { get; set; }
            [Required]
            public string AchterNaam { get; set; }
            [EmailAddress]
            [Display(Name = "E-mailadres")]
            public string Email { get; set; }
        }

        private async Task LoadAsync(CustomUser user)
        {
            var voorNaam = await Task.FromResult(user.VoorNaam);
            var achterNaam = await Task.FromResult(user.AchterNaam);
            var emailadres = await Task.FromResult(user.Email);
            var phonenumber = await Task.FromResult(user.PhoneNumber);
            var gemeente = await Task.FromResult(user.Gemeente);
            var postcode = await Task.FromResult(user.Postcode);
            var adres = await Task.FromResult(user.Adres);


            Input = new InputModel
            {
                VoorNaam = voorNaam,
                AchterNaam = achterNaam,
                Email = emailadres,
                PhoneNumber = phonenumber,
                Gemeente = gemeente,
                Postcode = postcode,
                Adres = adres
            };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            if (Input.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    StatusMessage = "Unexpected error when trying to set phone number.";
                    return RedirectToPage();
                }
            }

            user.Email = Input.Email;
            user.VoorNaam = Input.VoorNaam;
            user.AchterNaam = Input.AchterNaam;
            user.Gemeente = Input.Gemeente;
            user.Postcode = Input.Postcode;
            user.Adres = Input.Adres;

            await _userManager.UpdateAsync(user);
            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }
    }
}
