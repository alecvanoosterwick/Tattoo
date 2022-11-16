using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tattoo_Shop.Models
{
    [Table("Orderlijns")]
    public class OrderLijn
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        [Required]
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        [Required]
        public Product Product { get; set; }
        [Required]
        public Order Order { get; set; }
        [Required]
        public string Quantity { get; set; }

    }
}
