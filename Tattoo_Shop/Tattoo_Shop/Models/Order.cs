using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tattoo_Shop.Models
{
    public class Order
    {
        public int Id { get; set; }
        public ICollection<OrderLijn> OrderLijnen { get; set; }
    }
}
