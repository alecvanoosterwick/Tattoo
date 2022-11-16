using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tattoo_Shop.Models
{
    [Table("Artists")]
    public class Artist
    {
        public int Id { get; set; }
        [Required]
        public string Voornaam { get; set; }
        [Required]
        public string Achternaam { get; set; }
        [Required]
        public string Descriptie { get; set; }
        public string Specialiteiten { get; set; }

        [Required]
        public string Foto { get; set; }

        public ICollection<Tattoo> Tattoos { get; set; }
    }
}
