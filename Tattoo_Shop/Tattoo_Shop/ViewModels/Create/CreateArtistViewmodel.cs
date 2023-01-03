using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tattoo_Shop.ViewModels.Create
{
    public class CreateArtistViewmodel
    {
        
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Descriptie { get; set; }
        public string Specialiteiten { get; set; }
        public string Email { get; set; }
        public string Foto { get; set; }

    }
}
