using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tattoo_Shop.Models
{
    [Table("Artists")]
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
        public string Descriptie { get; set; }
        [Required]
        public string Specialiteiten { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Foto { get; set; }
        [Required]
        public ICollection<Tattoo> Tattoos { get; set; }
    }
}
