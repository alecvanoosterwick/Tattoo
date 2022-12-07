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
    public class TattooController : Controller
    {
        public List<Tattoo> tattoos;
        private readonly TattooContext _context;

        public TattooController(TattooContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            TattooListViewModel viewModel = new TattooListViewModel();
            viewModel.Tattoo = _context.Tattoos.ToList();
            return View(viewModel);
        }
        public IActionResult Search(TattooListViewModel viewModel)
        {
            if (!string.IsNullOrEmpty(viewModel.TattooSearch))
            {
                viewModel.Tattoo = _context.Tattoos.Where(p => p.Naam.Contains(viewModel.TattooSearch)).ToList();
            }
            else
            {
                viewModel.Tattoo = _context.Tattoos.ToList();
            }
            return View("Index", viewModel);
        }
        public IActionResult Detail(int id)
        {
            Tattoo tattoo = _context.Tattoos.Where(p => p.Id == id).FirstOrDefault();
            if (tattoo != null)
            {
                ProductDetailsViewmodel viewModel = new ProductDetailsViewmodel()
                {
                    Naam = tattoo.Naam,
                    Descriptie = tattoo.Descriptie,
                    Foto = tattoo.Foto,
                };
                return View(viewModel);
            }
            else
            {
                TattooListViewModel viewModel = new TattooListViewModel();
                viewModel.Tattoo = _context.Tattoos.ToList();
                return View("", viewModel);
            }
        }
    }
}
