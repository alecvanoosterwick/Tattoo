using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tattoo_Shop.Models;

namespace Tattoo_Shop.ViewModels
{
    public class ArtistListViewModel
    {
        public ICollection<Artist> Artists { get; set; }
    }
}
