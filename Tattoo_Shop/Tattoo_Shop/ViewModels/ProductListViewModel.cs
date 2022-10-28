using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tattoo_Shop.Models;

namespace Tattoo_Shop.ViewModels
{
    public class ProductListViewModel
    {
        public string ProductSearch { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
