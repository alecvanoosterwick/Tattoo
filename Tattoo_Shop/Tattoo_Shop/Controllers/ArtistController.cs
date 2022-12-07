using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tattoo_Shop.Data;
using Tattoo_Shop.Models;
using Tattoo_Shop.ViewModels;

namespace Tattoo_Shop.Controllers
{
    public class ArtistController : Controller
    {
        private readonly TattooContext _context;

        public ArtistController(TattooContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ArtistListViewModel viewModel = new ArtistListViewModel();
            viewModel.Artists = _context.Artists.ToList();
            return View(viewModel);
        }
        public IActionResult List()
        {
            return View();
        }
    }
}
