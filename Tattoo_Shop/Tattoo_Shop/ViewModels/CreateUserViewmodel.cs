using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Tattoo_Shop.Areas.Identity.data;

namespace Tattoo_Shop.ViewModels
{
    public class CreateUserViewmodel
    {
        [Required]
        public string VoorNaam { get; set; }
        [Required]
        public string AchterNaam { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Gemeente { get; set; }
        [Required]
        public string Postcode { get; set; }
        [Required]
        public string Adres { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
