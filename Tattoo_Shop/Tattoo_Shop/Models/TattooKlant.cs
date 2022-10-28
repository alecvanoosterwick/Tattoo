using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tattoo_Shop.Models
{
    public class TattooKlant
    {
        public int Id { get; set; }
        public Tattoo Tattoo { get; set; }
        public int TattooId { get; set; }
    }
}
