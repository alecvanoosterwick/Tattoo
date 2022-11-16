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
        public int Id { get; set; }

        public string Naam { get; set; }

        public string Descriptie { get; set; }
        [Required]
        public string Foto { get; set; }
        [ForeignKey("Artist")]
        public int ArtistId { get; set; }

        public Artist Artist { get; set; }

        public ICollection<TattooKlant> TattooKlanten { get; set; }
    }
}
