using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tattoo_Shop.Models
{
    [Table("Artists")]
    // authorize P21 identity , voor paginas te beveiligen met in te loggen.
    public class Artist
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public string Voornaam { get; set; }
        [Required]
        public string Achternaam { get; set; }
        [Required]
        public string? Descriptie { get; set; }
        [Required]
        public string? Specialiteiten { get; set; }

        [Required]
        public string Foto { get; set; }
        [Required]
        public ICollection<Tattoo> Tattoos { get; set; }
    }
}
