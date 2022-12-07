using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tattoo_Shop.ViewModels
{
    public class ArtistDetailViewModel
    {
        public int Id { get; set; }
        
        public string Voornaam { get; set; }
        
        public string Achternaam { get; set; }
        
        public string Descriptie { get; set; }
        
        public string Specialiteiten { get; set; }

        public string Foto { get; set; }
    }
}
