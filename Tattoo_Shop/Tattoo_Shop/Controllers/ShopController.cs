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
    public class ShopController : Controller
    {
        public List<Product> products;
        private readonly TattooContext _context;

        public ShopController(TattooContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ProductListViewModel viewModel = new ProductListViewModel();
            viewModel.Products = _context.Products.ToList();
            return View(viewModel);
        }
        public IActionResult Search(ProductListViewModel viewModel)
        {
            if (!string.IsNullOrEmpty(viewModel.ProductSearch))
            {
                viewModel.Products = _context.Products.Where(p => p.Naam.Contains(viewModel.ProductSearch)).ToList();
            }
            else
            {
                viewModel.Products = _context.Products.ToList();
            }
            return View("Index", viewModel);
        }
        public IActionResult Detail(int id)
        {
            Product product = _context.Products.Where(p => p.Id == id).FirstOrDefault();
            if (product != null)
            {
                ProductDetailsViewmodel viewModel = new ProductDetailsViewmodel()
                {
                    Naam = product.Naam,
                    Prijs = product.Prijs,
                    Descriptie = product.Descriptie,
                    Merk = product.Merk,
                    Foto = product.Foto,
                };
                return View(viewModel);
            }
            else
            {
                ProductListViewModel viewModel = new ProductListViewModel();
                viewModel.Products = _context.Products.ToList();
                return View("", viewModel);
            }
        }
    }
}
