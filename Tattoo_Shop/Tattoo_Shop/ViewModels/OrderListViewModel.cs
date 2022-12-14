using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tattoo_Shop.Models;

namespace Tattoo_Shop.ViewModels
{
    public class OrderListViewModel
    {
        public ICollection<Order> Orders { get; set; }
    }
}
