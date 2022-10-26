using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tattoo_Shop.Models
{
    public class OrderLijn
    {
        public int OrderLijnId { get; set; }
        public List<Product> Products { get; set; }
        public List<Order> Orders { get; set; }
        public string quantity { get; set; }
    }
}
