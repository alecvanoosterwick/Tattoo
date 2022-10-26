using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tattoo_Shop.Controllers
{
    public class TattooController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
