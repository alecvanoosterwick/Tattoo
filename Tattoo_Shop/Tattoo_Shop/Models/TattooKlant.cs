using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tattoo_Shop.Models
{
    public class TattooKlant
    {
        public int TattooKlantId { get; set; }
        public List<Tattoo> Tattoos { get; set; }
    }
}
