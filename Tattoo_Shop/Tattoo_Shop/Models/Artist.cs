using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tattoo_Shop.Models
{
    public class Artist
    {
        public int ArtistId { get; set; }

        [Required]
        public string Voornaam { get; set; }
        [Required]
        public string Achternaam { get; set; }

        public string Descriptie { get; set; }

        public string Specialiteiten { get; set; }

        [Required]
        public string Foto { get; set; }
    }
}
