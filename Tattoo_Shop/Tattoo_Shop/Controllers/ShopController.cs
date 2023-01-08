using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tattoo_Shop.Data;
using Tattoo_Shop.Models;
using Tattoo_Shop.ViewModels;
using Tattoo_Shop.ViewModels.Create;
using Tattoo_Shop.ViewModels.Delete;
using Tattoo_Shop.ViewModels.Edit;

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
        [Authorize(Roles = "Admin")]
        public IActionResult Admin()
        {
            ProductListViewModel viewModel = new ProductListViewModel()
            {
                Products = _context.Products.ToList()
            };
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
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateShopViewModel vm)
        {
            if (ModelState.IsValid)
            {
                _context.Add(new Product()
                {
                    Naam = vm.Naam,
                    Descriptie = vm.Descriptie,
                    Foto = "placeholder.jpg",
                    Merk = vm.Merk,
                    Prijs = vm.Prijs
                });

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(vm);
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Product product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }
            DeleteShopViewModel vm = new DeleteShopViewModel()
            {
                Id = product.Id,
                Naam = product.Naam,
                Merk = product.Merk
            };
            return View("Delete", product);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteDelete(int? id)
        {
            Product product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");

            }
            else
            {
                ModelState.AddModelError("", "Product bestaat niet");
            }
            return View("Index", _context.Products.ToList());
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Product product = _context.Products.Where(p => p.Id == id).FirstOrDefault();

            if (product == null)
            {
                return NotFound();
            }

            EditShopViewModel vm = new EditShopViewModel()
            {
                Naam = product.Naam,
                Descriptie = product.Descriptie,
                Foto = "placeholder.jpg",
                Merk = product.Merk,
                Prijs = product.Prijs
            };

            return View(vm);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, EditShopViewModel vm)
        {
            if (id != vm.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    Product p = new Product()
                    {
                        Naam = vm.Naam,
                        Descriptie = vm.Descriptie,
                        Foto = "placeholder.jpg",
                        Merk = vm.Merk,
                        Prijs = vm.Prijs
                    };
                    _context.Update(p);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Products.Any(p => p.Id == p.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(vm);
        }
    }
}
