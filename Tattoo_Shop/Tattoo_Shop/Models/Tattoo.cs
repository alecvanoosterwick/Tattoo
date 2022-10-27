using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tattoo_Shop.Models
{
    public class Tattoo
    {
        public int TattooId { get; set; }

        public string Naam { get; set; }

        public string Descriptie { get; set; }
        [Required]
        public string Foto { get; set; }

        public List<Artist> Artiesten { get; set; }
    }
}
