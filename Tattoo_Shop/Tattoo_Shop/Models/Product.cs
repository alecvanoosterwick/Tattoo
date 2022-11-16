using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tattoo_Shop.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Naam { get; set; }
        [Required]
        public Decimal? Prijs { get; set; }
        [Required]
        public string Foto { get; set; }
        [Required]
        public string Descriptie { get; set; }
        [Required]
        public string Merk { get; set; }
        [Required]
        public ICollection<OrderLijn> Orderlijnen { get;set; }
    }
}
