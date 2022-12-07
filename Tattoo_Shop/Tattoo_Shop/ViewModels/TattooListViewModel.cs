using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tattoo_Shop.Models;

namespace Tattoo_Shop.ViewModels
{
    public class TattooListViewModel
    {
        public string TattooSearch { get; set; }
        public ICollection<Tattoo> Tattoo { get; set; }
        
    }
}
