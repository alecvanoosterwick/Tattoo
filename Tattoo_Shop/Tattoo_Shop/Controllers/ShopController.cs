using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tattoo_Shop.Models;
using Tattoo_Shop.ViewModels;

namespace Tattoo_Shop.Controllers
{
    public class ShopController : Controller
    {
        public List<Product> products;

        public ShopController()
        {
            products = new List<Product>();
            products.Add(new Product() { Naam = "Roze Inkt", ProductId = 1, Prijs = 29, Descriptie = "Roze inkt die gemaakt is voor huid.", Foto = "rozeInkt.jpg", });
            products.Add(new Product() { Naam = "Blauw Inkt", ProductId = 2, Prijs = 29, Descriptie = "Blauw inkt die gemaakt is voor huid.", Foto = "blauwInkt.jpg" });
            products.Add(new Product() { Naam = "Gele Inkt", ProductId = 3, Prijs = 29, Descriptie = "Gele inkt die gemaakt is voor huid.", Foto = "geleInkt.jpg" });
        }
        public IActionResult Index()
        {
            ProductListViewModel viewModel = new ProductListViewModel();
            viewModel.Products = products;
            return View(viewModel);
        }
        public IActionResult Search(ProductListViewModel viewModel)
        {
            if (!string.IsNullOrEmpty(viewModel.ProductSearch))
            {
                viewModel.Products = products.Where(b => b.Naam.Contains(viewModel.ProductSearch)).ToList();
            }
            else
            {
                viewModel.Products = products;
            }
            return View("Index", viewModel);
        }
    }
}
