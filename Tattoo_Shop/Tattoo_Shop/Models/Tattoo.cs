using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tattoo_Shop.Models
{
    [Table("Tattoos")]
    public class Tattoo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Naam { get; set; }
        [Required]
        public string Descriptie { get; set; }
        [Required]
        public string Foto { get; set; }
        [Required]
        [ForeignKey("Artist")]
        public int ArtistId { get; set; }
        [Required]
        public Artist Artist { get; set; }
        [Required]
        public ICollection<TattooKlant> TattooKlanten { get; set; }
    }
}
