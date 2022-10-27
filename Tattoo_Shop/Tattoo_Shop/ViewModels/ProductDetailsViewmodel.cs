using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tattoo_Shop.ViewModels
{
    public class ProductDetailsViewmodel
    {
        public int ProductId { get; set; }
        public string Naam { get; set; }
        public Decimal? Prijs { get; set; }
        public string Foto { get; set; }
        public string Descriptie { get; set; }
        public string Merk { get; set; }
    }
}
