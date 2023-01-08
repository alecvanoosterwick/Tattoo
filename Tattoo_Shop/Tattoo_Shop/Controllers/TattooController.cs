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
            viewModel.Tattoo = _context.Tattoos.Include(t => t.Artist).ToList();
            return View(viewModel);
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Admin()
        {
            TattooListViewModel viewModel = new TattooListViewModel()
            {
                Tattoo = _context.Tattoos.ToList()
            };
            return View(viewModel);
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Search(TattooListViewModel viewModel)
        {
            if (!string.IsNullOrEmpty(viewModel.TattooSearch))
            {
                viewModel.Tattoo = _context.Tattoos.Where(p => p.Naam.Contains(viewModel.TattooSearch)).Include(t => t.Artist).ToList();
            }
            else
            {
                viewModel.Tattoo = _context.Tattoos.Include(t => t.Artist).ToList();
            }
            return View("Index", viewModel);
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create(CreateTattooViewmodel vm)
        {
            if (ModelState.IsValid)
            {
                _context.Add(new Tattoo()
                {
                    Naam = vm.Naam,
                    Descriptie = vm.Descriptie,
                    Foto = "placeholder.jpg",
                    ArtistId = vm.ArtistId
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
            Tattoo tattoo = await _context.Tattoos.FirstOrDefaultAsync(t => t.Id == id);

            if (tattoo == null)
            {
                return NotFound();
            }
            DeleteTattooViewModel vm = new DeleteTattooViewModel()
            {
                Id = tattoo.Id,
                Naam = tattoo.Naam,
                ArtistId = tattoo.ArtistId
            };
            return View("Delete", tattoo);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteDelete(int? id)
        {
            Tattoo tattoo = await _context.Tattoos.FindAsync(id);
            if (tattoo != null)
            {
                _context.Tattoos.Remove(tattoo);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");

            }
            else
            {
                ModelState.AddModelError("", "Tattoo bestaat niet");
            }
            return View("Index", _context.Tattoos.ToList());
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Tattoo tattoo = _context.Tattoos.Where(t => t.Id == id).FirstOrDefault();

            if (tattoo == null)
            {
                return NotFound();
            }

            EditTattooViewModel vm = new EditTattooViewModel()
            {
                Naam = tattoo.Naam,
                Descriptie = tattoo.Descriptie,
                ArtistId = tattoo.ArtistId,
                Foto = tattoo.Foto
            };

            return View(vm);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, EditTattooViewModel vm)
        {
            if (id != vm.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    Tattoo t = new Tattoo()
                    {
                        Naam = vm.Naam,
                        Descriptie = vm.Descriptie,
                        ArtistId = vm.ArtistId,
                        Foto = vm.Foto
                    };
                    _context.Update(t);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Artists.Any(t => t.Id == t.Id))
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

