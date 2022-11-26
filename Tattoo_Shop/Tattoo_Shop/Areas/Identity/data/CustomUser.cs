using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Tattoo_Shop.Models;

namespace Tattoo_Shop.Areas.Identity.data
{
    [Table("CustomUser")]
    public class CustomUser : IdentityUser
    {
        
            [Required]
            [PersonalData]
            public string VoorNaam { get; set; }
            [Required]
            [PersonalData]
            public string AchterNaam { get; set; }
            [Required]
            [PersonalData]
            public string Gemeente { get; set; }
            [Required]
            [PersonalData]
            public string Postcode { get; set; }
            [Required]
            [PersonalData]
            public string Adres { get; set; }
            //[PersonalData]
            ////public bool? Admin { get; set; }
            [Required]
            public ICollection<Order> Orders { get; set; }
            [Required]
            public ICollection<TattooKlant> TattooKlanten { get; set; }
        
    }
}
