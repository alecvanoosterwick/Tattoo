using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tattoo_Shop.Models
{
    [Table("Tattooklants")]
    public class TattooKlant
    {
        public int Id { get; set; }
        public Tattoo Tattoo { get; set; }
        [ForeignKey("Tattoo")]
        public int TattooId { get; set; }
    }
}
