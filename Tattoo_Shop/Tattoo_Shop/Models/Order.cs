using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tattoo_Shop.Models
{
    [Table("Orders")]
    public class Order
    {
        public int Id { get; set; }
        public ICollection<OrderLijn> Orderlijnen { get; set; }
    }
}
