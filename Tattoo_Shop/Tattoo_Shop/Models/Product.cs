using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tattoo_Shop.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string Naam { get; set; }

        public decimal Prijs { get; set; }

        public string Foto { get; set; }

        public string Descriptie { get; set; }
    }
}
