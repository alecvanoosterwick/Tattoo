using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tattoo_Shop.ViewModels
{
    public class OrderDetailViewModel
    {
        public int Id { get; set; }

        public Decimal Prijs { get; set; }

        public string Product { get; set; }

    }
}
