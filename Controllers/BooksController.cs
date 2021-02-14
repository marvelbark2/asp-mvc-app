using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using asp_mvc.Models;

namespace asp_mvc.Controllers
{
    public class BokksController : Controller
    {
        // GET : movies/Test
        public IActionResult Test()
        {
            var movie = new Books() { Name = "Test movie" };
            return View(movie);
        }

    }
}