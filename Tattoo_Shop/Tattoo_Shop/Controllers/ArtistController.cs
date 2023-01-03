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
    public class ArtistController : Controller
    {
        private readonly TattooContext _context;

        public ArtistController(TattooContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ArtistListViewModel viewModel = new ArtistListViewModel()
            {
                Artists = _context.Artists.ToList()
            };
            return View(viewModel);
        }
        public IActionResult Admin()
        {
            ArtistListViewModel viewModel = new ArtistListViewModel()
            {
                Artists = _context.Artists.ToList()
            };
            return View(viewModel);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult List()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(CreateArtistViewmodel vm)
        {
            if (ModelState.IsValid)
            {
                _context.Add(new Artist()
                {
                    Voornaam = vm.Voornaam,
                    Achternaam = vm.Achternaam,
                    Email = vm.Email,
                    Descriptie = vm.Descriptie,
                    Foto = "iets.jpg",
                    Specialiteiten = vm.Specialiteiten
                });

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(vm);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Artist artist = await _context.Artists.FirstOrDefaultAsync(a => a.Id == id);

            if (artist == null)
            {
                return NotFound();
            }
            DeleteArtistViewModel vm = new DeleteArtistViewModel()
            {
                Id = artist.Id,
                Voornaam = artist.Voornaam,
                Achternaam = artist.Achternaam
            };
            return View("Delete",artist);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteDelete(int? id)
        {
            Artist artist = await _context.Artists.FindAsync(id);
            if(artist != null)
            {
                _context.Artists.Remove(artist);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
                
            }
            else
            {
                ModelState.AddModelError("", "Artist bestaat niet");
            }
            return View("Index", _context.Artists.ToList());
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            Artist artist = _context.Artists.Where(a => a.Id == id).FirstOrDefault();
            
            if(artist == null)
            {
                return NotFound();
            }

            EditArtistViewModel vm = new EditArtistViewModel()
            {
                Voornaam = artist.Voornaam,
                Achternaam = artist.Achternaam,
                Id = artist.Id,
                Descriptie = artist.Descriptie,
                Specialiteiten = artist.Specialiteiten,
                Email = artist.Email,
                Foto = artist.Foto
            };

            return View(vm);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, EditArtistViewModel vm)
        {
            if(id != vm.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    Artist a = new Artist()
                    {
                        Voornaam = vm.Voornaam,
                        Achternaam = vm.Achternaam,
                        Id = vm.Id,
                        Descriptie = vm.Descriptie,
                        Specialiteiten = vm.Specialiteiten,
                        Email = vm.Email,
                        Foto = vm.Foto
                    };
                    _context.Update(a);
                    await _context.SaveChangesAsync();
                }
                catch(DbUpdateConcurrencyException e) 
                {
                    if (! _context.Artists.Any(a =>a.Id == vm.Id ))
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
