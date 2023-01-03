using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Tattoo_Shop.Areas.Identity.data;

namespace Tattoo_Shop.Models
{
    [Table("Tattooklants")]
    public class TattooKlant
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public Tattoo Tattoo { get; set; }
        [Required]
        [ForeignKey("Tattoo")]
        public int TattooId { get; set; }
        [Required]
        public CustomUser CustomUser { get; set; }
        [ForeignKey("CustomUser")]
        public string? CustomUserId { get; set; }
    }
}
