using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tattoo_Shop.Models
{
    [Table("Orders")]
    public class Order
    {

        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public CustomUser CustomUser { get; set; }

        [Required]
        [ForeignKey("CustomUser")]
        public int CustomUserId { get; set; }

        [Required]
        public ICollection<OrderLijn> Orderlijnen { get; set; }
    }
}
