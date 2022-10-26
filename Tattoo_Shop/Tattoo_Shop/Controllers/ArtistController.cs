using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tattoo_Shop.Models;
using Tattoo_Shop.ViewModels;

namespace Tattoo_Shop.Controllers
{
    public class ArtistController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
        public IActionResult List()
        {
            //List<Artist> artists = new List<Artist>();
            //artists.Add(new Artist() { ArtistId = 1, Voornaam = "alec", Achternaam = "van oosterwijck", Descriptie = "gespecialiseerd in niets", Specialiteiten = "none", Foto = "mikey.jpg" });

            //ArtistListViewModel viewModel = new ArtistListViewModel();
            //viewModel.Artists = artists;
            return View(/*viewModel*/);
        }
    }
}
